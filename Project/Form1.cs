﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button23_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Center.openConnection();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
