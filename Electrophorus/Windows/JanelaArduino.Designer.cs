
namespace Electrophorus
{
    partial class JanelaArduino
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
            this.components = new System.ComponentModel.Container();
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.btReceber = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.panBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBody
            // 
            this.panBody.Controls.Add(this.Salvar);
            this.panBody.Controls.Add(this.btClear);
            this.panBody.Controls.Add(this.btReceber);
            this.panBody.Controls.Add(this.textBoxReceber);
            this.panBody.Controls.Add(this.textBoxEnviar);
            this.panBody.Controls.Add(this.btEnviar);
            this.panBody.Controls.Add(this.comboBox1);
            this.panBody.Controls.Add(this.btConectar);
            this.panBody.Size = new System.Drawing.Size(800, 416);
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(30, 28);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(72, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.BtConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(30, 70);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(72, 23);
            this.btEnviar.TabIndex = 2;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Location = new System.Drawing.Point(120, 70);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(129, 23);
            this.textBoxEnviar.TabIndex = 3;
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Location = new System.Drawing.Point(31, 141);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(217, 247);
            this.textBoxReceber.TabIndex = 4;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.TimerCOM_Tick);
            // 
            // btReceber
            // 
            this.btReceber.Location = new System.Drawing.Point(30, 112);
            this.btReceber.Name = "btReceber";
            this.btReceber.Size = new System.Drawing.Size(72, 23);
            this.btReceber.TabIndex = 5;
            this.btReceber.Text = "Receber";
            this.btReceber.UseVisualStyleBackColor = true;
            this.btReceber.Click += new System.EventHandler(this.BtReceber_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(332, 109);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(79, 25);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(320, 274);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 7;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // JanelaArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "JanelaArduino";
            this.Text = "JanelaArduino";
            this.panBody.ResumeLayout(false);
            this.panBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.TextBox textBoxEnviar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.Button btReceber;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button Salvar;
    }
}