using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace politicalTriangle
{
    public partial class Form1 : Form
    {
        private Point location = Point.Empty;
        private string[] splitString = new string[2];
        private int selectedXVal = 0;
        private int selectedYVal = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Select();
            location = userPolitics.Location;
            Console.WriteLine(location.X + " " + location.Y + "\n");
        }

        // communism = 560, 278, absolutism = 806, 422, individualism = 806, 137
        // left = communism, down = individualism, and up = abolutism and right = darwinism/anti-egalitarian.
        private void button1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            button1.Enabled = false;
            // retrieve data from selected radio buttons
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control c in control.Controls)
                    {
                        if (c is RadioButton)
                        {
                            RadioButton radioButton = c as RadioButton;
                            if (radioButton.Checked)
                            {
                                splitString = ((string)radioButton.Tag).Split(',');
                                selectedXVal += Convert.ToInt32(splitString[0]);
                                selectedYVal += Convert.ToInt32(splitString[1]);
                                Console.Write(radioButton.Name + " " + selectedXVal + " , " + selectedYVal + "\n");
                            }
                        }
                    }
                }
            }
            location.X += selectedXVal;
            location.Y += selectedYVal;
            Console.WriteLine(selectedXVal + " " + selectedYVal + "\n");
            // bounds checking
            if (location.X <= 806 && location.X >= 560 && location.Y <= (0.5853 * location.X - 50) && location.Y >= (-0.5732 * location.X + 600))
            {
                userPolitics.Location = location;
            }
            else if (location.X > 806 && location.Y <= (0.5853 * location.X - 50) && location.Y >= (-0.5732 * location.X + 600))
            {
                location.X = 806;
                userPolitics.Location = location;
            }
            else if (location.X < 806 && location.X >= 560 && location.Y > (0.5853 * location.X - 50))
            {
                location.Y = (int)(0.5853 * location.X - 50);
                userPolitics.Location = location;
            }
            else if (location.X < 806 && location.X >= 560 && location.Y < (-0.5732 * location.X + 600))
            {
                location.Y = (int)(-0.5732 * location.X + 600);
                userPolitics.Location = location;
            }
            else if (location.X > 806 && location.Y < (-0.5732 * location.X + 600))
            {
                location.X = 806;
                location.Y = 137;
                userPolitics.Location = location;
            }
            else if (location.Y < (-0.5732 * location.X + 600) && location.Y > (0.5853 * location.X - 50))
            {
                location.X = 560;
                location.Y = 278;
                userPolitics.Location = location;
            }
            else if (location.X > 806 && location.Y > (0.5853 * location.X - 50))
            {
                location.X = 806;
                location.Y = 422;
                userPolitics.Location = location;
            }
            Console.WriteLine(userPolitics.Location.X + " " + userPolitics.Location.Y + "\n");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // refresh form and all stored data
            Console.WriteLine("Reset");
            this.Controls.Clear();
            this.InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            selectedXVal = 0;
            selectedYVal = 0;
            location = userPolitics.Location;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/TriangleStrategy/comments/ss1l47/the_games_name_could_refer_to_a_political/");
        }
    }
}
