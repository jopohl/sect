namespace EllipticCurves.View
{
    partial class CalculationForm
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
            this.richTextBoxCalculations = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxCalculations
            // 
            this.richTextBoxCalculations.BackColor = System.Drawing.Color.Black;
            this.richTextBoxCalculations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCalculations.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCalculations.ForeColor = System.Drawing.Color.White;
            this.richTextBoxCalculations.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCalculations.Name = "richTextBoxCalculations";
            this.richTextBoxCalculations.ReadOnly = true;
            this.richTextBoxCalculations.Size = new System.Drawing.Size(530, 368);
            this.richTextBoxCalculations.TabIndex = 0;
            this.richTextBoxCalculations.Text = "";
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 368);
            this.Controls.Add(this.richTextBoxCalculations);
            this.DoubleBuffered = true;
            this.Name = "CalculationForm";
            this.Text = "Calculation Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCalculations;
    }
}