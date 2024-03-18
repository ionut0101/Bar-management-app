using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Classes
{
    public class Draggable : Form
    {
        private bool draggingState = false;
        private Point mouseLocation = new Point(0, 0);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            draggingState = true;
            mouseLocation = e.Location;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
           base.OnMouseUp(e);
           draggingState = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
           base.OnMouseMove(e);
           if ( draggingState )
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
