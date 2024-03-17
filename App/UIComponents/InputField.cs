﻿using System;
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

        [DefaultValue("Title")]
        public string FieldTitle { get; set; }
        public string FieldText{ get; set; }
        public string FieldPlaceholder { get; set; }

        private Color fieldTextColor = Color.FromArgb( 15, 23, 42 );
        private Color fieldPlaceholderColor = Color.FromArgb( 71, 85, 105 );
        private Color fieldTitleColor = Color.FromArgb( 100, 116, 139 );
        
        public Color FieldTextColor
        {
            get { return fieldTextColor; }
            set
            {
                fieldTextColor = value;
            }
        }

        public Color FieldPlaceholderColor
        {
            get { return fieldPlaceholderColor; }
            set
            {
                fieldPlaceholderColor = value;
            }
        }

        public Color FieldTitleColor
        {
            get { return fieldTitleColor; }
            set
            {
                fieldTitleColor = value;
            }
        }

        [DefaultValue( '\0' )]
        public char FieldPassword { get; set; }

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

        private void InputField_Paint(object sender, PaintEventArgs e)
        {
            label.Text = FieldTitle;
            label.ForeColor = fieldTitleColor;

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
