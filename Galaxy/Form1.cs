﻿using Galaxy.Class;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.UserControl1 u1 = new Class.UserControl1(this);
            metroPanel1.Controls.Add(u1);
            u1.Dock = DockStyle.Fill;
            u1.BringToFront();
        }

        public void seen(UserControl UC)
        {
            switch (UC.Name)
            {
                case "UserControl1":
                    if (metroPanel1.Controls.Contains(UserControl1.instance))
                    {

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
