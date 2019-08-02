﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstCity.GetItemText(lstCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;

            MessageBox.Show(name + address);
        }
    }
}
