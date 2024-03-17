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
            this.authButton = new System.Windows.Forms.Button();
            this.passwordCheckbox = new System.Windows.Forms.CheckBox();
            this.passwordField = new App.UIComponents.InputField();
            this.nameField = new App.UIComponents.InputField();
            this.controlButton2 = new App.UIComponents.ControlButton();
            this.controlButton1 = new App.UIComponents.ControlButton();
            this.SuspendLayout();
            // 
            // authButton
            // 
            this.authButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authButton.Location = new System.Drawing.Point(30, 300);
            this.authButton.Margin = new System.Windows.Forms.Padding(0);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(340, 57);
            this.authButton.TabIndex = 2;
            this.authButton.Text = "Autentificare";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // passwordCheckbox
            // 
            this.passwordCheckbox.AutoSize = true;
            this.passwordCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckbox.Location = new System.Drawing.Point(30, 226);
            this.passwordCheckbox.Name = "passwordCheckbox";
            this.passwordCheckbox.Size = new System.Drawing.Size(119, 23);
            this.passwordCheckbox.TabIndex = 7;
            this.passwordCheckbox.Text = "Arata parola";
            this.passwordCheckbox.UseVisualStyleBackColor = true;
            this.passwordCheckbox.CheckedChanged += new System.EventHandler(this.passwordCheckbox_CheckedChanged);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.FieldPassword = '*';
            this.passwordField.FieldPlaceholder = "Parola ta...";
            this.passwordField.FieldPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.passwordField.FieldText = null;
            this.passwordField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.passwordField.FieldTitle = "Parola";
            this.passwordField.FieldTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.passwordField.FieldWidth = 340;
            this.passwordField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(30, 150);
            this.passwordField.Margin = new System.Windows.Forms.Padding(0);
            this.passwordField.Name = "passwordField";
            this.passwordField.Padding = new System.Windows.Forms.Padding(4);
            this.passwordField.Size = new System.Drawing.Size(340, 52);
            this.passwordField.TabIndex = 6;
            this.passwordField.TabStop = false;
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.White;
            this.nameField.FieldPassword = '\0';
            this.nameField.FieldPlaceholder = "Numele tau...";
            this.nameField.FieldPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.nameField.FieldText = "";
            this.nameField.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nameField.FieldTitle = "Nume";
            this.nameField.FieldTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.nameField.FieldWidth = 340;
            this.nameField.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(30, 78);
            this.nameField.Margin = new System.Windows.Forms.Padding(0);
            this.nameField.Name = "nameField";
            this.nameField.Padding = new System.Windows.Forms.Padding(4);
            this.nameField.Size = new System.Drawing.Size(340, 52);
            this.nameField.TabIndex = 5;
            this.nameField.TabStop = false;
            // 
            // controlButton2
            // 
            this.controlButton2.BackColor = System.Drawing.Color.Transparent;
            this.controlButton2.CustomText = "_";
            this.controlButton2.Location = new System.Drawing.Point(292, 0);
            this.controlButton2.Margin = new System.Windows.Forms.Padding(4);
            this.controlButton2.Name = "controlButton2";
            this.controlButton2.Size = new System.Drawing.Size(50, 50);
            this.controlButton2.TabIndex = 4;
            this.controlButton2.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // controlButton1
            // 
            this.controlButton1.BackColor = System.Drawing.Color.Transparent;
            this.controlButton1.CustomText = "x";
            this.controlButton1.Location = new System.Drawing.Point(350, 0);
            this.controlButton1.Margin = new System.Windows.Forms.Padding(4);
            this.controlButton1.Name = "controlButton1";
            this.controlButton1.Size = new System.Drawing.Size(50, 50);
            this.controlButton1.TabIndex = 3;
            this.controlButton1.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.passwordCheckbox);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.controlButton2);
            this.Controls.Add(this.controlButton1);
            this.Controls.Add(this.authButton);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrimaryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "None";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrimaryForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PrimaryForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PrimaryForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button authButton;
        private UIComponents.ControlButton controlButton1;
        private UIComponents.ControlButton controlButton2;
        private UIComponents.InputField nameField;
        private UIComponents.InputField passwordField;
        private System.Windows.Forms.CheckBox passwordCheckbox;
    }
}

