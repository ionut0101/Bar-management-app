using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UIComponents.Primitives
{
    public partial class RouteName : UserControl
    {

        public string RouteTitle { get; set; } = "Your text goes here...";
        public Color RouteColor { get; set; } = Color.FromArgb(31, 180, 86);

        public RouteName()
        {
            InitializeComponent();
        }

        private void RouteName_Load(object sender, EventArgs e)
        {
            label.Text = RouteTitle;
            label.ForeColor = RouteColor;
        }
    }
}
