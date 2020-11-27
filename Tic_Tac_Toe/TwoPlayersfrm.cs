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
    public partial class TwoPlayersfrm : Form
    {
        string Player1, PLayer2;
        char oper, oper2;
        byte click = 0, rec = 0;
        int P1S = 0, P2S = 0;

        public TwoPlayersfrm()
        {
            InitializeComponent();
        }

        public TwoPlayersfrm(string p1, string p2, char OP, char OP2)
        {
            Player1 = p1;
            PLayer2 = p2;
            oper = OP;
            oper2 = OP2;
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
                if (btn1.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn1.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn1.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (btn2.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn2.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn2.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (btn3.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn3.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn3.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (btn4.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn4.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn4.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (btn5.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn5.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn5.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (btn6.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn6.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn6.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (btn7.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn7.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn7.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
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
                btn8.Text = btn8.Text;
            }
            else
            {
                if (btn8.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn8.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn8.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (btn9.Text == "")
                {
                    if (Turnlbl.Text == Player1)
                    {
                        btn9.Text = oper.ToString();
                        Turnlbl.Text = PLayer2;
                    }
                    else
                    {
                        btn9.Text = oper2.ToString();
                        Turnlbl.Text = Player1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Move :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Win();
                Player1Score.Text = P1S.ToString();
                Player2Score.Text = P2S.ToString();
            }
        }

        private void TwoPlayersfrm_Load(object sender, EventArgs e)
        {
            TheGame();
        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {
            TheGame();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            rec = 1;
            this.Close();
            TwoPlayersfrmDetails f1 = new TwoPlayersfrmDetails();
            f1.Show();
            FirstForm f2 = new FirstForm();
            f2.Close();
        }

        private void TwoPlayersfrm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void TheGame()
        {
            label4.Show();
            Turnlbl.Show();
            click = 0;
            rec = 0;
            Turnlbl.Text = Player1;
            Player1Scorelbl.Text = Player1;
            Player2Scorelbl.Text = PLayer2;
            Player1Score.Text = P1S.ToString();
            Player2Score.Text = P2S.ToString();
            Player1lbl.Text = Player1 + " = " + oper;
            Player2lbl.Text = PLayer2 + " = " + oper2;
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
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn2.Text == oper.ToString() && btn5.Text == oper.ToString() && btn8.Text == oper.ToString())
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn3.Text == oper.ToString() && btn6.Text == oper.ToString() && btn9.Text == oper.ToString())
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn1.Text == oper.ToString() && btn2.Text == oper.ToString() && btn3.Text == oper.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn4.Text == oper.ToString() && btn5.Text == oper.ToString() && btn6.Text == oper.ToString())
            {
                btn5.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn7.Text == oper.ToString() && btn8.Text == oper.ToString() && btn9.Text == oper.ToString())
            {
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn1.Text == oper.ToString() && btn5.Text == oper.ToString() && btn9.Text == oper.ToString())
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn3.Text == oper.ToString() && btn5.Text == oper.ToString() && btn7.Text == oper.ToString())
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                P1S++;
                MessageBox.Show(Player1 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }

            else if (btn1.Text == oper2.ToString() && btn4.Text == oper2.ToString() && btn7.Text == oper2.ToString())
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn2.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn8.Text == oper2.ToString())
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn3.Text == oper2.ToString() && btn6.Text == oper2.ToString() && btn9.Text == oper2.ToString())
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn1.Text == oper2.ToString() && btn2.Text == oper2.ToString() && btn3.Text == oper2.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn4.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn6.Text == oper2.ToString())
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn7.Text == oper2.ToString() && btn8.Text == oper2.ToString() && btn9.Text == oper2.ToString())
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn1.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn9.Text == oper2.ToString())
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }
            else if (btn3.Text == oper2.ToString() && btn5.Text == oper2.ToString() && btn7.Text == oper2.ToString())
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                P2S++;
                MessageBox.Show(PLayer2 + " Wins :D ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                Turnlbl.Text = "";
            }

            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("Equality ;)");
                Turnlbl.Text = "";
            }
        }
    }
}