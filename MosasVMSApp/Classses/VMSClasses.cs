using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosasVMSApp.Classses
{
    public class VmsModel
    {
        public int FromId { get; set; }
        public List<string> ToIds { get; set; }
    }
    public class TravelTimeModel
    {
        public string FromName { get; set; }
        public int ToName { get; set; }
        public int TravelTime { get; set; }
    }
    public class SystemValues
    {
        public int Id { get; set; }
        public int Mode { get; set; }
        public string IpAdress { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
    }
    public class Sablon
    {
        public int IsRead { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Asset> Assets { get; set; } = new List<Asset>();
        public int Index { get; set; } = 0;
    }
    public class Asset
    {
        public string Filename { get; set; }
        public int Time { get; set; }
        public int Startx { get; set; }
        public int Starty { get; set; }

        public int Filetype { get; set; }
        public int Endx { get; set; }
        public int Endy { get; set; }
    }
    public class GunlukPlan
    {
        public DayOfWeek DayOfWeek { get; set; }
        public List<Plan> Plan { get; set; }
    }
    public class Plan
    {
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public string SablonAdi { get; set; }
    }
    public class Gosterilenimge
    {
        public int IsEnable { get; set; }
        public string Path { get; set; }
        public int Startx { get; set; }
        public int Starty { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
    class VMSClasses
    {
    }
}
