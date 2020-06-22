using System.Windows.Forms;

namespace EllipticCurveTool.View
{
    public partial class CalculationForm : Form
    {
        public CalculationForm(string calculations)
        {
            InitializeComponent();
            richTextBoxCalculations.Text = calculations;
        }
    }
}
