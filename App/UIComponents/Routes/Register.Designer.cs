namespace App.UIComponents.Routes
{
    partial class Register
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
            this.passwordConfirmField = new App.UIComponents.InputField();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.registerButton = new App.UIComponents.CommandButton();
            this.routeName1 = new App.UIComponents.Primitives.RouteName();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.CustomText = "x";
            this.closeButton.Location = new System.Drawing.Point(349, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(51, 50);
            this.closeButton.TabIndex = 0;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.CustomText = "_";
            this.minimizeButton.Location = new System.Drawing.Point(292, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(51, 50);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.White;
            this.nameField.FieldPassword = '\0';
            this.nameField.FieldPlaceholder = "Numele tau...";
            this.nameField.FieldText = null;
            this.nameField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nameField.FieldTitle = "Nume";
            this.nameField.FieldWidth = 340;
            this.nameField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(29, 109);
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
            this.passwordField.FieldPassword = '*';
            this.passwordField.FieldPlaceholder = "Parola ta...";
            this.passwordField.FieldText = null;
            this.passwordField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.passwordField.FieldTitle = "Parola";
            this.passwordField.FieldWidth = 340;
            this.passwordField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(29, 181);
            this.passwordField.Margin = new System.Windows.Forms.Padding(0);
            this.passwordField.Name = "passwordField";
            this.passwordField.Padding = new System.Windows.Forms.Padding(4);
            this.passwordField.Size = new System.Drawing.Size(340, 52);
            this.passwordField.TabIndex = 3;
            this.passwordField.TabStop = false;
            // 
            // passwordConfirmField
            // 
            this.passwordConfirmField.BackColor = System.Drawing.Color.White;
            this.passwordConfirmField.FieldPassword = '*';
            this.passwordConfirmField.FieldPlaceholder = "Parola ta...";
            this.passwordConfirmField.FieldText = null;
            this.passwordConfirmField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.passwordConfirmField.FieldTitle = "Confirmare parola";
            this.passwordConfirmField.FieldWidth = 340;
            this.passwordConfirmField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfirmField.Location = new System.Drawing.Point(29, 253);
            this.passwordConfirmField.Margin = new System.Windows.Forms.Padding(0);
            this.passwordConfirmField.Name = "passwordConfirmField";
            this.passwordConfirmField.Padding = new System.Windows.Forms.Padding(4);
            this.passwordConfirmField.Size = new System.Drawing.Size(340, 52);
            this.passwordConfirmField.TabIndex = 4;
            this.passwordConfirmField.TabStop = false;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Location = new System.Drawing.Point(29, 328);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(107, 20);
            this.passwordCheckBox.TabIndex = 5;
            this.passwordCheckBox.Text = "Arata parola";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.Click += new System.EventHandler(this.passwordCheckBox_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.CommandBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.registerButton.CommandBackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(246)))), ((int)(((byte)(217)))));
            this.registerButton.CommandBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.registerButton.CommandBorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.registerButton.CommandEnabled = true;
            this.registerButton.CommandHeight = 60;
            this.registerButton.CommandText = "Creeaza Cont";
            this.registerButton.CommandTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.registerButton.CommandTextColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.registerButton.CommandWidth = 340;
            this.registerButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(29, 391);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(340, 60);
            this.registerButton.TabIndex = 6;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // routeName1
            // 
            this.routeName1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeName1.Location = new System.Drawing.Point(30, 49);
            this.routeName1.Margin = new System.Windows.Forms.Padding(0);
            this.routeName1.Name = "routeName1";
            this.routeName1.RouteColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.routeName1.RouteTitle = "Înregistrare cont";
            this.routeName1.Size = new System.Drawing.Size(340, 50);
            this.routeName1.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 471);
            this.Controls.Add(this.routeName1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.passwordConfirmField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlButton closeButton;
        private ControlButton minimizeButton;
        private InputField nameField;
        private InputField passwordField;
        private InputField passwordConfirmField;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private CommandButton registerButton;
        private Primitives.RouteName routeName1;
    }
}