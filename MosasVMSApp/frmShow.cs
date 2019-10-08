using MosasVMSApp.Classses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MosasVMSApp
{
    public partial class frmShow : Form
    {
        BackgroundWorker BackgroundWorker { get; set; } = new BackgroundWorker();
        public frmShow()
        {
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            InitializeComponent();
            Globals.GeneralVariables.TryGetValue("Width", out object _w);
            Globals.GeneralVariables.TryGetValue("Height", out object _h);
            Globals.GeneralVariables.TryGetValue("StartX", out object _x);
            Globals.GeneralVariables.TryGetValue("StartY", out object _y);
            this.Width = (int)_w;
            this.Height = (int)_h;
            this.Left = (int)_x;
            this.Top = (int)_y;
            this.TopMost = true;
            //Timer _timer = new Timer();
            //_timer.Interval = 1000;
            Timer _timer = new Timer
            {
                Interval = 1000
            };
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {           
            if (!BackgroundWorker.IsBusy)
            {
                BackgroundWorker.RunWorkerAsync();
            }
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Globals.GeneralVariables.TryGetValue("GosterilenImge", out object obje1);
            Gosterilenimge obje = (Gosterilenimge)obje1; //= appClass.jsonreader.ReadAssetFile();
            if (obje.IsEnable == 1)
            {
                obje.IsEnable = 0;
                Jsonreader.WriteJsonObject(obje, "Set.json");
                Globals.GeneralVariables.AddOrUpdate("filePath", "", (k, v) => "");
                Globals.filePath = "";
            }
            else
            {
                Globals.GeneralVariables.TryGetValue("filePath", out object fp1);
                string filePath = (string)fp1;
                if (filePath == "")
                {
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Images\" + obje.Path;
                    Globals.GeneralVariables.AddOrUpdate("filePath", AppDomain.CurrentDomain.BaseDirectory + "\\Assets\\Images\\" + obje.Path, (k, v) => AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Images\" + obje.Path);

                    //displayStartX = obje.startx;
                    //displayStartY = obje.starty;
                    //if (obje.width != 0 && obje.height != 0)
                    //{
                    //    displayWidth = obje.width;
                    //    displayHeight = obje.height;
                    //}
                    bool isOk = true;
                    try
                    {
                        File.Copy(@filePath, AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Images\" + Path.GetFileNameWithoutExtension(filePath) + "_temp" + Path.GetExtension(filePath), true);
                        isOk = true;
                    }
                    catch //(Exception ex)
                    {
                        isOk = false;
                    }
                    if (isOk)
                    {
                        //filePath = AppDomain.CurrentDomain.BaseDirectory + @"\images\" + Path.GetFileNameWithoutExtension(filePath) + "_temp" + Path.GetExtension(filePath);
                        Globals.GeneralVariables.AddOrUpdate("filePath",
                            AppDomain.CurrentDomain.BaseDirectory + "\\Assets\\Images\\" + Path.GetFileNameWithoutExtension(filePath) + "_temp" + Path.GetExtension(filePath),
                            (k, v) => AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Images\" + Path.GetFileNameWithoutExtension(filePath) + "_temp" + Path.GetExtension(filePath));
                    }
                    SetImage(filePath);
                }
            }


        }
        private void SetImage(string filePath)
        {
            int fileType = 0;
            if (File.Exists(filePath))
            {
                if (Path.GetExtension(filePath) == ".bmp" || Path.GetExtension(filePath) == ".gif" || Path.GetExtension(filePath) == ".png" || Path.GetExtension(filePath) == ".jpg" || Path.GetExtension(filePath) == ".jpeg")
                {
                    fileType = 3;
                }
                else if (Path.GetExtension(filePath) == ".mp4" || Path.GetExtension(filePath) == ".avi")
                {
                    fileType = 2;
                }
                else if (Path.GetExtension(filePath) == ".swf" || Path.GetExtension(filePath) == ".flv")
                {
                    fileType = 1;
                }
                else if (Path.GetExtension(filePath) == ".txt")
                {
                    fileType = 4;
                }
            }
            else
            {
                fileType = 99;
            }
            ShowImage(fileType);
        }
        private void ShowImage(int fileType)
        {
            this.Invoke((MethodInvoker)delegate
            {
                
                Globals.GeneralVariables.TryGetValue("filePath", out object filePath1);
                string filePath = (string)filePath1;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    this.Controls[i].Visible = false;
                }
                
                pictureBox.Visible = false;
                axShockwaveFlash.Visible = false;
                //routes1.Visible = false;
                axWindowsMediaPlayer.Visible = false;
                axWindowsMediaPlayer.Ctlcontrols.stop();
                Globals.GeneralVariables.TryGetValue("StartX", out object displayStartX1);
                Globals.GeneralVariables.TryGetValue("StartY", out object displayStartY1);
                Globals.GeneralVariables.TryGetValue("Width", out object displayWidth1);
                Globals.GeneralVariables.TryGetValue("Height", out object displayHeight1);
                int displayStartX = (int)displayStartX1;
                int displayStartY = (int)displayStartY1;
                int displayWidth = (int)displayWidth1;
                int displayHeight = (int)displayHeight1;
                this.Location = new Point((int)displayStartX, (int)displayStartY);
                this.Size = new Size((int)displayWidth, (int)displayHeight);
                switch (fileType)
                {
                    case 0:
                        pictureBox.Visible = true;
                        pictureBox.Image = null;
                        pictureBox.Size = new Size(displayWidth, displayHeight);
                        break;
                    case 1:
                        axShockwaveFlash.Visible = true;
                        axShockwaveFlash.Movie = @filePath;
                        axShockwaveFlash.Size = new Size(displayWidth, displayHeight);
                        break;
                    case 2:
                        axWindowsMediaPlayer.Visible = true;
                        axWindowsMediaPlayer.URL = @filePath;
                        axWindowsMediaPlayer.settings.volume = 0;
                        axWindowsMediaPlayer.Ctlcontrols.play();
                        axWindowsMediaPlayer.uiMode = "none";
                        axWindowsMediaPlayer.settings.setMode("loop", true);
                        axWindowsMediaPlayer.Size = new Size(displayWidth, displayHeight);
                        break;
                    case 3:
                        pictureBox.Visible = true;
                        Image Img = Image.FromFile(filePath);
                        pictureBox.Image = Img;
                        pictureBox.Size = new Size(displayWidth, displayHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        //OzelAsset oa = new OzelAsset(filePath);
                        //oa.Dock = DockStyle.Left;
                        //oa.Width = this.Size.Width - 70;
                        //this.Controls.Add(oa);
                        break;
                    default:
                        //routes1.Visible = true;
                        //routes1.Width = this.Size.Width - 70;
                        break;
                }
                
            });
        }


    }
}
