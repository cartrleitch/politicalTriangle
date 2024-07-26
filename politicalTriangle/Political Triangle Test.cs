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
        public Form1()
        {
            InitializeComponent();
        }

        // communism = 560, 278, absolutism = 806, 422, individualism = 805, 137
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Banana";
            location.X = 560;
            location.Y = 278;
            userPolitics.Location = location;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Orange";
            location.X = 806;
            location.Y = 422;
            userPolitics.Location = location;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Blueburry";
            location.X = 805;
            location.Y = 137;
            userPolitics.Location = location;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
