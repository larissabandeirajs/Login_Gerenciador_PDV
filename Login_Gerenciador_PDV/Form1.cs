using System.Data.SqlClient;
namespace Login_Gerenciador_PDV
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            conexao.Open();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
        SqlCommand cm = new SqlCommand();
        SqlDataReader objDados;

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

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.MaxLength = 10;
            txtSenha.PasswordChar = '*';
        }
    }
}