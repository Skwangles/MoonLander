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
            this.pbLander = new System.Windows.Forms.PictureBox();
            this.TrackbarThrust = new System.Windows.Forms.TrackBar();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblfuel = new System.Windows.Forms.Label();
            this.Speedlbl = new System.Windows.Forms.Label();
            this.pbLandingPad = new System.Windows.Forms.PictureBox();
            this.Bottempanelpb = new System.Windows.Forms.PictureBox();
            this.ThrustLbl = new System.Windows.Forms.Label();
            this.lblspeedtrav = new System.Windows.Forms.Label();
            this.Moonscapepb = new System.Windows.Forms.PictureBox();
            this.yvallbl = new System.Windows.Forms.Label();
            this.lblxval = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.Movetmr = new System.Windows.Forms.Timer(this.components);
            this.SuccessFaillbl = new System.Windows.Forms.Label();
            this.PBStartBackground = new System.Windows.Forms.PictureBox();
            this.Infolbl = new System.Windows.Forms.Label();
            this.InfoLbl2 = new System.Windows.Forms.Label();
            this.Infolbl1 = new System.Windows.Forms.Label();
            this.Infolbl3 = new System.Windows.Forms.Label();
            this.CapsNameTB = new System.Windows.Forms.TextBox();
            this.FuelTB = new System.Windows.Forms.TextBox();
            this.Fuelnumtxtlbl = new System.Windows.Forms.Label();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.ColoringPB = new System.Windows.Forms.PictureBox();
            this.YNPB = new System.Windows.Forms.PictureBox();
            this.Capnamtxtlbl = new System.Windows.Forms.Label();
            this.StartButtonimg = new System.Windows.Forms.PictureBox();
            this.LanderVar = new System.Windows.Forms.ImageList(this.components);
            this.PadIL = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ThrustVallbl = new System.Windows.Forms.Label();
            this.Scoretxtlbl = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.LowFuellbl = new System.Windows.Forms.Label();
            this.TooFastlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarThrust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLandingPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottempanelpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moonscapepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBStartBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColoringPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButtonimg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLander
            // 
            this.pbLander.BackColor = System.Drawing.Color.Transparent;
            this.pbLander.Image = ((System.Drawing.Image)(resources.GetObject("pbLander.Image")));
            this.pbLander.Location = new System.Drawing.Point(407, 0);
            this.pbLander.Name = "pbLander";
            this.pbLander.Size = new System.Drawing.Size(93, 109);
            this.pbLander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLander.TabIndex = 1;
            this.pbLander.TabStop = false;
            this.pbLander.LocationChanged += new System.EventHandler(this.Lander_LocationChanged);
            this.pbLander.Click += new System.EventHandler(this.Lander_Click);
            // 
            // TrackbarThrust
            // 
            this.TrackbarThrust.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TrackbarThrust.LargeChange = 0;
            this.TrackbarThrust.Location = new System.Drawing.Point(128, 439);
            this.TrackbarThrust.Maximum = 40;
            this.TrackbarThrust.Name = "TrackbarThrust";
            this.TrackbarThrust.Size = new System.Drawing.Size(449, 45);
            this.TrackbarThrust.SmallChange = 0;
            this.TrackbarThrust.TabIndex = 2;
            this.TrackbarThrust.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            this.TrackbarThrust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrackBar_KeyDown);
            this.TrackbarThrust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrackBar_KeyPress);
            this.TrackbarThrust.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TrackBar_KeyUp);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(641, 439);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBar.Size = new System.Drawing.Size(129, 35);
            this.ProgressBar.TabIndex = 3;
            // 
            // lblfuel
            // 
            this.lblfuel.AutoSize = true;
            this.lblfuel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfuel.Location = new System.Drawing.Point(695, 423);
            this.lblfuel.Name = "lblfuel";
            this.lblfuel.Size = new System.Drawing.Size(27, 13);
            this.lblfuel.TabIndex = 4;
            this.lblfuel.Text = "Fuel";
            // 
            // Speedlbl
            // 
            this.Speedlbl.AutoSize = true;
            this.Speedlbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Speedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speedlbl.Location = new System.Drawing.Point(8, 445);
            this.Speedlbl.Name = "Speedlbl";
            this.Speedlbl.Size = new System.Drawing.Size(97, 17);
            this.Speedlbl.TabIndex = 5;
            this.Speedlbl.Text = "Speed (kph)";
            this.Speedlbl.Click += new System.EventHandler(this.Speed_Click);
            // 
            // pbLandingPad
            // 
            this.pbLandingPad.BackColor = System.Drawing.Color.Transparent;
            this.pbLandingPad.Image = ((System.Drawing.Image)(resources.GetObject("pbLandingPad.Image")));
            this.pbLandingPad.Location = new System.Drawing.Point(315, 320);
            this.pbLandingPad.Name = "pbLandingPad";
            this.pbLandingPad.Size = new System.Drawing.Size(134, 73);
            this.pbLandingPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLandingPad.TabIndex = 6;
            this.pbLandingPad.TabStop = false;
            // 
            // Bottempanelpb
            // 
            this.Bottempanelpb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bottempanelpb.Location = new System.Drawing.Point(1, 396);
            this.Bottempanelpb.Margin = new System.Windows.Forms.Padding(0);
            this.Bottempanelpb.Name = "Bottempanelpb";
            this.Bottempanelpb.Size = new System.Drawing.Size(799, 102);
            this.Bottempanelpb.TabIndex = 7;
            this.Bottempanelpb.TabStop = false;
            // 
            // ThrustLbl
            // 
            this.ThrustLbl.AutoSize = true;
            this.ThrustLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThrustLbl.Location = new System.Drawing.Point(332, 415);
            this.ThrustLbl.Name = "ThrustLbl";
            this.ThrustLbl.Size = new System.Drawing.Size(40, 13);
            this.ThrustLbl.TabIndex = 8;
            this.ThrustLbl.Text = "Thrust:";
            // 
            // lblspeedtrav
            // 
            this.lblspeedtrav.AutoSize = true;
            this.lblspeedtrav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblspeedtrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspeedtrav.Location = new System.Drawing.Point(24, 462);
            this.lblspeedtrav.Name = "lblspeedtrav";
            this.lblspeedtrav.Size = new System.Drawing.Size(31, 15);
            this.lblspeedtrav.TabIndex = 9;
            this.lblspeedtrav.Text = "0.00";
            // 
            // Moonscapepb
            // 
            this.Moonscapepb.BackColor = System.Drawing.Color.Transparent;
            this.Moonscapepb.Location = new System.Drawing.Point(1, 0);
            this.Moonscapepb.Margin = new System.Windows.Forms.Padding(0);
            this.Moonscapepb.Name = "Moonscapepb";
            this.Moonscapepb.Size = new System.Drawing.Size(799, 393);
            this.Moonscapepb.TabIndex = 10;
            this.Moonscapepb.TabStop = false;
            // 
            // yvallbl
            // 
            this.yvallbl.AutoSize = true;
            this.yvallbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yvallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yvallbl.Location = new System.Drawing.Point(95, 413);
            this.yvallbl.Name = "yvallbl";
            this.yvallbl.Size = new System.Drawing.Size(31, 15);
            this.yvallbl.TabIndex = 11;
            this.yvallbl.Text = "0.00";
            this.yvallbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblxval
            // 
            this.lblxval.AutoSize = true;
            this.lblxval.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblxval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxval.Location = new System.Drawing.Point(34, 413);
            this.lblxval.Name = "lblxval";
            this.lblxval.Size = new System.Drawing.Size(31, 15);
            this.lblxval.TabIndex = 12;
            this.lblxval.Text = "0.00";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(71, 413);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(19, 15);
            this.lblY.TabIndex = 13;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(8, 413);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 15);
            this.lblX.TabIndex = 14;
            this.lblX.Text = "X:";
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
            // PBStartBackground
            // 
            this.PBStartBackground.BackColor = System.Drawing.Color.Aqua;
            this.PBStartBackground.Location = new System.Drawing.Point(-759, 462);
            this.PBStartBackground.Name = "PBStartBackground";
            this.PBStartBackground.Size = new System.Drawing.Size(799, 496);
            this.PBStartBackground.TabIndex = 18;
            this.PBStartBackground.TabStop = false;
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
            this.Infolbl3.Location = new System.Drawing.Point(22, 259);
            this.Infolbl3.Name = "Infolbl3";
            this.Infolbl3.Size = new System.Drawing.Size(476, 225);
            this.Infolbl3.TabIndex = 22;
            this.Infolbl3.Text = resources.GetString("Infolbl3.Text");
            // 
            // CapsNameTB
            // 
            this.CapsNameTB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CapsNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapsNameTB.ForeColor = System.Drawing.Color.Yellow;
            this.CapsNameTB.Location = new System.Drawing.Point(618, 49);
            this.CapsNameTB.MaxLength = 9;
            this.CapsNameTB.Name = "CapsNameTB";
            this.CapsNameTB.Size = new System.Drawing.Size(85, 26);
            this.CapsNameTB.TabIndex = 23;
            this.CapsNameTB.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // FuelTB
            // 
            this.FuelTB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FuelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelTB.ForeColor = System.Drawing.Color.Yellow;
            this.FuelTB.Location = new System.Drawing.Point(632, 122);
            this.FuelTB.MaxLength = 4;
            this.FuelTB.Name = "FuelTB";
            this.FuelTB.Size = new System.Drawing.Size(60, 30);
            this.FuelTB.TabIndex = 25;
            // 
            // Fuelnumtxtlbl
            // 
            this.Fuelnumtxtlbl.AutoSize = true;
            this.Fuelnumtxtlbl.BackColor = System.Drawing.Color.Lime;
            this.Fuelnumtxtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fuelnumtxtlbl.Location = new System.Drawing.Point(585, 79);
            this.Fuelnumtxtlbl.Name = "Fuelnumtxtlbl";
            this.Fuelnumtxtlbl.Size = new System.Drawing.Size(149, 40);
            this.Fuelnumtxtlbl.TabIndex = 26;
            this.Fuelnumtxtlbl.Text = "How Much Fuel?\r\n      (0-5000)";
            this.Fuelnumtxtlbl.Click += new System.EventHandler(this.Fuel_Click);
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
            this.ErrorLbl.TextChanged += new System.EventHandler(this.ErrorLbl_TextChanged);
            // 
            // ColoringPB
            // 
            this.ColoringPB.BackColor = System.Drawing.Color.DarkOrange;
            this.ColoringPB.Location = new System.Drawing.Point(608, 220);
            this.ColoringPB.Name = "ColoringPB";
            this.ColoringPB.Size = new System.Drawing.Size(180, 129);
            this.ColoringPB.TabIndex = 28;
            this.ColoringPB.TabStop = false;
            this.ColoringPB.Click += new System.EventHandler(this.Coloring_Click);
            // 
            // YNPB
            // 
            this.YNPB.BackColor = System.Drawing.Color.Lime;
            this.YNPB.Location = new System.Drawing.Point(537, 12);
            this.YNPB.Name = "YNPB";
            this.YNPB.Size = new System.Drawing.Size(251, 149);
            this.YNPB.TabIndex = 29;
            this.YNPB.TabStop = false;
            // 
            // Capnamtxtlbl
            // 
            this.Capnamtxtlbl.AutoSize = true;
            this.Capnamtxtlbl.BackColor = System.Drawing.Color.Lime;
            this.Capnamtxtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capnamtxtlbl.Location = new System.Drawing.Point(540, 27);
            this.Capnamtxtlbl.Margin = new System.Windows.Forms.Padding(0);
            this.Capnamtxtlbl.Name = "Capnamtxtlbl";
            this.Capnamtxtlbl.Size = new System.Drawing.Size(245, 20);
            this.Capnamtxtlbl.TabIndex = 30;
            this.Capnamtxtlbl.Text = "What\'s Your Name Captain?";
            // 
            // StartButtonimg
            // 
            this.StartButtonimg.Image = ((System.Drawing.Image)(resources.GetObject("StartButtonimg.Image")));
            this.StartButtonimg.Location = new System.Drawing.Point(387, 71);
            this.StartButtonimg.Name = "StartButtonimg";
            this.StartButtonimg.Size = new System.Drawing.Size(95, 92);
            this.StartButtonimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartButtonimg.TabIndex = 31;
            this.StartButtonimg.TabStop = false;
            this.StartButtonimg.Visible = false;
            this.StartButtonimg.Click += new System.EventHandler(this.StartImg_Click);
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
            // ThrustVallbl
            // 
            this.ThrustVallbl.AutoSize = true;
            this.ThrustVallbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThrustVallbl.Location = new System.Drawing.Point(384, 415);
            this.ThrustVallbl.Name = "ThrustVallbl";
            this.ThrustVallbl.Size = new System.Drawing.Size(35, 13);
            this.ThrustVallbl.TabIndex = 32;
            this.ThrustVallbl.Text = "label3";
            // 
            // Scoretxtlbl
            // 
            this.Scoretxtlbl.AutoSize = true;
            this.Scoretxtlbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Scoretxtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretxtlbl.ForeColor = System.Drawing.Color.Chocolate;
            this.Scoretxtlbl.Location = new System.Drawing.Point(8, 9);
            this.Scoretxtlbl.Name = "Scoretxtlbl";
            this.Scoretxtlbl.Size = new System.Drawing.Size(55, 17);
            this.Scoretxtlbl.TabIndex = 33;
            this.Scoretxtlbl.Text = "Score:";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scorelbl.ForeColor = System.Drawing.Color.Chocolate;
            this.scorelbl.Location = new System.Drawing.Point(69, 12);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(13, 13);
            this.scorelbl.TabIndex = 34;
            this.scorelbl.Text = "0";
            // 
            // LowFuellbl
            // 
            this.LowFuellbl.AutoSize = true;
            this.LowFuellbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LowFuellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowFuellbl.ForeColor = System.Drawing.Color.DarkRed;
            this.LowFuellbl.Location = new System.Drawing.Point(568, 402);
            this.LowFuellbl.Name = "LowFuellbl";
            this.LowFuellbl.Size = new System.Drawing.Size(72, 17);
            this.LowFuellbl.TabIndex = 35;
            this.LowFuellbl.Text = "Low Fuel";
            // 
            // TooFastlbl
            // 
            this.TooFastlbl.AutoSize = true;
            this.TooFastlbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TooFastlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TooFastlbl.ForeColor = System.Drawing.Color.DarkRed;
            this.TooFastlbl.Location = new System.Drawing.Point(568, 419);
            this.TooFastlbl.Name = "TooFastlbl";
            this.TooFastlbl.Size = new System.Drawing.Size(72, 17);
            this.TooFastlbl.TabIndex = 36;
            this.TooFastlbl.Text = "Too Fast";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.Scoretxtlbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.StartButtonimg);
            this.Controls.Add(this.Capnamtxtlbl);
            this.Controls.Add(this.CapsNameTB);
            this.Controls.Add(this.Fuelnumtxtlbl);
            this.Controls.Add(this.FuelTB);
            this.Controls.Add(this.YNPB);
            this.Controls.Add(this.Infolbl1);
            this.Controls.Add(this.InfoLbl2);
            this.Controls.Add(this.Infolbl);
            this.Controls.Add(this.ColoringPB);
            this.Controls.Add(this.Infolbl3);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.PBStartBackground);
            this.Controls.Add(this.ThrustVallbl);
            this.Controls.Add(this.SuccessFaillbl);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblxval);
            this.Controls.Add(this.yvallbl);
            this.Controls.Add(this.lblspeedtrav);
            this.Controls.Add(this.ThrustLbl);
            this.Controls.Add(this.Speedlbl);
            this.Controls.Add(this.lblfuel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.TrackbarThrust);
            this.Controls.Add(this.LowFuellbl);
            this.Controls.Add(this.TooFastlbl);
            this.Controls.Add(this.Bottempanelpb);
            this.Controls.Add(this.pbLander);
            this.Controls.Add(this.pbLandingPad);
            this.Controls.Add(this.Moonscapepb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbLander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarThrust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLandingPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottempanelpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moonscapepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBStartBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColoringPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButtonimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLander;
        private System.Windows.Forms.TrackBar TrackbarThrust;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label lblfuel;
        private System.Windows.Forms.Label Speedlbl;
        private System.Windows.Forms.PictureBox pbLandingPad;
        private System.Windows.Forms.PictureBox Bottempanelpb;
        private System.Windows.Forms.Label ThrustLbl;
        private System.Windows.Forms.Label lblspeedtrav;
        private System.Windows.Forms.PictureBox Moonscapepb;
        private System.Windows.Forms.Label yvallbl;
        private System.Windows.Forms.Label lblxval;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Timer Movetmr;
        private System.Windows.Forms.Label SuccessFaillbl;
        private System.Windows.Forms.PictureBox PBStartBackground;
        private System.Windows.Forms.Label Infolbl;
        private System.Windows.Forms.Label InfoLbl2;
        private System.Windows.Forms.Label Infolbl1;
        private System.Windows.Forms.Label Infolbl3;
        private System.Windows.Forms.TextBox CapsNameTB;
        private System.Windows.Forms.TextBox FuelTB;
        private System.Windows.Forms.Label Fuelnumtxtlbl;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.PictureBox ColoringPB;
        private System.Windows.Forms.PictureBox YNPB;
        private System.Windows.Forms.Label Capnamtxtlbl;
        private System.Windows.Forms.PictureBox StartButtonimg;
        private System.Windows.Forms.ImageList LanderVar;
        private System.Windows.Forms.ImageList PadIL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ThrustVallbl;
        private System.Windows.Forms.Label Scoretxtlbl;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label LowFuellbl;
        private System.Windows.Forms.Label TooFastlbl;
    }
}