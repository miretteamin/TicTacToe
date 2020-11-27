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
    public partial class OnePlayerfrm : Form
    {
        public OnePlayerfrm()
        {
            InitializeComponent();
        }

        string Player, computer;
        char oper, oper2;
        byte click = 0, rec = 0, returnvalue = 4, radiobtn = 0;
        int P1S = 0, P2S = 0;

        public OnePlayerfrm(string p1, string p2, char OP, char OP2, byte checkedt)
        {
            Player = p1;
            computer = p2;
            oper = OP;
            oper2 = OP2;
            radiobtn = checkedt;
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            click = 1;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn1.Text == "" && click == 1)
                {
                    btn1.Text = "";
                }
                else if (btn1.Text != "" && click == 1)
                {
                    btn1.Text = btn1.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn1.Text = btn1.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn1.Text == "")
                    {
                        btn1.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            click = 2;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn2.Text == "" && click == 2)
                {
                    btn2.Text = "";
                }
                else if (btn2.Text != "" && click == 2)
                {
                    btn2.Text = btn2.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn2.Text = btn2.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn2.Text == "")
                    {
                        btn2.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            click = 3;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn3.Text == "" && click == 3)
                {
                    btn3.Text = "";
                }
                else if (btn3.Text != "" && click == 3)
                {
                    btn3.Text = btn3.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn3.Text = btn3.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn3.Text == "")
                    {
                        btn3.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            click = 4;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn4.Text == "" && click == 4)
                {
                    btn4.Text = "";
                }
                else if (btn4.Text != "" && click == 4)
                {
                    btn4.Text = btn4.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn4.Text = btn4.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn4.Text == "")
                    {
                        btn4.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();

                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            click = 5;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn5.Text == "" && click == 5)
                {
                    btn5.Text = "";
                }
                else if (btn5.Text != "" && click == 5)
                {
                    btn5.Text = btn5.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn5.Text = btn5.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn5.Text == "")
                    {
                        btn5.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            click = 6;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn6.Text == "" && click == 6)
                {
                    btn6.Text = "";
                }
                else if (btn6.Text != "" && click == 6)
                {
                    btn6.Text = btn6.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn6.Text = btn6.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn6.Text == "")
                    {
                        btn6.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            click = 7;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn7.Text == "" && click == 7)
                {
                    btn7.Text = "";
                }
                else if (btn7.Text != "" && click == 7)
                {
                    btn7.Text = btn7.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn7.Text = btn7.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn7.Text == "")
                    {
                        btn7.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            click = 8;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn8.Text == "" && click == 8)
                {
                    btn8.Text = "";
                }
                else if (btn8.Text != "" && click == 8)
                {
                    btn8.Text = btn8.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn8.Text = btn3.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn8.Text == "")
                    {
                        btn8.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            click = 9;
            if (btn1.BackColor == Color.Green || btn2.BackColor == Color.Green || btn3.BackColor == Color.Green || btn4.BackColor == Color.Green || btn5.BackColor == Color.Green || btn6.BackColor == Color.Green || btn7.BackColor == Color.Green || btn8.BackColor == Color.Green || btn9.BackColor == Color.Green)
            {
                if (btn9.Text == "" && click == 9)
                {
                    btn9.Text = "";
                }
                else if (btn9.Text != "" && click == 9)
                {
                    btn9.Text = btn9.Text;
                }
                PlayAgainbtn.Focus();
            }
            else if ((btn1.Text != "" && btn1.BackColor != Color.Green) && (btn2.Text != "" && btn2.BackColor != Color.Green) && (btn3.Text != "" && btn3.BackColor != Color.Green) && (btn4.Text != "" && btn4.BackColor != Color.Green) && (btn5.Text != "" && btn5.BackColor != Color.Green) && (btn6.Text != "" && btn6.BackColor != Color.Green) && (btn7.Text != "" && btn7.BackColor != Color.Green) && (btn8.Text != "" && btn8.BackColor != Color.Green) && (btn9.Text != "" && btn9.BackColor != Color.Green))
            {
                btn9.Text = btn9.Text;
            }
            else
            {
                if (Turnlbl.Text == Player)
                {
                    if (btn9.Text == "")
                    {
                        btn9.Text = oper.ToString();
                        if (btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
                        {
                            timer1.Start();
                            Turnlbl.Text = computer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Turnlbl.Text == computer)
                {
                    MessageBox.Show("Invalid Move :( \n\nIt's not your turn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void OnePlayerfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FirstForm f1 = new FirstForm();
            if (rec == 1)
            {
                f1.Close();
            }
            else
            {
                f1.Show();
            }
        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {
            TheGame();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            rec = 1;
            this.Close();
            OnePlayerfrmDetails f1 = new OnePlayerfrmDetails();
            f1.Show();
            FirstForm f2 = new FirstForm();
            f2.Close();
        }

        private void TheGame()
        {
            label4.Hide();
            Turnlbl.Show();
            click = 0;
            rec = 0;
            Turnlbl.Text = Player;
            Player1Scorelbl.Text = Player;
            Player2Scorelbl.Text = computer;
            Player1Score.Text = P1S.ToString();
            Player2Score.Text = P2S.ToString();
            Player1lbl.Text = Player + " = " + oper;
            Player2lbl.Text = computer + " = " + oper2;
            btn1.Text = "";
            btn1.BackColor = SystemColors.ControlLight;
            btn2.Text = "";
            btn2.BackColor = SystemColors.ControlLight;
            btn3.Text = "";
            btn3.BackColor = SystemColors.ControlLight;
            btn4.Text = "";
            btn4.BackColor = SystemColors.ControlLight;
            btn5.Text = "";
            btn5.BackColor = SystemColors.ControlLight;
            btn6.Text = "";
            btn6.BackColor = SystemColors.ControlLight;
            btn7.Text = "";
            btn7.BackColor = SystemColors.ControlLight;
            btn8.Text = "";
            btn8.BackColor = SystemColors.ControlLight;
            btn9.Text = "";
            btn9.BackColor = SystemColors.ControlLight;
        }

        private void Win()
        {
            if (btn1.Text == oper.ToString() && btn4.Text == oper.ToString() && btn7.Text == oper.ToString())
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                Turnlbl.Text = "";
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);


            }
            else if (btn2.Text == oper.ToString() && btn5.Text == oper.ToString() && btn8.Text == oper.ToString())
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                Turnlbl.Text = "";
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else if (btn3.Text == oper.ToString() && btn6.Text == oper.ToString() && btn9.Text == oper.ToString())
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = Player;
            }
            else if (btn1.Text == oper.ToString() && btn2.Text == oper.ToString() && btn3.Text == oper.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";

            }
            else if (btn4.Text == oper.ToString() && btn5.Text == oper.ToString() && btn6.Text == oper.ToString())
            {
                btn5.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                Turnlbl.Text = "";
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else if (btn7.Text == oper.ToString() && btn8.Text == oper.ToString() && btn9.Text == oper.ToString())
            {
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                Turnlbl.Text = "";
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else if (btn1.Text == oper.ToString() && btn5.Text == oper.ToString() && btn9.Text == oper.ToString())
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                Turnlbl.Text = "";
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else if (btn3.Text == oper.ToString() && btn5.Text == oper.ToString() && btn7.Text == oper.ToString())
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                Turnlbl.Text = "";
                P1S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            else if (btn1.Text == oper2.ToString() && btn4.Text == oper2.ToString() && btn7.Text == oper2.ToString())
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(computer + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (btn2.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn8.Text == oper2.ToString())
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(Player + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (btn3.Text == oper2.ToString() && btn6.Text == oper2.ToString() && btn9.Text == oper2.ToString())
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(computer + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (btn1.Text == oper2.ToString() && btn2.Text == oper2.ToString() && btn3.Text == oper2.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(computer + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (btn4.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn6.Text == oper2.ToString())
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(computer + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (btn7.Text == oper2.ToString() && btn8.Text == oper2.ToString() && btn9.Text == oper2.ToString())
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(computer + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (btn1.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn9.Text == oper2.ToString())
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(computer + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (btn3.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn7.Text == oper2.ToString())
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(computer + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("Equality ;)");
                Turnlbl.Text = "";
            }
        }

        private void Losetheanotherplayer()
        {
            if (Turnlbl.Text == computer && btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
            {
                if (btn1.Text == oper.ToString() && btn2.Text == oper.ToString() && btn3.Text == "")
                {
                    btn3.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn1.Text == oper.ToString() && btn4.Text == oper.ToString() && btn7.Text == "")
                {
                    btn7.Text = oper2.ToString();
                    returnvalue = 1;
                    Turnlbl.Text = Player;
                }
                else if (btn1.Text == oper.ToString() && btn5.Text == oper.ToString() && btn9.Text == "")
                {
                    btn9.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn2.Text == oper.ToString() && btn3.Text == oper.ToString() && btn1.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn2.Text == oper.ToString() && btn5.Text == oper.ToString() && btn8.Text == "")
                {
                    btn8.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn2.Text == oper.ToString() && btn3.Text == oper.ToString() && btn1.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn5.Text == oper.ToString() && btn6.Text == oper.ToString() && btn4.Text == "")
                {
                    btn4.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn2.Text == oper.ToString() && btn8.Text == oper.ToString() && btn5.Text == "")
                {
                    btn5.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn3.Text == oper.ToString() && btn6.Text == oper.ToString() && btn9.Text == "")
                {
                    btn9.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn3.Text == oper.ToString() && btn1.Text == oper.ToString() && btn2.Text == "")
                {
                    btn2.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn3.Text == oper.ToString() && btn5.Text == oper.ToString() && btn7.Text == "")
                {
                    btn7.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn4.Text == oper.ToString() && btn7.Text == oper.ToString() && btn1.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn4.Text == oper.ToString() && btn5.Text == oper.ToString() && btn6.Text == "")
                {
                    btn6.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn5.Text == oper.ToString() && btn6.Text == oper.ToString() && btn4.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn5.Text == oper.ToString() && btn7.Text == oper.ToString() && btn3.Text == "")
                {
                    btn3.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn5.Text == oper.ToString() && btn9.Text == oper.ToString() && btn1.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn6.Text == oper.ToString() && btn9.Text == oper.ToString() && btn3.Text == "")
                {
                    btn3.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn6.Text == oper.ToString() && btn4.Text == oper.ToString() && btn5.Text == "")
                {
                    btn5.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn7.Text == oper.ToString() && btn3.Text == oper.ToString() && btn5.Text == "")
                {
                    btn5.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn7.Text == oper.ToString() && btn8.Text == oper.ToString() && btn9.Text == "")
                {
                    btn9.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn7.Text == oper.ToString() && btn1.Text == oper.ToString() && btn4.Text == "")
                {
                    btn4.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn8.Text == oper.ToString() && btn9.Text == oper.ToString() && btn7.Text == "")
                {
                    btn7.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn8.Text == oper.ToString() && btn5.Text == oper.ToString() && btn2.Text == "")
                {
                    btn2.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }

                else if (btn9.Text == oper.ToString() && btn3.Text == oper.ToString() && btn6.Text == "")
                {
                    btn6.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn9.Text == oper.ToString() && btn7.Text == oper.ToString() && btn8.Text == "")
                {
                    btn8.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else if (btn9.Text == oper.ToString() && btn1.Text == oper.ToString() && btn5.Text == "")
                {
                    btn5.Text = oper2.ToString();
                    Turnlbl.Text = Player;
                    returnvalue = 1;
                }
                else
                {
                    returnvalue = 0;
                }
            }
        }

        private void ToWin()
        {
            if (Turnlbl.Text == computer && btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
            {
                if (btn1.Text == oper2.ToString() && btn2.Text == oper2.ToString() && btn3.Text == "")
                {
                    btn3.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn1.Text == oper2.ToString() && btn4.Text == oper2.ToString() && btn7.Text == "")
                {
                    btn7.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn1.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn9.Text == "")
                {
                    btn9.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn2.Text == oper2.ToString() && btn3.Text == oper2.ToString() && btn1.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn2.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn8.Text == "")
                {
                    btn8.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn3.Text == oper2.ToString() && btn6.Text == oper2.ToString() && btn9.Text == "")
                {
                    btn9.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn3.Text == oper2.ToString() && btn1.Text == oper2.ToString() && btn2.Text == "")
                {
                    btn2.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn3.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn7.Text == "")
                {
                    btn7.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn3.Text == oper2.ToString() && btn9.Text == oper2.ToString() && btn6.Text == "")
                {
                    btn6.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn4.Text == oper2.ToString() && btn7.Text == oper2.ToString() && btn1.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn4.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn6.Text == "")
                {
                    btn6.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn5.Text == oper2.ToString() && btn6.Text == oper2.ToString() && btn4.Text == "")
                {
                    btn4.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn5.Text == oper2.ToString() && btn7.Text == oper2.ToString() && btn3.Text == "")
                {
                    btn3.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn5.Text == oper2.ToString() && btn9.Text == oper2.ToString() && btn1.Text == "")
                {
                    btn1.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn6.Text == oper2.ToString() && btn9.Text == oper2.ToString() && btn3.Text == "")
                {
                    btn3.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn6.Text == oper2.ToString() && btn4.Text == oper2.ToString() && btn5.Text == "")
                {
                    btn5.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn7.Text == oper2.ToString() && btn3.Text == oper2.ToString() && btn5.Text == "")
                {
                    btn5.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn7.Text == oper2.ToString() && btn8.Text == oper2.ToString() && btn9.Text == "")
                {
                    btn9.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn7.Text == oper2.ToString() && btn1.Text == oper2.ToString() && btn4.Text == "")
                {
                    btn4.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn8.Text == oper2.ToString() && btn9.Text == oper2.ToString() && btn7.Text == "")
                {
                    btn7.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn8.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn2.Text == "")
                {
                    btn2.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }

                else if (btn9.Text == oper2.ToString() && btn6.Text == oper2.ToString() && btn3.Text == "")
                {
                    btn3.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn9.Text == oper2.ToString() && btn7.Text == oper2.ToString() && btn8.Text == "")
                {
                    btn8.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else if (btn9.Text == oper2.ToString() && btn1.Text == oper2.ToString() && btn5.Text == "")
                {
                    btn5.Text = oper2.ToString();
                    returnvalue = 2;
                    Turnlbl.Text = "";
                }
                else
                {
                    returnvalue = 3;
                }
            }
        }

        private void PlayEasy()
        {
            if (Turnlbl.Text == computer && btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
            {
                if (click == 1)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn8.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            //else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            //{
                            //    if (btn1.Text == "")
                            //    {
                            //        btn1.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn2.Text == "")
                            //    {
                            //        btn2.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn3.Text == "")
                            //    {
                            //        btn3.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn4.Text == "")
                            //    {
                            //        btn4.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn5.Text == "")
                            //    {
                            //        btn5.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn6.Text == "")
                            //    {
                            //        btn6.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn7.Text == "")
                            //    {
                            //        btn7.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn8.Text == "")
                            //    {
                            //        btn8.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn9.Text == "")
                            //    {
                            //        btn9.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //}
                        }
                    }

                }
                else if (click == 2)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            //else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            //{
                            //    if (btn1.Text == "")
                            //    {
                            //        btn1.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn2.Text == "")
                            //    {
                            //        btn2.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn3.Text == "")
                            //    {
                            //        btn3.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn4.Text == "")
                            //    {
                            //        btn4.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn5.Text == "")
                            //    {
                            //        btn5.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn6.Text == "")
                            //    {
                            //        btn6.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn7.Text == "")
                            //    {
                            //        btn7.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn8.Text == "")
                            //    {
                            //        btn8.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //    else if (btn9.Text == "")
                            //    {
                            //        btn9.Text = oper2.ToString();
                            //        Turnlbl.Text = Player;
                            //    }
                            //}
                        }
                    }
                }
                else if (click == 3)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 4)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 5)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 6)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 7)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn9.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn3.Text == "" && btn9.Text == "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 8)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn3.Text == "" && btn7.Text == "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 9)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn7.Text == "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                    if (click == 1)
                    {
                        if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                //else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                //{
                                //    if (btn1.Text == "")
                                //    {
                                //        btn1.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn2.Text == "")
                                //    {
                                //        btn2.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn3.Text == "")
                                //    {
                                //        btn3.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn4.Text == "")
                                //    {
                                //        btn4.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn5.Text == "")
                                //    {
                                //        btn5.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn6.Text == "")
                                //    {
                                //        btn6.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn7.Text == "")
                                //    {
                                //        btn7.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn8.Text == "")
                                //    {
                                //        btn8.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn9.Text == "")
                                //    {
                                //        btn9.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //}
                            }
                        }

                    }
                    else if (click == 2)
                    {
                        if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                //else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                //{
                                //    if (btn1.Text == "")
                                //    {
                                //        btn1.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn2.Text == "")
                                //    {
                                //        btn2.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn3.Text == "")
                                //    {
                                //        btn3.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn4.Text == "")
                                //    {
                                //        btn4.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn5.Text == "")
                                //    {
                                //        btn5.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn6.Text == "")
                                //    {
                                //        btn6.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn7.Text == "")
                                //    {
                                //        btn7.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn8.Text == "")
                                //    {
                                //        btn8.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //    else if (btn9.Text == "")
                                //    {
                                //        btn9.Text = oper2.ToString();
                                //        Turnlbl.Text = Player;
                                //    }
                                //}
                            }
                        }
                    }
                    else if (click == 3)
                    {
                        if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                {
                                    if (btn1.Text == "")
                                    {
                                        btn1.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn2.Text == "")
                                    {
                                        btn2.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn3.Text == "")
                                    {
                                        btn3.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn4.Text == "")
                                    {
                                        btn4.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn5.Text == "")
                                    {
                                        btn5.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn6.Text == "")
                                    {
                                        btn6.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn7.Text == "")
                                    {
                                        btn7.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn8.Text == "")
                                    {
                                        btn8.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn9.Text == "")
                                    {
                                        btn9.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                }
                            }
                        }
                    }
                    else if (click == 4)
                    {
                        if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                {
                                    if (btn1.Text == "")
                                    {
                                        btn1.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn2.Text == "")
                                    {
                                        btn2.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn3.Text == "")
                                    {
                                        btn3.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn4.Text == "")
                                    {
                                        btn4.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn5.Text == "")
                                    {
                                        btn5.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn6.Text == "")
                                    {
                                        btn6.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn7.Text == "")
                                    {
                                        btn7.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn8.Text == "")
                                    {
                                        btn8.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn9.Text == "")
                                    {
                                        btn9.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                }
                            }
                        }
                    }
                    else if (click == 5)
                    {
                        if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                {
                                    if (btn1.Text == "")
                                    {
                                        btn1.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn2.Text == "")
                                    {
                                        btn2.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn3.Text == "")
                                    {
                                        btn3.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn4.Text == "")
                                    {
                                        btn4.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn5.Text == "")
                                    {
                                        btn5.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn6.Text == "")
                                    {
                                        btn6.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn7.Text == "")
                                    {
                                        btn7.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn8.Text == "")
                                    {
                                        btn8.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn9.Text == "")
                                    {
                                        btn9.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                }
                            }
                        }
                    }
                    else if (click == 6)
                    {
                        if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                {
                                    if (btn1.Text == "")
                                    {
                                        btn1.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn2.Text == "")
                                    {
                                        btn2.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn3.Text == "")
                                    {
                                        btn3.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn4.Text == "")
                                    {
                                        btn4.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn5.Text == "")
                                    {
                                        btn5.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn6.Text == "")
                                    {
                                        btn6.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn7.Text == "")
                                    {
                                        btn7.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn8.Text == "")
                                    {
                                        btn8.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn9.Text == "")
                                    {
                                        btn9.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                }
                            }
                        }
                    }
                    else if (click == 7)
                    {
                        if (btn1.Text == "" && btn3.Text != "" && btn9.Text != "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn3.Text == "" && btn9.Text != "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn3.Text != "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == "" && btn3.Text == "" && btn9.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                {
                                    if (btn1.Text == "")
                                    {
                                        btn1.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn2.Text == "")
                                    {
                                        btn2.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn3.Text == "")
                                    {
                                        btn3.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn4.Text == "")
                                    {
                                        btn4.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn5.Text == "")
                                    {
                                        btn5.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn6.Text == "")
                                    {
                                        btn6.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn7.Text == "")
                                    {
                                        btn7.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn8.Text == "")
                                    {
                                        btn8.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn9.Text == "")
                                    {
                                        btn9.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                }
                            }
                        }
                    }
                    else if (click == 8)
                    {
                        if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == "" && btn3.Text == "" && btn7.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                {
                                    if (btn1.Text == "")
                                    {
                                        btn1.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn2.Text == "")
                                    {
                                        btn2.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn3.Text == "")
                                    {
                                        btn3.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn4.Text == "")
                                    {
                                        btn4.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn5.Text == "")
                                    {
                                        btn5.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn6.Text == "")
                                    {
                                        btn6.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn7.Text == "")
                                    {
                                        btn7.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn8.Text == "")
                                    {
                                        btn8.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn9.Text == "")
                                    {
                                        btn9.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                }
                            }
                        }
                    }
                    else if (click == 9)
                    {
                        if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == "" && btn7.Text == "" && btn7.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else
                        {
                            if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else
                            {
                                if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                                {
                                    if (btn1.Text == "")
                                    {
                                        btn1.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn2.Text == "")
                                    {
                                        btn2.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn3.Text == "")
                                    {
                                        btn3.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn4.Text == "")
                                    {
                                        btn4.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn5.Text == "")
                                    {
                                        btn5.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn6.Text == "")
                                    {
                                        btn6.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn7.Text == "")
                                    {
                                        btn7.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn8.Text == "")
                                    {
                                        btn8.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                    else if (btn9.Text == "")
                                    {
                                        btn9.Text = oper2.ToString();
                                        Turnlbl.Text = Player;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void PlayNormal()
        {
            if (Turnlbl.Text == computer && btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
            {
                if (click == 1)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }

                }
                else if (click == 2)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn8.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 3)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 4)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 5)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 6)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 7)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn9.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn3.Text == "" && btn9.Text == "")
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;

                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 8)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn3.Text == "" && btn7.Text == "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 9)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn7.Text == "")
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void PlayHard()
        {
            if (Turnlbl.Text == computer && btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
            {
                if (click == 1)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;

                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;

                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 2)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn8.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 3)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 4)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 5)
                {
                    if (btn3.Text == "" && btn9.Text != "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text == "" && btn7.Text != "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text != "" && btn9.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn3.Text == "" && btn9.Text == "" && btn7.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }

                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 6)
                {
                    if (btn1.Text == "" && btn7.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text == "" && btn9.Text != "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn7.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn9.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn7.Text == oper2.ToString() && btn8.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn9.Text == "" && btn7.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn7.Text == "" && btn8.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 7)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn9.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn9.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn9.Text == "")
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn3.Text == "" && btn9.Text == "")
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;

                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 8)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn3.Text == "" && btn7.Text == "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn6.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn3.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn3.Text == "" && btn6.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn1.Text == oper2.ToString() && btn5.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn1.Text == "" && btn9.Text == "")
                        {
                            btn9.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn9.Text == oper2.ToString() && btn5.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
                else if (click == 9)
                {
                    if (btn1.Text == "" && btn3.Text != "" && btn7.Text != "")
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text == "" && btn7.Text != "")
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text != "" && btn3.Text != "" && btn7.Text == "")
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else if (btn1.Text == "" && btn7.Text == "" && btn7.Text == "")
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player;
                    }
                    else
                    {
                        if (btn4.Text == oper2.ToString() && btn5.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn4.Text == "" && btn6.Text == "")
                        {
                            btn6.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn6.Text == oper2.ToString() && btn5.Text == "" && btn4.Text == "")
                        {
                            btn4.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn2.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn2.Text == oper2.ToString() && btn1.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn3.Text == oper2.ToString() && btn2.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn1.Text == oper2.ToString() && btn4.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn4.Text == oper2.ToString() && btn1.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn4.Text == "" && btn1.Text == "")
                        {
                            btn1.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn2.Text == oper2.ToString() && btn5.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn2.Text == "" && btn8.Text == "")
                        {
                            btn8.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn8.Text == oper2.ToString() && btn5.Text == "" && btn2.Text == "")
                        {
                            btn2.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else if (btn3.Text == oper2.ToString() && btn5.Text == "" && btn7.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn5.Text == oper2.ToString() && btn7.Text == "" && btn3.Text == "")
                        {
                            btn7.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }
                        else if (btn7.Text == oper2.ToString() && btn5.Text == "" && btn3.Text == "")
                        {
                            btn3.Text = oper2.ToString();
                            Turnlbl.Text = Player;
                        }

                        else
                        {
                            if (btn1.Text == "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn1.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text == "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn2.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text == "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn3.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text == "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn4.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text == "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn5.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text == "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn6.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text == "" && btn8.Text != "" && btn9.Text != "")
                            {
                                btn7.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text == "" && btn9.Text != "")
                            {
                                btn8.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text == "")
                            {
                                btn9.Text = oper2.ToString();
                                Turnlbl.Text = Player;
                            }
                            else if (btn1.Text == "" || btn2.Text == "" || btn3.Text == "" || btn4.Text == "" || btn5.Text == "" || btn6.Text == "" || btn7.Text == "" || btn8.Text == "" || btn9.Text == "")
                            {
                                if (btn1.Text == "")
                                {
                                    btn1.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn2.Text == "")
                                {
                                    btn2.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn3.Text == "")
                                {
                                    btn3.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn4.Text == "")
                                {
                                    btn4.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn5.Text == "")
                                {
                                    btn5.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn6.Text == "")
                                {
                                    btn6.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn7.Text == "")
                                {
                                    btn7.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn8.Text == "")
                                {
                                    btn8.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                                else if (btn9.Text == "")
                                {
                                    btn9.Text = oper2.ToString();
                                    Turnlbl.Text = Player;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Turnlbl_TextChanged(object sender, EventArgs e)
        {
            if (Turnlbl.Text == computer && btn1.BackColor != Color.Green && btn2.BackColor != Color.Green && btn3.BackColor != Color.Green && btn4.BackColor != Color.Green && btn5.BackColor != Color.Green && btn6.BackColor != Color.Green && btn7.BackColor != Color.Green && btn8.BackColor != Color.Green && btn9.BackColor != Color.Green)
            {
                if (radiobtn == 1)
                {
                    ToWin();
                    if (returnvalue == 3)
                    {
                        //No need for Losetheanotherplayer() function as it EASY mode.
                        PlayEasy();
                    }
                }
                else if (radiobtn == 2)
                {
                    ToWin();
                    if (returnvalue == 3)
                    {
                        Losetheanotherplayer();
                        if (returnvalue == 0)
                        {
                            PlayNormal();
                        }
                    }
                }
                else if (radiobtn == 3)
                {
                    ToWin();
                    if (returnvalue == 3)
                    {
                        Losetheanotherplayer();
                        if (returnvalue == 0)
                        {
                            PlayHard();
                        }
                    }
                }
            }
        }

        private void OnePlayerfrm_Load(object sender, EventArgs e)
        {
            if (radiobtn == 1)
            {
                label3.Text = "Easy";
            }
            else if (radiobtn == 2)
            {
                label3.Text = "Normal";
            }
            else if (radiobtn == 3)
            {
                label3.Text = "Hard";
            }
            TheGame();
        }
    }
}