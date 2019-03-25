﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Lander
{
    public partial class Game : Form
    {
        bool IsThrust;
        bool ThrustHalf;
        bool LeftB;
        bool RightB;
        bool Won = false;
        int Gravity = 3; //Gravity value
        int SpeedF = 30; //Default Speed of Gravity.
        string CapsName; //Captains name variable
        int TotalF;//Total Fuel value set by the user
        
        Random Rand = new Random();
        static string filepath = @"G:\VS - Coding\"; //Change this based on where the Project is
        Image DP = Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landing pads\landingPadProper.png");
        public Game()
        {
            InitializeComponent();
        } //Constructor
        #region starting Processes
        private void Game_Load(object sender, EventArgs e)
        {
            Moonscape.BackgroundImage = Image.FromFile((filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\moonScape.jpg"));
            

            //setting the picture size for each ImageList
            
            #region Add Images to ImgList
            AddIMGs();
            
            
            #endregion 
            //Adding to the ImgList is in the reigon above
            ErrorLbl.Hide(); //Makes sure the error label is hidden
            PB.Left = 0; //Sets the starting teal screen to cover the entire screen
            PB.Top = 0;
            Pad.Image = DP;
            Lander.Image = LanderVar.Images[0];
            StartImg.Left = (PB.Width / 2) - (StartImg.Width / 2); //sets the start button to centre  of screen
            StartImg.Top = (PB.Height / 4) - 20;
            Start("S"); //Sub which does the case. Show. It shows the info, and start screen
            SuccessFaillbl.Hide(); //Makes sure label is hidden
            SuccessFaillbl.Left = 0;
            SuccessFaillbl.Top = (Moonscape.Height / 2) - (SuccessFaillbl.Height / 2); //sets position of Labl                                  
            PadTop(); //sets pad y pos
            Lander.Top = 0; //sets lander y pos

        }
        void AddIMGs()
        {
            
            LanderVar.ImageSize = new Size(93, 83);
            PadIL.ImageSize = new Size(134, 100);
            var Land = LanderVar.Images;
            var PadL = PadIL.Images;
            //No-Thrust Lander Imgs
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landers\uprightLanderEdited.png")); //No Thrust Falling No Movement 0
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landers\smashedLander.png")); //End Lander 1
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landers\rightLander.png"));//2
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landers\leftLander.png"));//3

            //Thrust imgs
            //5 photos ^, 6 photos v
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\With thrust\leftHalfThrust.png"));//4
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\With thrust\leftThrust.png"));//5
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\With thrust\rightHalfThrust.png"));//6
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\With thrust\rightThrust.png"));//7
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\With thrust\uprightHalfThrust.png"));//8
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\With thrust\uprightThrust.png"));//9

            //Landing Pads imgs
            
            PadL.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landing pads\LanderOnPad.png"));//0
            PadL.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landing pads\SmashedLanderOnPad.png"));//1


        }


        void PadTop()
        {
            Pad.Top = Moonscape.Height - Pad.Height;
        }
        void Start(string H)
        {
            switch (H) //Hides Start screen
            {
                case "H":
                    StartImg.Hide();
                    PB.Hide();
                    Infolbl.Hide();
                    Infolbl1.Hide();
                    InfoLbl2.Hide();
                    Infolbl3.Hide();
                    YN.Hide();
                    Hidu.Hide();
                    TB1.Hide();
                    Fuel.Hide();
                    TB2.Hide();
                    Coloring.Hide();
                    break;
                case "S": //Shows Start screen
                    StartImg.Show();
                    PB.Show();
                    Infolbl.Show();
                    Infolbl1.Show();
                    InfoLbl2.Show();
                    Infolbl3.Show();
                    YN.Show();
                    Hidu.Show();
                    TB1.Show();
                    Fuel.Show();
                    TB2.Show();
                    Coloring.Show();
                    Lander.Show();
                    Pad.Height = 21;
                    Pad.Image = DP;
                    ResetLander();
                    break;
                default:
                    break;
            }

        }

        void Run()
        {
            CapsName = TB1.Text; //Sets Input caps name
            FuelBar.Maximum = TotalF; //set input fuel num
            Pad.Left = Rand.Next(0, (Moonscape.Width - Pad.Width)); //gets random x
            Lander.Left = Rand.Next(0, (Moonscape.Width - Lander.Width)); //gets random x
            TrackBar.Focus(); //Focuses the track bar which detects key presses
            Start("H"); //Hides start screen
            System.Threading.Thread.Sleep(500); //Pauses the start of the Game, till user focused
            Movetmr.Start(); //Starts the game

        }
        #endregion
        #region KeyCheckers
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Left://detects controls, detects Key held down
                    LeftB = true;
                    break;
                case (char)Keys.Right:
                    RightB = true;
                    break;
                default:
                    break;

            }

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue) //detects release of key
            {
                case (char)Keys.Left:
                    LeftB = false;
                    break;
                case (char)Keys.Right:
                    RightB = false;
                    break;
                default:
                    break;

            }
        }
        #endregion
        private void Movetmr_Tick(object sender, EventArgs e)
        {
            if (TrackBar.Value != 0) //Checks if track bar is applying thrust, and//or is less than half
            {
                IsThrust = true;
                if (TrackBar.Value < TrackBar.Maximum / 2) ThrustHalf = true;
                else { ThrustHalf = false; }
            }
            else { IsThrust = false; }
            yval.Text = (PB.Height - Lander.Top - Lander.Height).ToString(); //updateds x,y
            xval.Text = Lander.Left.ToString();
            SpeedF = (Gravity - TrackBar.Value) * 10; //Updates the speed lbl and val
            speedtrav.Text = ((Gravity - TrackBar.Value) * 10).ToString(); //sets lbl for speed

            if (Lander.Top + Lander.Height >= 335) Checkcol(); //Checks if the lander has reached pad's y level
            else
            {
                FuelLeft(); //applies thrust movement
            }
            if (LeftB)
            {
                if (IsThrust) //Checks if thrust is activated for the left movement image
                {
                    if (ThrustHalf) //Decides if the Lander Should go to Half Thrust of Full thrust img
                    {
                        Lander.Image = LanderVar.Images[4];
                    }
                    else
                    {
                        Lander.Image = LanderVar.Images[5];
                    }
                }
                else
                {
                    Lander.Image = LanderVar.Images[3]; //no thrust Left
                }
                Lander.Left -= 2;
            }//moves left
            else { ResetLander(); } //resets the image
            if (RightB)
            {
                if (IsThrust) //Checks if thrust is activated for the left movement image
                {
                    if (ThrustHalf) //Decides if the Lander Should go to Half Thrust of Full thrust img
                    {
                        Lander.Image = LanderVar.Images[6];
                    }
                    else
                    {
                        Lander.Image = LanderVar.Images[7];
                    }
                }
                else
                {
                    Lander.Image = LanderVar.Images[2]; //no thrust 
                }
                Lander.Left += 2;
            }//moves right, with images
            else { ResetLander(); }

        }

        void ResetLander()
        {
            if (IsThrust) //Checks if thrust is activated for the left movement image
            {
                if (ThrustHalf) //Decides if the Lander Should go to Half Thrust of Full thrust img
                {
                    Lander.Image = LanderVar.Images[8];
                }
                else
                {
                    Lander.Image = LanderVar.Images[9];
                }
            }
            else
            {
                Lander.Image = LanderVar.Images[0]; //no thrust 
            }
        } //Resets the Lander to No horizontal movement

        void Checkcol() //Checks if The lander, when it reaches bottem has landed on the pad or not, and applys the correct message accordingly
        {
            Movetmr.Stop();//stops game
            if (Lander.Left >= Pad.Left && Lander.Width + Lander.Left <= Pad.Left + Pad.Width) //checks if on landing pad
            {
                Pad.Height = 100;
                Lander.Hide();
                if (SpeedF <= 20)
                {
                    Won = true; //checks if lander is going to fast on touch down
                    
                    Pad.Image = PadIL.Images[0];               
                    PadTop();
                }
                else
                {
                    Won = false;                   
                    Pad.Image = PadIL.Images[1];
                    PadTop();
                }
            }
            else //If it reaches bottem and isn't on pad Crashes
            {
                Lander.Image = LanderVar.Images[1];
                Won = false;
                Lander.Top = Moonscape.Height - Lander.Height;//drops the Lander to the bottem of the screen
            } // if not on pad, crashes
            if (Won)
            {
                SuccessFaillbl.Text = "Congrats Captain " + CapsName + ", Mission Complete. Speed was: " + SpeedF + "m/s"; //based on condition, tells user if they have won
            }
            else
            {
                SuccessFaillbl.Text = "Sorry Captain " + CapsName + ", Mission Failed. Speed was: " + SpeedF + "m/s";
            }            
            SuccessFaillbl.Show(); //shows the label
        }

        void FuelLeft()  //moves lander Left and Right, as well as adds thrust, minus fuel and Apply movement
        {
            Lander.Left += (LeftB == true ? -2 : (RightB == true ? 2 : 0));
            if (TotalF - (TrackBar.Value * 10) <= 0) //Once Fuel has run out, makes sure only gravtiy works. LeftRight movement still works.
            {
                Lander.Top += Gravity;
                TotalF = 0;
                FuelBar.Value = 0;
            }
            else
            {
                Lander.Top += Gravity - TrackBar.Value; //While there is remaining fuel applies thrust.
                TotalF -= (TrackBar.Value * 10);
                FuelBar.Value = TotalF;
            }

        }

        #region Bunch Of Collapsed, and Trackbar Key listners
        private void button2_Click(object sender, EventArgs e) { }  //OldStartButtonhusk

        private void TrackBar_KeyDown(object sender, KeyEventArgs e) //Checks for the Key presses, since you are also changing thetrackbar value with mouse, you are focussed on the track bar, so it is easier to Check keys here.
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Left:
                    LeftB = true;
                    break;
                case (char)Keys.Right:
                    RightB = true;
                    break;
                default:
                    break;

            }
        }

        private void TrackBar_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Left:
                    LeftB = false;
                    break;
                case (char)Keys.Right:
                    RightB = false;
                    break;
                default:
                    break;

            }
        }

        private void TrackBar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Speed_Click(object sender, EventArgs e)
        {

        }

        private void Fuel_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void StartImg_Click(object sender, EventArgs e)
        {
            ErrorLbl.Hide();
            string Cap = TB1.Text;
            string TotalFuel = TB2.Text;

            if (Cap != "" && TotalFuel != "")
            {
                try //Checks if fuel is a number
                {
                    
                    TotalF = Convert.ToInt32(TotalFuel);
                    if(TotalF >= 0 && TotalF <= 5000)
                    {
                        Run();
                    }
                    else
                    {
                        ErrorLbl.Text = "Error: Enter a correct Fuel Value";
                        ErrorLbl.Show();
                    }
                }
                catch
                {
                    ErrorLbl.Text = "Error: Enter a correct Fuel Value";
                    ErrorLbl.Show();
                }
            }
            else
            {
                ErrorLbl.Text = "Error: Fill All Textboxes";
                ErrorLbl.Show();
            }
        }//Start Button
    }
}
