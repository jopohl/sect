namespace EllipticCurves.View
{
    partial class CurveParameterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelECFormula = new System.Windows.Forms.Label();
            this.lParameterA = new System.Windows.Forms.Label();
            this.lParameterB = new System.Windows.Forms.Label();
            this.lParameterP = new System.Windows.Forms.Label();
            this.textBoxParameterA = new System.Windows.Forms.TextBox();
            this.textBoxParameterB = new System.Windows.Forms.TextBox();
            this.textBoxParameterP = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxRealCurve = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelECFormula
            // 
            this.labelECFormula.AutoSize = true;
            this.labelECFormula.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelECFormula.Location = new System.Drawing.Point(16, 9);
            this.labelECFormula.Name = "labelECFormula";
            this.labelECFormula.Padding = new System.Windows.Forms.Padding(3, 3, 20, 0);
            this.labelECFormula.Size = new System.Drawing.Size(207, 21);
            this.labelECFormula.TabIndex = 8;
            this.labelECFormula.Text = "y² ≡ x³ + ax + b mod p";
            // 
            // lParameterA
            // 
            this.lParameterA.AutoSize = true;
            this.lParameterA.Location = new System.Drawing.Point(16, 50);
            this.lParameterA.Name = "lParameterA";
            this.lParameterA.Size = new System.Drawing.Size(28, 13);
            this.lParameterA.TabIndex = 9;
            this.lParameterA.Text = "a  = ";
            // 
            // lParameterB
            // 
            this.lParameterB.AutoSize = true;
            this.lParameterB.Location = new System.Drawing.Point(16, 76);
            this.lParameterB.Name = "lParameterB";
            this.lParameterB.Size = new System.Drawing.Size(28, 13);
            this.lParameterB.TabIndex = 10;
            this.lParameterB.Text = "b  = ";
            // 
            // lParameterP
            // 
            this.lParameterP.AutoSize = true;
            this.lParameterP.Location = new System.Drawing.Point(16, 102);
            this.lParameterP.Name = "lParameterP";
            this.lParameterP.Size = new System.Drawing.Size(28, 13);
            this.lParameterP.TabIndex = 11;
            this.lParameterP.Text = "p  = ";
            // 
            // textBoxParameterA
            // 
            this.textBoxParameterA.Location = new System.Drawing.Point(65, 47);
            this.textBoxParameterA.Name = "textBoxParameterA";
            this.textBoxParameterA.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterA.TabIndex = 12;
            this.textBoxParameterA.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxParameterA_Validating);
            // 
            // textBoxParameterB
            // 
            this.textBoxParameterB.Location = new System.Drawing.Point(65, 73);
            this.textBoxParameterB.Name = "textBoxParameterB";
            this.textBoxParameterB.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterB.TabIndex = 13;
            this.textBoxParameterB.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxParameterB_Validating);
            // 
            // textBoxParameterP
            // 
            this.textBoxParameterP.Location = new System.Drawing.Point(65, 99);
            this.textBoxParameterP.Name = "textBoxParameterP";
            this.textBoxParameterP.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterP.TabIndex = 14;
            this.textBoxParameterP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxParameterP_Validating);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(65, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Accept";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(172, 124);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(82, 23);
            this.btnAbort.TabIndex = 17;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // checkBoxRealCurve
            // 
            this.checkBoxRealCurve.AutoSize = true;
            this.checkBoxRealCurve.Location = new System.Drawing.Point(206, 101);
            this.checkBoxRealCurve.Name = "checkBoxRealCurve";
            this.checkBoxRealCurve.Size = new System.Drawing.Size(74, 17);
            this.checkBoxRealCurve.TabIndex = 17;
            this.checkBoxRealCurve.TabStop = false;
            this.checkBoxRealCurve.Text = "real Curve";
            this.checkBoxRealCurve.UseVisualStyleBackColor = true;
            this.checkBoxRealCurve.CheckedChanged += new System.EventHandler(this.checkBoxRealCurve_CheckedChanged);
            // 
            // CurveParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 162);
            this.Controls.Add(this.checkBoxRealCurve);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxParameterP);
            this.Controls.Add(this.textBoxParameterB);
            this.Controls.Add(this.textBoxParameterA);
            this.Controls.Add(this.lParameterP);
            this.Controls.Add(this.lParameterB);
            this.Controls.Add(this.lParameterA);
            this.Controls.Add(this.labelECFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurveParameterForm";
            this.Text = "Configure curve parameters";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelECFormula;
        private System.Windows.Forms.Label lParameterA;
        private System.Windows.Forms.Label lParameterB;
        private System.Windows.Forms.Label lParameterP;
        private System.Windows.Forms.TextBox textBoxParameterA;
        private System.Windows.Forms.TextBox textBoxParameterB;
        private System.Windows.Forms.TextBox textBoxParameterP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkBoxRealCurve;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}