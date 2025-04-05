namespace Practica_4_Doc_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, nsue;

            sueldo = double.Parse(textBox1.Text);

            if (sueldo < 400000.00)
                nsue = sueldo * 1.15;
            else
                nsue = sueldo * 1.08;

            textBox2.Text = nsue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();       // Limpia el texto
            textBox1.Focus();       // Coloca el cursor de nuevo ahí
        }
    }
}
