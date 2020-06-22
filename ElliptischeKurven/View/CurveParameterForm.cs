using System.Windows.Forms;
using EllipticCurves.Controller;

namespace EllipticCurves.View
{
    /// <summary>
    /// Form zum Festlegen der Parameter a,b und p der elliptischen Kurve
    /// </summary>
    public partial class CurveParameterForm : Form
    {
        private CurveParameterController controller;

        #region Properties
        /// <summary>
        /// Textbox zum Festlegen von Parameter a der elliptischen Kurve
        /// </summary>
        public TextBox TextBoxParameterA
        {
            get { return tBoxParameterA; }
        }

        public CheckBox CheckBoxCurveReal
        {
            get { return cbReell; }
        }

        /// <summary>
        /// Textbox zum Festlegen von Parameter b der elliptischen Kurve
        /// </summary>
        public TextBox TextBoxParameterB
        {
            get { return tBoxParameterB; }
        }

        /// <summary>
        /// Textbox zum Festlegen von Parameter p der elliptischen Kurve
        /// </summary>
        public TextBox TextBoxParameterP
        {
            get { return tBoxParameterP; }
        }

        public Label LabelFormulaCurve
        {
            get { return lAllgemeineFormelElliptischeKurve; }
        }

        /// <summary>
        /// Der ErrorProvider dieses Forms zum Verwalten von fehlerhaften Nutzereingaben.
        /// </summary>
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

        private void btnAbbrechen_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private void tBoxParameterA_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            controller.ValidateAorB(tBoxParameterA);
        }

        private void tBoxParameterB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            controller.ValidateAorB(tBoxParameterB);
        }

        private void tBoxParameterP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
                        "Bitte korrigieren Sie die fehlerhaften Eingaben!\n Hinweis:Wenn Sie mit der Maus über ein Fehlersymbol (Rotes Ausrufezeichen) fahren,"
                        + " bekommen Sie nähere Informationen zum entsprechenden Fehler.",
                        "Fehlerhafte Eingaben festgestellt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbReell_CheckedChanged(object sender, System.EventArgs e)
        {
            controller.SetCurveReal(cbReell.Checked);
        }
    }
}
