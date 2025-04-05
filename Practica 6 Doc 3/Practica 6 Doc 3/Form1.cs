namespace Practica_6_Doc_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);
            int C = int.Parse(textBox3.Text);

            if (A > B)
            {
                if (B > C)
                {
                    textBox4.Text = A.ToString();
                    textBox5.Text = B.ToString();
                    textBox6.Text = C.ToString();
                }
                else
                {
                    if (A > C)
                    {
                        textBox4.Text = A.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = B.ToString();
                    }
                    else
                    {
                        textBox4.Text = C.ToString();
                        textBox5.Text = A.ToString();
                        textBox6.Text = B.ToString();
                    }
                }
            }
            else
            {
                if (B > C)
                {
                    if (A > C)
                    {
                        textBox4.Text = B.ToString();
                        textBox5.Text = A.ToString();
                        textBox6.Text = C.ToString();
                    }
                    else
                    {
                        textBox4.Text = B.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = A.ToString();
                    }
                }
                else
                {
                    textBox4.Text = C.ToString();
                    textBox5.Text = B.ToString();
                    textBox6.Text = A.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // Opcional: también puedes limpiar los resultados
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            // Y regresar el cursor al primer campo
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
