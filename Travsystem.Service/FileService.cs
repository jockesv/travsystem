using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Travsystem.Model;

namespace Travsystem.Service
{
    public class FileService : IFileService
    {
        public BetFileResponse SaveATGFile(BetFileRequest request)
        {
            var raceDay = request.RaceDay;

			var coupons = new List<string[]> ();
			foreach (var row in request.Rows) 
			{
				var horses = row.Split (',').Select (x => Int32.Parse (x));
				var legs = new List<string>();
				foreach (var horse in horses) 
				{
					var marks = "000000000000000".ToArray();
					marks [horse - 1] = '1';
					legs.Add (new string(marks));
				}
				coupons.Add (legs.ToArray());
			}

            //var coupons = new List<string[]>() { request.Rows };

            var atgXMLFile = new issuer();
            atgXMLFile.company = "none";
            atgXMLFile.createddate = DateTime.Now;
            atgXMLFile.product = "TrabLab";
            atgXMLFile.version = "0.1";
            atgXMLFile.schemaversion = "ATG File Betting XSD ver 1.8";

            var betcoupons = new betcouponsType();
            atgXMLFile.betcoupons = betcoupons;

            if (request.RaceDay.BetType == "V75")
            {
                int couponId = 1;
                var couponTypes = new List<v75CouponType>();
                foreach (var kupong in coupons)
                {
                    var couponType = new v75CouponType();
                    couponType.date = new DateTime(raceDay.Year, raceDay.Month, raceDay.Date);
                    couponType.couponid = Convert.ToString(couponId++);

                    var legTypes = new List<legType>();
                    int legId = 1;
                    foreach (var leg in kupong)
                    {
                        legType legType = new legType();
                        legType.marks = leg;
                        legType.legno = Convert.ToString(legId++);
                        legTypes.Add(legType);
                    }
                    couponType.leg = legTypes.ToArray();
                    couponTypes.Add(couponType);
                }
                betcoupons.v75Coupon = couponTypes.ToArray();
            }
            else if (raceDay.BetType == "V65")
            {
                int couponId = 1;
                var couponTypes = new List<v65CouponType>();
                foreach (var kupong in coupons)
                {
                    var couponType = new v65CouponType();
                    couponType.date = new DateTime(raceDay.Year, raceDay.Month, raceDay.Date);
                    couponType.couponid = Convert.ToString(couponId++);

                    var legTypes = new List<legType>();
                    int legId = 1;
                    foreach (var leg in kupong)
                    {
                        legType legType = new legType();
                        legType.marks = leg;
                        legType.legno = Convert.ToString(legId++);
                        legTypes.Add(legType);
                    }
                    couponType.leg = legTypes.ToArray();
                    couponTypes.Add(couponType);
                }
                betcoupons.v65Coupon = couponTypes.ToArray();
            }
            else if (raceDay.BetType == "V86")
            {
                int couponId = 1;
                var couponTypes = new List<v86CouponType>();
                foreach (var kupong in coupons)
                {
                    var couponType = new v86CouponType();
                    couponType.date = new DateTime(raceDay.Year, raceDay.Month, raceDay.Date);
                    couponType.couponid = Convert.ToString(couponId++);
                    couponType.trackcode = raceDay.TrackId.ToString();
                    var legTypes = new List<legType>();
                    int legId = 1;
                    foreach (var leg in kupong)
                    {
                        legType legType = new legType();
                        legType.marks = leg;
                        legType.legno = Convert.ToString(legId++);
                        legTypes.Add(legType);
                    }
                    couponType.leg = legTypes.ToArray();
                    couponTypes.Add(couponType);
                }
                betcoupons.v86Coupon = couponTypes.ToArray();
            }
            else if (raceDay.BetType == "V64")
            {
                int couponId = 1;
                var couponTypes = new List<v64CouponType>();
                foreach (var kupong in coupons)
                {
                    var couponType = new v64CouponType();
                    couponType.date = new DateTime(raceDay.Year, raceDay.Month, raceDay.Date);
                    couponType.couponid = Convert.ToString(couponId++);

                    var legTypes = new List<legType>();
                    int legId = 1;
                    foreach (var leg in kupong)
                    {
                        legType legType = new legType();
                        legType.marks = leg;
                        legType.legno = Convert.ToString(legId++);
                        legTypes.Add(legType);
                    }
                    couponType.leg = legTypes.ToArray();
                    couponTypes.Add(couponType);
                }
                betcoupons.v64Coupon = couponTypes.ToArray();
            }
            else if (raceDay.BetType == "V5")
            {
                int couponId = 1;
                var couponTypes = new List<v5CouponType>();
                foreach (var kupong in coupons)
                {
                    var couponType = new v5CouponType();
                    couponType.date = new DateTime(raceDay.Year, raceDay.Month, raceDay.Date);
                    couponType.couponid = Convert.ToString(couponId++);
                    couponType.trackcode = raceDay.TrackId.ToString();
                    var legTypes = new List<legType>();
                    int legId = 1;
                    foreach (var leg in kupong)
                    {
                        legType legType = new legType();
                        legType.marks = leg;
                        legType.legno = Convert.ToString(legId++);
                        legTypes.Add(legType);
                    }
                    couponType.leg = legTypes.ToArray();
                    couponTypes.Add(couponType);
                }
                betcoupons.v5Coupon = couponTypes.ToArray();
            }
            else if (raceDay.BetType == "V4")
            {
                int couponId = 1;
                var couponTypes = new List<v4CouponType>();
                foreach (var kupong in coupons)
                {
                    var couponType = new v4CouponType();
                    couponType.date = new DateTime(raceDay.Year, raceDay.Month, raceDay.Date);
                    couponType.couponid = Convert.ToString(couponId++);
                    couponType.trackcode = raceDay.TrackId.ToString();
                    var legTypes = new List<legType>();
                    int legId = 1;
                    foreach (var leg in kupong)
                    {
                        legType legType = new legType();
                        legType.marks = leg;
                        legType.legno = Convert.ToString(legId++);
                        legTypes.Add(legType);
                    }
                    couponType.leg = legTypes.ToArray();
                    couponTypes.Add(couponType);
                }
                betcoupons.v4Coupon = couponTypes.ToArray();
            }

            //var systemSize = Coupon.CountRows(legs);
            //var reducedSize = coupon.Sum(x => Coupon.CountRows(x));

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(issuer));
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xmlSerializer.Serialize(xmlTextWriter, atgXMLFile);
            xmlTextWriter.BaseStream.Position = 0;
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(request.Filename);

