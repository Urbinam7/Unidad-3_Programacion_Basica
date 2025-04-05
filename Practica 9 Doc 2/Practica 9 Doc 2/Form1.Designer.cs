namespace Practica_9_Doc_2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 66);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 97);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(347, 65);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Z= X   +   X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 2);
            label4.Location = new Point(390, 51);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 3;
            label4.Text = "2 ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 51);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 4;
            label5.Text = "3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(61, 190);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 204);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(233, 190);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(144, 204);
            listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(407, 190);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(148, 204);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(611, 190);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(153, 204);
            listBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 162);
            label6.Name = "label6";
            label6.Size = new Size(23, 25);
            label6.TabIndex = 9;
            label6.Text = "X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 146);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 10;
            label7.Text = "2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 162);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 11;
            label8.Text = "X";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(467, 162);
            label9.Name = "label9";
            label9.Size = new Size(23, 25);
            label9.TabIndex = 12;
            label9.Text = "X";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(482, 146);
            label10.Name = "label10";
            label10.Size = new Size(22, 25);
            label10.TabIndex = 13;
            label10.Text = "3";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(678, 162);
            label11.Name = "label11";
            label11.Size = new Size(22, 25);
            label11.TabIndex = 14;
            label11.Text = "Z";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Location = new Point(287, 425);
            button1.Name = "button1";
            button1.Size = new Size(217, 39);
            button1.TabIndex = 15;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(824, 485);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form1";
            Text = "2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
    }
}
