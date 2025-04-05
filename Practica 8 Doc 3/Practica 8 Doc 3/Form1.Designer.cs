namespace Practica_8_Doc_3
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 25);
            label1.Name = "label1";
            label1.Size = new Size(430, 25);
            label1.TabIndex = 0;
            label1.Text = "Solicite 4 calificaciones y diga si esta o no reprobado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 147);
            label3.Name = "label3";
            label3.Size = new Size(251, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingrese la segunda calificación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 193);
            label4.Name = "label4";
            label4.Size = new Size(236, 25);
            label4.TabIndex = 3;
            label4.Text = "Ingrese la tercera calificación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 239);
            label5.Name = "label5";
            label5.Size = new Size(231, 25);
            label5.TabIndex = 4;
            label5.Text = "Ingrese la cuarta calificación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 100);
            label2.Name = "label2";
            label2.Size = new Size(244, 25);
            label2.TabIndex = 5;
            label2.Text = "Ingrese la primera calificación";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(306, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(306, 239);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(73, 31);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(44, 312);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Evaluar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(183, 312);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(317, 312);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 12;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 126);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 13;
            label6.Text = "El alumno esta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(488, 186);
            label7.Name = "label7";
            label7.Size = new Size(130, 32);
            label7.TabIndex = 14;
            label7.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(718, 425);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private Label label7;
    }
}
