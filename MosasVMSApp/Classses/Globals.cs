using Microsoft.Win32;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosasVMSApp.Classses
{
    public static class Globals
    {
        public static ConcurrentDictionary<string, object> GeneralVariables { get; set; } = new ConcurrentDictionary<string, object>();

        public static string filePath = "";

        static System.Windows.Forms.Timer SablonKontrol { get; set; } = new System.Windows.Forms.Timer();

        public static string[] reading_data = new string[100];
        public static Sablon Sablon { set; get; }
        private static List<GunlukPlan> HaftalikPlan { get; set; }
        static List<Plan> YillikPlan { get; set; }


        public static int SystemMode { get; set; } = 1;
        public static int DisplayStartX { get; set; } = 0;
        public static int DisplayStartY { get; set; } = 0;
        public static int DisplayWidth { get; set; } = 870;
        public static int DisplayHeight { get; set; } = 200;
        public static int Systemid { get; set; } = 0;
        public static string ServerIpAddress { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static void Init()
        {
            SystemValues sv = Jsonreader.ReadSystemFile();
            Systemid = sv.Id;
            SystemMode = sv.Mode;
            DisplayStartX = sv.StartX;
            DisplayStartY = sv.StartY;
            DisplayWidth = sv.Width;
            DisplayHeight = sv.Height;
            ServerIpAddress = sv.IpAdress;
            
            GeneralVariables.AddOrUpdate("SystemValues", sv, (k, v) => sv);
            GeneralVariables.AddOrUpdate("SystemMode", sv.Mode, (k, v) => sv.Mode);
            GeneralVariables.AddOrUpdate("StartX", sv.StartX, (k, v) => sv.StartX);
            GeneralVariables.AddOrUpdate("StartY", sv.StartY, (k, v) => sv.StartY);
            GeneralVariables.AddOrUpdate("Width", sv.Width, (k, v) => sv.Width);
            GeneralVariables.AddOrUpdate("Height", sv.Height, (k, v) => sv.Height);
            GeneralVariables.AddOrUpdate("ServerAddress", sv.IpAdress, (k, v) => sv.IpAdress);
            switch (SystemMode)
            {
                case 1:
                    GeneralVariables.AddOrUpdate("SablonAdi", "Sablon", (k, v) => "Sablon");
                    Read_sablon("Sablon");
                    break;
                case 2:
                    YillikPlan = Jsonreader.ReadYillikFile();
                    HaftalikPlan = Jsonreader.ReadHaftalikFile();
                    /*System.Windows.Forms.Timer checker = new System.Windows.Forms.Timer();
                    checker.Interval = 60000;*/

                    System.Windows.Forms.Timer checker = new System.Windows.Forms.Timer
                    {
                        Interval = 60000
                    };

                    //checker.Tick += Checker_Tick;
                    checker.Start();
                    Read_sablon("Sablon");
                    break;
                case 3:
                    GeneralVariables.AddOrUpdate("SablonAdi", "Sablon3", (k, v) => "Sablon3");
                    Read_sablon("Sablon3");
                    break;
                default:
                    break;
            }

        }
        public static void Read_sablon(string SablonAdi)
        {
            Sablon Sablon_temp = Jsonreader.ReadTemplateFile(SablonAdi + ".json");
            if (Sablon_temp.IsRead == 1)
            {
                Sablon_temp.IsRead = 0;
                GeneralVariables.AddOrUpdate("Sablon", Sablon_temp, (k, v) => Sablon_temp);
                Jsonreader.WriteJsonObject(Sablon_temp, @"\Assets\Sablonlar\" + SablonAdi + ".json");
                if (Sablon_temp.Assets.Count > 0)
                {
                    if (Sablon_temp.Assets[Sablon_temp.Index].Time != 0)
                    {
                        SablonKontrol.Interval = Sablon_temp.Assets[Sablon_temp.Index].Time * 1000;
                    }
                }
            }
            else if (Sablon == null)
            {
                Sablon = Sablon_temp;
                GeneralVariables.AddOrUpdate("Sablon", Sablon_temp, (k, v) => Sablon_temp);
            }
            /*SablonKontrol = new System.Windows.Forms.Timer();
            SablonKontrol.Interval = 1000;*/

            SablonKontrol = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            SablonKontrol.Tick += Tm_Tick;
            SablonKontrol.Start();

        }

        private static void Tm_Tick(object sender, EventArgs e)
        {
            GeneralVariables.TryGetValue("Sablon", out object Sablon1);
            Sablon Sablon = (Sablon)Sablon1;
            Sablon.Index = (Sablon.Index + 1) % (Sablon.Assets.Count + 1);
            if (Sablon.Index == 0)
            {
            }
            GeneralVariables.AddOrUpdate("Sablon", Sablon, (k, v) => Sablon);
            if (Sablon.Index == Sablon.Assets.Count)
            {
                GeneralVariables.TryGetValue("SablonAdi", out object sablonadi);
                Read_sablon((string)sablonadi);
                (sender as System.Windows.Forms.Timer).Stop();
                (sender as System.Windows.Forms.Timer).Dispose();
                return;
            }
            Gosterilenimge gi = new Gosterilenimge()
            {
                IsEnable = 1,
                Path = Sablon.Assets[Sablon.Index].Filename,
                Startx = Sablon.Assets[Sablon.Index].Startx,
                Starty = Sablon.Assets[Sablon.Index].Starty,
                Width = Sablon.Assets[Sablon.Index].Endx,
                Height = Sablon.Assets[Sablon.Index].Endy,
            };
            object temp = GeneralVariables.AddOrUpdate("GosterilenImge", gi, (k, v) => gi);
            (sender as System.Windows.Forms.Timer).Interval = Sablon.Assets[Sablon.Index].Time * 1000;
            Jsonreader.WriteJsonObject(gi, @"\Assets\Set.json");

        }

    }
}
