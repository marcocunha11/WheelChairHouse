﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelChairHouse
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChairControl CC = new ChairControl();
            CC.ShowDialog();
            this.Visible = true;
        }
    }
}
