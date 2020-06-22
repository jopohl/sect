using System;
using System.Windows.Forms;
using EllipticCurves.Controller;

namespace EllipticCurves.View
{
    public partial class Mainform : Form
    {
        private readonly MainController controller;

        #region Properties
        public TextBox TextBoxAdditionResult
        {
            get { return tBoxAddErgebnis; }
        }

        public TextBox TextBoxMultiplicationResult
        {
            get { return textBoxMultResult; }
        }

        public bool AdditionLogButtonEnabled
        {
            get { return btnShowAdditionLog.Enabled; }
            set { btnShowAdditionLog.Enabled = value; }
        }

        public bool MultiplicationLogButtonEnabled
        {
            get { return btnShowMultiplicationLog.Enabled; }
            set { btnShowMultiplicationLog.Enabled = value; }
        }

        public bool IsAdditionTabActive
        {
            get { return tabControl.SelectedIndex == 0; }
        }

        public int NumericUpDownXmaxValue
        {
            get { return (int)System.Math.Round(numericUpDownXMax.Value, MidpointRounding.AwayFromZero); }
            set { numericUpDownXMax.Value = value; }
        }

        public int NumericUpDownNValue
        {
            get { return (int)System.Math.Round(numericUpDownN.Value, MidpointRounding.AwayFromZero); }
        }

        public Label LabelCurrentCurve
        {
            get { return labelCurrentCurve; }
        }

        public PictureBox PicBoxGraph
        {
            get { return picBoxGraph; }
        }

        public ComboBox ComboBoxP
        {
            get { return comboBoxP; }
        }

        public ComboBox ComboBoxQ
        {
            get { return comboBoxQ; }
        }

        public ComboBox ComboBoxS
        {
            get { return comboBoxS; }
        }

        public bool EqualAspectRatioIsChecked
        {
            get { return checkBoxEqualAspectRatio.Checked; }
        }

        #endregion

        public Mainform(MainController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void picBoxGraph_MouseMove(object sender, MouseEventArgs e)
        {
            controller.MouseMoveInCoordinateSystem(e.X, e.Y);
        }

        private void btnConfigureCurve_Click(object sender, EventArgs e)
        {
            controller.ShowCurveParameterForm();
        }

        private void picBoxGraph_MouseClick(object sender, MouseEventArgs e)
        {
            controller.MouseClickInCoordinateSystem(e.Button);
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            controller.AddPoints();
        }

        public void EnableAddBtn()
        {
            btnAddition.Enabled = true;
        }

        public void DisableAddButton()
        {
            btnAddition.Enabled = false;
        }

        public void DisableMultiplicationButton()
        {
            btnMultiply.Enabled = false;
        }

        private void comboBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.DrawSummand1();
            if (comboBoxP.SelectedIndex > -1 && comboBoxQ.SelectedIndex > -1)
                EnableAddBtn();
        }

        private void comboBoxQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.DrawSummand2();
            if (comboBoxP.SelectedIndex > -1 && comboBoxQ.SelectedIndex > -1)
                EnableAddBtn();
        }

        private void checkBoxEqualAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            controller.DrawCurve();
        }

        private void picBoxGraph_SizeChanged(object sender, EventArgs e)
        {
            if (controller != null)
            {
                // The null check is not needed under Windows
                // The SizeChanged event fires under mono already at program launch
                // so we need to perform the check for the Linux version here
                controller.DrawCurve();
            }

        }

        private void numericUpDownXmax_ValueChanged(object sender, EventArgs e)
        {
            controller.ChangeXmax();
        }

        public void SetLimitsForXmax(int lower, int upper)
        {
            numericUpDownXMax.Minimum = lower;
            numericUpDownXMax.Maximum = upper;
        }

        public void EnableNumericUpDownXmax(bool enabled)
        {
            numericUpDownXMax.Enabled = enabled;
        }

        private void btnSaveGraph_Click(object sender, EventArgs e)
        {
            controller.SaveGraph();
        }

        private void btnShowAdditionLog_Click(object sender, EventArgs e)
        {
            controller.ShowAdditionLog();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            controller.Multiply();
        }

        private void comboBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxS.SelectedIndex > -1)
            {
                controller.DrawFactor();
                btnMultiply.Enabled = true;
            }
                
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.DrawCurve();
        }

        private void btnShowMultiplikationLog_Click(object sender, EventArgs e)
        {
            controller.ShowMultiplicationLog();
        }

        private void tlpFooter_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 2 && e.Row == 0)
            {
                e.Graphics.FillRectangle(System.Drawing.Brushes.Black, e.CellBounds);
            }
        }
    }
}
