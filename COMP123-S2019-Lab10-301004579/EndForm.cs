﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301004579
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            //this.Hide();
            Program.endForm.Hide();
            Program.mainForm.Show();
        }

        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
