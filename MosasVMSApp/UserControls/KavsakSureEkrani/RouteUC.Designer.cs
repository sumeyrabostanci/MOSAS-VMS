namespace MosasVMSApp.UserControls.KavsakSureEkrani
{
    partial class RouteUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RouteName = new System.Windows.Forms.RichTextBox();
            this.Time = new System.Windows.Forms.Label();
            this.pbRoute = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // RouteName
            // 
            this.RouteName.BackColor = System.Drawing.Color.Black;
            this.RouteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RouteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RouteName.ForeColor = System.Drawing.Color.Transparent;
            this.RouteName.Location = new System.Drawing.Point(0, 0);
            this.RouteName.Name = "RouteName";
            this.RouteName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RouteName.Size = new System.Drawing.Size(145, 51);
            this.RouteName.TabIndex = 6;
            this.RouteName.Text = "Selçuklu Cami";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Time.Location = new System.Drawing.Point(145, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(48, 20);
            this.Time.TabIndex = 5;
            this.Time.Text = "10dk";
            // 
            // pbRoute
            // 
            this.pbRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRoute.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbRoute.Location = new System.Drawing.Point(0, 0);
            this.pbRoute.Name = "pbRoute";
            this.pbRoute.Size = new System.Drawing.Size(0, 51);
            this.pbRoute.TabIndex = 4;
            this.pbRoute.TabStop = false;
            // 
            // RouteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RouteName);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.pbRoute);
            this.Name = "RouteUC";
            this.Size = new System.Drawing.Size(193, 51);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RouteName;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.PictureBox pbRoute;
    }
}
