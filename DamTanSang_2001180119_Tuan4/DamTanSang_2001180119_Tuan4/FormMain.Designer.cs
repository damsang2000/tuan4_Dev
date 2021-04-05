namespace DamTanSang_2001180119_Tuan4
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnToolStripMenuItem,
            this.nhânSựToolStripMenuItem,
            this.chấmCôngToolStripMenuItem,
            this.tínhLươngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.quảnToolStripMenuItem.Text = "Quản Lý Người Dùng";
            // 
            // nhânSựToolStripMenuItem
            // 
            this.nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
            this.nhânSựToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.nhânSựToolStripMenuItem.Text = "Nhân Sự";
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.chấmCôngToolStripMenuItem.Text = "Chấm Công";
            // 
            // tínhLươngToolStripMenuItem
            // 
            this.tínhLươngToolStripMenuItem.Name = "tínhLươngToolStripMenuItem";
            this.tínhLươngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tínhLươngToolStripMenuItem.Text = "Tính Lương";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(445, 304);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhLươngToolStripMenuItem;
    }
}