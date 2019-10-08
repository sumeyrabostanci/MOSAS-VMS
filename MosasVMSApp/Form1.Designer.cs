namespace MosasVMSApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtConnectionCtrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtAktifSablon = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbislem = new System.Windows.Forms.ToolStripProgressBar();
            this.txtAppStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.systemModeUC1 = new MosasVMSApp.UserControls.DuzenlemeEkranı.SystemModeUC();
            this.sablonAyarlama1 = new MosasVMSApp.UserControls.DuzenlemeEkranı.SablonAyarlama();
            this.kavsakSureleri1 = new MosasVMSApp.UserControls.DuzenlemeEkranı.KavsakSureleri();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtConnectionCtrl,
            this.txtAktifSablon,
            this.pbislem,
            this.txtAppStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtConnectionCtrl
            // 
            this.txtConnectionCtrl.Name = "txtConnectionCtrl";
            this.txtConnectionCtrl.Size = new System.Drawing.Size(99, 17);
            this.txtConnectionCtrl.Text = "Bağlantı Kontrolü";
            // 
            // txtAktifSablon
            // 
            this.txtAktifSablon.Name = "txtAktifSablon";
            this.txtAktifSablon.Size = new System.Drawing.Size(96, 17);
            this.txtAktifSablon.Text = "Aktif Şablon İsmi";
            // 
            // pbislem
            // 
            this.pbislem.Name = "pbislem";
            this.pbislem.Size = new System.Drawing.Size(90, 16);
            this.pbislem.Value = 100;
            // 
            // txtAppStatus
            // 
            this.txtAppStatus.Name = "txtAppStatus";
            this.txtAppStatus.Size = new System.Drawing.Size(34, 17);
            this.txtAppStatus.Text = "Hazır";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 419);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.systemModeUC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(547, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sistem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sablonAyarlama1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(616, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Şablon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.kavsakSureleri1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(616, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Süreler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(547, 364);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Özel İmge";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(547, 364);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Haftalık Plan";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(547, 364);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Yıllık Plan";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // systemModeUC1
            // 
            this.systemModeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemModeUC1.Location = new System.Drawing.Point(3, 2);
            this.systemModeUC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.systemModeUC1.Name = "systemModeUC1";
            this.systemModeUC1.Size = new System.Drawing.Size(541, 360);
            this.systemModeUC1.TabIndex = 0;
            // 
            // sablonAyarlama1
            // 
            this.sablonAyarlama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sablonAyarlama1.Location = new System.Drawing.Point(3, 2);
            this.sablonAyarlama1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sablonAyarlama1.Name = "sablonAyarlama1";
            this.sablonAyarlama1.Size = new System.Drawing.Size(610, 387);
            this.sablonAyarlama1.TabIndex = 0;
            // 
            // kavsakSureleri1
            // 
            this.kavsakSureleri1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kavsakSureleri1.Location = new System.Drawing.Point(0, 0);
            this.kavsakSureleri1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kavsakSureleri1.Name = "kavsakSureleri1";
            this.kavsakSureleri1.Size = new System.Drawing.Size(616, 391);
            this.kavsakSureleri1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMS Kontrol";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtConnectionCtrl;
        private System.Windows.Forms.ToolStripStatusLabel txtAktifSablon;
        private System.Windows.Forms.ToolStripProgressBar pbislem;
        private System.Windows.Forms.ToolStripStatusLabel txtAppStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private UserControls.DuzenlemeEkranı.SystemModeUC systemModeUC1;
        private UserControls.DuzenlemeEkranı.SablonAyarlama sablonAyarlama1;
        private UserControls.DuzenlemeEkranı.KavsakSureleri kavsakSureleri1;
    }
}

