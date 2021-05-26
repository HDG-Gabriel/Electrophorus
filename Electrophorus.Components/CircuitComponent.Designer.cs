
namespace Electrophorus.Components
{
    partial class CircuitComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircuitComponent));
            this.lblResistencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResistencia
            // 
            this.lblResistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResistencia.Image = ((System.Drawing.Image)(resources.GetObject("lblResistencia.Image")));
            this.lblResistencia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblResistencia.Location = new System.Drawing.Point(0, 0);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblResistencia.Size = new System.Drawing.Size(64, 96);
            this.lblResistencia.TabIndex = 0;
            this.lblResistencia.Text = "1 U";
            this.lblResistencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CircuitComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResistencia);
            this.Name = "CircuitComponent";
            this.Size = new System.Drawing.Size(64, 92);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblResistencia;
    }
}
