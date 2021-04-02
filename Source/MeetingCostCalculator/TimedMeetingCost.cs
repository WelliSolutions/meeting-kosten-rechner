using System;
using System.Windows.Forms;

namespace MeetingCostCalculator
{
    public partial class TimedMeetingCost : UserControl
    {
        public TimedMeetingCost()
        {
            InitializeComponent();
        }

        private void frmCostCalculator_Load(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            Calculate();
        }

        private void InputChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                var personen = int.Parse(txtPersonen.Text);
                var lohn = int.Parse(txtStundenlohn.Text);
                var kosten = personen * (DateTime.Now-StartTime).TotalSeconds * lohn /60/60;
                lblKosten.Text = kosten.ToString("0.00 €");
            }
            catch (Exception)
            {
                lblKosten.Text = (DateTime.Now - StartTime).ToString("mm\\:ss");
            }
        }

        private void TimedUpdate(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            btnStartStop.Enabled = false;
            btnReset.Enabled = true;
            tmrTimer.Enabled = true;
        }

        public DateTime StartTime { get; set; }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tmrTimer.Enabled = false;
            btnReset.Enabled = false;
            btnStartStop.Enabled = true;
        }
    }
}
