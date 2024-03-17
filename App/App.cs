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
    public partial class PrimaryForm : Form
    {

        private bool draggingState = false;
        private Point mouseLocation = new Point(0,0);

        public PrimaryForm()
        {
            InitializeComponent();
        }

        private void PrimaryForm_MouseDown(object sender, MouseEventArgs e)
        {
            draggingState = true;
            mouseLocation = e.Location;
        }

        private void PrimaryForm_MouseUp(object sender, MouseEventArgs e)
        {
            draggingState = false;
        }

        private void PrimaryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if( draggingState)
            {
                Point nextLocation = 
                    new Point(
                        this.Location.X - mouseLocation.X + e.X,
                        this.Location.Y - mouseLocation.Y + e.Y
                    );

                this.Location = nextLocation;
            }
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
            if (passwordCheckbox.Checked)
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
