
namespace Electrophorus.Components
{
    partial class Resistor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resistor));
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblValor.Image = ((System.Drawing.Image)(resources.GetObject("lblValor.Image")));
            this.lblValor.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValor.Margin = new System.Windows.Forms.Padding(0);
            this.lblValor.Padding = new System.Windows.Forms.Padding(0);
            this.lblValor.Size = new System.Drawing.Size(64, 62);
            this.lblValor.Text = "";
            // 
            // Resistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "Resistor";
            this.Size = new System.Drawing.Size(64, 64);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
