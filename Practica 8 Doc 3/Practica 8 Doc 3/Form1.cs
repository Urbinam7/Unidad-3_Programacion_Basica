namespace Practica_8_Doc_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaración de variables
            double c1, c2, c3, c4, promedio;

            // Conversión de los valores introducidos en los TextBox
            c1 = double.Parse(textBox1.Text);
            c2 = double.Parse(textBox2.Text);
            c3 = double.Parse(textBox3.Text);
            c4 = double.Parse(textBox4.Text);

            // Calcular el promedio
            promedio = (c1 + c2 + c3 + c4) / 4;

            // Evaluar condiciones para aprobar
            if (promedio >= 6.0 && c1 >= 6.0 && c2 >= 6.0 && c3 >= 6.0 && c4 >= 6.0)
            {
                label7.Text = "Aprobado";
            }
            else
            {
                label7.Text = "Reprobado";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label7.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
