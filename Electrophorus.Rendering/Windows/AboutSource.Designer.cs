namespace Electrophorus.Rendering.Windows
{
    partial class AboutSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutSource));
            this.lblCorrente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Bateria = new System.Windows.Forms.Label();
            this.imgOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorrente
            // 
            this.lblCorrente.AutoSize = true;
            this.lblCorrente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorrente.ForeColor = System.Drawing.Color.White;
            this.lblCorrente.Location = new System.Drawing.Point(12, 106);
            this.lblCorrente.Name = "lblCorrente";
            this.lblCorrente.Size = new System.Drawing.Size(19, 21);
            this.lblCorrente.TabIndex = 29;
            this.lblCorrente.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Corrente Elétrica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "(V)";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(133, 23);
            this.txtValor.TabIndex = 26;
            // 
            // Bateria
            // 
            this.Bateria.AutoSize = true;
            this.Bateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bateria.ForeColor = System.Drawing.Color.White;
            this.Bateria.Location = new System.Drawing.Point(12, 9);
            this.Bateria.Name = "Bateria";
            this.Bateria.Size = new System.Drawing.Size(73, 25);
            this.Bateria.TabIndex = 25;
            this.Bateria.Text = "DC Fonte";
            // 
            // imgOK
            // 
            this.imgOK.Image = ((System.Drawing.Image)(resources.GetObject("imgOK.Image")));
            this.imgOK.Location = new System.Drawing.Point(175, 124);
            this.imgOK.Name = "imgOK";
            this.imgOK.Size = new System.Drawing.Size(43, 40);
            this.imgOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOK.TabIndex = 30;
            this.imgOK.TabStop = false;
            // 
            // AboutSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(230, 176);
            this.Controls.Add(this.imgOK);
            this.Controls.Add(this.lblCorrente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.Bateria);
            this.Name = "AboutSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DC Fonte";
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label Bateria;
        private System.Windows.Forms.PictureBox imgOK;
    }
}