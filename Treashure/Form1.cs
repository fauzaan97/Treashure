﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treashure
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int rBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private void Signup_Load(object sender, EventArgs e)
        {
            btnSignUp2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp2.Width, btnSignUp2.Height, 30, 30));
            btnLogin2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp.Width, btnSignUp.Height, 30, 30));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
