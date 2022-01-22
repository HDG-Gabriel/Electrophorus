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
            this.pltView = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // pltView
            // 
            this.pltView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pltView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pltView.Location = new System.Drawing.Point(0, 0);
            this.pltView.Name = "pltView";
            this.pltView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pltView.Size = new System.Drawing.Size(800, 450);
            this.pltView.TabIndex = 0;
            this.pltView.Text = "plotView1";
            this.pltView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pltView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pltView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // PlotCkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pltView);
            this.Name = "PlotCkt";
            this.Text = "PlotCkt";
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView pltView;
    }
}