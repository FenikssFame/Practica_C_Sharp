namespace Task_3
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Высчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 171);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 18;
            label4.Text = "Результат";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 17;
            label3.Text = "dx";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 54);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 16;
            label2.Text = "xk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 15;
            label1.Text = "x0";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(34, 189);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 134);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 135);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 21;
            label5.Text = "b";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(34, 132);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 378);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox5;
    }
}