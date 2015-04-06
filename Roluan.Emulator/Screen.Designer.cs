namespace Roluan.Emulator
{
    partial class Screen
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
            this.panelScrn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelScrn
            // 
            this.panelScrn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelScrn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScrn.Location = new System.Drawing.Point(0, 0);
            this.panelScrn.Name = "panelScrn";
            this.panelScrn.Size = new System.Drawing.Size(610, 451);
            this.panelScrn.TabIndex = 0;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 451);
            this.Controls.Add(this.panelScrn);
            this.DoubleBuffered = true;
            this.Name = "Screen";
            this.Text = "Screen";
            this.Load += new System.EventHandler(this.Screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScrn;

    }
}

