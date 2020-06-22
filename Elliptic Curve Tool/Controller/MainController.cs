using System;
using System.Drawing;
using System.Windows.Forms;
using EllipticCurveTool.EC;
using EllipticCurveTool.View;

namespace EllipticCurveTool.Controller
{
    public class MainController
    {
        private EllipticCurve ellipticCurve;
        private CoordinateSystem coordinateSystem;

        private ECPoint mouseSelectedPoint;

        private ECPoint summand1;
        private ECPoint summand2;
        private ECPoint additionResult;

        private ECPoint factor;
        private ECPoint multiplicationResult;

        private ECPoint Summand1
        {
            set
            {
                if (summand1 != value)
                    additionResult = null;
                summand1 = value;
            }
        }

        private ECPoint Summand2
        {
            set
            {
                if (summand2 != value)
                    additionResult = null;
                summand2 = value;
            }
        }

        private ECPoint Factor
        {
            set
            {
                if (factor != value)
                    multiplicationResult = null;
                factor = value;
            }
        }

        public Mainform Form { private set; get; }

        public bool ShouldCurveBeDrawed { get; set; }

        public MainController()
        {
            ShouldCurveBeDrawed = true;
            Form = new Mainform(this);
            CreateIntCurve(2, 3, 7);
        }

        public void ShowCurveParameterForm()
        {
            CurveParameterController parameterController;
            int a = ellipticCurve.A;
            int b = ellipticCurve.B;
            if (ellipticCurve is EllipticCurveZ)
            {
                int p = ((EllipticCurveZ)ellipticCurve).P;
                parameterController = new CurveParameterController(a, b, p, this);
            }
            else
            {
                parameterController = new CurveParameterController(a, b, ellipticCurve.Xmin, ellipticCurve.Xmax, this);
            }

            parameterController.Form.ShowDialog();
        }

        public void CreateIntCurve(int a, int b, int p)
        {
            ellipticCurve = new EllipticCurveZ(a, b, p);
            InitCurve();
        }

        public void CreateRealCurve(int a, int b)
        {
            ellipticCurve = new EllipticCurveR(a, b);
            InitCurve();
        }

        public void CreateRealCurve(int a, int b, int xmax)
        {
            ellipticCurve = new EllipticCurveR(a, b, xmax);
            InitCurve();
        }

        private void InitCurve()
        {
            Form.LabelCurrentCurve.Text = ellipticCurve.ToString();
            Form.TextBoxAdditionResult.Text = "R";
            Form.TextBoxMultiplicationResult.Text = "n * S";
            if (ellipticCurve is EllipticCurveR)
            {
                int lowerBorder = ellipticCurve.Xmin + 1;
                if (lowerBorder <= 0)
                    lowerBorder = 1;

                Form.SetLimitsForXmax(lowerBorder, 100);
                Form.EnableNumericUpDownXmax(true);
            }
            else
            {
                // Show X_Max for curves over Z_p but make it read only
                Form.EnableNumericUpDownXmax(false);
                Form.SetLimitsForXmax(1, int.MaxValue);
            }
            Form.NumericUpDownXmaxValue = ellipticCurve.Xmax;

            mouseSelectedPoint = null;
            summand1 = null;
            summand2 = null;
            additionResult = null;
            factor = null;
            multiplicationResult = null;

            Form.ComboBoxP.Items.Clear();
            Form.ComboBoxQ.Items.Clear();
            Form.ComboBoxS.Items.Clear();
            Form.DisableAddButton();
            Form.DisableMultiplicationButton();
            Form.AdditionLogButtonEnabled = false;
            Form.MultiplicationLogButtonEnabled = false;

            object[] pointsArr = ellipticCurve.Points.ToArray();
            Form.ComboBoxP.Items.AddRange(pointsArr);
            Form.ComboBoxQ.Items.AddRange(pointsArr);
            Form.ComboBoxS.Items.AddRange(pointsArr);
            DrawCurve();
        }

        public void DrawCurve()
        {
            int width = Form.PicBoxGraph.Width;
            int height = Form.PicBoxGraph.Height;

            if (width <= 0 || height <= 0)
                return;

            Bitmap image = new Bitmap(width, height);

            if (!ShouldCurveBeDrawed)
            {
                Form.PicBoxGraph.Image = image;
                return;
            }

            coordinateSystem = new CoordinateSystem(ellipticCurve.Xmin, ellipticCurve.Xmax, ellipticCurve.Ymin, ellipticCurve.Ymax, image);

            coordinateSystem.Draw(Form.EqualAspectRatioIsChecked);

            ellipticCurve.Draw(coordinateSystem);
            coordinateSystem.SetSelection(mouseSelectedPoint);

            if (Form.IsAdditionTabActive)
            {
                if (summand1 != summand2)
                {
                    coordinateSystem.SetSummand1(summand1);
                    coordinateSystem.SetSummand2(summand2);
                }
                else
                {
                    coordinateSystem.SetDoubling(summand1);
                }
                coordinateSystem.SetAdditionResult(additionResult);

                if (ellipticCurve is EllipticCurveR)
                {
                    EllipticCurveR tmp = (EllipticCurveR)ellipticCurve;
                    if (summand1 != summand2)
                        tmp.DrawAddition(summand1, summand2, coordinateSystem);
                    else
                        tmp.DrawDoubling(summand1, coordinateSystem);
                }
            }
            else
            {
                // Draw Multiplication
                if (factor != multiplicationResult)
                    coordinateSystem.SetFactor(factor);
                coordinateSystem.SetMultiplicationResult(Form.NumericUpDownNValue, multiplicationResult);
            }
            Form.PicBoxGraph.Image = image;
        }

