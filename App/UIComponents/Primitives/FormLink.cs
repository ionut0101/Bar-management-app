using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.UIComponents.Primitives
{
    public partial class FormLink : UserControl
    {

        public string LinkText { get; set; } = "Your text goes here...";
        public Color LinkColor { get; set; } = Color.FromArgb(71, 85, 105);
        public Color LinkColorHover { get; set; } = Color.FromArgb(31, 180, 86);
        public int LinkWidth { get; set; } = 250;
        public int LinkHeight { get; set; } = 40;

        public FormLink()
        {
            InitializeComponent();
        }

        private void Link_Load(object sender, EventArgs e)
        {
            button.Text = LinkText;
            button.Height = LinkHeight;
            button.Width = LinkWidth;
            button.ForeColor = LinkColor;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;

            this.Width = LinkWidth;
            this.Height = LinkHeight;
        }

        private void button_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            button.ForeColor = LinkColorHover;
            button.Font = new Font( button.Font, FontStyle.Underline );
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            button.ForeColor = LinkColor;
            button.Font = new Font( button.Font, FontStyle.Regular );
        }
    }
}
