namespace mr_Exercise6._1
{
    partial class frmKlok
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
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblAmPm = new System.Windows.Forms.Label();
            this.cboAmPm = new System.Windows.Forms.CheckBox();
            this.btnPlusHour = new System.Windows.Forms.Button();
            this.btnMinHour = new System.Windows.Forms.Button();
            this.btnPlusMin = new System.Windows.Forms.Button();
            this.btnMinMin = new System.Windows.Forms.Button();
            this.btnPlusSec = new System.Windows.Forms.Button();
            this.btnMinSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(12, 9);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(87, 63);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(105, 9);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(87, 63);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(198, 9);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(87, 63);
            this.lblSec.TabIndex = 2;
            this.lblSec.Text = "00";
            // 
            // lblAmPm
            // 
            this.lblAmPm.AutoSize = true;
            this.lblAmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmPm.Location = new System.Drawing.Point(291, 38);
            this.lblAmPm.Name = "lblAmPm";
            this.lblAmPm.Size = new System.Drawing.Size(43, 25);
            this.lblAmPm.TabIndex = 3;
            this.lblAmPm.Text = "AM";
            // 
            // cboAmPm
            // 
            this.cboAmPm.AutoSize = true;
            this.cboAmPm.Location = new System.Drawing.Point(282, 75);
            this.cboAmPm.Name = "cboAmPm";
            this.cboAmPm.Size = new System.Drawing.Size(67, 17);
            this.cboAmPm.TabIndex = 6;
            this.cboAmPm.Text = "12h/24h";
            this.cboAmPm.UseVisualStyleBackColor = true;
            this.cboAmPm.CheckedChanged += new System.EventHandler(this.cboAmPm_CheckedChanged);
            // 
            // btnPlusHour
            // 
            this.btnPlusHour.Location = new System.Drawing.Point(16, 75);
            this.btnPlusHour.Name = "btnPlusHour";
            this.btnPlusHour.Size = new System.Drawing.Size(75, 23);
            this.btnPlusHour.TabIndex = 7;
            this.btnPlusHour.Text = "+ Hours";
            this.btnPlusHour.UseVisualStyleBackColor = true;
            this.btnPlusHour.Click += new System.EventHandler(this.btnPlusHour_Click);
            // 
            // btnMinHour
            // 
            this.btnMinHour.Location = new System.Drawing.Point(16, 100);
            this.btnMinHour.Name = "btnMinHour";
            this.btnMinHour.Size = new System.Drawing.Size(75, 23);
            this.btnMinHour.TabIndex = 8;
            this.btnMinHour.Text = "- Hours";
            this.btnMinHour.UseVisualStyleBackColor = true;
            this.btnMinHour.Click += new System.EventHandler(this.btnMinHour_Click);
            // 
            // btnPlusMin
            // 
            this.btnPlusMin.Location = new System.Drawing.Point(108, 75);
            this.btnPlusMin.Name = "btnPlusMin";
            this.btnPlusMin.Size = new System.Drawing.Size(75, 23);
            this.btnPlusMin.TabIndex = 9;
            this.btnPlusMin.Text = "+ Minutes";
            this.btnPlusMin.UseVisualStyleBackColor = true;
            this.btnPlusMin.Click += new System.EventHandler(this.btnPlusMin_Click);
            // 
            // btnMinMin
            // 
            this.btnMinMin.Location = new System.Drawing.Point(108, 100);
            this.btnMinMin.Name = "btnMinMin";
            this.btnMinMin.Size = new System.Drawing.Size(75, 23);
            this.btnMinMin.TabIndex = 10;
            this.btnMinMin.Text = "- Minutes";
            this.btnMinMin.UseVisualStyleBackColor = true;
            this.btnMinMin.Click += new System.EventHandler(this.btnMinMin_Click);
            // 
            // btnPlusSec
            // 
            this.btnPlusSec.Location = new System.Drawing.Point(201, 75);
            this.btnPlusSec.Name = "btnPlusSec";
            this.btnPlusSec.Size = new System.Drawing.Size(75, 23);
            this.btnPlusSec.TabIndex = 11;
            this.btnPlusSec.Text = "+ Seconds";
            this.btnPlusSec.UseVisualStyleBackColor = true;
            this.btnPlusSec.Click += new System.EventHandler(this.btnPlusSec_Click);
            // 
            // btnMinSec
            // 
            this.btnMinSec.Location = new System.Drawing.Point(201, 100);
            this.btnMinSec.Name = "btnMinSec";
            this.btnMinSec.Size = new System.Drawing.Size(75, 23);
            this.btnMinSec.TabIndex = 12;
            this.btnMinSec.Text = "- Seconds";
            this.btnMinSec.UseVisualStyleBackColor = true;
            this.btnMinSec.Click += new System.EventHandler(this.btnMinSec_Click);
            // 
            // frmKlok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 147);
            this.Controls.Add(this.btnMinSec);
            this.Controls.Add(this.btnPlusSec);
            this.Controls.Add(this.btnMinMin);
            this.Controls.Add(this.btnPlusMin);
            this.Controls.Add(this.btnMinHour);
            this.Controls.Add(this.btnPlusHour);
            this.Controls.Add(this.cboAmPm);
            this.Controls.Add(this.lblAmPm);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHour);
            this.Name = "frmKlok";
            this.Text = "Klok";
            this.Load += new System.EventHandler(this.frmKlok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblAmPm;
        private System.Windows.Forms.CheckBox cboAmPm;
        private System.Windows.Forms.Button btnPlusHour;
        private System.Windows.Forms.Button btnMinHour;
        private System.Windows.Forms.Button btnPlusMin;
        private System.Windows.Forms.Button btnMinMin;
        private System.Windows.Forms.Button btnPlusSec;
        private System.Windows.Forms.Button btnMinSec;
    }
}

