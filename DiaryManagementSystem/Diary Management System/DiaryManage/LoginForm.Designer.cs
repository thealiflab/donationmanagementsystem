namespace diary_manage
{
    partial class LoginForm
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
            this.User_Email_label = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.Signup_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.User_password_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User_Email_label
            // 
            this.User_Email_label.AutoSize = true;
            this.User_Email_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Email_label.Location = new System.Drawing.Point(94, 74);
            this.User_Email_label.Name = "User_Email_label";
            this.User_Email_label.Size = new System.Drawing.Size(103, 19);
            this.User_Email_label.TabIndex = 0;
            this.User_Email_label.Text = "User Email :";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(228, 73);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(166, 20);
            this.email_textBox.TabIndex = 1;
            // 
            // Signup_label
            // 
            this.Signup_label.AutoSize = true;
            this.Signup_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Signup_label.Location = new System.Drawing.Point(199, 265);
            this.Signup_label.Name = "Signup_label";
            this.Signup_label.Size = new System.Drawing.Size(206, 13);
            this.Signup_label.TabIndex = 2;
            this.Signup_label.Text = "don\'t have account? create new account.";
            this.Signup_label.Click += new System.EventHandler(this.Signup_label_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(228, 141);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(166, 20);
            this.password_textBox.TabIndex = 4;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // User_password_label
            // 
            this.User_password_label.AutoSize = true;
            this.User_password_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_password_label.Location = new System.Drawing.Point(94, 142);
            this.User_password_label.Name = "User_password_label";
            this.User_password_label.Size = new System.Drawing.Size(92, 19);
            this.User_password_label.TabIndex = 3;
            this.User_password_label.Text = "password :";
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(319, 221);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 358);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.User_password_label);
            this.Controls.Add(this.Signup_label);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.User_Email_label);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User_Email_label;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label Signup_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label User_password_label;
        private System.Windows.Forms.Button login_button;
    }
}