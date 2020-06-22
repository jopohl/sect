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
            this.lAllgemeineFormelElliptischeKurve = new System.Windows.Forms.Label();
            this.lParameterA = new System.Windows.Forms.Label();
            this.lParameterB = new System.Windows.Forms.Label();
            this.lParameterP = new System.Windows.Forms.Label();
            this.tBoxParameterA = new System.Windows.Forms.TextBox();
            this.tBoxParameterB = new System.Windows.Forms.TextBox();
            this.tBoxParameterP = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbReell = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lAllgemeineFormelElliptischeKurve
            // 
            this.lAllgemeineFormelElliptischeKurve.AutoSize = true;
            this.lAllgemeineFormelElliptischeKurve.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAllgemeineFormelElliptischeKurve.Location = new System.Drawing.Point(16, 9);
            this.lAllgemeineFormelElliptischeKurve.Name = "lAllgemeineFormelElliptischeKurve";
            this.lAllgemeineFormelElliptischeKurve.Padding = new System.Windows.Forms.Padding(3, 3, 20, 0);
            this.lAllgemeineFormelElliptischeKurve.Size = new System.Drawing.Size(207, 21);
            this.lAllgemeineFormelElliptischeKurve.TabIndex = 8;
            this.lAllgemeineFormelElliptischeKurve.Text = "y² ≡ x³ + ax + b mod p";
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
            // tBoxParameterA
            // 
            this.tBoxParameterA.Location = new System.Drawing.Point(65, 47);
            this.tBoxParameterA.Name = "tBoxParameterA";
            this.tBoxParameterA.Size = new System.Drawing.Size(100, 20);
            this.tBoxParameterA.TabIndex = 12;
            this.tBoxParameterA.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxParameterA_Validating);
            // 
            // tBoxParameterB
            // 
            this.tBoxParameterB.Location = new System.Drawing.Point(65, 73);
            this.tBoxParameterB.Name = "tBoxParameterB";
            this.tBoxParameterB.Size = new System.Drawing.Size(100, 20);
            this.tBoxParameterB.TabIndex = 13;
            this.tBoxParameterB.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxParameterB_Validating);
            // 
            // tBoxParameterP
            // 
            this.tBoxParameterP.Location = new System.Drawing.Point(65, 99);
            this.tBoxParameterP.Name = "tBoxParameterP";
            this.tBoxParameterP.Size = new System.Drawing.Size(100, 20);
            this.tBoxParameterP.TabIndex = 14;
            this.tBoxParameterP.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxParameterP_Validating);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(65, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Übernehmen";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(172, 124);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(82, 23);
            this.btnAbbrechen.TabIndex = 17;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbReell
            // 
            this.cbReell.AutoSize = true;
            this.cbReell.Location = new System.Drawing.Point(206, 101);
            this.cbReell.Name = "cbReell";
            this.cbReell.Size = new System.Drawing.Size(81, 17);
            this.cbReell.TabIndex = 17;
            this.cbReell.TabStop = false;
            this.cbReell.Text = "reelle Kurve";
            this.cbReell.UseVisualStyleBackColor = true;
            this.cbReell.CheckedChanged += new System.EventHandler(this.cbReell_CheckedChanged);
            // 
            // CurveParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 162);
            this.Controls.Add(this.cbReell);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tBoxParameterP);
            this.Controls.Add(this.tBoxParameterB);
            this.Controls.Add(this.tBoxParameterA);
            this.Controls.Add(this.lParameterP);
            this.Controls.Add(this.lParameterB);
            this.Controls.Add(this.lParameterA);
            this.Controls.Add(this.lAllgemeineFormelElliptischeKurve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurveParameterForm";
            this.Text = "Kurvenparameter festlegen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAllgemeineFormelElliptischeKurve;
        private System.Windows.Forms.Label lParameterA;
        private System.Windows.Forms.Label lParameterB;
        private System.Windows.Forms.Label lParameterP;
        private System.Windows.Forms.TextBox tBoxParameterA;
        private System.Windows.Forms.TextBox tBoxParameterB;
        private System.Windows.Forms.TextBox tBoxParameterP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbReell;
    }
}