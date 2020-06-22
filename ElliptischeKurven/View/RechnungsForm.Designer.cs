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
            this.rTBRechnung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTBRechnung
            // 
            this.rTBRechnung.BackColor = System.Drawing.Color.Black;
            this.rTBRechnung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBRechnung.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBRechnung.ForeColor = System.Drawing.Color.White;
            this.rTBRechnung.Location = new System.Drawing.Point(0, 0);
            this.rTBRechnung.Name = "rTBRechnung";
            this.rTBRechnung.ReadOnly = true;
            this.rTBRechnung.Size = new System.Drawing.Size(530, 368);
            this.rTBRechnung.TabIndex = 0;
            this.rTBRechnung.Text = "";
            // 
            // RechnungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 368);
            this.Controls.Add(this.rTBRechnung);
            this.DoubleBuffered = true;
            this.Name = "RechnungsForm";
            this.Text = "Lösungsweg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBRechnung;
    }
}