using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosasVMSApp.Classses
{
    public class KavsakSureleri
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Mesafe { get; set; }
        public List<KavsakSuresi> Kavsaklar { get; set; }
        public List<int> Yonler { get; set; }
    }
}
