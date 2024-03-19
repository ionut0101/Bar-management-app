namespace App.UIComponents.Routes
{
    partial class Authentication
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
            this.closeButton = new App.UIComponents.ControlButton();
            this.minimizeButton = new App.UIComponents.ControlButton();
            this.nameField = new App.UIComponents.InputField();
            this.passwordField = new App.UIComponents.InputField();
            this.authButton = new App.UIComponents.CommandButton();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.routeName1 = new App.UIComponents.Primitives.RouteName();
            this.formLink1 = new App.UIComponents.Primitives.FormLink();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.CustomText = "x";
            this.closeButton.Location = new System.Drawing.Point(349, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(51, 50);
            this.closeButton.TabIndex = 0;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.CustomText = "_";
            this.minimizeButton.Location = new System.Drawing.Point(292, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(51, 50);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.White;
            this.nameField.FieldFocus = false;
            this.nameField.FieldPassword = '\0';
            this.nameField.FieldPlaceholder = "Numele tau...";
            this.nameField.FieldPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.nameField.FieldText = null;
            this.nameField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nameField.FieldTitle = "Nume";
            this.nameField.FieldTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.nameField.FieldWidth = 340;
            this.nameField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(30, 119);
            this.nameField.Margin = new System.Windows.Forms.Padding(0);
            this.nameField.Name = "nameField";
            this.nameField.Padding = new System.Windows.Forms.Padding(4);
            this.nameField.Size = new System.Drawing.Size(340, 52);
            this.nameField.TabIndex = 2;
            this.nameField.TabStop = false;
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.FieldFocus = false;
            this.passwordField.FieldPassword = '*';
            this.passwordField.FieldPlaceholder = "Parola ta...";
            this.passwordField.FieldPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.passwordField.FieldText = null;
            this.passwordField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.passwordField.FieldTitle = "Parola";
            this.passwordField.FieldTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.passwordField.FieldWidth = 340;
            this.passwordField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(30, 194);
            this.passwordField.Margin = new System.Windows.Forms.Padding(0);
            this.passwordField.Name = "passwordField";
            this.passwordField.Padding = new System.Windows.Forms.Padding(4);
            this.passwordField.Size = new System.Drawing.Size(340, 52);
            this.passwordField.TabIndex = 3;
            this.passwordField.TabStop = false;
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
            this.authButton.Location = new System.Drawing.Point(29, 327);
            this.authButton.Margin = new System.Windows.Forms.Padding(0);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(340, 60);
            this.authButton.TabIndex = 13;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckBox.Location = new System.Drawing.Point(29, 268);
            this.passwordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(119, 23);
            this.passwordCheckBox.TabIndex = 12;
            this.passwordCheckBox.Text = "Arata parola";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.Click += new System.EventHandler(this.passwordCheckBox_Click);
            // 
            // routeName1
            // 
            this.routeName1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeName1.Location = new System.Drawing.Point(30, 51);
            this.routeName1.Margin = new System.Windows.Forms.Padding(0);
            this.routeName1.Name = "routeName1";
            this.routeName1.RouteColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.routeName1.RouteTitle = "Intrare în cont";
            this.routeName1.Size = new System.Drawing.Size(340, 50);
            this.routeName1.TabIndex = 14;
            // 
            // formLink1
            // 
            this.formLink1.BackColor = System.Drawing.Color.White;
            this.formLink1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.formLink1.LinkColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.formLink1.LinkHeight = 50;
            this.formLink1.LinkText = "Inregistreaza-te";
            this.formLink1.LinkWidth = 340;
            this.formLink1.Location = new System.Drawing.Point(29, 398);
            this.formLink1.Margin = new System.Windows.Forms.Padding(0);
            this.formLink1.Name = "formLink1";
            this.formLink1.Size = new System.Drawing.Size(340, 50);
            this.formLink1.TabIndex = 15;
            this.formLink1.Click += new System.EventHandler(this.registerLink_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 452);
            this.Controls.Add(this.formLink1);
            this.Controls.Add(this.routeName1);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlButton closeButton;
        private ControlButton minimizeButton;
        private InputField nameField;
        private InputField passwordField;
        private CommandButton authButton;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private Primitives.RouteName routeName1;
        private Primitives.FormLink formLink1;
    }
}