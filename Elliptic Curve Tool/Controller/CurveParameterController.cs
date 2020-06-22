using System.Windows.Forms;
using EllipticCurves.EC;
using EllipticCurves.View;

namespace EllipticCurves.Controller
{
    public class CurveParameterController
    {
        private readonly MainController parentController;
        private bool isCurveReal;

        private string GetNumberErrorMessage(int minimum, int maximum)
        {
            return string.Format("The entered number is not valid. It must be greater than {0} and smaller than {1}", minimum, maximum);
        }

        public CurveParameterForm Form { private set; get; }

        public CurveParameterController(int a, int b, int xmin, int xmax, MainController parentController)
        {
            Form = new CurveParameterForm(this);
            Form.TextBoxParameterA.Text = a.ToString();
            Form.TextBoxParameterB.Text = b.ToString();
            this.parentController = parentController;

            SetCurveReal(true);
        }

        public CurveParameterController(int a, int b, int p, MainController parentController)
        {
            Form = new CurveParameterForm(this);
            Form.TextBoxParameterA.Text = a.ToString();
            Form.TextBoxParameterB.Text = b.ToString();
            Form.TextBoxParameterP.Text = p.ToString();
            this.parentController = parentController;

            SetCurveReal(false);
        }

        public bool ValidateAorB(TextBox textBox)
        {
            int aorb;

            if (isCurveReal && !int.TryParse(textBox.Text, out aorb))
            {
                Form.ErrorProvider.SetError(textBox, GetNumberErrorMessage(int.MinValue, int.MaxValue));
                return false;
            }

            if (!isCurveReal && (!int.TryParse(textBox.Text, out aorb) || aorb <= 0))
            {
                Form.ErrorProvider.SetError(textBox, GetNumberErrorMessage(0, int.MaxValue));
                return false;
            }

            Form.ErrorProvider.SetError(textBox, string.Empty);
            return true;
        }

        public bool ValidateP()
        {
            if (isCurveReal)
            {
                Form.ErrorProvider.SetError(Form.TextBoxParameterP, string.Empty);
                return true;
            }
            int p;

            if (!int.TryParse(Form.TextBoxParameterP.Text, out p) || p <= 0)
            {
                Form.ErrorProvider.SetError(Form.TextBoxParameterP, GetNumberErrorMessage(0, int.MaxValue));
                return false;
            }

            if (!p.IsPrime() || p <= 3)
            {
                Form.ErrorProvider.SetError(Form.TextBoxParameterP, "The parameter p must be a prime number greater than 3.");
                return false;
            }

            Form.ErrorProvider.SetError(Form.TextBoxParameterP, string.Empty);
            return true;
        }

        public bool ValidateXminOrXmax(TextBox textBox)
        {
            int xminOrXmax;

            if (!int.TryParse(textBox.Text, out xminOrXmax))
            {
                Form.ErrorProvider.SetError(textBox, GetNumberErrorMessage(int.MinValue, int.MaxValue));
                return false;
            }

            Form.ErrorProvider.SetError(textBox, string.Empty);
            return true;
        }

        public bool ValidateForm()
        {
            if (!ValidateAorB(Form.TextBoxParameterA))
                return false;
            if (!ValidateAorB(Form.TextBoxParameterB))
                return false;

            int a = int.Parse(Form.TextBoxParameterA.Text);
            int b = int.Parse(Form.TextBoxParameterB.Text);

            if (!isCurveReal)
            {
                if (!ValidateP())
                    return false;
                int p = int.Parse(Form.TextBoxParameterP.Text);

                if (a >= p)
                {
                    Form.ErrorProvider.SetError(Form.TextBoxParameterA, "The value of a must be smaller than p = " + p + ".");
                    return false;
                }

                if (b >= p)
                {
                    Form.ErrorProvider.SetError(Form.TextBoxParameterB, "The value of b must be smaller than p = " + p + ".");
                    return false;
                }

                if ((4 * a * a * a + 27 * b * b).Mod(p) == 0)
                {
                    string error = "For parameters a and b the following condition must hold: 4a³ + 27b² " + '\u2260' + "0 mod p";
                    Form.ErrorProvider.SetError(Form.TextBoxParameterA, error);
                    Form.ErrorProvider.SetError(Form.TextBoxParameterB, error);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Accept the inputs and pass them to the MainController.
        /// Close this form afterwards.
        /// </summary>
        public void AcceptInputs()
        {
            int a = int.Parse(Form.TextBoxParameterA.Text);
            int b = int.Parse(Form.TextBoxParameterB.Text);
            if (!isCurveReal)
            {
                int p = int.Parse(Form.TextBoxParameterP.Text);
                if (p > 1000)
                {
                    const string info = "You entered a very large prime (> 1000) as modulus. " +
                                        "Depending on your system the calculation of the curve may take a significant amount of time." +
                                        "\nMoreover, some points will be so close to each other in the graph that you can barely distinguish them. " +
                                        "\n\nDo you really want to proceed?\n\n\n" +
                                        "Hint:\nClicking \"Yes\" will draw the curve anyway.\n\n" +
                                        "Clicking \"No\" will accept the curve (for calculations), but not draw it into the coordinate system.\n" +
                                        "Caution: Even then the program may not react for a while due to heavy computation.\n\n" +
                                        "Click \"Abort\" will leave you in this dialog and enable you to enter another prime modulus.";
                    DialogResult dialogResult = MessageBox.Show(info, "Warning: Large prime number detected", MessageBoxButtons.YesNoCancel,
                                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                    if (dialogResult == DialogResult.Yes)
                        parentController.ShouldCurveBeDrawed = true;

                    if (dialogResult == DialogResult.No)
                        parentController.ShouldCurveBeDrawed = false;

                    if (dialogResult == DialogResult.Cancel)
                        return;
                }
                else
                {
                    parentController.ShouldCurveBeDrawed = true;
                }

                parentController.CreateIntCurve(a, b, p);
            }
            else
            {
                parentController.CreateRealCurve(a, b);
            }
            Form.Close();
        }

        /// <summary>
        /// Switch between a curve over the real number R and Z_p
        /// </summary>
        /// <param name="curveReal">True, if curve should be over real numbers else false</param>
        public void SetCurveReal(bool curveReal)
        {
            Form.TextBoxParameterP.Enabled = !curveReal;
            Form.CheckBoxCurveReal.Checked = curveReal;
            if (curveReal)
            {
                Form.LabelFormulaCurve.Text = "y² = x³ + ax + b";
                Form.ErrorProvider.SetError(Form.TextBoxParameterP, string.Empty);
            }
            else
            {
                Form.LabelFormulaCurve.Text = "y² " + '\u2261' + " x³ + ax + b mod p";
            }
            isCurveReal = curveReal;
            ValidateAorB(Form.TextBoxParameterA);
            ValidateAorB(Form.TextBoxParameterB);
        }
    }
}
