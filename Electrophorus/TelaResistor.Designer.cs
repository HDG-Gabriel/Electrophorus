
namespace Electrophorus
{
    partial class TelaResistor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaResistor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgResistor = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbFaixa2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbFaixa3 = new System.Windows.Forms.ComboBox();
            this.CbFaixa1 = new System.Windows.Forms.ComboBox();
            this.BtnBackTelaInicial = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CbValorResistor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CbFaixa4 = new System.Windows.Forms.ComboBox();
            this.CbFaixa5 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgResistor)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBackTelaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ImgResistor);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 282);
            this.panel1.TabIndex = 1;
            // 
            // ImgResistor
            // 
            this.ImgResistor.Image = ((System.Drawing.Image)(resources.GetObject("ImgResistor.Image")));
            this.ImgResistor.Location = new System.Drawing.Point(167, 0);
            this.ImgResistor.Name = "ImgResistor";
            this.ImgResistor.Size = new System.Drawing.Size(512, 282);
            this.ImgResistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgResistor.TabIndex = 0;
            this.ImgResistor.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(105)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CbFaixa2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CbFaixa3);
            this.panel2.Controls.Add(this.CbFaixa1);
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 275);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Faixa 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faixa 1";
            // 
            // CbFaixa2
            // 
            this.CbFaixa2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFaixa2.FormattingEnabled = true;
            this.CbFaixa2.Items.AddRange(new object[] {
            "Preto",
            "Marrom",
            "Vermelho",
            "Laranja",
            "Amarelo",
            "Verde",
            "Azul",
            "Violeta",
            "Cinza",
            "Branco"});
            this.CbFaixa2.Location = new System.Drawing.Point(12, 136);
            this.CbFaixa2.Name = "CbFaixa2";
            this.CbFaixa2.Size = new System.Drawing.Size(323, 31);
            this.CbFaixa2.TabIndex = 5;
            this.CbFaixa2.Text = "Selecione uma cor";
            this.CbFaixa2.SelectedIndexChanged += new System.EventHandler(this.CbFaixa2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Faixa 2";
            // 
            // CbFaixa3
            // 
            this.CbFaixa3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFaixa3.FormattingEnabled = true;
            this.CbFaixa3.Items.AddRange(new object[] {
            "Preto",
            "Marrom",
            "Vermelho",
            "Laranja",
            "Amarelo",
            "Verde",
            "Azul",
            "Violeta",
            "Cinza",
            "Branco"});
            this.CbFaixa3.Location = new System.Drawing.Point(12, 229);
            this.CbFaixa3.Name = "CbFaixa3";
            this.CbFaixa3.Size = new System.Drawing.Size(323, 31);
            this.CbFaixa3.TabIndex = 3;
            this.CbFaixa3.Text = "Selecione uma cor";
            this.CbFaixa3.SelectedIndexChanged += new System.EventHandler(this.CbFaixa3_SelectedIndexChanged);
            // 
            // CbFaixa1
            // 
            this.CbFaixa1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFaixa1.FormattingEnabled = true;
            this.CbFaixa1.Items.AddRange(new object[] {
            "Preto",
            "Marrom",
            "Vermelho",
            "Laranja",
            "Amarelo",
            "Verde",
            "Azul",
            "Violeta",
            "Cinza",
            "Branco"});
            this.CbFaixa1.Location = new System.Drawing.Point(12, 47);
            this.CbFaixa1.Name = "CbFaixa1";
            this.CbFaixa1.Size = new System.Drawing.Size(323, 31);
            this.CbFaixa1.TabIndex = 1;
            this.CbFaixa1.Text = "Selecione uma cor";
            this.CbFaixa1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnBackTelaInicial
            // 
            this.BtnBackTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackTelaInicial.Image")));
            this.BtnBackTelaInicial.Location = new System.Drawing.Point(350, 518);
            this.BtnBackTelaInicial.Name = "BtnBackTelaInicial";
            this.BtnBackTelaInicial.Size = new System.Drawing.Size(38, 44);
            this.BtnBackTelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBackTelaInicial.TabIndex = 3;
            this.BtnBackTelaInicial.TabStop = false;
            this.BtnBackTelaInicial.Click += new System.EventHandler(this.BtnBackTelaInicial_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.Location = new System.Drawing.Point(396, 518);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(38, 44);
            this.BtnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnReset.TabIndex = 4;
            this.BtnReset.TabStop = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(105)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.CbValorResistor);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.CbFaixa4);
            this.panel3.Controls.Add(this.CbFaixa5);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(440, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 275);
            this.panel3.TabIndex = 14;
            // 
            // CbValorResistor
            // 
            this.CbValorResistor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbValorResistor.FormattingEnabled = true;
            this.CbValorResistor.Location = new System.Drawing.Point(9, 227);
            this.CbValorResistor.Name = "CbValorResistor";
            this.CbValorResistor.Size = new System.Drawing.Size(323, 33);
            this.CbValorResistor.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor do resistor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Multiplicador               (faixa 4)";
            // 
            // CbFaixa4
            // 
            this.CbFaixa4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFaixa4.FormattingEnabled = true;
            this.CbFaixa4.Items.AddRange(new object[] {
            "Preto",
            "Marrom",
            "Vermelho",
            "Laranja",
            "Amarelo",
            "Verde",
            "Azul",
            "Violeta",
            "Cinza",
            "Branco",
            "Ouro",
            "Prata"});
            this.CbFaixa4.Location = new System.Drawing.Point(9, 47);
            this.CbFaixa4.Name = "CbFaixa4";
            this.CbFaixa4.Size = new System.Drawing.Size(323, 31);
            this.CbFaixa4.TabIndex = 6;
            this.CbFaixa4.Text = "Selecione uma cor";
            this.CbFaixa4.SelectedIndexChanged += new System.EventHandler(this.CbFaixa4_SelectedIndexChanged);
            // 
            // CbFaixa5
            // 
            this.CbFaixa5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFaixa5.FormattingEnabled = true;
            this.CbFaixa5.Items.AddRange(new object[] {
            "Marrom",
            "Vermelho",
            "Verde",
            "Azul",
            "Violeta",
            "Cinza",
            "Ouro",
            "Prata"});
            this.CbFaixa5.Location = new System.Drawing.Point(9, 136);
            this.CbFaixa5.Name = "CbFaixa5";
            this.CbFaixa5.Size = new System.Drawing.Size(323, 31);
            this.CbFaixa5.TabIndex = 4;
            this.CbFaixa5.Text = "Selecione uma cor";
            this.CbFaixa5.SelectedIndexChanged += new System.EventHandler(this.CbFaixa5_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 29);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tolerância                    (faixa 5)";
            // 
            // TelaResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBackTelaInicial);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TelaResistor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaResistor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgResistor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBackTelaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgResistor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFaixa1;
        private System.Windows.Forms.PictureBox BtnBackTelaInicial;
        private System.Windows.Forms.PictureBox BtnReset;
        private System.Windows.Forms.ComboBox CbFaixa2;
        private System.Windows.Forms.ComboBox CbFaixa3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CbValorResistor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbFaixa4;
        private System.Windows.Forms.ComboBox CbFaixa5;
        private System.Windows.Forms.Label label12;
    }
}