using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class OnePlayerfrmDetails : Form
    {
        public OnePlayerfrmDetails()
        {
            InitializeComponent();
        }

        byte checkedt = 1;

        private void Donebtn_Click(object sender, EventArgs e)
        {
            char op, op2;
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                textBox1.Text = "Player 1";
                textBox2.Text = "Computer";
                op = 'X';
                op2 = 'O';
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                textBox2.Text = "Computer";
                op = 'X';
                op2 = 'O';
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                textBox1.Text = "Computer";
                op = 'X';
                op2 = 'O';
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                op = 'X';
                op2 = 'O';
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
            {
                textBox1.Text = "Player 1";
                textBox2.Text = "Computer";
                op = Convert.ToChar(textBox3.Text);
                if (op != 'X' && op != 'x')
                {
                    op2 = 'X';
                }
                else
                {
                    op2 = 'O';
                }
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text != "")
            {
                textBox1.Text = "Player 1";
                textBox2.Text = "Computer";
                op2 = Convert.ToChar(textBox4.Text);
                if (op2 != 'X' && op2 != 'x')
                {
                    op = 'X';
                }
                else
                {
                    op = 'O';
                }
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
            {
                op = Convert.ToChar(textBox3.Text);
                if (op != 'X' && op != 'x')
                {
                    op2 = 'X';
                }
                else
                {
                    op2 = 'O';
                }
                textBox2.Text = "Computer";
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text != "")
            {
                op2 = Convert.ToChar(textBox4.Text);
                if (op2 != 'X' && op2 != 'x')
                {
                    op = 'X';
                }
                else
                {
                    op = 'O';
                }
                textBox1.Text = "You";
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                op = Convert.ToChar(textBox3.Text);
                op2 = Convert.ToChar(textBox4.Text);
                OnePlayerfrm p1 = new OnePlayerfrm(textBox1.Text, textBox2.Text, op, op2, checkedt);
                this.Hide();
                p1.Show();
            }
        }

        private void OnePlayerfrmDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            FirstForm f1 = new FirstForm();
            this.Hide();
            f1.Show();
        }

        private void Normalrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Normalrbtn.Checked == true)
            {
                checkedt = 2;
            }
        }

        private void Hardrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Hardrbtn.Checked == true)
            {
                checkedt = 3;
            }
        }

        private void Easybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Easybtn.Checked == true)
            {
                checkedt = 1;
            }
        }
    }
}