            Crc16 crc16 = new Crc16();
            string checkSumAsHexString = crc16.GetCheckSumAsHexString(xmlTextWriter.BaseStream);
            var fileName = string.Format("{0}_{1}_{2}_{3}.xml", fileNameWithoutExtension, request.ReducedSize, request.SystemSize, checkSumAsHexString);

            xmlTextWriter.BaseStream.Position = 0;
            StreamReader streamReader = new StreamReader(xmlTextWriter.BaseStream);
            return new BetFileResponse() { XML = streamReader.ReadToEnd(), Filename = fileName };
            //string end = streamReader.ReadToEnd();
            //StreamWriter streamWriter = new StreamWriter(fileName, false);
            //streamWriter.Write(end);
            //streamWriter.Flush();
            //streamWriter.Close();
            //xmlTextWriter.Close();
            //return fileName;
        }

        //public static void SaveTextFile(List<Leg> legs, string headerInformation, string reductionText, string informationText, string fileName)
        //{
        //    using (TextWriter tw = new StreamWriter(fileName.Replace(".xml", ".txt")))
        //    {
        //        tw.WriteLine(headerInformation);
        //        tw.WriteLine("Avd\tOrdinarie hästar");
        //        foreach (var leg in legs)
        //        {
        //            var sb = new StringBuilder();
        //            sb.AppendFormat("{0}\t", leg.Number);
        //            if (leg.Horses.Count(x => x.Rank != Ranks.None) == 1)
        //            {
        //                var horse = leg.Horses.FirstOrDefault(x => x.Rank != Ranks.None);
        //                sb.AppendFormat("{0} {1}", horse.StartNumber, horse.Name);
        //            }
        //            else
        //            {
        //                leg.Horses.OrderBy(x => x.StartNumber).Where(x => x.Rank != Ranks.None).ForEach(x => sb.AppendFormat("{0}{1}, ", x.StartNumber, x.Rank.ToString()));
        //                sb.Remove(sb.Length - 2, 2);
        //            }
        //            sb.AppendLine();
        //            tw.Write(sb);                    
        //        }

        //        tw.WriteLine();
        //        tw.WriteLine(reductionText);
        //        tw.WriteLine(informationText);
        //        tw.Close();
        //    }
        //}


        //public static void SaveTravLab(AppState appState, string fileName)
        //{
        //    try
        //    {
        //        XmlSerializer xml = new XmlSerializer(typeof(AppState));
        //        using (TextWriter tw = new StreamWriter(fileName))
        //        {
        //            xml.Serialize(tw, appState);
        //            tw.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}

        //public static AppState LoadTravLab(string fileName)
        //{
        //    AppState appState = null;
        //    try
        //    {
        //        using (TextReader tr = new StreamReader(fileName))
        //        {
        //            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(AppState));
        //            appState = xml.Deserialize(tr) as AppState;
        //            tr.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //    return appState;
        //}

        private static string CreateMarks(HorseResponse[] legs)
        {
            char[] marks = new char[] { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
            foreach (var horse in legs)
            {
                marks[horse.StartNumber - 1] = '1';
            }
            return new string(marks);
        }

        //public static List<RaceTrack> LoadRaceTracks(string fileName)
        //{
        //    var raceTracks = new List<RaceTrack>();
        //    try
        //    {
        //        using (TextReader tr = new StreamReader(fileName))
        //        {
        //            var line = tr.ReadLine();
        //            while (!string.IsNullOrEmpty(line))
        //            {
        //                var tmp = line.Split(new char [] {' '});
        //                var code = tmp[0];
        //                var abb = tmp[1];
        //                var index = line.IndexOf(abb) + abb.Count();
        //                string name = line.Substring(index).Trim();
        //                raceTracks.Add(new RaceTrack(name, abb, code));
        //                line = tr.ReadLine();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //    return raceTracks;
        //}
    }
}
