namespace WatchV2._0
{
    partial class Dong_Ho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dong_Ho));
            this.LBGio = new System.Windows.Forms.Label();
            this.LBGiay = new System.Windows.Forms.Label();
            this.DMY = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PB1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBGio
            // 
            this.LBGio.AutoSize = true;
            this.LBGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBGio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBGio.Location = new System.Drawing.Point(87, 0);
            this.LBGio.Name = "LBGio";
            this.LBGio.Size = new System.Drawing.Size(199, 73);
            this.LBGio.TabIndex = 0;
            this.LBGio.Text = "00:00";
            this.LBGio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dong_Ho_MouseMove);
            // 
            // LBGiay
            // 
            this.LBGiay.AutoSize = true;
            this.LBGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBGiay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBGiay.Location = new System.Drawing.Point(271, 30);
            this.LBGiay.Name = "LBGiay";
            this.LBGiay.Size = new System.Drawing.Size(55, 37);
            this.LBGiay.TabIndex = 1;
            this.LBGiay.Text = "00";
            this.LBGiay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dong_Ho_MouseMove);
            // 
            // DMY
            // 
            this.DMY.AutoSize = true;
            this.DMY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMY.Location = new System.Drawing.Point(96, 75);
            this.DMY.Name = "DMY";
            this.DMY.Size = new System.Drawing.Size(269, 22);
            this.DMY.TabIndex = 2;
            this.DMY.Text = "Thứ Hai, 5 Tháng 11 Năm 2018";
            this.DMY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dong_Ho_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(3, 7);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(90, 90);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 3;
            this.PB1.TabStop = false;
            // 
            // Dong_Ho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(377, 106);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.DMY);
            this.Controls.Add(this.LBGiay);
            this.Controls.Add(this.LBGio);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dong_Ho";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watch";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Dong_Ho_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dong_Ho_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBGio;
        private System.Windows.Forms.Label LBGiay;
        private object fontDialog;
        private System.Windows.Forms.Label DMY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PB1;
    }
}

