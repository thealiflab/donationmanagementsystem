namespace diary_manage
{
    partial class HomeForm
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
            this.Welcome_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Action_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.email_home_textBox2 = new System.Windows.Forms.TextBox();
            this.Email_home_label = new System.Windows.Forms.Label();
            this.Phn_home_textBox = new System.Windows.Forms.TextBox();
            this.User_phn_home_label = new System.Windows.Forms.Label();
            this.name_home_textBox = new System.Windows.Forms.TextBox();
            this.User_name_home_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(162, 48);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(422, 27);
            this.Welcome_label.TabIndex = 0;
            this.Welcome_label.Text = "Welcome to Dairy Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(298, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // Action_button
            // 
            this.Action_button.Location = new System.Drawing.Point(575, 396);
            this.Action_button.Name = "Action_button";
            this.Action_button.Size = new System.Drawing.Size(86, 39);
            this.Action_button.TabIndex = 2;
            this.Action_button.Text = "Action";
            this.Action_button.UseVisualStyleBackColor = true;
            this.Action_button.Click += new System.EventHandler(this.Action_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.Location = new System.Drawing.Point(465, 396);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(86, 39);
            this.Logout_button.TabIndex = 3;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // email_home_textBox2
            // 
            this.email_home_textBox2.Location = new System.Drawing.Point(167, 262);
            this.email_home_textBox2.Name = "email_home_textBox2";
            this.email_home_textBox2.Size = new System.Drawing.Size(166, 20);
            this.email_home_textBox2.TabIndex = 18;
            // 
            // Email_home_label
            // 
            this.Email_home_label.AutoSize = true;
            this.Email_home_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_home_label.Location = new System.Drawing.Point(34, 262);
            this.Email_home_label.Name = "Email_home_label";
            this.Email_home_label.Size = new System.Drawing.Size(103, 19);
            this.Email_home_label.TabIndex = 17;
            this.Email_home_label.Text = "User Email :";
            // 
            // Phn_home_textBox
            // 
            this.Phn_home_textBox.Location = new System.Drawing.Point(167, 191);
            this.Phn_home_textBox.Name = "Phn_home_textBox";
            this.Phn_home_textBox.Size = new System.Drawing.Size(166, 20);
            this.Phn_home_textBox.TabIndex = 16;
            // 
            // User_phn_home_label
            // 
            this.User_phn_home_label.AutoSize = true;
            this.User_phn_home_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_phn_home_label.Location = new System.Drawing.Point(34, 192);
            this.User_phn_home_label.Name = "User_phn_home_label";
            this.User_phn_home_label.Size = new System.Drawing.Size(129, 19);
            this.User_phn_home_label.TabIndex = 15;
            this.User_phn_home_label.Text = "Phone Number :";
            // 
            // name_home_textBox
            // 
            this.name_home_textBox.Location = new System.Drawing.Point(167, 123);
            this.name_home_textBox.Name = "name_home_textBox";
            this.name_home_textBox.Size = new System.Drawing.Size(166, 20);
            this.name_home_textBox.TabIndex = 14;
            // 
            // User_name_home_label
            // 
            this.User_name_home_label.AutoSize = true;
            this.User_name_home_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_name_home_label.Location = new System.Drawing.Point(34, 124);
            this.User_name_home_label.Name = "User_name_home_label";
            this.User_name_home_label.Size = new System.Drawing.Size(68, 19);
            this.User_name_home_label.TabIndex = 13;
            this.User_name_home_label.Text = "Name  :";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 463);
            this.Controls.Add(this.email_home_textBox2);
            this.Controls.Add(this.Email_home_label);
            this.Controls.Add(this.Phn_home_textBox);
            this.Controls.Add(this.User_phn_home_label);
            this.Controls.Add(this.name_home_textBox);
            this.Controls.Add(this.User_name_home_label);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Action_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Welcome_label);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Action_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.TextBox email_home_textBox2;
        private System.Windows.Forms.Label Email_home_label;
        private System.Windows.Forms.TextBox Phn_home_textBox;
        private System.Windows.Forms.Label User_phn_home_label;
        private System.Windows.Forms.TextBox name_home_textBox;
        private System.Windows.Forms.Label User_name_home_label;
    }
}

