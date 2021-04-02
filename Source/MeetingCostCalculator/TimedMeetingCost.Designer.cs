
namespace MeetingCostCalculator
{
    partial class TimedMeetingCost
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimedMeetingCost));
            this.lblPersonen = new System.Windows.Forms.Label();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.txtPersonen = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPer4 = new System.Windows.Forms.Label();
            this.lblStunde = new System.Windows.Forms.Label();
            this.txtStundenlohn = new System.Windows.Forms.TextBox();
            this.lblKosten = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPersonen
            // 
            this.lblPersonen.AutoSize = true;
            this.lblPersonen.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonen.Location = new System.Drawing.Point(295, 24);
            this.lblPersonen.Name = "lblPersonen";
            this.lblPersonen.Size = new System.Drawing.Size(52, 13);
            this.lblPersonen.TabIndex = 5;
            this.lblPersonen.Text = "Personen";
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPer2.Location = new System.Drawing.Point(295, 28);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(70, 13);
            this.lblPer2.TabIndex = 6;
            this.lblPer2.Text = "________  à ";
            // 
            // lblMeeting
            // 
            this.lblMeeting.AutoSize = true;
            this.lblMeeting.BackColor = System.Drawing.Color.Transparent;
            this.lblMeeting.Location = new System.Drawing.Point(295, 41);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(45, 13);
            this.lblMeeting.TabIndex = 7;
            this.lblMeeting.Text = "Meeting";
            // 
            // txtPersonen
            // 
            this.txtPersonen.Location = new System.Drawing.Point(247, 28);
            this.txtPersonen.Name = "txtPersonen";
            this.txtPersonen.Size = new System.Drawing.Size(38, 20);
            this.txtPersonen.TabIndex = 4;
            this.txtPersonen.Text = "5";
            this.txtPersonen.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.BackColor = System.Drawing.Color.Transparent;
            this.lblEuro.Location = new System.Drawing.Point(295, 57);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 13;
            this.lblEuro.Text = "Euro";
            // 
            // lblPer4
            // 
            this.lblPer4.AutoSize = true;
            this.lblPer4.BackColor = System.Drawing.Color.Transparent;
            this.lblPer4.Location = new System.Drawing.Point(295, 61);
            this.lblPer4.Name = "lblPer4";
            this.lblPer4.Size = new System.Drawing.Size(43, 13);
            this.lblPer4.TabIndex = 14;
            this.lblPer4.Text = "______";
            // 
            // lblStunde
            // 
            this.lblStunde.AutoSize = true;
            this.lblStunde.BackColor = System.Drawing.Color.Transparent;
            this.lblStunde.Location = new System.Drawing.Point(295, 74);
            this.lblStunde.Name = "lblStunde";
            this.lblStunde.Size = new System.Drawing.Size(41, 13);
            this.lblStunde.TabIndex = 15;
            this.lblStunde.Text = "Stunde";
            // 
            // txtStundenlohn
            // 
            this.txtStundenlohn.Location = new System.Drawing.Point(247, 61);
            this.txtStundenlohn.Name = "txtStundenlohn";
            this.txtStundenlohn.Size = new System.Drawing.Size(38, 20);
            this.txtStundenlohn.TabIndex = 12;
            this.txtStundenlohn.Text = "60";
            this.txtStundenlohn.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // lblKosten
            // 
            this.lblKosten.BackColor = System.Drawing.Color.Transparent;
            this.lblKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKosten.ForeColor = System.Drawing.Color.Black;
            this.lblKosten.Location = new System.Drawing.Point(94, 112);
            this.lblKosten.Name = "lblKosten";
            this.lblKosten.Size = new System.Drawing.Size(263, 45);
            this.lblKosten.TabIndex = 16;
            this.lblKosten.Text = "0,00 €";
            this.lblKosten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(206, 164);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 21;
            this.btnStartStop.Text = "▶ Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(287, 164);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "⏹ Stop";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 200;
            this.tmrTimer.Tick += new System.EventHandler(this.TimedUpdate);
            // 
            // TimedMeetingCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblKosten);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblPer4);
            this.Controls.Add(this.lblStunde);
            this.Controls.Add(this.txtStundenlohn);
            this.Controls.Add(this.lblPersonen);
            this.Controls.Add(this.lblPer2);
            this.Controls.Add(this.lblMeeting);
            this.Controls.Add(this.txtPersonen);
            this.MaximumSize = new System.Drawing.Size(488, 238);
            this.MinimumSize = new System.Drawing.Size(488, 238);
            this.Name = "TimedMeetingCost";
            this.Size = new System.Drawing.Size(488, 238);
            this.Load += new System.EventHandler(this.frmCostCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPersonen;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.Label lblMeeting;
        private System.Windows.Forms.TextBox txtPersonen;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblPer4;
        private System.Windows.Forms.Label lblStunde;
        private System.Windows.Forms.TextBox txtStundenlohn;
        private System.Windows.Forms.Label lblKosten;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer tmrTimer;
    }
}

