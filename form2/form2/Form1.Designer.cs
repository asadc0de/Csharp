﻿namespace form2
{
    partial class Form1
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
            this.hello = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Location = new System.Drawing.Point(594, 280);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(44, 16);
            this.hello.TabIndex = 0;
            this.hello.Text = "label1";
            this.hello.Click += new System.EventHandler(this.hello_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 793);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hello);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Button button1;
    }
}

