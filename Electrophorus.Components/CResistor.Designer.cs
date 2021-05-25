
namespace Electrophorus.Components
{
    partial class CResistor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CResistor));
            this.lblResistencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResistencia
            // 
            this.lblResistencia.BackColor = System.Drawing.Color.Transparent;
            this.lblResistencia.Image = ((System.Drawing.Image)(resources.GetObject("lblResistencia.Image")));
            this.lblResistencia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblResistencia.Location = new System.Drawing.Point(0, 0);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Padding = new System.Windows.Forms.Padding(0, 8, 0, 5);
            this.lblResistencia.Size = new System.Drawing.Size(64, 64);
            this.lblResistencia.TabIndex = 1;
            this.lblResistencia.Text = "1 Ω";
            this.lblResistencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblResistencia);
            this.Name = "CResistor";
            this.Size = new System.Drawing.Size(64, 64);
            this.Load += new System.EventHandler(this.CResistor_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblResistencia;
    }
}
