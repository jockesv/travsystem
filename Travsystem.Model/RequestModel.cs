using System;
using System.Collections.Generic;

namespace Travsystem.Model
{
    public class RaceDayResponse
    { 
        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
        public string BetType { get; set; }
        public int TrackId { get; set; }
    }

	public class LegResponse
	{
		public LegResponse ()
		{
			Horses = new List<HorseResponse> ();
		}
		public int Number { get; set; }
		public string Type { get; set; }
		public List<HorseResponse> Horses { get; set; }
		public bool Open { get; set; }
	}

	public class HorseResponse
	{
		public int StartNumber { get; set; }
		public string Name { get; set; }
		public string Driver { get; set; }
		public int MarksQuantity { get; set; }
		public float MarksPercentage { get; set; }
		public float Odds { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public bool Enabled { get; set; }
		public string Rank { get; set; }
		public float RankTal { get; set; }
		public int RankOrder { get; set; }
	}

	public class LoginRequest
	{
		public string username { get; set; }
		public string password { get; set; }
	}

	public class LoginResponse 
	{
		public string Ticket { get; set; }
		public string Role { get; set; }
		public string Name { get; set; }
	}

	public class LogoutRequest 
	{
		public string Ticket { get; set; }
	}

	public class RaceRequest
	{
		public string Ticket { get; set; }
		public RaceDayResponse Race { get; set; }
	}

	public class RaceDaysRequest 
	{
		public string Ticket { get; set; }
	}

    public class BetFileRequest
    { 
		public string Ticket { get; set; }
        public RaceDayResponse RaceDay { get; set; }
        public string[] Rows { get; set; }
        public int SystemSize { get; set; }
        public int ReducedSize { get; set; }
        public string Filename { get; set; }
    }

    public class BetFileResponse
    {
        public string XML { get; set; }
		public string Filename { get; set; }
    }

    public class RemoteFileInfo : IDisposable
    {
        public string FileName;
        public long Length;
        public System.IO.Stream FileByteStream;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }
}