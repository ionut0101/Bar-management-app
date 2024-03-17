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
            this.button1 = new System.Windows.Forms.Button();
            this.inputField2 = new App.UIComponents.InputField();
            this.inputField1 = new App.UIComponents.InputField();
            this.controlButton2 = new App.UIComponents.ControlButton();
            this.controlButton1 = new App.UIComponents.ControlButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputField2
            // 
            this.inputField2.BackColor = System.Drawing.Color.White;
            this.inputField2.FieldPassword = '*';
            this.inputField2.FieldPlaceholder = "Parola ta...";
            this.inputField2.FieldPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.inputField2.FieldText = null;
            this.inputField2.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.inputField2.FieldTitle = "Parola";
            this.inputField2.FieldTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.inputField2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputField2.Location = new System.Drawing.Point(28, 156);
            this.inputField2.Margin = new System.Windows.Forms.Padding(0);
            this.inputField2.Name = "inputField2";
            this.inputField2.Padding = new System.Windows.Forms.Padding(4);
            this.inputField2.Size = new System.Drawing.Size(340, 52);
            this.inputField2.TabIndex = 6;
            this.inputField2.TabStop = false;
            // 
            // inputField1
            // 
            this.inputField1.BackColor = System.Drawing.Color.White;
            this.inputField1.FieldPlaceholder = "Numele tau...";
            this.inputField1.FieldPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.inputField1.FieldText = "";
            this.inputField1.FieldTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.inputField1.FieldTitle = "Nume";
            this.inputField1.FieldTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.inputField1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputField1.Location = new System.Drawing.Point(28, 78);
            this.inputField1.Margin = new System.Windows.Forms.Padding(0);
            this.inputField1.Name = "inputField1";
            this.inputField1.Padding = new System.Windows.Forms.Padding(4);
            this.inputField1.Size = new System.Drawing.Size(340, 52);
            this.inputField1.TabIndex = 5;
            this.inputField1.TabStop = false;
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
            this.controlButton2.Click += new System.EventHandler(this.controlButton2_Click);
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
            this.controlButton1.Click += new System.EventHandler(this.controlButton1_Click);
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 381);
            this.Controls.Add(this.inputField2);
            this.Controls.Add(this.inputField1);
            this.Controls.Add(this.controlButton2);
            this.Controls.Add(this.controlButton1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrimaryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "None";
            this.Load += new System.EventHandler(this.PrimaryForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrimaryForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PrimaryForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PrimaryForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private UIComponents.ControlButton controlButton1;
        private UIComponents.ControlButton controlButton2;
        private UIComponents.InputField inputField1;
        private UIComponents.InputField inputField2;
    }
}

