using System;
using System.Windows.Forms;

namespace MeetingCostCalculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var window = new MainWindow();
            window.Calculators.Add(new TimedMeetingCost());
            window.Calculators.Add(new CostCalculator());
            Application.Run(window);
        }
    }
}
