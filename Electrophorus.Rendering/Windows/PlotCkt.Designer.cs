namespace Electrophorus.Rendering.Windows
{
    partial class PlotCkt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlotCkt));
            this.pltView = new OxyPlot.WindowsForms.PlotView();
            this.cmbPlotOption = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pltView
            // 
            this.pltView.BackColor = System.Drawing.Color.White;
            this.pltView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pltView.Location = new System.Drawing.Point(0, 0);
            this.pltView.Name = "pltView";
            this.pltView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pltView.Size = new System.Drawing.Size(800, 477);
            this.pltView.TabIndex = 0;
            this.pltView.Text = "plotView1";
            this.pltView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pltView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pltView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // cmbPlotOption
            // 
            this.cmbPlotOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbPlotOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlotOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPlotOption.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPlotOption.FormattingEnabled = true;
            this.cmbPlotOption.Items.AddRange(new object[] {
            "Corrente",
            "Tensão"});
            this.cmbPlotOption.Location = new System.Drawing.Point(684, 10);
            this.cmbPlotOption.Name = "cmbPlotOption";
            this.cmbPlotOption.Size = new System.Drawing.Size(99, 27);
            this.cmbPlotOption.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PlotCkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbPlotOption);
            this.Controls.Add(this.pltView);
            this.Name = "PlotCkt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView pltView;
        private System.Windows.Forms.ComboBox cmbPlotOption;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}