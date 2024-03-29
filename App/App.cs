﻿using App.Classes;
using App.UIComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class PrimaryForm : Draggable
    {
        public PrimaryForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void passwordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if ( passwordCheckBox.Checked == true )
            {
                passwordField.FieldPassword = '\0';
            }
            else
            {
                passwordField.FieldPassword = '*';
            }
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            
            string userName = nameField.Text;
            string password = passwordField.Text;

            MessageBox.Show($"Username :\t{userName}\nPassword :\t{password}");
        }

    }
}
