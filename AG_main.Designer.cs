namespace Gusev_OOP_KT2
{
    partial class AG_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AG_main));
            AG_lblInfo = new Label();
            AG_lblInfo2 = new Label();
            AG_lblRand = new Label();
            AG_lblKatse = new Label();
            AG_lblKirjeldus = new Label();
            AG_lblKatseInfo = new Label();
            AG_grb1 = new GroupBox();
            AG_start = new Button();
            AG_ok = new Button();
            AG_Pilt = new PictureBox();
            AG_pilt1 = new PictureBox();
            AG_pilt2 = new PictureBox();
            AG_pilt3 = new PictureBox();
            AG_grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AG_Pilt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AG_pilt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AG_pilt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AG_pilt3).BeginInit();
            SuspendLayout();
            // 
            // AG_lblInfo
            // 
            AG_lblInfo.AutoSize = true;
            AG_lblInfo.BackColor = SystemColors.Control;
            AG_lblInfo.FlatStyle = FlatStyle.System;
            AG_lblInfo.Font = new Font("Segoe UI", 14F);
            AG_lblInfo.ForeColor = Color.Goldenrod;
            AG_lblInfo.ImageAlign = ContentAlignment.MiddleLeft;
            AG_lblInfo.Location = new Point(12, 9);
            AG_lblInfo.Name = "AG_lblInfo";
            AG_lblInfo.Size = new Size(763, 25);
            AG_lblInfo.TabIndex = 0;
            AG_lblInfo.Text = "Jälgi, mitu korda klõpsad, et saada kas 0 või 10. Pea meeles, et iga klõps maksab ühe euro.";
            // 
            // AG_lblInfo2
            // 
            AG_lblInfo2.AutoSize = true;
            AG_lblInfo2.BackColor = SystemColors.Control;
            AG_lblInfo2.FlatStyle = FlatStyle.System;
            AG_lblInfo2.Font = new Font("Segoe UI", 10F);
            AG_lblInfo2.ForeColor = Color.FromArgb(144, 32, 24);
            AG_lblInfo2.ImageAlign = ContentAlignment.MiddleLeft;
            AG_lblInfo2.Location = new Point(12, 34);
            AG_lblInfo2.Name = "AG_lblInfo2";
            AG_lblInfo2.Size = new Size(689, 19);
            AG_lblInfo2.TabIndex = 10;
            AG_lblInfo2.Text = "Kui see võtab vähem kui kümme klõpsu, jääb summa teile, kui rohkem kui kümme, siis peate selle välja maksma";
            // 
            // AG_lblRand
            // 
            AG_lblRand.BackColor = SystemColors.Control;
            AG_lblRand.BorderStyle = BorderStyle.Fixed3D;
            AG_lblRand.Font = new Font("Segoe UI", 32F);
            AG_lblRand.ForeColor = Color.DimGray;
            AG_lblRand.Location = new Point(39, 44);
            AG_lblRand.Margin = new Padding(3);
            AG_lblRand.Name = "AG_lblRand";
            AG_lblRand.Size = new Size(100, 75);
            AG_lblRand.TabIndex = 1;
            AG_lblRand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AG_lblKatse
            // 
            AG_lblKatse.BackColor = SystemColors.Control;
            AG_lblKatse.BorderStyle = BorderStyle.Fixed3D;
            AG_lblKatse.Font = new Font("Segoe UI", 32F);
            AG_lblKatse.ForeColor = Color.Brown;
            AG_lblKatse.Location = new Point(235, 44);
            AG_lblKatse.Margin = new Padding(3);
            AG_lblKatse.Name = "AG_lblKatse";
            AG_lblKatse.RightToLeft = RightToLeft.Yes;
            AG_lblKatse.Size = new Size(100, 75);
            AG_lblKatse.TabIndex = 2;
            AG_lblKatse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AG_lblKirjeldus
            // 
            AG_lblKirjeldus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AG_lblKirjeldus.BackColor = Color.FromArgb(32, 96, 48);
            AG_lblKirjeldus.BorderStyle = BorderStyle.FixedSingle;
            AG_lblKirjeldus.FlatStyle = FlatStyle.System;
            AG_lblKirjeldus.Font = new Font("Segoe UI", 16F);
            AG_lblKirjeldus.ForeColor = Color.White;
            AG_lblKirjeldus.ImageAlign = ContentAlignment.BottomLeft;
            AG_lblKirjeldus.Location = new Point(9, 412);
            AG_lblKirjeldus.Margin = new Padding(0);
            AG_lblKirjeldus.Name = "AG_lblKirjeldus";
            AG_lblKirjeldus.Size = new Size(766, 40);
            AG_lblKirjeldus.TabIndex = 3;
            AG_lblKirjeldus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AG_lblKatseInfo
            // 
            AG_lblKatseInfo.FlatStyle = FlatStyle.System;
            AG_lblKatseInfo.Font = new Font("Segoe UI", 14F);
            AG_lblKatseInfo.ForeColor = Color.White;
            AG_lblKatseInfo.ImageAlign = ContentAlignment.BottomRight;
            AG_lblKatseInfo.Location = new Point(162, 96);
            AG_lblKatseInfo.Name = "AG_lblKatseInfo";
            AG_lblKatseInfo.Size = new Size(67, 23);
            AG_lblKatseInfo.TabIndex = 4;
            AG_lblKatseInfo.Text = "Clicks:";
            AG_lblKatseInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AG_grb1
            // 
            AG_grb1.Controls.Add(AG_start);
            AG_grb1.Controls.Add(AG_ok);
            AG_grb1.Controls.Add(AG_lblKatse);
            AG_grb1.Controls.Add(AG_lblKatseInfo);
            AG_grb1.Controls.Add(AG_lblRand);
            AG_grb1.ForeColor = Color.White;
            AG_grb1.Location = new Point(205, 60);
            AG_grb1.Name = "AG_grb1";
            AG_grb1.Size = new Size(375, 225);
            AG_grb1.TabIndex = 5;
            AG_grb1.TabStop = false;
            AG_grb1.Text = "Random mäng";
            // 
            // AG_start
            // 
            AG_start.FlatStyle = FlatStyle.System;
            AG_start.Font = new Font("Segoe UI", 14F);
            AG_start.Location = new Point(39, 125);
            AG_start.Name = "AG_start";
            AG_start.Size = new Size(60, 60);
            AG_start.TabIndex = 6;
            AG_start.Text = "Play/ Retry";
            AG_start.UseVisualStyleBackColor = true;
            AG_start.Click += AG_start_Click;
            // 
            // AG_ok
            // 
            AG_ok.FlatStyle = FlatStyle.System;
            AG_ok.Font = new Font("Segoe UI", 20F);
            AG_ok.Location = new Point(105, 125);
            AG_ok.Name = "AG_ok";
            AG_ok.Size = new Size(230, 60);
            AG_ok.TabIndex = 5;
            AG_ok.Text = "       Click!";
            AG_ok.TextAlign = ContentAlignment.MiddleLeft;
            AG_ok.UseVisualStyleBackColor = true;
            AG_ok.Click += AG_ok_Click;
            // 
            // AG_Pilt
            // 
            AG_Pilt.BackColor = SystemColors.Control;
            AG_Pilt.BorderStyle = BorderStyle.Fixed3D;
            AG_Pilt.Location = new Point(9, 309);
            AG_Pilt.Name = "AG_Pilt";
            AG_Pilt.Size = new Size(100, 100);
            AG_Pilt.SizeMode = PictureBoxSizeMode.StretchImage;
            AG_Pilt.TabIndex = 6;
            AG_Pilt.TabStop = false;
            // 
            // AG_pilt1
            // 
            AG_pilt1.BackColor = SystemColors.Control;
            AG_pilt1.BackgroundImageLayout = ImageLayout.None;
            AG_pilt1.BorderStyle = BorderStyle.Fixed3D;
            AG_pilt1.Image = (Image)resources.GetObject("AG_pilt1.Image");
            AG_pilt1.Location = new Point(140, 359);
            AG_pilt1.Name = "AG_pilt1";
            AG_pilt1.Size = new Size(50, 50);
            AG_pilt1.TabIndex = 7;
            AG_pilt1.TabStop = false;
            // 
            // AG_pilt2
            // 
            AG_pilt2.BackColor = SystemColors.Control;
            AG_pilt2.BorderStyle = BorderStyle.Fixed3D;
            AG_pilt2.Image = (Image)resources.GetObject("AG_pilt2.Image");
            AG_pilt2.Location = new Point(196, 359);
            AG_pilt2.Name = "AG_pilt2";
            AG_pilt2.Size = new Size(50, 50);
            AG_pilt2.TabIndex = 8;
            AG_pilt2.TabStop = false;
            // 
            // AG_pilt3
            // 
            AG_pilt3.BackColor = SystemColors.Control;
            AG_pilt3.BorderStyle = BorderStyle.Fixed3D;
            AG_pilt3.Location = new Point(252, 359);
            AG_pilt3.Name = "AG_pilt3";
            AG_pilt3.Size = new Size(50, 50);
            AG_pilt3.TabIndex = 9;
            AG_pilt3.TabStop = false;
            // 
            // AG_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 461);
            Controls.Add(AG_lblInfo2);
            Controls.Add(AG_pilt3);
            Controls.Add(AG_pilt2);
            Controls.Add(AG_pilt1);
            Controls.Add(AG_Pilt);
            Controls.Add(AG_grb1);
            Controls.Add(AG_lblKirjeldus);
            Controls.Add(AG_lblInfo);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "AG_main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Random mäng";
            Load += AG_main_Load;
            AG_grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AG_Pilt).EndInit();
            ((System.ComponentModel.ISupportInitialize)AG_pilt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AG_pilt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AG_pilt3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AG_lblInfo;
        private Label AG_lblRand;
        private Label AG_lblKatse;
        private Label AG_lblKirjeldus;
        private Label AG_lblKatseInfo;
        private GroupBox AG_grb1;
        private Button AG_ok;
        private Button AG_start;
        private PictureBox AG_Pilt;
        private PictureBox AG_pilt1;
        private PictureBox AG_pilt2;
        private PictureBox AG_pilt3;
        private Label AG_lblInfo2;
    }
}
