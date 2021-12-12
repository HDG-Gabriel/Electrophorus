namespace Electrophorus
{
    partial class OpcaoMainWindow
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcaoMainWindow));
            this.imgOpcao = new System.Windows.Forms.PictureBox();
            this.lblTititulo = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpcao)).BeginInit();
            this.SuspendLayout();
            // 
            // imgOpcao
            // 
            this.imgOpcao.Image = ((System.Drawing.Image)(resources.GetObject("imgOpcao.Image")));
            this.imgOpcao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgOpcao.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgOpcao.InitialImage")));
            this.imgOpcao.Location = new System.Drawing.Point(15, 21);
            this.imgOpcao.Name = "imgOpcao";
            this.imgOpcao.Size = new System.Drawing.Size(64, 64);
            this.imgOpcao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgOpcao.TabIndex = 1;
            this.imgOpcao.TabStop = false;
            // 
            // lblTititulo
            // 
            this.lblTititulo.AutoSize = true;
            this.lblTititulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTititulo.ForeColor = System.Drawing.Color.White;
            this.lblTititulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTititulo.Location = new System.Drawing.Point(98, 11);
            this.lblTititulo.Name = "lblTititulo";
            this.lblTititulo.Size = new System.Drawing.Size(87, 32);
            this.lblTititulo.TabIndex = 2;
            this.lblTititulo.Text = "Titulo";
            // 
            // lblLegenda
            // 
            this.lblLegenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLegenda.ForeColor = System.Drawing.Color.White;
            this.lblLegenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLegenda.Location = new System.Drawing.Point(98, 53);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(226, 49);
            this.lblLegenda.TabIndex = 3;
            this.lblLegenda.Text = "Teste seus conhecimentos";
            // 
            // OpcaoMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.lblTititulo);
            this.Controls.Add(this.imgOpcao);
            this.Name = "OpcaoMainWindow";
            this.Size = new System.Drawing.Size(360, 110);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OpcaoMainWindow_Paint);
            this.MouseEnter += new System.EventHandler(this.OpcaoMainWindow_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.OpcaoMainWindow_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.imgOpcao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpcao;
        private System.Windows.Forms.Label lblTititulo;
        private System.Windows.Forms.Label lblLegenda;
    }
}
