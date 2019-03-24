using System;
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
        ImageList Land = new ImageList();
        bool LeftB;
        bool RightB;
        bool Won = false;
        int Gravity = 3; //Gravity value
        int SpeedF = 30; //Default Speed of Gravity.
        string CapsName; //Captains name variable
        int TotalF;//Total Fuel value set by the user
       

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            ErrorLbl.Hide(); //Makes sure the error label is hidden
            PB.Left = 0; //Sets the starting teal screen to cover the entire screen
            PB.Top = 0; 
            Butt.Left = (PB.Width / 2) - (Butt.Width / 2); //sets the start button to centre  of screen
            Butt.Top = PB.Height / 4; 
            Start("S"); //Sub which does the case. Show. It shows the info, and start screen
            SuccessFaillbl.Hide(); //Makes sure label is hidden
            SuccessFaillbl.Left = 0; 
            SuccessFaillbl.Top = (Moonscape.Height / 2) - (SuccessFaillbl.Height / 2); //sets position of Labl                                  
            Pad.Top = Moonscape.Height - Pad.Height; //sets pad y pos
            Lander.Top = 0; //sets lander y pos

        }

        void Start(string H)
        {
            switch (H) //Hides Start screen
            {
                case "H":
                    Butt.Hide();
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
                    Butt.Show();
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
                    break;
                default:
                    break;
            }

        }

        void Run()
        {
            CapsName = TB1.Text; //Sets Input caps name
            FuelBar.Maximum = TotalF; //set input fuel num
            Pad.Left = GetRand(0, (Moonscape.Width - Pad.Width)); //gets random x
            Lander.Left = GetRand(0, (Moonscape.Width - Lander.Width)); //gets random x
            TrackBar.Focus(); //Focuses the track bar which detects key presses
            Start("H"); //Hides start screen
            System.Threading.Thread.Sleep(500); //Pauses the start of the Game, till user focused
            Movetmr.Start(); //Starts the game
            
        }

        int GetRand(int min, int max) //gets random value
        {
            Random Rand = new Random();
            return Rand.Next(min, max);

        }

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

        private void Movetmr_Tick(object sender, EventArgs e)
        {
            yval.Text = (PB.Height - Lander.Top).ToString(); //updateds x,y
            xval.Text = Lander.Left.ToString();
            SpeedF = (Gravity - TrackBar.Value)*10; //Updates the speed lbl and val
            speedtrav.Text = ((Gravity - TrackBar.Value) * 10).ToString(); //sets lbl for speed
           
            if (Lander.Top + Lander.Height >= 335) Checkcol(); //Checks if the lander has reached pad's y level
            else
            {
                ThrustLR(); //applies thrust movement
            }
            if (LeftB) Lander.Left -= 2; //moves left
            if (RightB) Lander.Left += 2; //moves right

        }

        void Checkcol() //Checks if The lander, when it reaches bottem has landed on the pad or not, and applys the correct message accordingly
        {
            if (Lander.Left >= Pad.Left && Lander.Width + Lander.Left <= Pad.Left + Pad.Width) //checks if on landing pad
            {
                if (SpeedF <= 20) Won = true; //checks if lander is going to fast on touch down
                else { Won = false;} 
            }
            else
            { Won = false; } // if not on pad, crashes
            if (Won)
            {
                SuccessFaillbl.Text = "Congrats Captain " + CapsName + ", Mission Complete. Speed was: " + SpeedF+"m/s"; //based on condition, tells user if they have won
            }
            else
            {
                SuccessFaillbl.Text = "Sorry Captain " + CapsName + ", Mission Failed. Speed was: " + SpeedF + "m/s";
            }
            Movetmr.Stop();//stops game
            SuccessFaillbl.Show(); //shows the label
        }

        void ThrustLR()  //moves lander Left and Right, as well as adds thrust, minus fuel and Apply movement
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
        

        private void button2_Click(object sender, EventArgs e)  //Starts game, Hided Info Screen
        {

            ErrorLbl.Hide(); 
            string Cap = TB1.Text;
            string TotalFuel = TB2.Text;
            
            if (Cap != "" && TotalFuel != "")
            {
                try //Checks if fuel is a number
                {
                    TotalF = Convert.ToInt32(TotalFuel); 
                    Run();
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

            
        }

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
    }
}
