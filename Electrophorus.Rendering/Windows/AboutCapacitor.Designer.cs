namespace Electrophorus.Rendering.Windows
{
    partial class AboutCapacitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutCapacitor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapacitancia = new System.Windows.Forms.TextBox();
            this.imgOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capacitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "(F)";
            // 
            // txtCapacitancia
            // 
            this.txtCapacitancia.Location = new System.Drawing.Point(12, 48);
            this.txtCapacitancia.Name = "txtCapacitancia";
            this.txtCapacitancia.Size = new System.Drawing.Size(118, 23);
            this.txtCapacitancia.TabIndex = 7;
            // 
            // imgOK
            // 
            this.imgOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgOK.Image = ((System.Drawing.Image)(resources.GetObject("imgOK.Image")));
            this.imgOK.Location = new System.Drawing.Point(132, 103);
            this.imgOK.Name = "imgOK";
            this.imgOK.Size = new System.Drawing.Size(30, 30);
            this.imgOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOK.TabIndex = 36;
            this.imgOK.TabStop = false;
            // 
            // AboutCapacitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(171, 143);
            this.Controls.Add(this.imgOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapacitancia);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AboutCapacitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapacitancia;
        private System.Windows.Forms.PictureBox imgOK;
    }
}