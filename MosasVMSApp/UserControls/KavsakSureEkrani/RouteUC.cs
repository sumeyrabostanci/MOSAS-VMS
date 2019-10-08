using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosasVMSApp.Properties;

namespace MosasVMSApp.UserControls.KavsakSureEkrani
{
    public partial class RouteUC : UserControl
    {
        public RouteUC()
        {
            InitializeComponent();
        }
        public RouteUC(int Route, string RouteName, string Timevalue)
        {
            InitializeComponent();

            this.RouteName.Text = RouteName;
            Time.Text = Timevalue;
            switch (Route)
            {
                case 1:
                    pbRoute.BackgroundImage = Resources.arrow_up;
                    break;
                case 2:
                    pbRoute.BackgroundImage = Resources.arrow_left;
                    break;
                case 3:
                    pbRoute.BackgroundImage = Resources.arrow_right;
                    break;
                case 4:
                    pbRoute.BackgroundImage = Resources.arrow_down;
                    break;
                default:
                    break;
            }
        }
        public RouteUC(int Route, string RouteName, string Timevalue, string color, int state, string simge)
        {
            InitializeComponent();
            switch (color)
            {
                case "green":
                case "yeşil":
                case "yesil":
                case "Yeşil":
                case "Yesil":
                case "Green":
                    //this.BackColor = Color.Green;
                    this.RouteName.BackColor = Color.Green;
                    this.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "blue":
                case "Blue":
                case "mavi":
                case "Mavi":
                    //this.BackColor = Color.Blue;
                    this.RouteName.BackColor = Color.Blue;
                    this.BorderStyle = BorderStyle.FixedSingle;
                    break;
                default:
                    break;
            }

            //if (simge == null)
            //    this.RouteName.Font = new Font("Arial", RouteName.Length > 10 ? 14 : 18, FontStyle.Bold);
            //else
            //{
            //    if (Timevalue.Length > 0)
            //    {
            //        this.RouteName.Font = new Font("Arial", RouteName.Length > 10 ? 14 : 18, FontStyle.Bold);
            //    }
            //    else
            //    {
            //        this.RouteName.Font = new Font("Arial", RouteName.Length > 10 ? 14 : 18, FontStyle.Bold);
            //    }
            //}



            Time.Text = Timevalue;
            this.Time.Font = new Font("Arial", Timevalue.Length > 3 ? 14 : 16, FontStyle.Bold);
            if (simge != null)
                switch (simge)
                {
                    case "H":
                        pbRoute.Width = 50;
                        pbRoute.BackgroundImage = Resources.hastane;
                        break;
                    case "G":
                        pbRoute.Width = 50;
                        pbRoute.BackgroundImage = Resources.tcdd;
                        break;
                    case "S":
                        pbRoute.Width = 50;
                        pbRoute.BackgroundImage = Resources.stad;
                        break;
                    case "U":
                        pbRoute.Width = 50;
                        pbRoute.BackgroundImage = Resources.sakunv;
                        break;
                    case "T":
                        pbRoute.Width = 50;
                        pbRoute.BackgroundImage = Resources.bus;
                        break;
                    default:
                        break;
                }
            switch (state)
            {
                case 1:
                    Time.ForeColor = Color.LightGreen;
                    break;
                case 2:
                    Time.ForeColor = Color.Yellow;
                    break;
                case 3:
                    Time.ForeColor = Color.OrangeRed;
                    break;
            }
            this.RouteName.Text = RouteName;
            //this.RouteName. //RouteName.Length > 10 ? (float)14 : (float)20;
            this.RouteName.Font = new Font("Arial", RouteName.Length < 6 ? 18 : RouteName.Length < 10 ? 16 : 14, FontStyle.Bold);

        }
        private Font GetCorrectFont(Graphics graphic, String text, Size maxStringSize, Font labelFont)
        {
            maxStringSize.Width -= 20;
            //based on the Label string,we need to vary font size 
            //current width the text string
            SizeF sizeStr = graphic.MeasureString(text, labelFont);
            Font fontStr = new Font(labelFont.Name, labelFont.Size, FontStyle.Bold);
            float newSize = fontStr.Size;
            while (sizeStr.Height < maxStringSize.Height && sizeStr.Width < maxStringSize.Width)
            {

                newSize++;
                //this creates a new font with given fontfamily name
                fontStr = new Font(labelFont.Name, newSize);
                sizeStr = graphic.MeasureString(text, fontStr);
            }
            newSize--;
            //this creates a new font with given fontfamily name
            fontStr = new Font(labelFont.Name, newSize);
            sizeStr = graphic.MeasureString(text, fontStr);
            return fontStr;
        }
    }
}
