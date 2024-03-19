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
    public partial class Register : Draggable
    {
        public Register()
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            string userName = nameField.Text;
            string password = passwordField.Text;
            string passwordConfirm = passwordConfirmField.Text;

            MessageBox.Show($"Nume :\t{userName}\nParola :\t{password}\nConfirm :\t{passwordConfirm}");
        }

        private void passwordCheckBox_Click(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked)
            {
                passwordField.FieldPassword = '\0';
                passwordConfirmField.FieldPassword = '\0';
            }
            else
            {
                passwordField.FieldPassword = '*';
                passwordConfirmField.FieldPassword = '*';
            }
        }

        private void authLink_Click(object sender, EventArgs e)
        {
            this.Hide();

            Authentication authWindow = new Authentication();
            authWindow.Show();
        }
    }
}
