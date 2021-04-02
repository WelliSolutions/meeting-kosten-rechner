using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetingCostCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<UserControl> Calculators { get; set; } = new List<UserControl>();
        private int _showIndex = -1;

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            HideAllCalculators();
            AddAllCalculators();
            ShowNextCalculator();
        }

        private void AddAllCalculators()
        {
            foreach (var calculator in Calculators)
            {
                Controls.Add(calculator);
            }
        }

        private void HideAllCalculators()
        {
            foreach (var calculator in Calculators)
            {
                calculator.Visible = false;
            }
        }

        private void lblBurgerMenu_Click(object sender, System.EventArgs e)
        {
            ShowNextCalculator();
        }

        private void ShowNextCalculator()
        {
            SuspendLayout();
            _showIndex++;
            _showIndex %= Calculators.Count;
            HideAllCalculators();
            Calculators[_showIndex].Visible = true;
            ResumeLayout();
        }
    }
}
