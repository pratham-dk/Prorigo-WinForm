﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text;
            string b = textBox1.Text;   
            string c = textBox3.Text;
            string d = textBox4.Text;

            lblOutput.Text = a + " " + b + " " + c + " " + d;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

      
    }
}
