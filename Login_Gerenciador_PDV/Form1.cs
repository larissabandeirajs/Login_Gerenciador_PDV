using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            string connectionString = "Data Source = LARISSA; integrated security = SSPI; initial catalog = SISTEMAPDV";
            string query = "SELECT COUNT(*) FROM tbUsuario WHERE usuario= @usuario AND senha= @senha";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", txtLogin.Text);
                    command.Parameters.AddWithValue("@senha", txtSenha.Text);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    if (count > 0)
                    {
                        Form2 abrirForm2 = new Form2();
                        this.Hide();
                        abrirForm2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha invalidos", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        txtLogin.Select();
                    }
                }
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 10;
        }
    }
}