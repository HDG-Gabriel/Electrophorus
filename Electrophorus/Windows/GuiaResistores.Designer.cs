namespace Electrophorus.Windows
{
    partial class GuiaResistores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiaResistores));
            this.label1 = new System.Windows.Forms.Label();
            this.imgGuia = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgGuia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // imgGuia
            // 
            this.imgGuia.Location = new System.Drawing.Point(32, 42);
            this.imgGuia.Name = "imgGuia";
            this.imgGuia.Size = new System.Drawing.Size(182, 111);
            this.imgGuia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGuia.TabIndex = 1;
            this.imgGuia.TabStop = false;
            this.imgGuia.Click += new System.EventHandler(this.imgGuia_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(496, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GuiaResistores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(583, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgGuia);
            this.Controls.Add(this.label1);
            this.Name = "GuiaResistores";
            this.Text = "GuiaResistores";
            this.Load += new System.EventHandler(this.GuiaResistores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgGuia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgGuia;
        private System.Windows.Forms.Button button1;
    }
}