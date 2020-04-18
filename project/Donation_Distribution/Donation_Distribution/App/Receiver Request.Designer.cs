namespace Donation_Distribution
{
    partial class Receiver_Request
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
            this.Receiver_amount_ok_button = new System.Windows.Forms.Button();
            this.Receiver_enter_amount_textBox = new System.Windows.Forms.TextBox();
            this.Receiver_enter_amount_label = new System.Windows.Forms.Label();
            this.Receiver_reason_textBox = new System.Windows.Forms.TextBox();
            this.Receiver_reason_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Receiver_amount_ok_button
            // 
            this.Receiver_amount_ok_button.Location = new System.Drawing.Point(166, 249);
            this.Receiver_amount_ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.Receiver_amount_ok_button.Name = "Receiver_amount_ok_button";
            this.Receiver_amount_ok_button.Size = new System.Drawing.Size(68, 25);
            this.Receiver_amount_ok_button.TabIndex = 9;
            this.Receiver_amount_ok_button.Text = "OK";
            this.Receiver_amount_ok_button.UseVisualStyleBackColor = true;
            this.Receiver_amount_ok_button.Click += new System.EventHandler(this.Receiver_amount_ok_button_Click);
            // 
            // Receiver_enter_amount_textBox
            // 
            this.Receiver_enter_amount_textBox.Location = new System.Drawing.Point(166, 189);
            this.Receiver_enter_amount_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Receiver_enter_amount_textBox.Name = "Receiver_enter_amount_textBox";
            this.Receiver_enter_amount_textBox.Size = new System.Drawing.Size(130, 22);
            this.Receiver_enter_amount_textBox.TabIndex = 8;
            // 
            // Receiver_enter_amount_label
            // 
            this.Receiver_enter_amount_label.AutoSize = true;
            this.Receiver_enter_amount_label.Location = new System.Drawing.Point(48, 192);
            this.Receiver_enter_amount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receiver_enter_amount_label.Name = "Receiver_enter_amount_label";
            this.Receiver_enter_amount_label.Size = new System.Drawing.Size(102, 17);
            this.Receiver_enter_amount_label.TabIndex = 7;
            this.Receiver_enter_amount_label.Text = "Enter Amount :";
            // 
            // Receiver_reason_textBox
            // 
            this.Receiver_reason_textBox.Location = new System.Drawing.Point(166, 70);
            this.Receiver_reason_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Receiver_reason_textBox.Multiline = true;
            this.Receiver_reason_textBox.Name = "Receiver_reason_textBox";
            this.Receiver_reason_textBox.Size = new System.Drawing.Size(238, 91);
            this.Receiver_reason_textBox.TabIndex = 6;
            // 
            // Receiver_reason_label1
            // 
            this.Receiver_reason_label1.AutoSize = true;
            this.Receiver_reason_label1.Location = new System.Drawing.Point(48, 70);
            this.Receiver_reason_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receiver_reason_label1.Name = "Receiver_reason_label1";
            this.Receiver_reason_label1.Size = new System.Drawing.Size(65, 17);
            this.Receiver_reason_label1.TabIndex = 5;
            this.Receiver_reason_label1.Text = "Reason :";
            // 
            // Receiver_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 305);
            this.Controls.Add(this.Receiver_amount_ok_button);
            this.Controls.Add(this.Receiver_enter_amount_textBox);
            this.Controls.Add(this.Receiver_enter_amount_label);
            this.Controls.Add(this.Receiver_reason_textBox);
            this.Controls.Add(this.Receiver_reason_label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Receiver_Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiver_Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Receiver_amount_ok_button;
        private System.Windows.Forms.TextBox Receiver_enter_amount_textBox;
        private System.Windows.Forms.Label Receiver_enter_amount_label;
        private System.Windows.Forms.TextBox Receiver_reason_textBox;
        private System.Windows.Forms.Label Receiver_reason_label1;
    }
}