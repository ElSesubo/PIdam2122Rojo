﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floridapp.UserControls
{
    public partial class RealizarReservaBiblioteca : UserControl
    {
        public RealizarReservaBiblioteca()
        {
            InitializeComponent();
        }

        private void RealizarReservaBiblioteca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSala.Checked == false)
            {
                cbSalas.Enabled = false;
            }
            else
            {
                cbSalas.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
