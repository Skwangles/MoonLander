using System;
using System.Drawing;
using System.Windows.Forms;

namespace Moon_Lander
{
    public partial class Game : Form
    {
        bool IsThrust;
        bool ThrustHalf;
        bool LeftB;
        bool RightB;
        int TooFast = 10; //Sets the limit for how fast lander should be traveling on touch down
        public int TrackVal;
        const int Gravity = 1; //Gravity value
        int score = 0;
        bool Is0;
        int StartingTrackVal = 15; //Starting Trackbar value.
        int SpeedF = 0; //Default Speed of Gravity.
        string CapsName; //Captains name variable
        int TotalF;//Total Fuel value set by the user
        int wait;

        string Character = "`~!@#$%^&*()_+{}|\\][-=;':\",./<>?1234567890"; //Special char list for checking if they are in the captains name.
        Random Rand = new Random();
        static string filepath = @"G:\VS - Coding\"; //Change this based on where the Project is

        //To keep it public and outside a method so it can be accessed anywhere in the code.



        public Game()
        {
            InitializeComponent();
        } //Constructor

        #region starting Processes
        private void Game_Load(object sender, EventArgs e)
        {

            Moonscapepb.Left = 0;//Sets the background for boundaries to set in the corner.
            Moonscapepb.Top = 0;

            //setting the picture size for each ImageList

            #region Add Images to ImgList
            AddIMGs(); //Runs the adding of the imgs


            #endregion
            Start("S"); //Shows the start screen.

        }

        void setGame() //Sets up the visual things and positions
        {
            scorelbl.Text = score.ToString();
            //Adding to the ImgList is in the reigon above
            ErrorLbl.Hide(); //Makes sure the error label is hidden
            PBStartBackground.Left = 0; //Sets the starting teal screen to cover the entire screen
            PBStartBackground.Top = 0;
            pbLandingPad.Height = 73;
            pbLandingPad.Image = PadIL.Images[2];
            ResetLander();
            StartButtonimg.Left = (PBStartBackground.Width / 2) - (StartButtonimg.Width / 2); //sets the start button to centre  of screen
            StartButtonimg.Top = (PBStartBackground.Height / 4) - (StartButtonimg.Height / 17);
            wait = 0;
            SuccessFaillbl.Hide(); //Makes sure label is hidden
            SuccessFaillbl.Left = 0;
            SuccessFaillbl.Top = (Moonscapepb.Height / 2) - (SuccessFaillbl.Height / 2); //sets position of Win/lose Labl                                  
            PadTop(); //sets pad y pos
            pbLander.Top = 0; //sets lander y pos
            TrackbarThrust.Value = StartingTrackVal;
        }
        #region Focusi Grav issue

        void AddIMGs() //Adds in the image files
        {

            LanderVar.ImageSize = new Size(93, 109);
            PadIL.ImageSize = new Size(134, 73);
            var Land = LanderVar.Images;
            var PadL = PadIL.Images;
            //No-Thrust Lander Imgs
            Land.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landers\uprightLander.png")); //No Thrust Falling No Movement 0
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
            PadL.Add(Image.FromFile(filepath + @"MoonLanderSchoolProject\Lunar Lander files 2019\Landing pads\landingPad.png"));//2

        }


        void PadTop() //Makes sure that the pad is just above the control panel.
        {
            pbLandingPad.Top = Moonscapepb.Height - pbLandingPad.Height;
        }
        void Start(string H)
        {
            switch (H) //Hides Start screen, by hiding all start screen elements, and sets the speed, and resets the positions of the lander and pad.
            {
                case "H":
                    StartButtonimg.Hide();
                    PBStartBackground.Hide();
                    Infolbl.Hide();
                    Infolbl1.Hide();
                    InfoLbl2.Hide();
                    Infolbl3.Hide();
                    YNPB.Hide();
                    Capnamtxtlbl.Hide();
                    CapsNameTB.Hide();
                    Fuelnumtxtlbl.Hide();
                    FuelTB.Hide();
                    ColoringPB.Hide();
                    TooFastlbl.Hide();
                    LowFuellbl.Hide();
                    PadTop(); //Flattens the landing pad to the bottom.
                    SpeedF = 2;
                    break;
                case "S": //Shows Start screen, by showing all the elements over the game.
                    setGame();
                    StartButtonimg.Show();
                    PBStartBackground.Show();
                    Infolbl.Show();
                    Infolbl1.Show();
                    InfoLbl2.Show();
                    Infolbl3.Show();
                    YNPB.Show();
                    Capnamtxtlbl.Show();
                    CapsNameTB.Show();
                    Fuelnumtxtlbl.Show();
                    FuelTB.Show();
                    ColoringPB.Show();
                    pbLander.Show();

                    break;
                default:
                    break;
            }

        }

