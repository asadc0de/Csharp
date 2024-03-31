namespace WinFormsApp1
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
            T1 = new TextBox();
            T2 = new TextBox();
            T3 = new TextBox();
            Sum = new Button();
            SuspendLayout();
            // 
            // T1
            // 
            T1.Location = new Point(362, 170);
            T1.Name = "T1";
            T1.Size = new Size(202, 27);
            T1.TabIndex = 0;
            // 
            // T2
            // 
            T2.Location = new Point(371, 248);
            T2.Name = "T2";
            T2.Size = new Size(190, 27);
            T2.TabIndex = 1;
            // 
            // T3
            // 
            T3.Location = new Point(731, 173);
            T3.Name = "T3";
            T3.Size = new Size(334, 27);
            T3.TabIndex = 2;
            // 
            // Sum
            // 
            Sum.Location = new Point(259, 360);
            Sum.Name = "Sum";
            Sum.Size = new Size(199, 70);
            Sum.TabIndex = 3;
            Sum.Text = "button1";
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Sum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 789);
            Controls.Add(Sum);
            Controls.Add(T3);
            Controls.Add(T2);
            Controls.Add(T1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox T1;
        private TextBox T2;
        private TextBox T3;
        private Button Sum;
    }
}
