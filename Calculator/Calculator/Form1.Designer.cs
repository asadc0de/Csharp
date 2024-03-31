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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            sum = new Button();
            sub = new Button();
            mul = new Button();
            div = new Button();
            reset = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(394, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 41);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(394, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 41);
            textBox3.TabIndex = 2;
            // 
            // sum
            // 
            sum.Location = new Point(416, 266);
            sum.Name = "sum";
            sum.Size = new Size(94, 29);
            sum.TabIndex = 3;
            sum.Text = "sum";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // sub
            // 
            sub.Location = new Point(547, 266);
            sub.Name = "sub";
            sub.Size = new Size(94, 29);
            sub.TabIndex = 4;
            sub.Text = "sub";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // mul
            // 
            mul.Location = new Point(416, 325);
            mul.Name = "mul";
            mul.Size = new Size(94, 29);
            mul.TabIndex = 5;
            mul.Text = "mul";
            mul.UseVisualStyleBackColor = true;
            mul.Click += mul_Click;
            // 
            // div
            // 
            div.Location = new Point(547, 325);
            div.Name = "div";
            div.Size = new Size(94, 29);
            div.TabIndex = 6;
            div.Text = "div";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // reset
            // 
            reset.Location = new Point(416, 383);
            reset.Name = "reset";
            reset.Size = new Size(225, 29);
            reset.TabIndex = 7;
            reset.Text = "reset form";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 181);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 632);
            Controls.Add(label1);
            Controls.Add(reset);
            Controls.Add(div);
            Controls.Add(mul);
            Controls.Add(sub);
            Controls.Add(sum);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private Button sum;
        private Button sub;
        private Button mul;
        private Button div;
        private Button reset;
        private Label label1;
    }
}
