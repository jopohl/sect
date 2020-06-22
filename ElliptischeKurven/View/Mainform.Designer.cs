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
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.gBoxAktuelleKurve = new System.Windows.Forms.GroupBox();
            this.flpAktuelleKurve = new System.Windows.Forms.FlowLayoutPanel();
            this.lAktuelleKurve = new System.Windows.Forms.Label();
            this.btnKurveAendern = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.cBoxQ = new System.Windows.Forms.ComboBox();
            this.lQ = new System.Windows.Forms.Label();
            this.cBoxP = new System.Windows.Forms.ComboBox();
            this.lP = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cBoxS = new System.Windows.Forms.ComboBox();
            this.flpAddition = new System.Windows.Forms.FlowLayoutPanel();
            this.panelP = new System.Windows.Forms.Panel();
            this.lPlus = new System.Windows.Forms.Label();
            this.panelQ = new System.Windows.Forms.Panel();
            this.lGleich = new System.Windows.Forms.Label();
            this.tBoxAddErgebnis = new System.Windows.Forms.TextBox();
            this.btnShowAdditionRechnung = new System.Windows.Forms.Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAddition = new System.Windows.Forms.TabPage();
            this.tabMultiplikation = new System.Windows.Forms.TabPage();
            this.flpMultiplikation = new System.Windows.Forms.FlowLayoutPanel();
            this.panN = new System.Windows.Forms.Panel();
            this.ln = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.lMal = new System.Windows.Forms.Label();
            this.panelPMult = new System.Windows.Forms.Panel();
            this.lS = new System.Windows.Forms.Label();
            this.lGleichMult = new System.Windows.Forms.Label();
            this.tBoxMultErgebnis = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnShowMultiplikationRechnung = new System.Windows.Forms.Button();
            this.gbGraphoptionen = new System.Windows.Forms.GroupBox();
            this.lxmax = new System.Windows.Forms.Label();
            this.cbGleichesSeitenverhaeltnis = new System.Windows.Forms.CheckBox();
            this.nudXmax = new System.Windows.Forms.NumericUpDown();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.lCopyright = new System.Windows.Forms.Label();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.gBoxAktuelleKurve.SuspendLayout();
            this.flpAktuelleKurve.SuspendLayout();
            this.flpAddition.SuspendLayout();
            this.panelP.SuspendLayout();
            this.panelQ.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAddition.SuspendLayout();
            this.tabMultiplikation.SuspendLayout();
            this.flpMultiplikation.SuspendLayout();
            this.panN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.panelPMult.SuspendLayout();
            this.gbGraphoptionen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXmax)).BeginInit();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGraph
            // 
            this.pbGraph.BackColor = System.Drawing.Color.White;
            this.pbGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGraph.Location = new System.Drawing.Point(0, 65);
            this.pbGraph.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(1211, 492);
            this.pbGraph.TabIndex = 4;
            this.pbGraph.TabStop = false;
            this.pbGraph.SizeChanged += new System.EventHandler(this.pbGraph_SizeChanged);
            this.pbGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGraph_MouseClick);
            this.pbGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGraph_MouseMove);
            // 
            // gBoxAktuelleKurve
            // 
            this.gBoxAktuelleKurve.AutoSize = true;
            this.gBoxAktuelleKurve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gBoxAktuelleKurve.Controls.Add(this.flpAktuelleKurve);
            this.gBoxAktuelleKurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxAktuelleKurve.Location = new System.Drawing.Point(3, 3);
            this.gBoxAktuelleKurve.Name = "gBoxAktuelleKurve";
            this.gBoxAktuelleKurve.Size = new System.Drawing.Size(300, 59);
            this.gBoxAktuelleKurve.TabIndex = 6;
            this.gBoxAktuelleKurve.TabStop = false;
            this.gBoxAktuelleKurve.Text = "Aktuelle Kurve";
            // 
            // flpAktuelleKurve
            // 
            this.flpAktuelleKurve.AutoSize = true;
            this.flpAktuelleKurve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpAktuelleKurve.Controls.Add(this.lAktuelleKurve);
            this.flpAktuelleKurve.Controls.Add(this.btnKurveAendern);
            this.flpAktuelleKurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAktuelleKurve.Location = new System.Drawing.Point(3, 16);
            this.flpAktuelleKurve.Name = "flpAktuelleKurve";
            this.flpAktuelleKurve.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flpAktuelleKurve.Size = new System.Drawing.Size(294, 40);
            this.flpAktuelleKurve.TabIndex = 2;
            this.flpAktuelleKurve.WrapContents = false;
            // 
            // lAktuelleKurve
            // 
            this.lAktuelleKurve.AutoSize = true;
            this.lAktuelleKurve.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAktuelleKurve.Location = new System.Drawing.Point(3, 8);
            this.lAktuelleKurve.Name = "lAktuelleKurve";
            this.lAktuelleKurve.Padding = new System.Windows.Forms.Padding(3, 3, 20, 0);
            this.lAktuelleKurve.Size = new System.Drawing.Size(207, 21);
            this.lAktuelleKurve.TabIndex = 7;
            this.lAktuelleKurve.Text = "y² ≡ x³ + ax + b mod p";
            // 
            // btnKurveAendern
            // 
            this.btnKurveAendern.Location = new System.Drawing.Point(216, 11);
            this.btnKurveAendern.Name = "btnKurveAendern";
            this.btnKurveAendern.Size = new System.Drawing.Size(75, 23);
            this.btnKurveAendern.TabIndex = 1;
            this.btnKurveAendern.Text = "Ändern...";
            this.btnKurveAendern.UseVisualStyleBackColor = true;
            this.btnKurveAendern.Click += new System.EventHandler(this.btnKurveAendern_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.AutoSize = true;
            this.btnAddition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddition.Location = new System.Drawing.Point(642, 4);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(69, 23);
            this.btnAddition.TabIndex = 8;
            this.btnAddition.Text = "Berechnen";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // cBoxQ
            // 
            this.cBoxQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxQ.FormattingEnabled = true;
            this.cBoxQ.Location = new System.Drawing.Point(36, 3);
            this.cBoxQ.Name = "cBoxQ";
            this.cBoxQ.Size = new System.Drawing.Size(121, 21);
            this.cBoxQ.TabIndex = 14;
            this.toolTip.SetToolTip(this.cBoxQ, "Auswahl durch Rechtsklick im CoordinateSystem oder aus Liste.");
            this.cBoxQ.SelectedIndexChanged += new System.EventHandler(this.cBoxQ_SelectedIndexChanged);
            // 
            // lQ
            // 
            this.lQ.AutoSize = true;
            this.lQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ.Location = new System.Drawing.Point(3, 6);
            this.lQ.Name = "lQ";
            this.lQ.Size = new System.Drawing.Size(27, 13);
            this.lQ.TabIndex = 13;
            this.lQ.Text = "Q =";
            // 
            // cBoxP
            // 
            this.cBoxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxP.FormattingEnabled = true;
            this.cBoxP.Location = new System.Drawing.Point(36, 3);
            this.cBoxP.Name = "cBoxP";
            this.cBoxP.Size = new System.Drawing.Size(121, 21);
            this.cBoxP.TabIndex = 11;
            this.toolTip.SetToolTip(this.cBoxP, "Auswahl durch Linksklick im CoordinateSystem oder aus Liste.\r\n");
            this.cBoxP.SelectedIndexChanged += new System.EventHandler(this.cBoxP_SelectedIndexChanged);
            // 
            // lP
            // 
            this.lP.AutoSize = true;
            this.lP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lP.Location = new System.Drawing.Point(3, 6);
            this.lP.Name = "lP";
            this.lP.Size = new System.Drawing.Size(26, 13);
            this.lP.TabIndex = 10;
            this.lP.Text = "P =";
            // 
            // cBoxS
            // 
            this.cBoxS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxS.FormattingEnabled = true;
            this.cBoxS.Location = new System.Drawing.Point(36, 3);
            this.cBoxS.Name = "cBoxS";
            this.cBoxS.Size = new System.Drawing.Size(121, 21);
            this.cBoxS.TabIndex = 14;
            this.toolTip.SetToolTip(this.cBoxS, "Auswahl durch Linksklick im CoordinateSystem oder aus Liste.");
            this.cBoxS.SelectedIndexChanged += new System.EventHandler(this.cbS_SelectedIndexChanged);
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
            this.flpAddition.Controls.Add(this.btnShowAdditionRechnung);
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
            this.panelP.Controls.Add(this.lP);
            this.panelP.Controls.Add(this.cBoxP);
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
            this.panelQ.Controls.Add(this.lQ);
            this.panelQ.Controls.Add(this.cBoxQ);
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
            // btnShowAdditionRechnung
            // 
            this.btnShowAdditionRechnung.AutoSize = true;
            this.btnShowAdditionRechnung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowAdditionRechnung.Location = new System.Drawing.Point(719, 4);
            this.btnShowAdditionRechnung.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAdditionRechnung.Name = "btnShowAdditionRechnung";
            this.btnShowAdditionRechnung.Size = new System.Drawing.Size(122, 23);
            this.btnShowAdditionRechnung.TabIndex = 20;
            this.btnShowAdditionRechnung.Text = "Rechnung anzeigen...";
            this.btnShowAdditionRechnung.UseVisualStyleBackColor = true;
            this.btnShowAdditionRechnung.Click += new System.EventHandler(this.btnShowAdditionRechnung_Click);
            // 
            // tlpHeader
            // 
            this.tlpHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.Controls.Add(this.gBoxAktuelleKurve, 0, 0);
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
            this.tabControl.Controls.Add(this.tabMultiplikation);
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
            // tabMultiplikation
            // 
            this.tabMultiplikation.BackColor = System.Drawing.SystemColors.Control;
            this.tabMultiplikation.Controls.Add(this.flpMultiplikation);
            this.tabMultiplikation.Location = new System.Drawing.Point(4, 22);
            this.tabMultiplikation.Name = "tabMultiplikation";
            this.tabMultiplikation.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiplikation.Size = new System.Drawing.Size(891, 33);
            this.tabMultiplikation.TabIndex = 1;
            this.tabMultiplikation.Text = "Multiplikation n * S";
            // 
            // flpMultiplikation
            // 
            this.flpMultiplikation.AutoSize = true;
            this.flpMultiplikation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMultiplikation.Controls.Add(this.panN);
            this.flpMultiplikation.Controls.Add(this.lMal);
            this.flpMultiplikation.Controls.Add(this.panelPMult);
            this.flpMultiplikation.Controls.Add(this.lGleichMult);
            this.flpMultiplikation.Controls.Add(this.tBoxMultErgebnis);
            this.flpMultiplikation.Controls.Add(this.btnMultiply);
            this.flpMultiplikation.Controls.Add(this.btnShowMultiplikationRechnung);
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
            this.panN.Controls.Add(this.ln);
            this.panN.Controls.Add(this.nudN);
            this.panN.Location = new System.Drawing.Point(3, 3);
            this.panN.Name = "panN";
            this.panN.Size = new System.Drawing.Size(107, 26);
            this.panN.TabIndex = 16;
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.Location = new System.Drawing.Point(3, 6);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(25, 13);
            this.ln.TabIndex = 10;
            this.ln.Text = "n =";
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(34, 3);
            this.nudN.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(70, 20);
            this.nudN.TabIndex = 19;
            this.nudN.Value = new decimal(new int[] {
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
            this.panelPMult.Controls.Add(this.lS);
            this.panelPMult.Controls.Add(this.cBoxS);
            this.panelPMult.Location = new System.Drawing.Point(134, 3);
            this.panelPMult.Name = "panelPMult";
            this.panelPMult.Size = new System.Drawing.Size(160, 27);
            this.panelPMult.TabIndex = 17;
            // 
            // lS
            // 
            this.lS.AutoSize = true;
            this.lS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lS.Location = new System.Drawing.Point(3, 6);
            this.lS.Name = "lS";
            this.lS.Size = new System.Drawing.Size(26, 13);
            this.lS.TabIndex = 13;
            this.lS.Text = "S =";
            // 
            // lGleichMult
            // 
            this.lGleichMult.AutoSize = true;
            this.lGleichMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGleichMult.Location = new System.Drawing.Point(300, 8);
            this.lGleichMult.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lGleichMult.Name = "lGleichMult";
            this.lGleichMult.Size = new System.Drawing.Size(14, 13);
            this.lGleichMult.TabIndex = 19;
            this.lGleichMult.Text = "=";
            // 
            // tBoxMultErgebnis
            // 
            this.tBoxMultErgebnis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBoxMultErgebnis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxMultErgebnis.CausesValidation = false;
            this.tBoxMultErgebnis.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMultErgebnis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tBoxMultErgebnis.Location = new System.Drawing.Point(320, 7);
            this.tBoxMultErgebnis.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tBoxMultErgebnis.MinimumSize = new System.Drawing.Size(0, 18);
            this.tBoxMultErgebnis.Name = "tBoxMultErgebnis";
            this.tBoxMultErgebnis.ReadOnly = true;
            this.tBoxMultErgebnis.Size = new System.Drawing.Size(260, 18);
            this.tBoxMultErgebnis.TabIndex = 16;
            this.tBoxMultErgebnis.Text = "n * S";
            this.tBoxMultErgebnis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMultiply.Location = new System.Drawing.Point(587, 4);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(69, 23);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "Berechnen";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnShowMultiplikationRechnung
            // 
            this.btnShowMultiplikationRechnung.AutoSize = true;
            this.btnShowMultiplikationRechnung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowMultiplikationRechnung.Location = new System.Drawing.Point(664, 4);
            this.btnShowMultiplikationRechnung.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMultiplikationRechnung.Name = "btnShowMultiplikationRechnung";
            this.btnShowMultiplikationRechnung.Size = new System.Drawing.Size(122, 23);
            this.btnShowMultiplikationRechnung.TabIndex = 20;
            this.btnShowMultiplikationRechnung.Text = "Rechnung anzeigen...";
            this.btnShowMultiplikationRechnung.UseVisualStyleBackColor = true;
            this.btnShowMultiplikationRechnung.Click += new System.EventHandler(this.btnShowMultiplikationRechnung_Click);
            // 
            // gbGraphoptionen
            // 
            this.gbGraphoptionen.AutoSize = true;
            this.gbGraphoptionen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbGraphoptionen.Controls.Add(this.lxmax);
            this.gbGraphoptionen.Controls.Add(this.cbGleichesSeitenverhaeltnis);
            this.gbGraphoptionen.Controls.Add(this.nudXmax);
            this.gbGraphoptionen.Controls.Add(this.btnSaveGraph);
            this.gbGraphoptionen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGraphoptionen.Location = new System.Drawing.Point(3, 3);
            this.gbGraphoptionen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gbGraphoptionen.Name = "gbGraphoptionen";
            this.gbGraphoptionen.Size = new System.Drawing.Size(441, 56);
            this.gbGraphoptionen.TabIndex = 17;
            this.gbGraphoptionen.TabStop = false;
            this.gbGraphoptionen.Text = "Graphoptionen";
            // 
            // lxmax
            // 
            this.lxmax.AutoSize = true;
            this.lxmax.Location = new System.Drawing.Point(156, 16);
            this.lxmax.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lxmax.Name = "lxmax";
            this.lxmax.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lxmax.Size = new System.Drawing.Size(46, 17);
            this.lxmax.TabIndex = 1;
            this.lxmax.Text = "x_max =";
            // 
            // cbGleichesSeitenverhaeltnis
            // 
            this.cbGleichesSeitenverhaeltnis.AutoSize = true;
            this.cbGleichesSeitenverhaeltnis.Location = new System.Drawing.Point(6, 19);
            this.cbGleichesSeitenverhaeltnis.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cbGleichesSeitenverhaeltnis.Name = "cbGleichesSeitenverhaeltnis";
            this.cbGleichesSeitenverhaeltnis.Size = new System.Drawing.Size(145, 17);
            this.cbGleichesSeitenverhaeltnis.TabIndex = 0;
            this.cbGleichesSeitenverhaeltnis.Text = "Gleiches Seitenverhältnis";
            this.cbGleichesSeitenverhaeltnis.UseVisualStyleBackColor = true;
            this.cbGleichesSeitenverhaeltnis.CheckedChanged += new System.EventHandler(this.cbGleichesSeitenverhaeltnis_CheckedChanged);
            // 
            // nudXmax
            // 
            this.nudXmax.Location = new System.Drawing.Point(205, 19);
            this.nudXmax.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.nudXmax.Name = "nudXmax";
            this.nudXmax.Size = new System.Drawing.Size(120, 20);
            this.nudXmax.TabIndex = 2;
            this.nudXmax.ValueChanged += new System.EventHandler(this.nudXmax_ValueChanged);
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.AutoSize = true;
            this.btnSaveGraph.Location = new System.Drawing.Point(331, 17);
            this.btnSaveGraph.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(104, 23);
            this.btnSaveGraph.TabIndex = 3;
            this.btnSaveGraph.Text = "Graph speichern...";
            this.btnSaveGraph.UseVisualStyleBackColor = true;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // lCopyright
            // 
            this.lCopyright.AutoSize = true;
            this.lCopyright.BackColor = System.Drawing.Color.Black;
            this.lCopyright.Font = new System.Drawing.Font("Droid Sans Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCopyright.ForeColor = System.Drawing.Color.Red;
            this.lCopyright.Location = new System.Drawing.Point(1033, 25);
            this.lCopyright.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(175, 15);
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
            this.tlpFooter.Controls.Add(this.gbGraphoptionen, 0, 0);
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
            // Hauptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 616);
            this.Controls.Add(this.pbGraph);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpHeader);
            this.Name = "Hauptform";
            this.Text = "Elliptische Kurven Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.gBoxAktuelleKurve.ResumeLayout(false);
            this.gBoxAktuelleKurve.PerformLayout();
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
            this.tabMultiplikation.ResumeLayout(false);
            this.tabMultiplikation.PerformLayout();
            this.flpMultiplikation.ResumeLayout(false);
            this.flpMultiplikation.PerformLayout();
            this.panN.ResumeLayout(false);
            this.panN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.panelPMult.ResumeLayout(false);
            this.panelPMult.PerformLayout();
            this.gbGraphoptionen.ResumeLayout(false);
            this.gbGraphoptionen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXmax)).EndInit();
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.GroupBox gBoxAktuelleKurve;
        private System.Windows.Forms.FlowLayoutPanel flpAktuelleKurve;
        private System.Windows.Forms.Label lAktuelleKurve;
        private System.Windows.Forms.Button btnKurveAendern;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.ComboBox cBoxQ;
        private System.Windows.Forms.Label lQ;
        private System.Windows.Forms.ComboBox cBoxP;
        private System.Windows.Forms.Label lP;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel flpAddition;
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.Panel panelQ;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lPlus;
        private System.Windows.Forms.Label lGleich;
        private System.Windows.Forms.TextBox tBoxAddErgebnis;
        private System.Windows.Forms.Button btnShowAdditionRechnung;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAddition;
        private System.Windows.Forms.TabPage tabMultiplikation;
        private System.Windows.Forms.FlowLayoutPanel flpMultiplikation;
        private System.Windows.Forms.Panel panN;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label lMal;
        private System.Windows.Forms.Panel panelPMult;
        private System.Windows.Forms.Label lS;
        private System.Windows.Forms.ComboBox cBoxS;
        private System.Windows.Forms.Label lGleichMult;
        private System.Windows.Forms.TextBox tBoxMultErgebnis;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnShowMultiplikationRechnung;
        private System.Windows.Forms.GroupBox gbGraphoptionen;
        private System.Windows.Forms.Label lxmax;
        private System.Windows.Forms.CheckBox cbGleichesSeitenverhaeltnis;
        private System.Windows.Forms.NumericUpDown nudXmax;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
    }
}

