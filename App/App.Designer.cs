namespace App
{
    partial class PrimaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.authButton = new App.UIComponents.CommandButton();
            this.passwordField = new App.UIComponents.InputField();
            this.nameField = new App.UIComponents.InputField();
            this.controlButton2 = new App.UIComponents.ControlButton();
            this.controlButton1 = new App.UIComponents.ControlButton();
            this.routeName1 = new App.UIComponents.Primitives.RouteName();
            this.SuspendLayout();
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckBox.Location = new System.Drawing.Point(30, 266);
            this.passwordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(119, 23);
            this.passwordCheckBox.TabIndex = 11;
            this.passwordCheckBox.Text = "Arata parola";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.passwordCheckbox_CheckedChanged);
            // 
            // authButton
            // 
            this.authButton.BackColor = System.Drawing.Color.White;
            this.authButton.CommandBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.authButton.CommandBackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(246)))), ((int)(((byte)(217)))));
            this.authButton.CommandBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.authButton.CommandBorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.authButton.CommandEnabled = true;
            this.authButton.CommandHeight = 60;
            this.authButton.CommandText = "Autentificare";
            this.authButton.CommandTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.authButton.CommandTextColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.authButton.CommandWidth = 340;
            this.authButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authButton.Location = new System.Drawing.Point(30, 334);
            this.authButton.Margin = new System.Windows.Forms.Padding(0);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(340, 60);
            this.authButton.TabIndex = 12;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.FieldPassword = '*';
            this.passwordField.FieldPlaceholder = "Parola ta...";
            this.passwordField.FieldText = null;
            this.passwordField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.passwordField.FieldTitle = "Parola";
            this.passwordField.FieldWidth = 340;
            this.passwordField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(30, 192);
            this.passwordField.Margin = new System.Windows.Forms.Padding(0);
            this.passwordField.Name = "passwordField";
            this.passwordField.Padding = new System.Windows.Forms.Padding(4);
            this.passwordField.Size = new System.Drawing.Size(340, 52);
            this.passwordField.TabIndex = 9;
            this.passwordField.TabStop = false;
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.White;
            this.nameField.FieldPassword = '\0';
            this.nameField.FieldPlaceholder = "Numele tau...";
            this.nameField.FieldText = "";
            this.nameField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nameField.FieldTitle = "Nume";
            this.nameField.FieldWidth = 340;
            this.nameField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(30, 117);
            this.nameField.Margin = new System.Windows.Forms.Padding(0);
            this.nameField.Name = "nameField";
            this.nameField.Padding = new System.Windows.Forms.Padding(4);
            this.nameField.Size = new System.Drawing.Size(340, 52);
            this.nameField.TabIndex = 8;
            this.nameField.TabStop = false;
            // 
            // controlButton2
            // 
            this.controlButton2.BackColor = System.Drawing.Color.Transparent;
            this.controlButton2.CustomText = "_";
            this.controlButton2.Location = new System.Drawing.Point(292, 0);
            this.controlButton2.Margin = new System.Windows.Forms.Padding(0);
            this.controlButton2.Name = "controlButton2";
            this.controlButton2.Size = new System.Drawing.Size(51, 50);
            this.controlButton2.TabIndex = 7;
            this.controlButton2.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // controlButton1
            // 
            this.controlButton1.BackColor = System.Drawing.Color.Transparent;
            this.controlButton1.CustomText = "x";
            this.controlButton1.Location = new System.Drawing.Point(349, 0);
            this.controlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.controlButton1.Name = "controlButton1";
            this.controlButton1.Size = new System.Drawing.Size(51, 50);
            this.controlButton1.TabIndex = 6;
            this.controlButton1.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // routeName1
            // 
            this.routeName1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeName1.Location = new System.Drawing.Point(30, 49);
            this.routeName1.Margin = new System.Windows.Forms.Padding(0);
            this.routeName1.Name = "routeName1";
            this.routeName1.RouteColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.routeName1.RouteTitle = "Intrare în cont";
            this.routeName1.Size = new System.Drawing.Size(340, 50);
            this.routeName1.TabIndex = 13;
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 415);
            this.Controls.Add(this.routeName1);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.controlButton2);
            this.Controls.Add(this.controlButton1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrimaryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "None";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIComponents.ControlButton controlButton1;
        private UIComponents.ControlButton controlButton2;
        private UIComponents.InputField nameField;
        private UIComponents.InputField passwordField;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private UIComponents.CommandButton authButton;
        private UIComponents.Primitives.RouteName routeName1;
    }
}

