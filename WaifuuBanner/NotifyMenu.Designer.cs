﻿namespace WaifuuBanner
{
    partial class NotifyMenu
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.imgchngbtn = new System.Windows.Forms.Button();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
>>>>>>> 5e62cfe33182163c8f72ca74f531b9aaa935ce80
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(2, 255);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(85, 33);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "종료";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(254, 255);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(88, 33);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "닫기";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // imgchngbtn
            // 
            this.imgchngbtn.Location = new System.Drawing.Point(12, 12);
            this.imgchngbtn.Name = "imgchngbtn";
            this.imgchngbtn.Size = new System.Drawing.Size(317, 83);
            this.imgchngbtn.TabIndex = 2;
            this.imgchngbtn.Text = "이미지 변경";
            this.imgchngbtn.UseVisualStyleBackColor = true;
            this.imgchngbtn.Click += new System.EventHandler(this.imgchngbtn_Click);
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Location = new System.Drawing.Point(12, 193);
            this.opacityTrackBar.Maximum = 100;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(317, 56);
            this.opacityTrackBar.TabIndex = 3;
            this.opacityTrackBar.Value = 100;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.opacityTrackBar_Scroll);
            this.opacityTrackBar.ValueChanged += new System.EventHandler(this.opacityTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(12, 175);
=======
            this.label1.Location = new System.Drawing.Point(13, 163);
>>>>>>> 5e62cfe33182163c8f72ca74f531b9aaa935ce80
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "투명도";
            // 
<<<<<<< HEAD
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "크기";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 116);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(317, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
=======
>>>>>>> 5e62cfe33182163c8f72ca74f531b9aaa935ce80
            // NotifyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(341, 290);
<<<<<<< HEAD
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
=======
>>>>>>> 5e62cfe33182163c8f72ca74f531b9aaa935ce80
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opacityTrackBar);
            this.Controls.Add(this.imgchngbtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotifyMenu";
            this.ShowInTaskbar = false;
            this.Text = "NotifyMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotifyMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
=======
>>>>>>> 5e62cfe33182163c8f72ca74f531b9aaa935ce80
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button imgchngbtn;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
=======
>>>>>>> 5e62cfe33182163c8f72ca74f531b9aaa935ce80
    }
}