        void Run() //Runs starting processes, like unhides the game, and hides the loading screen, gives focus time for the user to register game and get ready. Sets the max fuel, sets the captains name, sets the Focus to the trackbar for key registering.
        {
            CapsName = CapsNameTB.Text; //Sets Input caps name
            ProgressBar.Maximum = TotalF; //set input fuel num
            pbLandingPad.Left = Rand.Next(0, (Moonscapepb.Width - pbLandingPad.Width)); //gets random x
            pbLander.Left = Rand.Next(0, (Moonscapepb.Width - pbLander.Width)); //gets random x
            TrackbarThrust.Focus(); //Focuses the track bar which detects key presses
            Start("H"); //Hides start screen
            System.Threading.Thread.Sleep(500); //Pauses the start of the Game, till user focused
            Movetmr.Start();

        }

        #region KeyCheckers
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs e) //If the user, focuses off the Trackbar, will still apply the key checkers, on the form
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

        private void Game_KeyUp(object sender, KeyEventArgs e) //If the user, focuses off the Trackbar, will still apply the key checkers on the form
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
        #endregion//Holds the Key Event listeners
        #endregion
        #endregion
        private void Movetmr_Tick(object sender, EventArgs e) //Timer tick process - Runs all tests 
        {
            TrackVal = (TrackbarThrust.Value) / 15; //Breaks down the size of the 40 numbers, to only a certain bit greater than Gravity.

            #region Half or greater than half thrust checker
            if (TrackbarThrust.Value != 0) //Checks if track bar is applying thrust, and if it is less than half, thus allowing the movement subroutines to know which type of thrust to apply
            {
                IsThrust = true;
                if (TrackbarThrust.Value < TrackbarThrust.Maximum / 2) ThrustHalf = true;
                else { ThrustHalf = false; }
            }
            else { IsThrust = false; } //checks if the thrust is actually being applied.

            yvallbl.Text = (PBStartBackground.Height - pbLander.Top - pbLander.Height).ToString(); //updateds x,y labels
            lblxval.Text = pbLander.Left.ToString(); 
            #endregion


            if (Is0) //Applies the speed based on if there if fuel left, If yes, applies thrust and Gravity. If not, only gravity
            {
                SpeedF += Gravity;

            }
            else
            {
                SpeedF += Gravity;
                SpeedF -= TrackVal;
            }

            if (SpeedF > 20) //Checks if speed is over terminal velocity.
            {
                SpeedF = 20; //Keeps the Lander at a terminal velocity. So it doesn't infinitly speed up, also so the user had time to react to falling.
            }

            lblspeedtrav.Text = SpeedF.ToString(); //Updates the label which shows the speed.
            if(SpeedF > TooFast)
            {
                TooFastlbl.Show(); //Shows warning label for if speed is too great
            }
            else
            {
                TooFastlbl.Hide(); //If speed is fine, removes label, or keeps it hidden
            }

            //Gets the speed. Can handle if the next round will result in Fuel = 0

            //sets lbl for speed

            //Terminal velocity check

            //Set the label to the Speed.
            if (pbLander.Top + pbLander.Height - 20 >= Moonscapepb.Height - pbLandingPad.Height + 52) Checkcol(); //Checks if the lander has reached pad's y level, if so, starts the Landing Pad Collision checker
            else
            {
                FuelLeft(); //applies thrust movement based on if there is still fuel left in the tank.


                if (LeftB) //Moves the lander left, and changes the image to suit, based on if there is full thrust, half, or none
                {
                    if (IsThrust) //Checks if thrust is activated for the left movement image
                    {
                        if (ThrustHalf) //Decides if the Lander Should go to Half Thrust of Full thrust img
                        {
                            pbLander.Image = LanderVar.Images[4];
                        }
                        else
                        {
                            pbLander.Image = LanderVar.Images[5];
                        }
                    }
                    else
                    {
                        pbLander.Image = LanderVar.Images[3]; //no thrust Left
                    }
                    pbLander.Left -= 2;
                }//moves lander left, and changes img

                if (RightB)
                {
                    if (IsThrust) //Checks if thrust is activated for the left movement image
                    {
                        if (ThrustHalf) //Decides if the Lander Should go to Half Thrust of Full thrust img
                        {
                            pbLander.Image = LanderVar.Images[6]; //sets lander img to half thrust
                        }
                        else
                        {
                            pbLander.Image = LanderVar.Images[7]; //Sets lander img to full thrust
                        }
                    }
                    else
                    {
                        pbLander.Image = LanderVar.Images[2]; //no thrust 
                    }
                    pbLander.Left += 2;
                }//moves lander right, with changed images
                if (LeftB || RightB) { } //Checks if either key is being pressed, else, changes the landers image to no, left or right lean
                else { ResetLander(); }
            }//If lander is still in play will continue check
        }
        #region To Focus on Gravity issue
        void ResetLander()
        {
            if (IsThrust) //Checks if thrust is activated for the left movement image
            {
                if (ThrustHalf) //Decides if the Lander Should go to Half Thrust of Full thrust img
                {
                    pbLander.Image = LanderVar.Images[8];
                }
                else
                {
                    pbLander.Image = LanderVar.Images[9];
                }
            }
            else
            {
                pbLander.Image = LanderVar.Images[0]; //no thrust 
            }
        } //Resets the Lander to No horizontal movement

