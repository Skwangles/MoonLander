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
    public partial class Form1 : Form
    {
        public string Cap;
        string TotalFuel;
        public int TotalF;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ErrorLbl.Hide();
        }
        private void ShowHide()
        {         
            ErrorLbl.Show();                   
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ErrorLbl.Hide();
            Cap = TB1.Text;
            TotalFuel = TB2.Text;
            if (Cap != "" && TotalFuel != "")
            {
                try
                {
                    TotalF = Convert.ToInt32(TotalFuel);
                    SetUp(TotalF);
                }
                catch
                {
                    ErrorLbl.Text = "Enter a correct Fuel Value";
                    ShowHide();
                }
            }
            else
            {
                ErrorLbl.Text = "Fill All Textboxes";
                ShowHide();
            }
        }

        private void SetUp(int TotalF)
        {
            if (TotalF <= 5000 && TotalF >= 0)
            {
                Game o = new Game();
                o.Setmainform(this);
                o.ShowDialog();
                
            }
            else
            {
                ErrorLbl.Text = "Fuel must be between 0-5000";
                ShowHide();
            }
        }



    }
}
