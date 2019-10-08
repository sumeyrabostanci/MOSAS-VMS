using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosasVMSApp.Classses;
using System.IO;
using MosasVMSApp.Properties;

namespace MosasVMSApp.UserControls.KavsakSureEkrani
{
    public partial class RoutesGrid : UserControl
    {
        int column = 0;
        int row = 0;
        List<KavsakSuresi> kavsaks = new List<KavsakSuresi>();
        KavsakSureleri KavsakSureleri { get; set; }
        public RoutesGrid(int r, int c, List<KavsakSuresi> ks)
        {
            InitializeComponent();
            ReadKavsakSureleri();
            Timer timer = new Timer
            {
                Interval = 10000
            };
            timer.Tick += Timer_Tick;
            timer.Start();
            this.RoutesTable.CellPaint += TableLayoutPanel_CellPaint;
            GenerateTable(column, row);
        }
        private void TableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.White, new Point(e.CellBounds.Right, e.CellBounds.Top), new Point(e.CellBounds.Right, e.CellBounds.Bottom));
        }
        public RoutesGrid()
        {
            InitializeComponent();

            Timer timer = new Timer
            {
                Interval = 1800000 / 3 //30 dk
            };
            timer.Tick += Timer_Tick1; ;
            timer.Start();

            KavsakSureleri kks = Jsonreader.ReadTimeFile();
            KavsakSureleri = kks;
            kavsaks = kks.Kavsaklar;
            column = kks.Column;
            row = kks.Row;
            //GenerateTable(kks.column, kks.row);
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }
        public void GenerateColumnsGorevi()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            KavsakSureleri =  Jsonreader.ReadTimeFile();
            kavsaks = KavsakSureleri.Kavsaklar;
            VmsModel vmsModel = new VmsModel
            {
                FromId = Globals.Systemid,
                ToIds = new List<string>()
            };
            foreach (var item in kavsaks)
            {
                //if (item.Id != null && item.Id != 0)
                if (item.Id != 0) 
                {
                    vmsModel.ToIds.Clear();
                    vmsModel.ToIds.Add(item.Id.ToString());
                    List< TravelTimeModel> ttm =  WebApiConnection.ReadSureler(vmsModel);
                    try
                    {
                        if (ttm != null && ttm.Count > 0)
                        {
                            foreach (var item1 in ttm)
                            {
                                item.Sure = (item1.TravelTime / 60) + "";
                            }
                        }
                        else
                        {
                            item.Sure = "0";
                        }
                    }
                    catch //(Exception ex)
                    {
                        item.Sure = "0";
                    }
                }
            }

            //KavsakSureleri.kavsaklar.Clear();
            //KavsakSureleri.kavsaklar .AddRange( kavsaks);
             Jsonreader.WriteJsonObject(KavsakSureleri, "KavsakSureleri.json");
            //kavsaks.Clear();
            //KavsakSureleri kks =  jsonreader.ReadTimeFile();
            //kavsaks = kks.kavsaklar;
            //GenerateTable(kks.column, kks.row);
            GenerateTable(column, row);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            kavsaks.Clear();
            ReadKavsakSureleri();
            GenerateTable(column, row);
        }

        private void ReadKavsakSureleri()
        {
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\KavsakSureleri.txt", Encoding.UTF8))
            {
                int index = 0;
                while (sr.Peek() >= 0)
                {
                    string readLine = sr.ReadLine();
                    switch (index)
                    {
                        case 0:
                            column = Convert.ToInt32(readLine);
                            break;
                        case 1:
                            row = Convert.ToInt32(readLine);
                            break;
                        default:
                            int v = (index - 2) % 6;
                            switch (v)
                            {
                                case 0:
                                    kavsaks.Add(new KavsakSuresi() { Adi = readLine });
                                    break;
                                case 1:
                                    kavsaks[kavsaks.Count - 1].Yonu = Convert.ToInt32(readLine);
                                    break;
                                case 2:
                                    kavsaks[kavsaks.Count - 1].Sure = readLine;
                                    break;
                                case 3:
                                    kavsaks[kavsaks.Count - 1].X = Convert.ToInt32(readLine);
                                    break;
                                case 4:
                                    kavsaks[kavsaks.Count - 1].Y = Convert.ToInt32(readLine);
                                    break;
                                case 5:
                                    kavsaks[kavsaks.Count - 1].Rengi = readLine;
                                    break;
                                default:
                                    break;
                            }
                            break;
                    }
                    index++;
                }
                KavsakSureleri ks = new KavsakSureleri
                {
                    Column = column,
                    Row = row,
                    Kavsaklar = kavsaks
                };
                // jsonreader.WriteJsonObject(ks,"KavsakSureleri.json");
            }
        }
        public void GenerateTable(int columnCount, int rowCount)
        {
            RoutesTable.Invoke(new Action(() =>
            {
                //Clear out the existing controls, we are generating a new table layout
                RoutesTable.Controls.Clear();

                //Clear out the existing row and column styles
                RoutesTable.ColumnStyles.Clear();
                RoutesTable.RowStyles.Clear();

                //Now we will generate the table, setting up the row and column counts first
                RoutesTable.ColumnCount = columnCount;
                RoutesTable.RowCount = rowCount;
                for (int x = 0; x < columnCount; x++)
                {
                    //First add a column
                    RoutesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount));

                    for (int y = 0; y < rowCount + 1; y++)
                    {
                        //Next, add a row.  Only do this when once, when creating the first column
                        if (x == 0)
                        {
                            RoutesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));
                        }

                        //Create the control, in this case we will add a button
                        KavsakSuresi ks = kavsaks.Find(p => p.X == x && p.Y == y);
                        if (ks != null)
                        {
                            string sure = "";
                            if (Convert.ToInt32(ks.Sure) > 0)
                                sure = ks.Sure + "dk";
                            //System.Windows.Forms.Integration.ElementHost elementHost1 = new System.Windows.Forms.Integration.ElementHost();

                            //RouteUC cmd = new RouteUC(ks.yonu, ks.adi, sure, ks.rengi, Convert.ToInt32(ks.sure) < ks.min ? 1 : Convert.ToInt32(ks.sure) < ks.max ? 2 : 3, ks.simge);
                            RouteUC cmd = new RouteUC(ks.Yonu, ks.Adi, sure, ks.Rengi, Convert.ToInt32(ks.Sure) < ks.Min ? 1 : Convert.ToInt32(ks.Sure) < ks.Max ? 2 : 3, ks.Simge)
                            {

                                //elementHost1.Child=cmd;
                                Dock = DockStyle.Fill       //Finally, add the control to the correct location in the table
                            };
                            RoutesTable.Controls.Add(cmd, x, y);
                        }
                        else
                        {
                            if (y == rowCount)
                            {
                                PictureBox pb = new PictureBox() { Dock = DockStyle.Fill, BackgroundImageLayout = ImageLayout.Zoom };
                                switch (KavsakSureleri.Yonler[x])
                                {
                                    case 1:
                                        pb.BackgroundImage = Resources.arrow_down;
                                        break;
                                    case 2:
                                        pb.BackgroundImage = Resources.arrow_left_up;
                                        break;
                                    case 3:
                                        pb.BackgroundImage = Resources.arrow_right_up;
                                        break;
                                    case 4:
                                        pb.BackgroundImage = Resources.arrow_up;
                                        break;
                                    default:
                                        break;
                                }
                                RoutesTable.Controls.Add(pb, x, y);
                                if (x == columnCount - 1)
                                {
                                    if (KavsakSureleri.Mesafe != 0)
                                    {
                                        RoutesTable.Dock = DockStyle.Top;
                                        RoutesTable.Height = Globals.Height - 20;

                                        Label lblMesafe = new Label() { Name = "lblMesafe", Left = Globals.Width - 150, Top = Globals.Height - 20, ForeColor = Color.White, BackColor = Color.Black };
                                        lblMesafe.Text = (KavsakSureleri.Mesafe != 0 ? KavsakSureleri.Mesafe + "mt." : "");
                                        lblMesafe.Font = new Font("Arial", 14, FontStyle.Bold);
                                        int wal = (int)lblMesafe.CreateGraphics().MeasureString(lblMesafe.Text, lblMesafe.Font).Width;
                                        lblMesafe.Left = Globals.Width - 70 - wal;
                                        lblMesafe.BorderStyle = BorderStyle.Fixed3D;
                                        this.Controls.Add(lblMesafe);
                                    }
                                }
                            }
                        }
                    }
                }
                this.RoutesTable.CellPaint += TableLayoutPanel_CellPaint;
            }));
        }
    }
}
