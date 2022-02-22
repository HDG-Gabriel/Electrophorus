
namespace Electrophorus
{
    partial class GuiaDeAprendizagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiaDeAprendizagem));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WinCapacitores = new Electrophorus.OpcaoMainWindow();
            this.BtnBackTelaInicial = new System.Windows.Forms.PictureBox();
            this.WinIndutor = new Electrophorus.OpcaoMainWindow();
            this.panBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBackTelaInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // panBody
            // 
            this.panBody.Controls.Add(this.WinIndutor);
            this.panBody.Controls.Add(this.BtnBackTelaInicial);
            this.panBody.Controls.Add(this.WinCapacitores);
            this.panBody.Controls.Add(this.label2);
            this.panBody.Controls.Add(this.pictureBox2);
            this.panBody.Size = new System.Drawing.Size(800, 416);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(369, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 373);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(348, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guia De Aprendizado";
            // 
            // WinCapacitores
            // 
            this.WinCapacitores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.WinCapacitores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WinCapacitores.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.WinCapacitores.Location = new System.Drawing.Point(12, 65);
            this.WinCapacitores.Name = "WinCapacitores";
            this.WinCapacitores.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.WinCapacitores.Size = new System.Drawing.Size(317, 103);
            this.WinCapacitores.TabIndex = 11;
            this.WinCapacitores.Window = null;
            this.WinCapacitores.Load += new System.EventHandler(this.WinCapacitores_Load);
            // 
            // BtnBackTelaInicial
            // 
            this.BtnBackTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackTelaInicial.Image")));
            this.BtnBackTelaInicial.Location = new System.Drawing.Point(3, 0);
            this.BtnBackTelaInicial.Name = "BtnBackTelaInicial";
            this.BtnBackTelaInicial.Size = new System.Drawing.Size(38, 44);
            this.BtnBackTelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBackTelaInicial.TabIndex = 27;
            this.BtnBackTelaInicial.TabStop = false;
            this.BtnBackTelaInicial.Click += new System.EventHandler(this.BtnBackTelaInicial_Click);
            // 
            // WinIndutor
            // 
            this.WinIndutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.WinIndutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WinIndutor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.WinIndutor.Location = new System.Drawing.Point(12, 195);
            this.WinIndutor.Name = "WinIndutor";
            this.WinIndutor.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.WinIndutor.Size = new System.Drawing.Size(317, 103);
            this.WinIndutor.TabIndex = 28;
            this.WinIndutor.Window = null;
            // 
            // GuiaDeAprendizagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GuiaDeAprendizagem";
            this.Text = "GuiaDeAprendizagem";
            this.panBody.ResumeLayout(false);
            this.panBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBackTelaInicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private OpcaoMainWindow WinCapacitores;
        private System.Windows.Forms.PictureBox BtnBackTelaInicial;
        private OpcaoMainWindow WinIndutor;
    }
}