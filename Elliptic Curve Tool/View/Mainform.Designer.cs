namespace EllipticCurves.View
{
    partial class Mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBoxGraph = new System.Windows.Forms.PictureBox();
            this.groupBoxCurrentCurve = new System.Windows.Forms.GroupBox();
            this.flpAktuelleKurve = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCurrentCurve = new System.Windows.Forms.Label();
            this.btnConfigureKurve = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.comboBoxQ = new System.Windows.Forms.ComboBox();
            this.labelQ = new System.Windows.Forms.Label();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.labelP = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxS = new System.Windows.Forms.ComboBox();
            this.flpAddition = new System.Windows.Forms.FlowLayoutPanel();
            this.panelP = new System.Windows.Forms.Panel();
            this.lPlus = new System.Windows.Forms.Label();
            this.panelQ = new System.Windows.Forms.Panel();
            this.lGleich = new System.Windows.Forms.Label();
            this.tBoxAddErgebnis = new System.Windows.Forms.TextBox();
            this.btnShowAdditionLog = new System.Windows.Forms.Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAddition = new System.Windows.Forms.TabPage();
            this.tabMultiplication = new System.Windows.Forms.TabPage();
            this.flpMultiplikation = new System.Windows.Forms.FlowLayoutPanel();
            this.panN = new System.Windows.Forms.Panel();
            this.labelN = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.lMal = new System.Windows.Forms.Label();
            this.panelPMult = new System.Windows.Forms.Panel();
            this.labelS = new System.Windows.Forms.Label();
            this.labelEqualMult = new System.Windows.Forms.Label();
            this.textBoxMultResult = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnShowMultiplicationLog = new System.Windows.Forms.Button();
            this.groupBoxGraphoptions = new System.Windows.Forms.GroupBox();
            this.labelXMax = new System.Windows.Forms.Label();
            this.checkBoxEqualAspectRatio = new System.Windows.Forms.CheckBox();
            this.numericUpDownXMax = new System.Windows.Forms.NumericUpDown();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.lCopyright = new System.Windows.Forms.Label();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGraph)).BeginInit();
            this.groupBoxCurrentCurve.SuspendLayout();
            this.flpAktuelleKurve.SuspendLayout();
            this.flpAddition.SuspendLayout();
            this.panelP.SuspendLayout();
            this.panelQ.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAddition.SuspendLayout();
            this.tabMultiplication.SuspendLayout();
            this.flpMultiplikation.SuspendLayout();
            this.panN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.panelPMult.SuspendLayout();
            this.groupBoxGraphoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).BeginInit();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxGraph
            // 
            this.picBoxGraph.BackColor = System.Drawing.Color.White;
            this.picBoxGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxGraph.Location = new System.Drawing.Point(0, 65);
            this.picBoxGraph.MinimumSize = new System.Drawing.Size(100, 100);
            this.picBoxGraph.Name = "picBoxGraph";
            this.picBoxGraph.Size = new System.Drawing.Size(1211, 492);
            this.picBoxGraph.TabIndex = 4;
            this.picBoxGraph.TabStop = false;
            this.picBoxGraph.SizeChanged += new System.EventHandler(this.picBoxGraph_SizeChanged);
            this.picBoxGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxGraph_MouseClick);
            this.picBoxGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxGraph_MouseMove);
            // 
            // groupBoxCurrentCurve
            // 
            this.groupBoxCurrentCurve.AutoSize = true;
            this.groupBoxCurrentCurve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCurrentCurve.Controls.Add(this.flpAktuelleKurve);
            this.groupBoxCurrentCurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCurrentCurve.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCurrentCurve.Name = "groupBoxCurrentCurve";
            this.groupBoxCurrentCurve.Size = new System.Drawing.Size(300, 59);
            this.groupBoxCurrentCurve.TabIndex = 6;
            this.groupBoxCurrentCurve.TabStop = false;
            this.groupBoxCurrentCurve.Text = "Current Elliptic Curve";
            // 
            // flpAktuelleKurve
            // 
            this.flpAktuelleKurve.AutoSize = true;
            this.flpAktuelleKurve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpAktuelleKurve.Controls.Add(this.labelCurrentCurve);
            this.flpAktuelleKurve.Controls.Add(this.btnConfigureKurve);
            this.flpAktuelleKurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAktuelleKurve.Location = new System.Drawing.Point(3, 16);
            this.flpAktuelleKurve.Name = "flpAktuelleKurve";
            this.flpAktuelleKurve.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flpAktuelleKurve.Size = new System.Drawing.Size(294, 40);
            this.flpAktuelleKurve.TabIndex = 2;
            this.flpAktuelleKurve.WrapContents = false;
            // 
            // labelCurrentCurve
            // 
            this.labelCurrentCurve.AutoSize = true;
            this.labelCurrentCurve.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentCurve.Location = new System.Drawing.Point(3, 8);
            this.labelCurrentCurve.Name = "labelCurrentCurve";
            this.labelCurrentCurve.Padding = new System.Windows.Forms.Padding(3, 3, 20, 0);
            this.labelCurrentCurve.Size = new System.Drawing.Size(207, 21);
            this.labelCurrentCurve.TabIndex = 7;
            this.labelCurrentCurve.Text = "y² ≡ x³ + ax + b mod p";
            // 
            // btnConfigureKurve
            // 
            this.btnConfigureKurve.Location = new System.Drawing.Point(216, 11);
            this.btnConfigureKurve.Name = "btnConfigureKurve";
            this.btnConfigureKurve.Size = new System.Drawing.Size(75, 23);
            this.btnConfigureKurve.TabIndex = 1;
            this.btnConfigureKurve.Text = "Configure...";
            this.btnConfigureKurve.UseVisualStyleBackColor = true;
            this.btnConfigureKurve.Click += new System.EventHandler(this.btnConfigureCurve_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.AutoSize = true;
            this.btnAddition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddition.Location = new System.Drawing.Point(642, 4);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(61, 23);
            this.btnAddition.TabIndex = 8;
            this.btnAddition.Text = "Calculate";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // comboBoxQ
            // 
            this.comboBoxQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQ.FormattingEnabled = true;
            this.comboBoxQ.Location = new System.Drawing.Point(36, 3);
            this.comboBoxQ.Name = "comboBoxQ";
            this.comboBoxQ.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQ.TabIndex = 14;
            this.toolTip.SetToolTip(this.comboBoxQ, "Auswahl durch Rechtsklick im CoordinateSystem oder aus Liste.");
            this.comboBoxQ.SelectedIndexChanged += new System.EventHandler(this.comboBoxQ_SelectedIndexChanged);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ.Location = new System.Drawing.Point(3, 6);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(27, 13);
            this.labelQ.TabIndex = 13;
            this.labelQ.Text = "Q =";
            // 
            // comboBoxP
            // 
            this.comboBoxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Location = new System.Drawing.Point(36, 3);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxP.TabIndex = 11;
            this.toolTip.SetToolTip(this.comboBoxP, "Auswahl durch Linksklick im CoordinateSystem oder aus Liste.\r\n");
            this.comboBoxP.SelectedIndexChanged += new System.EventHandler(this.comboBoxP_SelectedIndexChanged);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.Location = new System.Drawing.Point(3, 6);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(26, 13);
            this.labelP.TabIndex = 10;
            this.labelP.Text = "P =";
            // 
            // comboBoxS
            // 
            this.comboBoxS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxS.FormattingEnabled = true;
            this.comboBoxS.Location = new System.Drawing.Point(36, 3);
            this.comboBoxS.Name = "comboBoxS";
            this.comboBoxS.Size = new System.Drawing.Size(121, 21);
            this.comboBoxS.TabIndex = 14;
            this.toolTip.SetToolTip(this.comboBoxS, "Auswahl durch Linksklick im CoordinateSystem oder aus Liste.");
            this.comboBoxS.SelectedIndexChanged += new System.EventHandler(this.comboBoxS_SelectedIndexChanged);
            // 
            // flpAddition
            // 
            this.flpAddition.AutoSize = true;
            this.flpAddition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpAddition.Controls.Add(this.panelP);
            this.flpAddition.Controls.Add(this.lPlus);
            this.flpAddition.Controls.Add(this.panelQ);
            this.flpAddition.Controls.Add(this.lGleich);
            this.flpAddition.Controls.Add(this.tBoxAddErgebnis);
            this.flpAddition.Controls.Add(this.btnAddition);
            this.flpAddition.Controls.Add(this.btnShowAdditionLog);
            this.flpAddition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAddition.Location = new System.Drawing.Point(3, 3);
            this.flpAddition.Margin = new System.Windows.Forms.Padding(0);
            this.flpAddition.Name = "flpAddition";
            this.flpAddition.Size = new System.Drawing.Size(885, 27);
            this.flpAddition.TabIndex = 0;
            // 
            // panelP
            // 
            this.panelP.AutoSize = true;
            this.panelP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelP.Controls.Add(this.labelP);
            this.panelP.Controls.Add(this.comboBoxP);
            this.panelP.Location = new System.Drawing.Point(3, 3);
            this.panelP.Name = "panelP";
            this.panelP.Size = new System.Drawing.Size(160, 27);
            this.panelP.TabIndex = 16;
            // 
            // lPlus
            // 
            this.lPlus.AutoSize = true;
            this.lPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlus.Location = new System.Drawing.Point(169, 8);
            this.lPlus.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lPlus.Name = "lPlus";
            this.lPlus.Size = new System.Drawing.Size(14, 13);
            this.lPlus.TabIndex = 18;
            this.lPlus.Text = "+";
            // 
            // panelQ
            // 
            this.panelQ.AutoSize = true;
            this.panelQ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelQ.Controls.Add(this.labelQ);
            this.panelQ.Controls.Add(this.comboBoxQ);
            this.panelQ.Location = new System.Drawing.Point(189, 3);
            this.panelQ.Name = "panelQ";
            this.panelQ.Size = new System.Drawing.Size(160, 27);
            this.panelQ.TabIndex = 17;
            // 
            // lGleich
            // 
            this.lGleich.AutoSize = true;
            this.lGleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGleich.Location = new System.Drawing.Point(355, 8);
            this.lGleich.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lGleich.Name = "lGleich";
            this.lGleich.Size = new System.Drawing.Size(14, 13);
            this.lGleich.TabIndex = 19;
            this.lGleich.Text = "=";
            // 
            // tBoxAddErgebnis
            // 
            this.tBoxAddErgebnis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBoxAddErgebnis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxAddErgebnis.CausesValidation = false;
            this.tBoxAddErgebnis.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAddErgebnis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tBoxAddErgebnis.Location = new System.Drawing.Point(375, 7);
            this.tBoxAddErgebnis.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tBoxAddErgebnis.MinimumSize = new System.Drawing.Size(0, 18);
            this.tBoxAddErgebnis.Name = "tBoxAddErgebnis";
            this.tBoxAddErgebnis.ReadOnly = true;
            this.tBoxAddErgebnis.Size = new System.Drawing.Size(260, 18);
            this.tBoxAddErgebnis.TabIndex = 16;
            this.tBoxAddErgebnis.Text = "R";
            this.tBoxAddErgebnis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowAdditionLog
            // 
            this.btnShowAdditionLog.AutoSize = true;
            this.btnShowAdditionLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowAdditionLog.Location = new System.Drawing.Point(711, 4);
            this.btnShowAdditionLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAdditionLog.Name = "btnShowAdditionLog";
            this.btnShowAdditionLog.Size = new System.Drawing.Size(107, 23);
            this.btnShowAdditionLog.TabIndex = 20;
            this.btnShowAdditionLog.Text = "Show calculation...";
            this.btnShowAdditionLog.UseVisualStyleBackColor = true;
            this.btnShowAdditionLog.Click += new System.EventHandler(this.btnShowAdditionLog_Click);
            // 
            // tlpHeader
            // 
            this.tlpHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.Controls.Add(this.groupBoxCurrentCurve, 0, 0);
            this.tlpHeader.Controls.Add(this.tabControl, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(1211, 65);
            this.tlpHeader.TabIndex = 16;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAddition);
            this.tabControl.Controls.Add(this.tabMultiplication);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(309, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(899, 59);
            this.tabControl.TabIndex = 7;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabAddition
            // 
            this.tabAddition.BackColor = System.Drawing.SystemColors.Control;
            this.tabAddition.Controls.Add(this.flpAddition);
            this.tabAddition.Location = new System.Drawing.Point(4, 22);
            this.tabAddition.Name = "tabAddition";
            this.tabAddition.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddition.Size = new System.Drawing.Size(891, 33);
            this.tabAddition.TabIndex = 0;
            this.tabAddition.Text = "Addition P + Q = R";
            // 
            // tabMultiplication
            // 
            this.tabMultiplication.BackColor = System.Drawing.SystemColors.Control;
            this.tabMultiplication.Controls.Add(this.flpMultiplikation);
            this.tabMultiplication.Location = new System.Drawing.Point(4, 22);
            this.tabMultiplication.Name = "tabMultiplication";
            this.tabMultiplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiplication.Size = new System.Drawing.Size(891, 33);
            this.tabMultiplication.TabIndex = 1;
            this.tabMultiplication.Text = "Multiplication n * S";
            // 
            // flpMultiplikation
            // 
            this.flpMultiplikation.AutoSize = true;
            this.flpMultiplikation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMultiplikation.Controls.Add(this.panN);
            this.flpMultiplikation.Controls.Add(this.lMal);
            this.flpMultiplikation.Controls.Add(this.panelPMult);
            this.flpMultiplikation.Controls.Add(this.labelEqualMult);
            this.flpMultiplikation.Controls.Add(this.textBoxMultResult);
            this.flpMultiplikation.Controls.Add(this.btnMultiply);
            this.flpMultiplikation.Controls.Add(this.btnShowMultiplicationLog);
            this.flpMultiplikation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMultiplikation.Location = new System.Drawing.Point(3, 3);
            this.flpMultiplikation.Margin = new System.Windows.Forms.Padding(0);
            this.flpMultiplikation.Name = "flpMultiplikation";
            this.flpMultiplikation.Size = new System.Drawing.Size(885, 27);
            this.flpMultiplikation.TabIndex = 18;
            // 
            // panN
            // 
            this.panN.AutoSize = true;
            this.panN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panN.Controls.Add(this.labelN);
            this.panN.Controls.Add(this.numericUpDownN);
            this.panN.Location = new System.Drawing.Point(3, 3);
            this.panN.Name = "panN";
            this.panN.Size = new System.Drawing.Size(107, 26);
            this.panN.TabIndex = 16;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.Location = new System.Drawing.Point(3, 6);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(25, 13);
            this.labelN.TabIndex = 10;
            this.labelN.Text = "n =";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(34, 3);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownN.TabIndex = 19;
            this.numericUpDownN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lMal
            // 
            this.lMal.AutoSize = true;
            this.lMal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMal.Location = new System.Drawing.Point(116, 8);
            this.lMal.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lMal.Name = "lMal";
            this.lMal.Size = new System.Drawing.Size(12, 13);
            this.lMal.TabIndex = 18;
            this.lMal.Text = "*";
            // 
            // panelPMult
            // 
            this.panelPMult.AutoSize = true;
            this.panelPMult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPMult.Controls.Add(this.labelS);
            this.panelPMult.Controls.Add(this.comboBoxS);
            this.panelPMult.Location = new System.Drawing.Point(134, 3);
            this.panelPMult.Name = "panelPMult";
            this.panelPMult.Size = new System.Drawing.Size(160, 27);
            this.panelPMult.TabIndex = 17;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.Location = new System.Drawing.Point(3, 6);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(26, 13);
            this.labelS.TabIndex = 13;
            this.labelS.Text = "S =";
            // 
            // labelEqualMult
            // 
            this.labelEqualMult.AutoSize = true;
            this.labelEqualMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEqualMult.Location = new System.Drawing.Point(300, 8);
            this.labelEqualMult.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelEqualMult.Name = "labelEqualMult";
            this.labelEqualMult.Size = new System.Drawing.Size(14, 13);
            this.labelEqualMult.TabIndex = 19;
            this.labelEqualMult.Text = "=";
            // 
            // textBoxMultResult
            // 
            this.textBoxMultResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMultResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMultResult.CausesValidation = false;
            this.textBoxMultResult.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMultResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxMultResult.Location = new System.Drawing.Point(320, 7);
            this.textBoxMultResult.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.textBoxMultResult.MinimumSize = new System.Drawing.Size(0, 18);
            this.textBoxMultResult.Name = "textBoxMultResult";
            this.textBoxMultResult.ReadOnly = true;
            this.textBoxMultResult.Size = new System.Drawing.Size(260, 18);
            this.textBoxMultResult.TabIndex = 16;
            this.textBoxMultResult.Text = "n * S";
            this.textBoxMultResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMultiply.Location = new System.Drawing.Point(587, 4);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(61, 23);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "Calculate";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnShowMultiplicationLog
            // 
            this.btnShowMultiplicationLog.AutoSize = true;
            this.btnShowMultiplicationLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowMultiplicationLog.Location = new System.Drawing.Point(656, 4);
            this.btnShowMultiplicationLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMultiplicationLog.Name = "btnShowMultiplicationLog";
            this.btnShowMultiplicationLog.Size = new System.Drawing.Size(107, 23);
            this.btnShowMultiplicationLog.TabIndex = 20;
            this.btnShowMultiplicationLog.Text = "Show calculation...";
            this.btnShowMultiplicationLog.UseVisualStyleBackColor = true;
            this.btnShowMultiplicationLog.Click += new System.EventHandler(this.btnShowMultiplikationLog_Click);
            // 
            // groupBoxGraphoptions
            // 
            this.groupBoxGraphoptions.AutoSize = true;
            this.groupBoxGraphoptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxGraphoptions.Controls.Add(this.labelXMax);
            this.groupBoxGraphoptions.Controls.Add(this.checkBoxEqualAspectRatio);
            this.groupBoxGraphoptions.Controls.Add(this.numericUpDownXMax);
            this.groupBoxGraphoptions.Controls.Add(this.btnSaveGraph);
            this.groupBoxGraphoptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGraphoptions.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGraphoptions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBoxGraphoptions.Name = "groupBoxGraphoptions";
            this.groupBoxGraphoptions.Size = new System.Drawing.Size(441, 56);
            this.groupBoxGraphoptions.TabIndex = 17;
            this.groupBoxGraphoptions.TabStop = false;
            this.groupBoxGraphoptions.Text = "Graph options";
            // 
            // labelXMax
            // 
            this.labelXMax.AutoSize = true;
            this.labelXMax.Location = new System.Drawing.Point(156, 16);
            this.labelXMax.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelXMax.Name = "labelXMax";
            this.labelXMax.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelXMax.Size = new System.Drawing.Size(46, 17);
            this.labelXMax.TabIndex = 1;
            this.labelXMax.Text = "x_max =";
            // 
            // checkBoxEqualAspectRatio
            // 
            this.checkBoxEqualAspectRatio.AutoSize = true;
            this.checkBoxEqualAspectRatio.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEqualAspectRatio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.checkBoxEqualAspectRatio.Name = "checkBoxEqualAspectRatio";
            this.checkBoxEqualAspectRatio.Size = new System.Drawing.Size(111, 17);
            this.checkBoxEqualAspectRatio.TabIndex = 0;
            this.checkBoxEqualAspectRatio.Text = "Equal aspect ratio";
            this.checkBoxEqualAspectRatio.UseVisualStyleBackColor = true;
            this.checkBoxEqualAspectRatio.CheckedChanged += new System.EventHandler(this.checkBoxEqualAspectRatio_CheckedChanged);
            // 
            // numericUpDownXMax
            // 
            this.numericUpDownXMax.Location = new System.Drawing.Point(205, 19);
            this.numericUpDownXMax.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.numericUpDownXMax.Name = "numericUpDownXMax";
            this.numericUpDownXMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXMax.TabIndex = 2;
            this.numericUpDownXMax.ValueChanged += new System.EventHandler(this.numericUpDownXmax_ValueChanged);
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.AutoSize = true;
            this.btnSaveGraph.Location = new System.Drawing.Point(331, 17);
            this.btnSaveGraph.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(104, 23);
            this.btnSaveGraph.TabIndex = 3;
            this.btnSaveGraph.Text = "Save graph...";
            this.btnSaveGraph.UseVisualStyleBackColor = true;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // lCopyright
            // 
            this.lCopyright.AutoSize = true;
            this.lCopyright.BackColor = System.Drawing.Color.Black;
            this.lCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCopyright.ForeColor = System.Drawing.Color.Red;
            this.lCopyright.Location = new System.Drawing.Point(1066, 25);
            this.lCopyright.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(142, 16);
            this.lCopyright.TabIndex = 17;
            this.lCopyright.Text = "© Johannes Pohl, 2012";
            // 
            // tlpFooter
            // 
            this.tlpFooter.AutoSize = true;
            this.tlpFooter.ColumnCount = 3;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFooter.Controls.Add(this.groupBoxGraphoptions, 0, 0);
            this.tlpFooter.Controls.Add(this.lCopyright, 2, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 557);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(1211, 59);
            this.tlpFooter.TabIndex = 18;
            this.tlpFooter.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpFooter_CellPaint);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 616);
            this.Controls.Add(this.picBoxGraph);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpHeader);
            this.Name = "Mainform";
            this.Text = "Simple Elliptic Curve Tool";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGraph)).EndInit();
            this.groupBoxCurrentCurve.ResumeLayout(false);
            this.groupBoxCurrentCurve.PerformLayout();
            this.flpAktuelleKurve.ResumeLayout(false);
            this.flpAktuelleKurve.PerformLayout();
            this.flpAddition.ResumeLayout(false);
            this.flpAddition.PerformLayout();
            this.panelP.ResumeLayout(false);
            this.panelP.PerformLayout();
            this.panelQ.ResumeLayout(false);
            this.panelQ.PerformLayout();
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabAddition.ResumeLayout(false);
            this.tabAddition.PerformLayout();
            this.tabMultiplication.ResumeLayout(false);
            this.tabMultiplication.PerformLayout();
            this.flpMultiplikation.ResumeLayout(false);
            this.flpMultiplikation.PerformLayout();
            this.panN.ResumeLayout(false);
            this.panN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.panelPMult.ResumeLayout(false);
            this.panelPMult.PerformLayout();
            this.groupBoxGraphoptions.ResumeLayout(false);
            this.groupBoxGraphoptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).EndInit();
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxGraph;
        private System.Windows.Forms.GroupBox groupBoxCurrentCurve;
        private System.Windows.Forms.FlowLayoutPanel flpAktuelleKurve;
        private System.Windows.Forms.Label labelCurrentCurve;
        private System.Windows.Forms.Button btnConfigureKurve;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.ComboBox comboBoxQ;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel flpAddition;
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.Panel panelQ;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lPlus;
        private System.Windows.Forms.Label lGleich;
        private System.Windows.Forms.TextBox tBoxAddErgebnis;
        private System.Windows.Forms.Button btnShowAdditionLog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAddition;
        private System.Windows.Forms.TabPage tabMultiplication;
        private System.Windows.Forms.FlowLayoutPanel flpMultiplikation;
        private System.Windows.Forms.Panel panN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Label lMal;
        private System.Windows.Forms.Panel panelPMult;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.ComboBox comboBoxS;
        private System.Windows.Forms.Label labelEqualMult;
        private System.Windows.Forms.TextBox textBoxMultResult;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnShowMultiplicationLog;
        private System.Windows.Forms.GroupBox groupBoxGraphoptions;
        private System.Windows.Forms.Label labelXMax;
        private System.Windows.Forms.CheckBox checkBoxEqualAspectRatio;
        private System.Windows.Forms.NumericUpDown numericUpDownXMax;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
    }
}

