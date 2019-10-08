namespace MosasVMSApp.UserControls.KavsakSureEkrani
{
    partial class RoutesGrid
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
            this.RoutesTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // RoutesTable
            // 
            this.RoutesTable.ColumnCount = 2;
            this.RoutesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RoutesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RoutesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoutesTable.Location = new System.Drawing.Point(0, 0);
            this.RoutesTable.Name = "RoutesTable";
            this.RoutesTable.RowCount = 2;
            this.RoutesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RoutesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RoutesTable.Size = new System.Drawing.Size(494, 252);
            this.RoutesTable.TabIndex = 1;
            // 
            // RoutesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoutesTable);
            this.Name = "RoutesGrid";
            this.Size = new System.Drawing.Size(494, 252);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RoutesTable;
    }
}
