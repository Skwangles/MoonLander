namespace Moon_Lander
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Lander = new System.Windows.Forms.PictureBox();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.FuelBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.Pad = new System.Windows.Forms.PictureBox();
            this.Bottempanel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speedtrav = new System.Windows.Forms.Label();
            this.Moonscape = new System.Windows.Forms.PictureBox();
            this.yval = new System.Windows.Forms.Label();
            this.xval = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Movetmr = new System.Windows.Forms.Timer(this.components);
            this.SuccessFaillbl = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.Infolbl = new System.Windows.Forms.Label();
            this.InfoLbl2 = new System.Windows.Forms.Label();
            this.Infolbl1 = new System.Windows.Forms.Label();
            this.Infolbl3 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.Fuel = new System.Windows.Forms.Label();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.Coloring = new System.Windows.Forms.PictureBox();
            this.YN = new System.Windows.Forms.PictureBox();
            this.Hidu = new System.Windows.Forms.Label();
            this.StartImg = new System.Windows.Forms.PictureBox();
            this.LanderVar = new System.Windows.Forms.ImageList(this.components);
            this.PadIL = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Lander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottempanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moonscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coloring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Lander
            // 
            this.Lander.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lander.Image = ((System.Drawing.Image)(resources.GetObject("Lander.Image")));
            this.Lander.Location = new System.Drawing.Point(424, 12);
            this.Lander.Name = "Lander";
            this.Lander.Size = new System.Drawing.Size(93, 83);
            this.Lander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lander.TabIndex = 1;
            this.Lander.TabStop = false;
            // 
            // TrackBar
            // 
            this.TrackBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TrackBar.LargeChange = 0;
            this.TrackBar.Location = new System.Drawing.Point(132, 387);
            this.TrackBar.Maximum = 40;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(449, 45);
            this.TrackBar.SmallChange = 0;
            this.TrackBar.TabIndex = 2;
            this.TrackBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrackBar_KeyDown);
            this.TrackBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrackBar_KeyPress);
            this.TrackBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TrackBar_KeyUp);
            // 
            // FuelBar
            // 
            this.FuelBar.Location = new System.Drawing.Point(639, 393);
            this.FuelBar.Name = "FuelBar";
            this.FuelBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FuelBar.Size = new System.Drawing.Size(129, 35);
            this.FuelBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(690, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fuel";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed.Location = new System.Drawing.Point(12, 393);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(97, 17);
            this.Speed.TabIndex = 5;
            this.Speed.Text = "Speed (kph)";
            this.Speed.Click += new System.EventHandler(this.Speed_Click);
            // 
            // Pad
            // 
            this.Pad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pad.Image = ((System.Drawing.Image)(resources.GetObject("Pad.Image")));
            this.Pad.Location = new System.Drawing.Point(306, 328);
            this.Pad.Name = "Pad";
            this.Pad.Size = new System.Drawing.Size(134, 21);
            this.Pad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pad.TabIndex = 6;
            this.Pad.TabStop = false;
            // 
            // Bottempanel
            // 
            this.Bottempanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bottempanel.Location = new System.Drawing.Point(1, 349);
            this.Bottempanel.Margin = new System.Windows.Forms.Padding(0);
            this.Bottempanel.Name = "Bottempanel";
            this.Bottempanel.Size = new System.Drawing.Size(799, 102);
            this.Bottempanel.TabIndex = 7;
            this.Bottempanel.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thrust";
            // 
            // speedtrav
            // 
            this.speedtrav.AutoSize = true;
            this.speedtrav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.speedtrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedtrav.Location = new System.Drawing.Point(22, 415);
            this.speedtrav.Name = "speedtrav";
            this.speedtrav.Size = new System.Drawing.Size(31, 15);
            this.speedtrav.TabIndex = 9;
            this.speedtrav.Text = "0.00";
            // 
            // Moonscape
            // 
            this.Moonscape.Image = ((System.Drawing.Image)(resources.GetObject("Moonscape.Image")));
            this.Moonscape.Location = new System.Drawing.Point(1, 0);
            this.Moonscape.Margin = new System.Windows.Forms.Padding(0);
            this.Moonscape.Name = "Moonscape";
            this.Moonscape.Size = new System.Drawing.Size(799, 349);
            this.Moonscape.TabIndex = 10;
            this.Moonscape.TabStop = false;
            // 
            // yval
            // 
            this.yval.AutoSize = true;
            this.yval.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yval.Location = new System.Drawing.Point(94, 371);
            this.yval.Name = "yval";
            this.yval.Size = new System.Drawing.Size(31, 15);
            this.yval.TabIndex = 11;
            this.yval.Text = "0.00";
            this.yval.Click += new System.EventHandler(this.label3_Click);
            // 
            // xval
            // 
            this.xval.AutoSize = true;
            this.xval.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xval.Location = new System.Drawing.Point(34, 371);
            this.xval.Name = "xval";
            this.xval.Size = new System.Drawing.Size(31, 15);
            this.xval.TabIndex = 12;
            this.xval.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "X:";
            // 
            // Movetmr
            // 
            this.Movetmr.Interval = 50;
            this.Movetmr.Tick += new System.EventHandler(this.Movetmr_Tick);
            // 
            // SuccessFaillbl
            // 
            this.SuccessFaillbl.AutoSize = true;
            this.SuccessFaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessFaillbl.Location = new System.Drawing.Point(262, 147);
            this.SuccessFaillbl.Name = "SuccessFaillbl";
            this.SuccessFaillbl.Size = new System.Drawing.Size(119, 31);
            this.SuccessFaillbl.TabIndex = 15;
            this.SuccessFaillbl.Text = "WinLose";
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.Aqua;
            this.PB.Location = new System.Drawing.Point(1, 0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(799, 451);
            this.PB.TabIndex = 18;
            this.PB.TabStop = false;
            // 
            // Infolbl
            // 
            this.Infolbl.AutoSize = true;
            this.Infolbl.BackColor = System.Drawing.Color.Firebrick;
            this.Infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infolbl.Location = new System.Drawing.Point(610, 220);
            this.Infolbl.Name = "Infolbl";
            this.Infolbl.Size = new System.Drawing.Size(178, 44);
            this.Infolbl.TabIndex = 19;
            this.Infolbl.Text = "Controls:";
            // 
            // InfoLbl2
            // 
            this.InfoLbl2.AutoSize = true;
            this.InfoLbl2.BackColor = System.Drawing.Color.DarkOrange;
            this.InfoLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl2.Location = new System.Drawing.Point(621, 273);
            this.InfoLbl2.Name = "InfoLbl2";
            this.InfoLbl2.Size = new System.Drawing.Size(149, 25);
            this.InfoLbl2.TabIndex = 20;
            this.InfoLbl2.Text = "Left Arrow - Left";
            // 
            // Infolbl1
            // 
            this.Infolbl1.AutoSize = true;
            this.Infolbl1.BackColor = System.Drawing.Color.DarkOrange;
            this.Infolbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infolbl1.Location = new System.Drawing.Point(612, 298);
            this.Infolbl1.Name = "Infolbl1";
            this.Infolbl1.Size = new System.Drawing.Size(173, 50);
            this.Infolbl1.TabIndex = 21;
            this.Infolbl1.Text = "Right Arrow - Right\r\nTrackBar - Thrust\r\n";
            // 
            // Infolbl3
            // 
            this.Infolbl3.AutoSize = true;
            this.Infolbl3.BackColor = System.Drawing.Color.OrangeRed;
            this.Infolbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infolbl3.Location = new System.Drawing.Point(3, 220);
            this.Infolbl3.Name = "Infolbl3";
            this.Infolbl3.Size = new System.Drawing.Size(479, 225);
            this.Infolbl3.TabIndex = 22;
            this.Infolbl3.Text = resources.GetString("Infolbl3.Text");
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB1.ForeColor = System.Drawing.Color.Yellow;
            this.TB1.Location = new System.Drawing.Point(618, 49);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(85, 26);
            this.TB1.TabIndex = 23;
            this.TB1.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB2.ForeColor = System.Drawing.Color.Yellow;
            this.TB2.Location = new System.Drawing.Point(632, 122);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(60, 30);
            this.TB2.TabIndex = 25;
            this.TB2.Text = "5000";
            // 
            // Fuel
            // 
            this.Fuel.AutoSize = true;
            this.Fuel.BackColor = System.Drawing.Color.Lime;
            this.Fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fuel.Location = new System.Drawing.Point(585, 79);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(149, 40);
            this.Fuel.TabIndex = 26;
            this.Fuel.Text = "How Much Fuel?\r\n      (0-5000)";
            this.Fuel.Click += new System.EventHandler(this.Fuel_Click);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.BackColor = System.Drawing.Color.Yellow;
            this.ErrorLbl.Font = new System.Drawing.Font("Niagara Engraved", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLbl.Location = new System.Drawing.Point(29, 33);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(253, 43);
            this.ErrorLbl.TabIndex = 27;
            this.ErrorLbl.Text = "Fuel Value Is Incorrect";
            // 
            // Coloring
            // 
            this.Coloring.BackColor = System.Drawing.Color.DarkOrange;
            this.Coloring.Location = new System.Drawing.Point(608, 220);
            this.Coloring.Name = "Coloring";
            this.Coloring.Size = new System.Drawing.Size(180, 129);
            this.Coloring.TabIndex = 28;
            this.Coloring.TabStop = false;
            // 
            // YN
            // 
            this.YN.BackColor = System.Drawing.Color.Lime;
            this.YN.Location = new System.Drawing.Point(537, 12);
            this.YN.Name = "YN";
            this.YN.Size = new System.Drawing.Size(251, 149);
            this.YN.TabIndex = 29;
            this.YN.TabStop = false;
            // 
            // Hidu
            // 
            this.Hidu.AutoSize = true;
            this.Hidu.BackColor = System.Drawing.Color.Lime;
            this.Hidu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hidu.Location = new System.Drawing.Point(540, 27);
            this.Hidu.Margin = new System.Windows.Forms.Padding(0);
            this.Hidu.Name = "Hidu";
            this.Hidu.Size = new System.Drawing.Size(245, 20);
            this.Hidu.TabIndex = 30;
            this.Hidu.Text = "What\'s Your Name Captain?";
            // 
            // StartImg
            // 
            this.StartImg.Image = ((System.Drawing.Image)(resources.GetObject("StartImg.Image")));
            this.StartImg.Location = new System.Drawing.Point(387, 71);
            this.StartImg.Name = "StartImg";
            this.StartImg.Size = new System.Drawing.Size(95, 92);
            this.StartImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartImg.TabIndex = 31;
            this.StartImg.TabStop = false;
            this.StartImg.Visible = false;
            this.StartImg.Click += new System.EventHandler(this.StartImg_Click);
            // 
            // LanderVar
            // 
            this.LanderVar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.LanderVar.ImageSize = new System.Drawing.Size(16, 16);
            this.LanderVar.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PadIL
            // 
            this.PadIL.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.PadIL.ImageSize = new System.Drawing.Size(16, 16);
            this.PadIL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartImg);
            this.Controls.Add(this.Hidu);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.Fuel);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.YN);
            this.Controls.Add(this.Infolbl1);
            this.Controls.Add(this.InfoLbl2);
            this.Controls.Add(this.Infolbl);
            this.Controls.Add(this.Coloring);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.Infolbl3);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.SuccessFaillbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xval);
            this.Controls.Add(this.yval);
            this.Controls.Add(this.speedtrav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FuelBar);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.Lander);
            this.Controls.Add(this.Bottempanel);
            this.Controls.Add(this.Pad);
            this.Controls.Add(this.Moonscape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Lander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottempanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moonscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coloring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Lander;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.ProgressBar FuelBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.PictureBox Pad;
        private System.Windows.Forms.PictureBox Bottempanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label speedtrav;
        private System.Windows.Forms.PictureBox Moonscape;
        private System.Windows.Forms.Label yval;
        private System.Windows.Forms.Label xval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer Movetmr;
        private System.Windows.Forms.Label SuccessFaillbl;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label Infolbl;
        private System.Windows.Forms.Label InfoLbl2;
        private System.Windows.Forms.Label Infolbl1;
        private System.Windows.Forms.Label Infolbl3;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Label Fuel;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.PictureBox Coloring;
        private System.Windows.Forms.PictureBox YN;
        private System.Windows.Forms.Label Hidu;
        private System.Windows.Forms.PictureBox StartImg;
        private System.Windows.Forms.ImageList LanderVar;
        private System.Windows.Forms.ImageList PadIL;
        private System.Windows.Forms.Timer timer1;
    }
}