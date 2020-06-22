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
            get { return tBoxMultErgebnis; }
        }

        public bool AdditionLogButtonEnabled
        {
            get { return btnShowAdditionRechnung.Enabled; }
            set { btnShowAdditionRechnung.Enabled = value; }
        }

        public bool MultiplicationLogButtonEnabled
        {
            get { return btnShowMultiplikationRechnung.Enabled; }
            set { btnShowMultiplikationRechnung.Enabled = value; }
        }

        public bool IsAdditionTabActive
        {
            get { return tabControl.SelectedIndex == 0; }
        }

        public int NumericUpDownXmaxValue
        {
            get { return (int)System.Math.Round(nudXmax.Value, MidpointRounding.AwayFromZero); }
            set { nudXmax.Value = value; }
        }

        public int NumericUpDownNValue
        {
            get { return (int)System.Math.Round(nudN.Value, MidpointRounding.AwayFromZero); }
        }

        public Label LabelCurrentCurve
        {
            get { return lAktuelleKurve; }
        }

        public PictureBox PicBoxGraph
        {
            get { return pbGraph; }
        }

        public ComboBox ComboBoxP
        {
            get { return cBoxP; }
        }

        public ComboBox ComboBoxQ
        {
            get { return cBoxQ; }
        }

        public ComboBox ComboBoxS
        {
            get { return cBoxS; }
        }

        public bool EqualAspectRatioIsChecked
        {
            get { return cbGleichesSeitenverhaeltnis.Checked; }
        }

        #endregion

        public Mainform(MainController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void pbGraph_MouseMove(object sender, MouseEventArgs e)
        {
            controller.MouseMoveInCoordinateSystem(e.X, e.Y);
        }

        private void btnKurveAendern_Click(object sender, EventArgs e)
        {
            controller.ShowCurveParameterForm();
        }

        private void pbGraph_MouseClick(object sender, MouseEventArgs e)
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

        private void cBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.DrawSummand1();
            if (cBoxP.SelectedIndex > -1 && cBoxQ.SelectedIndex > -1)
                EnableAddBtn();
        }

        private void cBoxQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.DrawSummand2();
            if (cBoxP.SelectedIndex > -1 && cBoxQ.SelectedIndex > -1)
                EnableAddBtn();
        }

        private void cbGleichesSeitenverhaeltnis_CheckedChanged(object sender, EventArgs e)
        {
            // Kurve neuzeichnen
            controller.DrawCurve();
        }

        private void pbGraph_SizeChanged(object sender, EventArgs e)
        {
            // Kurve neuzeichnen
            if (controller != null)
            {
                // Die Überprüfung ob der Controller null ist, ist eigentlich unnötig (unter Windows)
                // Da das Size Changed Event unter Mono aber schon beim Programmstart feuert, muss es 
                // für die Linux Version an dieser Stelle geprüft werden
                controller.DrawCurve();
            }

        }

        private void nudXmax_ValueChanged(object sender, EventArgs e)
        {
            controller.ChangeXmax();
        }

        public void SetLimitsForXmax(int lower, int upper)
        {
            nudXmax.Minimum = lower;
            nudXmax.Maximum = upper;
        }

        public void EnableNuDXmax(bool enabled)
        {
            nudXmax.Enabled = enabled;
        }

        private void btnSaveGraph_Click(object sender, EventArgs e)
        {
            controller.SaveGraph();
        }

        private void btnShowAdditionRechnung_Click(object sender, EventArgs e)
        {
            controller.ShowAdditionLog();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            controller.Multiply();
        }

        private void cbS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxS.SelectedIndex > -1)
            {
                controller.DrawFactor();
                btnMultiply.Enabled = true;
            }
                
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kurve neuzeichnen
            controller.DrawCurve();
        }

        private void btnShowMultiplikationRechnung_Click(object sender, EventArgs e)
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
