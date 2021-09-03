
namespace Electrophorus
{
    partial class JanelaResistor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaResistor));
            this.ImgResistor = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbValorResistor = new System.Windows.Forms.ComboBox();
            this.panBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgResistor)).BeginInit();
            this.SuspendLayout();
            // 
            // panBody
            // 
            this.panBody.Controls.Add(this.CbValorResistor);
            this.panBody.Controls.Add(this.label7);
            this.panBody.Controls.Add(this.ImgResistor);
            // 
            // ImgResistor
            // 
            this.ImgResistor.Image = ((System.Drawing.Image)(resources.GetObject("ImgResistor.Image")));
            this.ImgResistor.Location = new System.Drawing.Point(3, 59);
            this.ImgResistor.Name = "ImgResistor";
            this.ImgResistor.Size = new System.Drawing.Size(797, 282);
            this.ImgResistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgResistor.TabIndex = 1;
            this.ImgResistor.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor do resistor";
            // 
            // CbValorResistor
            // 
            this.CbValorResistor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbValorResistor.FormattingEnabled = true;
            this.CbValorResistor.Location = new System.Drawing.Point(200, 13);
            this.CbValorResistor.Name = "CbValorResistor";
            this.CbValorResistor.Size = new System.Drawing.Size(323, 33);
            this.CbValorResistor.TabIndex = 15;
            // 
            // JanelaResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "JanelaResistor";
            this.Text = "JanelaResistor";
            this.Load += new System.EventHandler(this.JanelaResistor_Load);
            this.panBody.ResumeLayout(false);
            this.panBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgResistor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgResistor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbValorResistor;
    }
}