        void Checkcol() //Checks if The lander, when it reaches bottem has landed on the pad or not, and applys the correct message accordingly and adds to score, and resets game.
        {
            Movetmr.Stop();//stops game so lander is not moving.
            if (pbLander.Left >= pbLandingPad.Left && pbLander.Width + pbLander.Left <= pbLandingPad.Left + pbLandingPad.Width) //checks if on landing pad, if so checks if speed is too great. 
            {
                pbLandingPad.Height = 100;
                pbLander.Hide();
                if (SpeedF <= TooFast) //If speed is less than the variable of what is too fast, shows win scenario
                {

                    pbLandingPad.Image = PadIL.Images[0];
                    PadTop();//resets Landing pad Position
                    score++; //adds too score
                    SuccessFaillbl.Text = "Congrats Captain " + CapsName + ", Mission Complete." + Environment.NewLine + " Speed was: " + SpeedF + "kph";
                }
                else
                {
                    pbLandingPad.Image = PadIL.Images[1]; //if greater than speed limit, loose scenario is shown
                    PadTop();
                    SuccessFaillbl.Text = "Sorry Captain " + CapsName + ", Mission Failed." + Environment.NewLine + " You landed too fast at: " + SpeedF + "kph";
                }
            }
            else //If it reaches bottem and isn't on pad Crashes
            {
                pbLander.Image = LanderVar.Images[1];
                SuccessFaillbl.Text = "Sorry Captain " + CapsName + ", Mission Failed. You missed the Landing Pad.";
                pbLander.Top = Moonscapepb.Height - pbLander.Height + 50;//drops the Lander to the bottem of the screen, 50 is to compensate for the extra bit of image at the bottem of the craft.
            } // if not on pad, crashes

            SuccessFaillbl.Show(); //shows the label for WIn LOse scenario
            timer1.Start(); //Starts the wait timer, before reseting.
        }
        #endregion



