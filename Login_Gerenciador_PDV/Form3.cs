using System.Data.SqlClient;
using System.Data;

namespace Login_Gerenciador_PDV
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblNomeDoProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharCadastroProduto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("INSERT INTO tbProduto (id, nome, valor) values (@id, @nome, @valor )", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDProduto.Text;
            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeProduto.Text;
            cm.Parameters.Add("@valor", SqlDbType.Int).Value = txtValorProduto.Text;


            if (txtIDProduto.Text != "" & txtNomeProduto.Text != "" & txtValorProduto.Text != "")
            {

                try
                {
                    conexao.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIDProduto.Text = "";
                    txtNomeProduto.Text = "";
                    txtValorProduto.Text = "";

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

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("Select * from tbProduto where id like @id", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDProduto.Text;


            try
            {
                conexao.Open();
                SqlDataReader consulta = cm.ExecuteReader();
                if (consulta.HasRows == false)
                {
                    throw new Exception("ID não encontrado");
                }
                consulta.Read();

                txtIDProduto.Text = Convert.ToString(consulta["id"]);
                txtNomeProduto.Text = Convert.ToString(consulta["nome"]);
                txtValorProduto.Text = Convert.ToString(consulta["valor"]);

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

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("update tbProduto set id=@id, nome=@nome, valor=@valor where id=@id ", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDProduto.Text;
            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeProduto.Text;
            cm.Parameters.Add("@valor", SqlDbType.Int).Value = txtValorProduto.Text;


            if (txtIDProduto.Text != "" & txtNomeProduto.Text != "" & txtValorProduto.Text != "")
            {

                try
                {
                    conexao.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Produto Alterado com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIDProduto.Text = "";
                    txtNomeProduto.Text = "";
                    txtValorProduto.Text = "";

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

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            string query = "DELETE FROM tbProduto WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conexao);
            command.Parameters.AddWithValue("@id", txtIDProduto.Text);

            conexao.Open();
            // Executar a consulta SQL
            int rowsAffected = command.ExecuteNonQuery();

            // Fechar a conexão com o banco de dados
            conexao.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Produto excluido com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDProduto.Text = "";
                txtNomeProduto.Text = "";
                txtValorProduto.Text = "";
                
            }
            else
            {
                MessageBox.Show("Falha ao excluir o cliente.", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
    

