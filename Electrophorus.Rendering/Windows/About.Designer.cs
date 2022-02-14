namespace Electrophorus.Rendering.Windows
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbMagnitude = new System.Windows.Forms.ComboBox();
            this.lblUnity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblDDP = new System.Windows.Forms.Label();
            this.imgApply = new System.Windows.Forms.PictureBox();
            this.btnPlot = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Nome Elemento";
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue.Location = new System.Drawing.Point(12, 47);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(66, 27);
            this.txtValue.TabIndex = 2;
            // 
            // cmbMagnitude
            // 
            this.cmbMagnitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMagnitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMagnitude.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMagnitude.FormattingEnabled = true;
            this.cmbMagnitude.Items.AddRange(new object[] {
            "p",
            "n",
            "μ",
            "m",
            "1",
            "K",
            "M",
            "G",
            "T"});
            this.cmbMagnitude.Location = new System.Drawing.Point(84, 47);
            this.cmbMagnitude.Name = "cmbMagnitude";
            this.cmbMagnitude.Size = new System.Drawing.Size(45, 27);
            this.cmbMagnitude.TabIndex = 3;
            // 
            // lblUnity
            // 
            this.lblUnity.AutoSize = true;
            this.lblUnity.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnity.ForeColor = System.Drawing.Color.White;
            this.lblUnity.Location = new System.Drawing.Point(133, 50);
            this.lblUnity.Name = "lblUnity";
            this.lblUnity.Size = new System.Drawing.Size(22, 23);
            this.lblUnity.TabIndex = 4;
            this.lblUnity.Text = "U";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Corrente Elétrica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tensão";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(12, 116);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(20, 23);
            this.lblCurrent.TabIndex = 7;
            this.lblCurrent.Text = "0";
            // 
            // lblDDP
            // 
            this.lblDDP.AutoSize = true;
            this.lblDDP.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDDP.ForeColor = System.Drawing.Color.White;
            this.lblDDP.Location = new System.Drawing.Point(12, 186);
            this.lblDDP.Name = "lblDDP";
            this.lblDDP.Size = new System.Drawing.Size(20, 23);
            this.lblDDP.TabIndex = 8;
            this.lblDDP.Text = "0";
            // 
            // imgApply
            // 
            this.imgApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgApply.Image = ((System.Drawing.Image)(resources.GetObject("imgApply.Image")));
            this.imgApply.Location = new System.Drawing.Point(214, 234);
            this.imgApply.Name = "imgApply";
            this.imgApply.Size = new System.Drawing.Size(43, 40);
            this.imgApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgApply.TabIndex = 36;
            this.imgApply.TabStop = false;
            this.toolTip.SetToolTip(this.imgApply, "Aplicar");
            // 
            // btnPlot
            // 
            this.btnPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlot.Image = global::Electrophorus.Rendering.Properties.Resources.graph;
            this.btnPlot.Location = new System.Drawing.Point(12, 228);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(46, 46);
            this.btnPlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlot.TabIndex = 37;
            this.btnPlot.TabStop = false;
            this.toolTip.SetToolTip(this.btnPlot, "Realizar o plot");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(269, 286);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.imgApply);
            this.Controls.Add(this.lblDDP);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUnity);
            this.Controls.Add(this.cmbMagnitude);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imgApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbMagnitude;
        private System.Windows.Forms.Label lblUnity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblDDP;
        private System.Windows.Forms.PictureBox imgApply;
        private System.Windows.Forms.PictureBox btnPlot;
        private System.Windows.Forms.ToolTip toolTip;
    }
}