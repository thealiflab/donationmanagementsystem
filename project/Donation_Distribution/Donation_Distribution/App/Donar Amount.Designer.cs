namespace Donation_Distribution
{
    partial class Donar_Amount
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
            this.Donar_amountConfirm_ok_button = new System.Windows.Forms.Button();
            this.Enter_amount_textBox = new System.Windows.Forms.TextBox();
            this.Enter_Amount_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Donar_amountConfirm_ok_button
            // 
            this.Donar_amountConfirm_ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.Donar_amountConfirm_ok_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Donar_amountConfirm_ok_button.Location = new System.Drawing.Point(130, 106);
            this.Donar_amountConfirm_ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.Donar_amountConfirm_ok_button.Name = "Donar_amountConfirm_ok_button";
            this.Donar_amountConfirm_ok_button.Size = new System.Drawing.Size(60, 23);
            this.Donar_amountConfirm_ok_button.TabIndex = 5;
            this.Donar_amountConfirm_ok_button.Text = "OK";
            this.Donar_amountConfirm_ok_button.UseVisualStyleBackColor = false;
            // 
            // Enter_amount_textBox
            // 
            this.Enter_amount_textBox.Location = new System.Drawing.Point(140, 60);
            this.Enter_amount_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Enter_amount_textBox.Name = "Enter_amount_textBox";
            this.Enter_amount_textBox.Size = new System.Drawing.Size(116, 20);
            this.Enter_amount_textBox.TabIndex = 4;
            // 
            // Enter_Amount_label
            // 
            this.Enter_Amount_label.AutoSize = true;
            this.Enter_Amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold);
            this.Enter_Amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.Enter_Amount_label.Location = new System.Drawing.Point(46, 63);
            this.Enter_Amount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enter_Amount_label.Name = "Enter_Amount_label";
            this.Enter_Amount_label.Size = new System.Drawing.Size(95, 13);
            this.Enter_Amount_label.TabIndex = 3;
            this.Enter_Amount_label.Text = "Enter Amount : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 29);
            this.flowLayoutPanel1.TabIndex = 127;
            // 
            // Donar_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 188);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Donar_amountConfirm_ok_button);
            this.Controls.Add(this.Enter_amount_textBox);
            this.Controls.Add(this.Enter_Amount_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Donar_Amount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donar_Amount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Donar_amountConfirm_ok_button;
        private System.Windows.Forms.TextBox Enter_amount_textBox;
        private System.Windows.Forms.Label Enter_Amount_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}