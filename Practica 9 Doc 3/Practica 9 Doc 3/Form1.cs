namespace Practica_9_Doc_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;

            // Validar que sea un número entero
            if (int.TryParse(textBox1.Text, out edad) && edad >= 0)
            {
                if (edad < 12)
                    label4.Text = "Es un Niño";
                else if (edad < 18)
                    label4.Text = "Es un Adolescente";
                else if (edad < 60)
                    label4.Text = "Es un Adulto";
                else
                    label4.Text = "Es un Adulto mayor";
            }
            else
            {
                label4.Text = "Por favor, introduce una edad válida (número entero positivo).";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
