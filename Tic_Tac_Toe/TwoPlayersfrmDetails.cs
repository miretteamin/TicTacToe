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
    public partial class TwoPlayersfrmDetails : Form
    {
        public TwoPlayersfrmDetails()
        {
            InitializeComponent();
        }

        private void Donebtn_Click(object sender, EventArgs e)
        {
            char op, op2;
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                textBox1.Text = "Player 1";
                textBox2.Text = "Player 2";
                op = 'X';
                op2 = 'O';
                TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                textBox2.Text = "Player 2";
                op = 'X';
                op2 = 'O';
                TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                textBox1.Text = "Player 2";
                op = 'X';
                op2 = 'O';
                TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                op = 'X';
                op2 = 'O';
                TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
            {
                textBox1.Text = "Player 1";
                textBox2.Text = "Player 2";
                op = Convert.ToChar(textBox3.Text);
                if (op != 'X' && op != 'x')
                {
                    op2 = 'X';
                }
                else
                {
                    op2 = 'O';
                } 
                TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text != "")
            {
                textBox1.Text = "Player 1";
                textBox2.Text = "Player 2";
                op2 = Convert.ToChar(textBox4.Text);
                if (op2 !='X' && op2 != 'x')
                {
                    op = 'X';
                }
                else
                {
                    op = 'O';
                }
                TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                this.Hide();
                p1.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                op = Convert.ToChar(textBox3.Text);
                op2 = Convert.ToChar(textBox4.Text);
                TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                this.Hide();
                p1.Show();
            }
            else
            {
                if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
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
                    textBox2.Text = "Player 2";
                    TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
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
                    TwoPlayersfrm p1 = new TwoPlayersfrm(textBox1.Text, textBox2.Text, op, op2);
                    this.Hide();
                    p1.Show();
                }
            }
        }

        private void TwoPlayersfrmDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            FirstForm f1 = new FirstForm();
            this.Hide();
            f1.Show();
        }

        private void TwoPlayersfrmDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