        void FuelLeft()  //moves lander Vertically, as well as horizontally., minus fuel from the progressbar and applys movement
        {
           

            if (TotalF - TrackbarThrust.Value <= 0) //Once Fuel has run out, makes sure only gravtiy works. LeftRight movement still works. But disables all vertical movement by thrust
            {
                Is0 = true;

                ProgressBar.Value = 0;
            }

            pbLander.Top += SpeedF; //Moves the lander vertically.

            //While there is remaining fuel applies thrust.

            if (Is0 != true) //If there is still remaining fuel, applies thrust and changes the value of the progress bar.
            {
                TotalF -= (TrackVal) * 15;
                ProgressBar.Value = TotalF;
            }

            if(TotalF < Convert.ToInt32(FuelTB.Text) / 4)  //If remaining fuel is less than a quarter. Shows the LowFUEL label.
            {
                LowFuellbl.Show();
            }

        }
        #region tofocus on grav issue

        #region Bunch Of Collapsed, and Trackbar Key listners
        private void button2_Click(object sender, EventArgs e) { }  //OldStartButtonhusk, no use. 

        private void TrackBar_KeyDown(object sender, KeyEventArgs e) //Checks for the Key pressed, while it is pressed, it gives a true value, since you are also changing thetrackbar value with mouse, you are focussed on the track bar, so it is easier to Check keys here for the lander movement
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

        private void TrackBar_KeyUp(object sender, KeyEventArgs e) //Checks which key has been released upon this event. If so, turns off the activation of that key.
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
            string Cap = CapsNameTB.Text; //Gets the values to be checked from the text boxes
            string TotalFuel = FuelTB.Text;
            bool NoSpecCap = true; 
            if (Cap != "" && TotalFuel != "") //Checks if textboxes are empty - Else throws error.
            {

                foreach (char a in Character) //Checks if any of the special caps in an array are present, if not continues. Does this for numbers and special caps. in the Cap's Name Textbox.
                {
                    if (Cap.Contains(a.ToString()))
                    {
                        NoSpecCap = false;
                        break;
                    }

                }

                if (NoSpecCap)
                {
                    try //Checks if fuel is a number - If not stops the process and returns error
                    {

                        TotalF = Convert.ToInt32(TotalFuel);
                        if (TotalF >= 0 && TotalF <= 5000)
                        {
                            Run();
                        }
                        else
                        {
                            ErrorLbl.Text = "Error: Enter correct Fuel Value," + Environment.NewLine + " Captain " + Cap;
                            ErrorLbl.Show();
                        }
                    }
                    catch
                    {
                        ErrorLbl.Text = "Error: Enter correct Fuel Value, " + Environment.NewLine + " Captain " + Cap;
                        ErrorLbl.Show();
                    }
                }
                else //If the NoSpecCap is false throws error, to remove special chars
                {
                    ErrorLbl.Text = "Error: Remove Numbers and Special Characters ";
                    ErrorLbl.Show();
                }
            }
            else
            {
                ErrorLbl.Text = "Error: Fill All Textboxes"; 
                ErrorLbl.Show();
            }

        }//Start Button - Checks all text box cases to make sure that correct entries have been input

        private void timer1_Tick(object sender, EventArgs e)
        {
            wait++; //Waits after game is won to reset.
            if (wait > 20)
            {
                timer1.Stop();
                Start("S");
            }
        }

        private void Lander_Click(object sender, EventArgs e)
        {

        }

        private void Lander_LocationChanged(object sender, EventArgs e) //Updates the location, and creates wrap around, where if the lander goes of one side, it comes back on the other.
        {
            if (pbLander.Left - 1 > Moonscapepb.Width)
            {
                pbLander.Left = 0 - pbLander.Width;
            }
            if (pbLander.Top < 0)
            {
                pbLander.Top = 0;
                SpeedF = (SpeedF * -1);
                TrackbarThrust.Value = 10;
            }
        }

        private void Coloring_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar_ValueChanged(object sender, EventArgs e) //Updated the Trackbars Thrust value.
        {
            
            ThrustVallbl.Text = TrackbarThrust.Value.ToString();
        }

        private void ErrorLbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion//Created this reigon to focus on a bug
}
