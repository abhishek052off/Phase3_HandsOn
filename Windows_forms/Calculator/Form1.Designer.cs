﻿
namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.first_number = new System.Windows.Forms.TextBox();
            this.Second_number = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Radio_add = new System.Windows.Forms.RadioButton();
            this.Radio_sub = new System.Windows.Forms.RadioButton();
            this.Radio_Mul = new System.Windows.Forms.RadioButton();
            this.Radio_div = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_number
            // 
            this.first_number.Location = new System.Drawing.Point(85, 114);
            this.first_number.Name = "first_number";
            this.first_number.Size = new System.Drawing.Size(359, 23);
            this.first_number.TabIndex = 1;
            // 
            // Second_number
            // 
            this.Second_number.Location = new System.Drawing.Point(85, 153);
            this.Second_number.Name = "Second_number";
            this.Second_number.Size = new System.Drawing.Size(359, 23);
            this.Second_number.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Radio_add
            // 
            this.Radio_add.AutoSize = true;
            this.Radio_add.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radio_add.Location = new System.Drawing.Point(85, 182);
            this.Radio_add.Name = "Radio_add";
            this.Radio_add.Size = new System.Drawing.Size(70, 19);
            this.Radio_add.TabIndex = 4;
            this.Radio_add.TabStop = true;
            this.Radio_add.Text = "Addition";
            this.Radio_add.UseVisualStyleBackColor = true;
            this.Radio_add.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Radio_sub
            // 
            this.Radio_sub.AutoSize = true;
            this.Radio_sub.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radio_sub.Location = new System.Drawing.Point(161, 182);
            this.Radio_sub.Name = "Radio_sub";
            this.Radio_sub.Size = new System.Drawing.Size(90, 19);
            this.Radio_sub.TabIndex = 5;
            this.Radio_sub.TabStop = true;
            this.Radio_sub.Text = "Substraction";
            this.Radio_sub.UseVisualStyleBackColor = true;
            this.Radio_sub.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Radio_Mul
            // 
            this.Radio_Mul.AutoSize = true;
            this.Radio_Mul.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radio_Mul.Location = new System.Drawing.Point(257, 182);
            this.Radio_Mul.Name = "Radio_Mul";
            this.Radio_Mul.Size = new System.Drawing.Size(97, 19);
            this.Radio_Mul.TabIndex = 6;
            this.Radio_Mul.TabStop = true;
            this.Radio_Mul.Text = "Multiplication";
            this.Radio_Mul.UseVisualStyleBackColor = true;
            this.Radio_Mul.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Radio_div
            // 
            this.Radio_div.AutoSize = true;
            this.Radio_div.Location = new System.Drawing.Point(361, 182);
            this.Radio_div.Name = "Radio_div";
            this.Radio_div.Size = new System.Drawing.Size(67, 20);
            this.Radio_div.TabIndex = 7;
            this.Radio_div.TabStop = true;
            this.Radio_div.Text = "Division";
            this.Radio_div.UseVisualStyleBackColor = true;
            this.Radio_div.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Radio_div);
            this.Controls.Add(this.Radio_Mul);
            this.Controls.Add(this.Radio_sub);
            this.Controls.Add(this.Radio_add);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Second_number);
            this.Controls.Add(this.first_number);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Addition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first_number;
        private System.Windows.Forms.TextBox Second_number;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Radio_add;
        private System.Windows.Forms.RadioButton Radio_sub;
        private System.Windows.Forms.RadioButton Radio_Mul;
        private System.Windows.Forms.RadioButton Radio_div;
        private System.Windows.Forms.Button button1;
    }
}

