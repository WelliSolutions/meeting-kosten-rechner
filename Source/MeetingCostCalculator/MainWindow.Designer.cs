
namespace MeetingCostCalculator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblBurgerMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBurgerMenu
            // 
            this.lblBurgerMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBurgerMenu.AutoSize = true;
            this.lblBurgerMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblBurgerMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurgerMenu.Location = new System.Drawing.Point(432, 195);
            this.lblBurgerMenu.Name = "lblBurgerMenu";
            this.lblBurgerMenu.Size = new System.Drawing.Size(24, 22);
            this.lblBurgerMenu.TabIndex = 0;
            this.lblBurgerMenu.Text = "☰";
            this.lblBurgerMenu.Click += new System.EventHandler(this.lblBurgerMenu_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 230);
            this.Controls.Add(this.lblBurgerMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 269);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(488, 269);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting-Kosten-Rechner";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBurgerMenu;
    }
}