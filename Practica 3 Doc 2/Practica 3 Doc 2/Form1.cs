namespace Practica_3_Doc_2
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Bot�n SumarN�meros
            textBox2.Text = Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

            // Aqu� es donde pasamos el par�metro
            f_num = float.Parse(textBox1.Text);
            Total += f_num;

            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
