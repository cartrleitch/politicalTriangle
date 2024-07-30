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
            location = userPolitics.Location;
        }

        // communism = 560, 278, absolutism = 806, 422, individualism = 805, 137
        // left = communism, up = individualism, and down = abolutismm and right = darwinism/anti-egalitarian.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /*splitString = ((string)radioButton1.Tag).Split(',');
            selectedXVal = Convert.ToInt32(splitString[0]);
            selectedYVal = Convert.ToInt32(splitString[1]);
            location.X = 1088;
            location.Y = 447;*/
        }
       private void button1_Click(object sender, EventArgs e)
        {  
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
            userPolitics.Location = location;
        } 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void userPolitics_Click(object sender, EventArgs e)
        {
 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
