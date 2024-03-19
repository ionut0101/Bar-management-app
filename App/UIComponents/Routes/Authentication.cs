using App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UIComponents.Routes
{
    public partial class Authentication : Draggable
    {
        public Authentication()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void passwordCheckBox_Click(object sender, EventArgs e)
        {
            if( passwordCheckBox.Checked )
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

        private void registerLink_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register registerWindow = new Register();
            registerWindow.Show();
        }
    }
}
