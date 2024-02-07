using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondesjakk_ny
{
    public partial class TicTacToeUI : Form
    {
        public TicTacToeUI()
        {
            InitializeComponent();
        }


        //Click
        private void LblBox1_Click(object sender, EventArgs e)
        {
            LblBox1.Text = "x";
        }

        private void LblBox2_Click(object sender, EventArgs e)
        {
            LblBox2.Text = "x";
        }

        private void LblBox3_Click(object sender, EventArgs e)
        {
            LblBox3.Text = "x";
        }

        private void LblBox4_Click(object sender, EventArgs e)
        {
            LblBox4.Text = "x";
        }

        private void LblBox5_Click(object sender, EventArgs e)
        {
            LblBox5.Text = "x";
        }

        private void LblBox6_Click(object sender, EventArgs e)
        {
            LblBox6.Text = "x";
        }

        private void LblBox7_Click(object sender, EventArgs e)
        {
            LblBox7.Text = "x";
        }

        private void LblBox8_Click(object sender, EventArgs e)
        {
            LblBox8.Text = "x";
        }

        private void LblBox9_Click(object sender, EventArgs e)
        {
            LblBox9.Text = "x";
        }

        //Doubleclick

        private void LblBox1_DoubleClick(object sender, EventArgs e)
        {
            LblBox1.Text = "o";
        }

        private void LblBox2_DoubleClick(object sender, EventArgs e)
        {
            LblBox2.Text = "o";
        }

        private void LblBox3_DoubleClick(object sender, EventArgs e)
        {
            LblBox3.Text = "o";
        }

        private void LblBox4_DoubleClick(object sender, EventArgs e)
        {
            LblBox4.Text = "o";
        }

        private void LblBox5_DoubleClick(object sender, EventArgs e)
        {
            LblBox5.Text = "o";
        }

        private void LblBox6_DoubleClick(object sender, EventArgs e)
        {
            LblBox6.Text = "o";
        }

        private void LblBox7_DoubleClick(object sender, EventArgs e)
        {
            LblBox7.Text = "o";
        }

        private void LblBox8_DoubleClick(object sender, EventArgs e)
        {
            LblBox8.Text = "o";
        }

        private void LblBox9_DoubleClick(object sender, EventArgs e)
        {
            LblBox9.Text = "o";
        }

        // Extra

        private void BtnAvbryt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNyttForsøk_Click(object sender, EventArgs e)
        {
            LblBox1.Text = string.Empty;
            LblBox2.Text = string.Empty;
            LblBox3.Text = string.Empty;
            LblBox4.Text = string.Empty;
            LblBox5.Text = string.Empty;
            LblBox6.Text = string.Empty;
            LblBox7.Text = string.Empty;
            LblBox8.Text = string.Empty;
            LblBox9.Text = string.Empty;
        }

    }
}
