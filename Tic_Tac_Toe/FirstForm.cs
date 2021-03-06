﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void OnePlayerbtn_Click(object sender, EventArgs e)
        {
            OnePlayerfrmDetails f1 = new OnePlayerfrmDetails();
            f1.Show();
            this.Hide();
        }

        private void TwoPlayersbtn_Click(object sender, EventArgs e)
        {

            TwoPlayersfrmDetails fi = new TwoPlayersfrmDetails();
            fi.Show();
            this.Hide();
        }

        private void FirstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
