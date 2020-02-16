using System.Text;
using System.IO;

namespace Travsystem.Service
{
    class Crc16
    {
        const ushort polynomial = 0xA001;
        ushort[] table = new ushort[256];

        public ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = 0;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc;
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return new byte[2] { (byte)(crc >> 8), (byte)(crc & 255) };
        }

        public Crc16()
        {
            ushort value;
            ushort temp;
            for (ushort i = 0; i < table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
        }

        private string CreateChecksumString(StreamReader sr)
        {
            string end = sr.ReadToEnd();
            UTF8Encoding uTF8Encoding = new UTF8Encoding(false);
            byte[] bytes = uTF8Encoding.GetBytes(end);
            byte[] numArray = this.ComputeChecksumBytes(bytes);
            string str = string.Concat(numArray[0].ToString("X2"), numArray[1].ToString("X2"));
            return str;
        }

        public string GetCheckSumAsHexString(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName, new UTF8Encoding(false));
            return this.CreateChecksumString(streamReader);
        }

        public string GetCheckSumAsHexString(Stream stream)
        {
            StreamReader streamReader = new StreamReader(stream, new UTF8Encoding(false));
            return this.CreateChecksumString(streamReader);
        }
    }
}
