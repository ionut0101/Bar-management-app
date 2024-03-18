using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.UIComponents
{
    public partial class CommandButton : UserControl
    {

        public string CommandText { get; set; } = "Button";
        public Color CommandTextColor { get; set; } = Color.FromArgb(15, 23, 42);
        public Color CommandTextColorHover { get; set; } = Color.FromArgb(17, 24, 39);
        public bool CommandEnabled { get; set; } = true;
        public Color CommandBackgroundColor { get; set; } = Color.FromArgb(244, 244, 245);
        public Color CommandBackgroundColorHover { get; set; } = Color.FromArgb(201, 246, 217);
        public Color CommandBorderColor { get; set; } = Color.FromArgb(244, 244, 245);
        public Color CommandBorderColorHover { get; set; } = Color.FromArgb(31, 180, 86);
        public int CommandWidth { get; set; } = 250;
        public int CommandHeight { get; set; } = 60;

        public CommandButton()
        {
            InitializeComponent();
        }

        private void CommandButton_Load(object sender, EventArgs e)
        {
            button.Enabled = CommandEnabled;
            button.ForeColor = CommandTextColor;
            button.BackColor = CommandBackgroundColor;

            button.Text = CommandText;
            button.Width = CommandWidth;
            button.Height = CommandHeight;
            button.FlatAppearance.BorderColor = CommandBorderColor;

            this.Width = CommandWidth;
            this.Height = CommandHeight;
        }

        private void button_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            button.BackColor = CommandBackgroundColorHover;
            button.FlatAppearance.BorderColor = CommandBorderColorHover;
            button.ForeColor = CommandTextColorHover;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            button.BackColor = CommandBackgroundColor;
            button.FlatAppearance.BorderColor = CommandBorderColor;
            button.ForeColor = CommandTextColor;
        }
    }
}
