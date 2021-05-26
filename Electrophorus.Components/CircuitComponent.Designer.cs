
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
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValor.Image = ((System.Drawing.Image)(resources.GetObject("lblValor.Image")));
            this.lblValor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblValor.Location = new System.Drawing.Point(0, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblValor.Size = new System.Drawing.Size(64, 92);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "1 U";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CircuitComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblValor);
            this.Name = "CircuitComponent";
            this.Size = new System.Drawing.Size(64, 92);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblValor;
    }
}
