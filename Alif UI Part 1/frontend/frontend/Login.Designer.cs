namespace frontend
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Signin_btn = new System.Windows.Forms.Button();
            this.Username_txtbox = new System.Windows.Forms.TextBox();
            this.Password_txtbox = new System.Windows.Forms.TextBox();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForgetPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.Username_label.Location = new System.Drawing.Point(231, 265);
            this.Username_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(94, 16);
            this.Username_label.TabIndex = 0;
            this.Username_label.Text = "User Name :";
            this.Username_label.Click += new System.EventHandler(this.Username_label_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.Password_label.Location = new System.Drawing.Point(231, 328);
            this.Password_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(88, 16);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "Password : ";
            // 
            // Signin_btn
            // 
            this.Signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.Signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signin_btn.Location = new System.Drawing.Point(240, 416);
            this.Signin_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Signin_btn.Name = "Signin_btn";
            this.Signin_btn.Size = new System.Drawing.Size(119, 28);
            this.Signin_btn.TabIndex = 2;
            this.Signin_btn.Text = "Sign in";
            this.Signin_btn.UseVisualStyleBackColor = false;
            this.Signin_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Username_txtbox
            // 
            this.Username_txtbox.Location = new System.Drawing.Point(234, 289);
            this.Username_txtbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Username_txtbox.Name = "Username_txtbox";
            this.Username_txtbox.Size = new System.Drawing.Size(276, 20);
            this.Username_txtbox.TabIndex = 3;
            // 
            // Password_txtbox
            // 
            this.Password_txtbox.Location = new System.Drawing.Point(234, 351);
            this.Password_txtbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Password_txtbox.Name = "Password_txtbox";
            this.Password_txtbox.Size = new System.Drawing.Size(276, 20);
            this.Password_txtbox.TabIndex = 4;
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.Signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signup_btn.Location = new System.Drawing.Point(386, 416);
            this.Signup_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(117, 28);
            this.Signup_btn.TabIndex = 6;
            this.Signup_btn.Text = "Sign up";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 66);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.ForgetPassword.Location = new System.Drawing.Point(402, 382);
            this.ForgetPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(108, 13);
            this.ForgetPassword.TabIndex = 10;
            this.ForgetPassword.Text = "Forget Password?";
            this.ForgetPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 482);
            this.Controls.Add(this.ForgetPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.Password_txtbox);
            this.Controls.Add(this.Username_txtbox);
            this.Controls.Add(this.Signin_btn);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Login";
            this.Text = " Donar Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Signin_btn;
        private System.Windows.Forms.TextBox Username_txtbox;
        private System.Windows.Forms.TextBox Password_txtbox;
        private System.Windows.Forms.Button Signup_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ForgetPassword;
    }
}