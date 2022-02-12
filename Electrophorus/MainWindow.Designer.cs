
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.winSimulador = new Electrophorus.OpcaoMainWindow();
            this.winResistor = new Electrophorus.OpcaoMainWindow();
            this.winGuiaAprendizado = new Electrophorus.OpcaoMainWindow();
            this.winArduino = new Electrophorus.OpcaoMainWindow();
            this.panBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panBody
            // 
            this.panBody.Controls.Add(this.winArduino);
            this.panBody.Controls.Add(this.winGuiaAprendizado);
            this.panBody.Controls.Add(this.winResistor);
            this.panBody.Controls.Add(this.winSimulador);
            this.panBody.Controls.Add(this.panel1);
            this.panBody.Controls.Add(this.pictureBox2);
            this.panBody.Controls.Add(this.label3);
            this.panBody.Size = new System.Drawing.Size(800, 637);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Olá! O que desejas fazer?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 7);
            this.panel1.TabIndex = 7;
            // 
            // winSimulador
            // 
            this.winSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winSimulador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winSimulador.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winSimulador.Location = new System.Drawing.Point(24, 354);
            this.winSimulador.Name = "winSimulador";
            this.winSimulador.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.winSimulador.Size = new System.Drawing.Size(360, 110);
            this.winSimulador.TabIndex = 8;
            this.winSimulador.Window = null;
            // 
            // winResistor
            // 
            this.winResistor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winResistor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winResistor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winResistor.Location = new System.Drawing.Point(24, 222);
            this.winResistor.Name = "winResistor";
            this.winResistor.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.winResistor.Size = new System.Drawing.Size(360, 110);
            this.winResistor.TabIndex = 9;
            this.winResistor.Window = null;
            // 
            // winGuiaAprendizado
            // 
            this.winGuiaAprendizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winGuiaAprendizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winGuiaAprendizado.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winGuiaAprendizado.Location = new System.Drawing.Point(24, 90);
            this.winGuiaAprendizado.Name = "winGuiaAprendizado";
            this.winGuiaAprendizado.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.winGuiaAprendizado.Size = new System.Drawing.Size(360, 110);
            this.winGuiaAprendizado.TabIndex = 10;
            this.winGuiaAprendizado.Window = null;
            // 
            // winArduino
            // 
            this.winArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winArduino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winArduino.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.winArduino.Location = new System.Drawing.Point(24, 486);
            this.winArduino.Name = "winArduino";
            this.winArduino.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.winArduino.Size = new System.Drawing.Size(360, 110);
            this.winArduino.TabIndex = 11;
            this.winArduino.Window = null;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panBody.ResumeLayout(false);
            this.panBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private OpcaoMainWindow winSimulador;
        private OpcaoMainWindow winResistor;
        private OpcaoMainWindow winGuiaAprendizado;
        private OpcaoMainWindow winArduino;
    }
}