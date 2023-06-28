using System.Data;
using System.Data.SqlClient;

namespace Login_Gerenciador_PDV
{
    public partial class CadastroDeCliente : Form
    {
        public CadastroDeCliente()
        {
            InitializeComponent();
        }

        private void btnFecharCadastroCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("INSERT INTO tbCliente (id, nome, cpf, cnpj, endereco, telefone, email) values (@id, @nome, @cpf, @cnpj, @endereco, @telefone, @email )", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDCliente.Text;
            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeCliente.Text;
            cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCPFCliente.Text;
            cm.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = txtCNPJCliente.Text;
            cm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEnderecoCliente.Text;
            cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefoneCliente.Text;
            cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmailCliente.Text;

            if (txtIDCliente.Text != "" & txtNomeCliente.Text != "" & txtCPFCliente.Text != "" & txtCNPJCliente.Text != "" & txtEnderecoCliente.Text != "" & txtTelefoneCliente.Text != "" & txtEmailCliente.Text != "")
            {

                try
                {
                    conexao.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIDCliente.Text = "";
                    txtNomeCliente.Text = "";
                    txtCPFCliente.Text = "";
                    txtCNPJCliente.Text = "";
                    txtEnderecoCliente.Text = "";
                    txtTelefoneCliente.Text = "";
                    txtEmailCliente.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {

                    conexao.Close();
                }

            }
            else
            {

                MessageBox.Show("Todos os campos são obrigatório", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("update tbCliente set  id=@id, nome=@nome, cpf=@cpf, cnpj=@cnpj, endereco=@endereco, telefone=@telefone, email=@email where id=@id", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDCliente.Text;
            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeCliente.Text;
            cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCPFCliente.Text;
            cm.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = txtCNPJCliente.Text;
            cm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEnderecoCliente.Text;
            cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefoneCliente.Text;
            cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmailCliente.Text;

            if (txtIDCliente.Text != "" & txtNomeCliente.Text != "" & txtCPFCliente.Text != "" & txtCNPJCliente.Text != "" & txtEnderecoCliente.Text != "" & txtTelefoneCliente.Text != "" & txtEmailCliente.Text != "")
            {

                try
                {
                    conexao.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Cliente Alterado com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIDCliente.Text = "";
                    txtNomeCliente.Text = "";
                    txtCPFCliente.Text = "";
                    txtCNPJCliente.Text = "";
                    txtEnderecoCliente.Text = "";
                    txtTelefoneCliente.Text = "";
                    txtEmailCliente.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {

                    conexao.Close();
                }

            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("Select * from tbCliente where id like @id", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDCliente.Text;


            try
            {
                conexao.Open();
                SqlDataReader consulta = cm.ExecuteReader();
                if (consulta.HasRows == false)
                {
                    throw new Exception("ID não encontrado");
                }
                consulta.Read();

                txtIDCliente.Text = Convert.ToString(consulta["id"]);
                txtNomeCliente.Text = Convert.ToString(consulta["nome"]);
                txtCPFCliente.Text = Convert.ToString(consulta["cpf"]);
                txtCNPJCliente.Text = Convert.ToString(consulta["cnpj"]);
                txtEnderecoCliente.Text = Convert.ToString(consulta["endereco"]);
                txtTelefoneCliente.Text = Convert.ToString(consulta["telefone"]);
                txtEmailCliente.Text = Convert.ToString(consulta["email"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

                conexao.Close();
            }

        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            string query = "DELETE FROM tbCliente WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conexao);
            command.Parameters.AddWithValue("@id", txtIDCliente.Text);

            conexao.Open();
            // Executar a consulta SQL
            int rowsAffected = command.ExecuteNonQuery();

            // Fechar a conexão com o banco de dados
            conexao.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Cliente excluido com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCliente.Text = "";
                txtNomeCliente.Text = "";
                txtCPFCliente.Text = "";
                txtCNPJCliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtTelefoneCliente.Text = "";
                txtEmailCliente.Text = "";
                txtIDCliente.Select();
            }
            else
            {
                MessageBox.Show("Falha ao excluir o cliente.","Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}



