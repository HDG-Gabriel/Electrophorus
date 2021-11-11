
namespace Electrophorus
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panQuiz = new System.Windows.Forms.Panel();
            this.lblTextQuiz = new System.Windows.Forms.Label();
            this.lblTitleQuiz = new System.Windows.Forms.Label();
            this.imgQuiz = new System.Windows.Forms.PictureBox();
            this.panResistor = new System.Windows.Forms.Panel();
            this.lblTextResistor = new System.Windows.Forms.Label();
            this.lblTitleResistor = new System.Windows.Forms.Label();
            this.imgResistor = new System.Windows.Forms.PictureBox();
            this.panSimulador = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panBody.SuspendLayout();
            this.panQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuiz)).BeginInit();
            this.panResistor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResistor)).BeginInit();
            this.panSimulador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panBody
            // 
            this.panBody.Controls.Add(this.pictureBox2);
            this.panBody.Controls.Add(this.label3);
            this.panBody.Controls.Add(this.panSimulador);
            this.panBody.Controls.Add(this.panResistor);
            this.panBody.Controls.Add(this.panQuiz);
            this.panBody.Size = new System.Drawing.Size(800, 512);
            // 
            // panQuiz
            // 
            this.panQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panQuiz.Controls.Add(this.lblTextQuiz);
            this.panQuiz.Controls.Add(this.lblTitleQuiz);
            this.panQuiz.Controls.Add(this.imgQuiz);
            this.panQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panQuiz.Location = new System.Drawing.Point(38, 98);
            this.panQuiz.Name = "panQuiz";
            this.panQuiz.Size = new System.Drawing.Size(341, 92);
            this.panQuiz.TabIndex = 1;
            this.panQuiz.Paint += new System.Windows.Forms.PaintEventHandler(this.panQuiz_Paint);
            this.panQuiz.MouseEnter += new System.EventHandler(this.panQuiz_MouseEnter);
            this.panQuiz.MouseLeave += new System.EventHandler(this.panQuiz_MouseLeave);
            // 
            // lblTextQuiz
            // 
            this.lblTextQuiz.AutoSize = true;
            this.lblTextQuiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextQuiz.ForeColor = System.Drawing.Color.White;
            this.lblTextQuiz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextQuiz.Location = new System.Drawing.Point(94, 58);
            this.lblTextQuiz.Name = "lblTextQuiz";
            this.lblTextQuiz.Size = new System.Drawing.Size(191, 18);
            this.lblTextQuiz.TabIndex = 2;
            this.lblTextQuiz.Text = "Teste seus conhecimentos";
            // 
            // lblTitleQuiz
            // 
            this.lblTitleQuiz.AutoSize = true;
            this.lblTitleQuiz.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleQuiz.ForeColor = System.Drawing.Color.White;
            this.lblTitleQuiz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitleQuiz.Location = new System.Drawing.Point(94, 13);
            this.lblTitleQuiz.Name = "lblTitleQuiz";
            this.lblTitleQuiz.Size = new System.Drawing.Size(72, 32);
            this.lblTitleQuiz.TabIndex = 1;
            this.lblTitleQuiz.Text = "Quiz";
            // 
            // imgQuiz
            // 
            this.imgQuiz.Image = ((System.Drawing.Image)(resources.GetObject("imgQuiz.Image")));
            this.imgQuiz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgQuiz.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgQuiz.InitialImage")));
            this.imgQuiz.Location = new System.Drawing.Point(15, 13);
            this.imgQuiz.Name = "imgQuiz";
            this.imgQuiz.Size = new System.Drawing.Size(64, 64);
            this.imgQuiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgQuiz.TabIndex = 0;
            this.imgQuiz.TabStop = false;
            // 
            // panResistor
            // 
            this.panResistor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panResistor.Controls.Add(this.lblTextResistor);
            this.panResistor.Controls.Add(this.lblTitleResistor);
            this.panResistor.Controls.Add(this.imgResistor);
            this.panResistor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panResistor.Location = new System.Drawing.Point(38, 223);
            this.panResistor.Name = "panResistor";
            this.panResistor.Size = new System.Drawing.Size(341, 111);
            this.panResistor.TabIndex = 4;
            this.panResistor.Click += new System.EventHandler(this.panResistor_Click);
            this.panResistor.Paint += new System.Windows.Forms.PaintEventHandler(this.panResistor_Paint);
            this.panResistor.MouseEnter += new System.EventHandler(this.panResistor_MouseEnter);
            this.panResistor.MouseLeave += new System.EventHandler(this.panResistor_MouseLeave);
            // 
            // lblTextResistor
            // 
            this.lblTextResistor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextResistor.ForeColor = System.Drawing.Color.White;
            this.lblTextResistor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextResistor.Location = new System.Drawing.Point(94, 58);
            this.lblTextResistor.Name = "lblTextResistor";
            this.lblTextResistor.Size = new System.Drawing.Size(219, 47);
            this.lblTextResistor.TabIndex = 2;
            this.lblTextResistor.Text = "Calcule a resistência inserindo as cores";
            // 
            // lblTitleResistor
            // 
            this.lblTitleResistor.AutoSize = true;
            this.lblTitleResistor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleResistor.ForeColor = System.Drawing.Color.White;
            this.lblTitleResistor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitleResistor.Location = new System.Drawing.Point(94, 13);
            this.lblTitleResistor.Name = "lblTitleResistor";
            this.lblTitleResistor.Size = new System.Drawing.Size(124, 32);
            this.lblTitleResistor.TabIndex = 1;
            this.lblTitleResistor.Text = "Resistor";
            // 
            // imgResistor
            // 
            this.imgResistor.Image = ((System.Drawing.Image)(resources.GetObject("imgResistor.Image")));
            this.imgResistor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgResistor.InitialImage = null;
            this.imgResistor.Location = new System.Drawing.Point(15, 13);
            this.imgResistor.Name = "imgResistor";
            this.imgResistor.Size = new System.Drawing.Size(64, 64);
            this.imgResistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgResistor.TabIndex = 0;
            this.imgResistor.TabStop = false;
            // 
            // panSimulador
            // 
            this.panSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panSimulador.Controls.Add(this.label1);
            this.panSimulador.Controls.Add(this.label2);
            this.panSimulador.Controls.Add(this.pictureBox1);
            this.panSimulador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panSimulador.Location = new System.Drawing.Point(38, 366);
            this.panSimulador.Name = "panSimulador";
            this.panSimulador.Size = new System.Drawing.Size(341, 92);
            this.panSimulador.TabIndex = 3;
            this.panSimulador.Click += new System.EventHandler(this.panSimulador_Click);
            this.panSimulador.Paint += new System.Windows.Forms.PaintEventHandler(this.panSimulador_Paint);
            this.panSimulador.MouseEnter += new System.EventHandler(this.panSimulador_MouseEnter);
            this.panSimulador.MouseLeave += new System.EventHandler(this.panSimulador_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(101, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monte seu circuito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(94, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simulador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Olá! O que desejas fazer?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(475, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panBody.ResumeLayout(false);
            this.panBody.PerformLayout();
            this.panQuiz.ResumeLayout(false);
            this.panQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuiz)).EndInit();
            this.panResistor.ResumeLayout(false);
            this.panResistor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResistor)).EndInit();
            this.panSimulador.ResumeLayout(false);
            this.panSimulador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panQuiz;
        private System.Windows.Forms.Label lblTextQuiz;
        private System.Windows.Forms.Label lblTitleQuiz;
        private System.Windows.Forms.PictureBox imgQuiz;
        private System.Windows.Forms.Panel panResistor;
        private System.Windows.Forms.Label lblTextResistor;
        private System.Windows.Forms.Label lblTitleResistor;
        private System.Windows.Forms.PictureBox imgResistor;
        private System.Windows.Forms.Panel panSimulador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}