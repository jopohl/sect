using System.Windows.Forms;
using EllipticCurveTool.Controller;

namespace EllipticCurveTool.View
{
    /// <summary>
    /// Form to configure parameters a,b and p of the elliptic curve
    /// </summary>
    public partial class CurveParameterForm : Form
    {
        private CurveParameterController controller;

        #region Properties
        public TextBox TextBoxParameterA
        {
            get { return textBoxParameterA; }
        }

        public CheckBox CheckBoxCurveReal
        {
            get { return checkBoxRealCurve; }
        }

        public TextBox TextBoxParameterB
        {
            get { return textBoxParameterB; }
        }

        public TextBox TextBoxParameterP
        {
            get { return textBoxParameterP; }
        }

        public Label LabelFormulaCurve
        {
            get { return labelECFormula; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return errorProvider; }
        }

        #endregion

        public CurveParameterForm(CurveParameterController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnAbort_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private void textBoxParameterA_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            controller.ValidateAorB(textBoxParameterA);
        }

        private void textBoxParameterB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            controller.ValidateAorB(textBoxParameterB);
        }

        private void textBoxParameterP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            controller.ValidateP();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (controller.ValidateForm())
            {
                controller.AcceptInputs();
            }
            else
            {
                MessageBox.Show(
                        "Please correct any invalid inputs!\n " +
                        "Hint: Hover with the mouse over an error symbol (red exclamation mark) " +
                        "for further information about the error.",
                        "Invalid inputs detected", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
            }

        }

        private void checkBoxRealCurve_CheckedChanged(object sender, System.EventArgs e)
        {
            controller.SetCurveReal(checkBoxRealCurve.Checked);
        }
    }
}
