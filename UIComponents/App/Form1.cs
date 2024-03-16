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

        private void PrimaryForm_Load(object sender, EventArgs e)
        {

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
    }
}
