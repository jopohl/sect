using System.Windows.Forms;

namespace EllipticCurves.View
{
    public partial class CalculationForm : Form
    {
        public CalculationForm(string rechnung)
        {
            InitializeComponent();
            rTBRechnung.Text = rechnung;
        }
    }
}
