using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.UIComponents
{
    public partial class InputField : UserControl
    {

        private string previousText = string.Empty;
        private char passwordChar = '\0';

        [DefaultValue("Title")]
        public string FieldTitle { get; set; }
        public string FieldText { get; set; }
        public string FieldPlaceholder { get; set; }
        public Color FieldTextColor { get; set; } = Color.FromArgb(15, 23, 42);
        private Color FieldPlaceholderColor { get; set; } = Color.FromArgb(71, 85, 105);
        private Color FieldTitleColor { get; set; } = Color.FromArgb(100, 116, 139);
        public int FieldWidth { get; set; } = 250;

        public char FieldPassword
        {
            get
            {
                return passwordChar;
            }
            set
            {
                passwordChar = value;
                textBox.PasswordChar = value;
            }
        }

        [DefaultValue(false)]
        public bool FieldFocus { get; set; }

        public InputField()
        {
            InitializeComponent();
            this.TabStop = FieldFocus;
        }

        public override string Text
        {
            get
            {
                return previousText;
            }
        }

        private void InputField_Load(object sender, EventArgs e)
        {
            textBox.Width = FieldWidth;
            this.Width = FieldWidth;
        }

        private void InputField_Paint(object sender, PaintEventArgs e)
        {
            label.Text = FieldTitle;
            label.ForeColor = FieldTitleColor;

            if( FieldPassword != '\0' )
            {
                textBox.PasswordChar = FieldPassword;
            }

            if ( FieldText == null || FieldText.Length == 0 )
            {
                textBox.Text = FieldPlaceholder;
                if ( FieldPassword == '\0' )
                {
                    textBox.ForeColor = FieldPlaceholderColor;
                }
            } 
            else
            {
                textBox.Text = FieldText;
                textBox.ForeColor = FieldTextColor;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            previousText = textBox.Text;

            if ( textBox.Text == "" )
            {
                textBox.Text = FieldPlaceholder;
                textBox.ForeColor = FieldPlaceholderColor;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if ( textBox.Text == FieldPlaceholder && previousText != FieldPlaceholder )
            {
                textBox.Text = "";
                textBox.ForeColor = FieldTextColor;
            }
        }
    }
}
