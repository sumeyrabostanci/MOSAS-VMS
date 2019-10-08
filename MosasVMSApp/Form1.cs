using Microsoft.Win32;
using MosasVMSApp.Classses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MosasVMSApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                if (!key.GetValueNames().Contains("Mosas DMS Uygulaması"))
                {
                    key.SetValue("Mosas DMS Uygulaması", "\"" + Application.ExecutablePath + "\"");
                }
            }
            Globals.Init();
            frmShow frmShow = new frmShow();
            frmShow.Show();
        }
    }
}
