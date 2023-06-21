namespace Login_Gerenciador_PDV
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
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form2 abrirForm2 = new Form2();
            abrirForm2.ShowDialog();
        }
    }
}