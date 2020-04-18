namespace diary_manage
{
    partial class SignupForm
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
            this.Phn_textBox = new System.Windows.Forms.TextBox();
            this.User_phn_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.User_name_label = new System.Windows.Forms.Label();
            this.Password_textBox2 = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.email_textBox2 = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Signup_button = new System.Windows.Forms.Button();
            this.Back_to_login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Phn_textBox
            // 
            this.Phn_textBox.Location = new System.Drawing.Point(238, 133);
            this.Phn_textBox.Name = "Phn_textBox";
            this.Phn_textBox.Size = new System.Drawing.Size(166, 20);
            this.Phn_textBox.TabIndex = 8;
            // 
            // User_phn_label
            // 
            this.User_phn_label.AutoSize = true;
            this.User_phn_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_phn_label.Location = new System.Drawing.Point(104, 134);
            this.User_phn_label.Name = "User_phn_label";
            this.User_phn_label.Size = new System.Drawing.Size(129, 19);
            this.User_phn_label.TabIndex = 7;
            this.User_phn_label.Text = "Phone Number :";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(238, 65);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(166, 20);
            this.name_textBox.TabIndex = 6;
            // 
            // User_name_label
            // 
            this.User_name_label.AutoSize = true;
            this.User_name_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_name_label.Location = new System.Drawing.Point(104, 66);
            this.User_name_label.Name = "User_name_label";
            this.User_name_label.Size = new System.Drawing.Size(68, 19);
            this.User_name_label.TabIndex = 5;
            this.User_name_label.Text = "Name  :";
            // 
            // Password_textBox2
            // 
            this.Password_textBox2.Location = new System.Drawing.Point(238, 272);
            this.Password_textBox2.Name = "Password_textBox2";
            this.Password_textBox2.Size = new System.Drawing.Size(166, 20);
            this.Password_textBox2.TabIndex = 12;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(104, 273);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(93, 19);
            this.Password_label.TabIndex = 11;
            this.Password_label.Text = "Password :";
            // 
            // email_textBox2
            // 
            this.email_textBox2.Location = new System.Drawing.Point(238, 204);
            this.email_textBox2.Name = "email_textBox2";
            this.email_textBox2.Size = new System.Drawing.Size(166, 20);
            this.email_textBox2.TabIndex = 10;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(104, 205);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(103, 19);
            this.Email_label.TabIndex = 9;
            this.Email_label.Text = "User Email :";
            // 
            // Signup_button
            // 
            this.Signup_button.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_button.Location = new System.Drawing.Point(329, 337);
            this.Signup_button.Name = "Signup_button";
            this.Signup_button.Size = new System.Drawing.Size(75, 23);
            this.Signup_button.TabIndex = 13;
            this.Signup_button.Text = "Signup";
            this.Signup_button.UseVisualStyleBackColor = true;
            this.Signup_button.Click += new System.EventHandler(this.Signup_button_Click);
            // 
            // Back_to_login_button
            // 
            this.Back_to_login_button.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_to_login_button.Location = new System.Drawing.Point(238, 337);
            this.Back_to_login_button.Name = "Back_to_login_button";
            this.Back_to_login_button.Size = new System.Drawing.Size(75, 23);
            this.Back_to_login_button.TabIndex = 14;
            this.Back_to_login_button.Text = "Back";
            this.Back_to_login_button.UseVisualStyleBackColor = true;
            this.Back_to_login_button.Click += new System.EventHandler(this.Back_to_login_button_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 400);
            this.Controls.Add(this.Back_to_login_button);
            this.Controls.Add(this.Signup_button);
            this.Controls.Add(this.Password_textBox2);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.email_textBox2);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Phn_textBox);
            this.Controls.Add(this.User_phn_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.User_name_label);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Phn_textBox;
        private System.Windows.Forms.Label User_phn_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label User_name_label;
        private System.Windows.Forms.TextBox Password_textBox2;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox email_textBox2;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Button Signup_button;
        private System.Windows.Forms.Button Back_to_login_button;
    }
}