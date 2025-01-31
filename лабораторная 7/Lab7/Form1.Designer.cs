namespace Lab7
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
            button1 = new Button();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxXStart = new TextBox();
            textBoxXEnd = new TextBox();
            textBoxN = new TextBox();
            textBoxStep = new TextBox();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(254, 193);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 237);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 16;
            label7.Text = "Результаты";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 88);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 17;
            label1.Text = "конечное значение x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 55);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 18;
            label2.Text = "начальное значение x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 121);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 19;
            label3.Text = "n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 154);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 20;
            label4.Text = "шаг";
            // 
            // textBoxXStart
            // 
            textBoxXStart.Location = new Point(254, 52);
            textBoxXStart.Name = "textBoxXStart";
            textBoxXStart.Size = new Size(125, 27);
            textBoxXStart.TabIndex = 21;
            // 
            // textBoxXEnd
            // 
            textBoxXEnd.Location = new Point(254, 85);
            textBoxXEnd.Name = "textBoxXEnd";
            textBoxXEnd.Size = new Size(125, 27);
            textBoxXEnd.TabIndex = 22;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(254, 118);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(125, 27);
            textBoxN.TabIndex = 23;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(254, 151);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(125, 27);
            textBoxStep.TabIndex = 24;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(90, 273);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(289, 236);
            textBoxResult.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 554);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxStep);
            Controls.Add(textBoxN);
            Controls.Add(textBoxXEnd);
            Controls.Add(textBoxXStart);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Лабораторная работа №7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxXStart;
        private TextBox textBoxXEnd;
        private TextBox textBoxN;
        private TextBox textBoxStep;
        private TextBox textBoxResult;
    }
}
