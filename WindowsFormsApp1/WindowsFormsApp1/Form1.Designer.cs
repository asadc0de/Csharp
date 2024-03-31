namespace WindowsFormsApp1
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
            this.value1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(211, 77);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(285, 22);
            this.value1.TabIndex = 0;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(211, 228);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(285, 22);
            this.result.TabIndex = 1;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(211, 155);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(285, 22);
            this.value2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.value1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.Button button1;
    }
}

