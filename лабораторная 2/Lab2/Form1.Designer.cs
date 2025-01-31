namespace Lab2
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox_result = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 74);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "a =";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox_result
            // 
            textBox_result.Location = new Point(110, 205);
            textBox_result.Multiline = true;
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(254, 163);
            textBox_result.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(139, 390);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 3;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 182);
            label2.Name = "label2";
            label2.Size = new Size(254, 20);
            label2.TabIndex = 4;
            label2.Text = "Результат выполнения программы";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 27);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 140);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 5;
            label3.Text = "c =";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 27);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 107);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 7;
            label4.Text = "b =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox_result);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Лабораторная работа №2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox_result;
        private Button button1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}
