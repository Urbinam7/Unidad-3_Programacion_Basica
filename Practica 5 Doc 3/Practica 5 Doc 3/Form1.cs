namespace Practica_5_Doc_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();       // Limpia el texto
            textBox1.Focus();       // Coloca el cursor de nuevo ahí
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);

            if (num % 2 == 0)
            {
                MessageBox.Show("EL NÚMERO ES PAR");
            }
            else
            {
                if (num % 3 == 0)
                {
                    MessageBox.Show("EL NÚMERO ES IMPAR Y ES DIVISIBLE POR 3");
                }
                else
                {
                    MessageBox.Show("EL NÚMERO ES IMPAR Y NO ES DIVISIBLE POR 3");
                }
            }
        }
    }
}
