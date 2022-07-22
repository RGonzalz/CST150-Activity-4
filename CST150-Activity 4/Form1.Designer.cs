namespace CST150_Activity_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_inputSec = new System.Windows.Forms.TextBox();
            this.btn_count = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_hrs = new System.Windows.Forms.TextBox();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input seconds";
            // 
            // txt_inputSec
            // 
            this.txt_inputSec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_inputSec.Location = new System.Drawing.Point(151, 84);
            this.txt_inputSec.Name = "txt_inputSec";
            this.txt_inputSec.Size = new System.Drawing.Size(100, 29);
            this.txt_inputSec.TabIndex = 1;
            // 
            // btn_count
            // 
            this.btn_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_count.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_count.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_count.Location = new System.Drawing.Point(151, 391);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(100, 38);
            this.btn_count.TabIndex = 5;
            this.btn_count.Text = "Calculate";
            this.btn_count.UseVisualStyleBackColor = false;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(292, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(292, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Days";
            // 
            // txt_min
            // 
            this.txt_min.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_min.Location = new System.Drawing.Point(151, 150);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(100, 29);
            this.txt_min.TabIndex = 9;
            // 
            // txt_hrs
            // 
            this.txt_hrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_hrs.Location = new System.Drawing.Point(151, 235);
            this.txt_hrs.Name = "txt_hrs";
            this.txt_hrs.Size = new System.Drawing.Size(100, 29);
            this.txt_hrs.TabIndex = 10;
            // 
            // txt_days
            // 
            this.txt_days.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_days.Location = new System.Drawing.Point(151, 321);
            this.txt_days.Name = "txt_days";
            this.txt_days.Size = new System.Drawing.Size(100, 29);
            this.txt_days.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST150_Activity_4.Properties.Resources.Screenshot_2022_07_21_213034;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.txt_days);
            this.Controls.Add(this.txt_hrs);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.txt_inputSec);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Count seconds by minutes, hours and days";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_inputSec;
        private Button btn_count;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_min;
        private TextBox txt_hrs;
        private TextBox txt_days;
    }
}