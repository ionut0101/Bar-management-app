using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UIComponents
{
    public partial class ControlButton : UserControl
    {
        public string CustomText { get; set; }

        public ControlButton()
        {
            InitializeComponent();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            button.ForeColor = Color.Red;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            button.ForeColor = Color.Gray;
        }

        private void button_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void ControlButton_Paint(object sender, PaintEventArgs e)
        {
            button.Text = CustomText;
        }
    }
}
