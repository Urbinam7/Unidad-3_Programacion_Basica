namespace Practica_9_Doc_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, cua, cub, zeta;

            for (i = 1; i <= 50; i++)
            {
                cua = i * i;
                cub = i * i * i;
                zeta = cua + cub;

                listBox1.Items.Add(i);      // Número
                listBox2.Items.Add(cua);    // Cuadrado
                listBox3.Items.Add(cub);    // Cubo
                listBox4.Items.Add(zeta);   // Suma de cuadrado + cubo
            }
        }
    }
}
