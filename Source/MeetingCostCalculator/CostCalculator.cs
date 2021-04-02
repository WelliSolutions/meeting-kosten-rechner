using System;
using System.Windows.Forms;

namespace MeetingCostCalculator
{
    public partial class CostCalculator : UserControl
    {
        public CostCalculator()
        {
            InitializeComponent();
        }

        private void frmCostCalculator_Load(object sender, EventArgs e)
        {
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
                var meetings = int.Parse(txtMeetings.Text);
                var personen = int.Parse(txtPersonen.Text);
                var dauer = double.Parse(txtDauer.Text);
                var lohn = int.Parse(txtStundenlohn.Text);
                var kosten = meetings * personen * dauer * lohn;
                lblKosten.Text = kosten.ToString("0");
            }
            catch (Exception)
            {
                lblKosten.Text = "???";
            }
        }
    }
}