        /// <summary>
        /// Happens when mouse is moved in coordinate system.
        /// If mouse selects an ECPoint it will be colored with the selection color.
        /// </summary>
        /// <param name="x">x-Position of mouse cursor</param>
        /// <param name="y">y-Position of mouse cursor</param>
        public void MouseMoveInCoordinateSystem(int x, int y)
        {
            if (coordinateSystem == null)
                return;

            ECPoint point = coordinateSystem.FindSelectedPoint(x, y, ellipticCurve.Points);
            if (mouseSelectedPoint != point)
            {
                mouseSelectedPoint = point;
                DrawCurve();
            }
        }

        public void MouseClickInCoordinateSystem(MouseButtons button)
        {
            if (coordinateSystem == null || mouseSelectedPoint == null) return;

            if (button == MouseButtons.Left)
            {
                if (Form.IsAdditionTabActive)
                {
                    Form.ComboBoxP.SelectedItem = mouseSelectedPoint;
                    Summand1 = mouseSelectedPoint;
                }
                else
                {
                    Form.ComboBoxS.SelectedItem = mouseSelectedPoint;
                    Factor = mouseSelectedPoint;
                }
                DrawCurve();
                return;
            }

            if (button == MouseButtons.Right && Form.IsAdditionTabActive)
            {
                Form.ComboBoxQ.SelectedItem = mouseSelectedPoint;
                Summand2 = mouseSelectedPoint;
                DrawCurve();
            }
        }

        public void AddPoints()
        {
            additionResult = ellipticCurve.Add(summand1, summand2);
            Form.TextBoxAdditionResult.Text = additionResult.ToString();
            Form.AdditionLogButtonEnabled = true;
            DrawCurve();
        }

        public void Multiply()
        {
            int n = Form.NumericUpDownNValue;
            ECPoint s = (ECPoint)Form.ComboBoxS.SelectedItem;
            multiplicationResult = ellipticCurve.Multiply(n, s);
            Form.TextBoxMultiplicationResult.Text = multiplicationResult.ToString();
            Form.MultiplicationLogButtonEnabled = true;
            DrawCurve();
        }

        public void DrawSummand1()
        {
            if (Form.ComboBoxP.SelectedIndex == -1)
                return;

            Summand1 = (ECPoint)Form.ComboBoxP.SelectedItem;
            DrawCurve();
        }

        public void DrawSummand2()
        {
            if (Form.ComboBoxQ.SelectedIndex == -1)
                return;

            Summand2 = (ECPoint)Form.ComboBoxQ.SelectedItem;
            DrawCurve();
        }

        public void DrawFactor()
        {
            Factor = (ECPoint)Form.ComboBoxS.SelectedItem;
            DrawCurve();
        }

        public void ChangeXmax()
        {
            if (ellipticCurve is EllipticCurveR)
            {
                int oldXmax = ellipticCurve.Xmax;
                ellipticCurve = new EllipticCurveR(ellipticCurve.A, ellipticCurve.B, Form.NumericUpDownXmaxValue);
                try
                {
                    DrawCurve();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\nCurve was not drawn.", "Error during curve drawing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form.NumericUpDownXmaxValue = oldXmax;
                }
            }

            
        }

        /// <summary>
        /// Save current graph as png image
        /// </summary>
        public void SaveGraph()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "Portable-Network-Graphic|*.png";

            string suggestedFilename = "a = " + ellipticCurve.A + " b = " + ellipticCurve.B;
            if (ellipticCurve is EllipticCurveZ)
            {
                EllipticCurveZ tmp = (EllipticCurveZ)ellipticCurve;
                suggestedFilename += " p = " + tmp.P;
            }

            saveFileDialog.FileName = suggestedFilename;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(Form.PicBoxGraph.Image);
                Bitmap croppedBmp = bmp.Clone(new Rectangle(0, 0, coordinateSystem.Width, coordinateSystem.Height),
                                              bmp.PixelFormat);
                croppedBmp.Save(saveFileDialog.FileName);
            }
        }

        public void ShowAdditionLog()
        {
            CalculationForm calculationForm = new CalculationForm(ellipticCurve.AdditionLog);
            calculationForm.ShowDialog();
        }

        public void ShowMultiplicationLog()
        {
            CalculationForm calculationForm = new CalculationForm(ellipticCurve.MultiplicationLog);
            calculationForm.ShowDialog();
        }
    }
}
