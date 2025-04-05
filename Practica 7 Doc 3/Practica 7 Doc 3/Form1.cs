namespace Practica_7_Doc_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double lado1, lado2, lado3;
            lado1 = double.Parse(textBox1.Text);
            lado2 = double.Parse(textBox2.Text);
            lado3 = double.Parse(textBox3.Text);

            // Verificamos si realmente puede formar un triángulo
            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                if ((lado1 == lado2) && (lado2 == lado3))
                {
                    textBox4.Text = "Equilátero";
                }
                else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
                {
                    textBox4.Text = "Isósceles";
                }
                else
                {
                    textBox4.Text = "Escaleno";
                }
            }
            else
            {
                textBox4.Text = "No forma un triángulo válido";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}
