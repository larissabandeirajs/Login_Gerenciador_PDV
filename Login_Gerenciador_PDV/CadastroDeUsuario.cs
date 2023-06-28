using System.Data;
using System.Data.SqlClient;

namespace Login_Gerenciador_PDV
{
    public partial class CadastroDeUsuario : Form
    {
        public CadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFecharCadastroUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("INSERT INTO tbUsuario (id, nome,endereco, telefone, email, usuario, senha) values (@id, @nome, @endereco, @telefone, @email, @usuario, @senha )", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDUsuario.Text;
            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeUsuario.Text;
            cm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEnderecoUsuario.Text;
            cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefoneUsuario.Text;
            cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmailUsuario.Text;
            cm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuarioUsuario.Text;
            cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaUsuario.Text;

            //  if (txtIDUsuario.Text != "" & txtNomeUsuario.Text != "" & txtEnderecoUsuario.Text != "" & txtTelefoneUsuario.Text != "" & txtEmailUsuario.Text != "" & txtUsuarioUsuario.Text != "" & txtSenhaUsuario.Text !="")
            if (txtIDUsuario.Text != "" & txtNomeUsuario.Text != "" & txtUsuarioUsuario.Text != "" & txtSenhaUsuario.Text != "")
            {

                try
                {
                    conexao.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Usuário cadastrado com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIDUsuario.Text = "";
                    txtNomeUsuario.Text = "";
                    txtEnderecoUsuario.Text = "";
                    txtTelefoneUsuario.Text = "";
                    txtEmailUsuario.Text = "";
                    txtSenhaUsuario.Text = "";
                    txtSenhaUsuario.Text = "";

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

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            string query = "DELETE FROM tbUsuario WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conexao);
            command.Parameters.AddWithValue("@id", txtIDUsuario.Text);

            conexao.Open();
            // Executar a consulta SQL
            int rowsAffected = command.ExecuteNonQuery();

            // Fechar a conexão com o banco de dados
            conexao.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Usuário excluido com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDUsuario.Text = "";
                txtNomeUsuario.Text = "";
                txtEnderecoUsuario.Text = "";
                txtTelefoneUsuario.Text = "";
                txtEmailUsuario.Text = "";
                txtUsuarioUsuario.Text = "";
                txtSenhaUsuario.Text = "";
                txtIDUsuario.Select();
            }
            else
            {
                MessageBox.Show("Falha ao excluir o usuário.", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlterarUuario_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("update tbUsuario set  id=@id, nome=@nome, endereco=@endereco, telefone=@telefone, email=@email, usuario=@usuario, senha=@senha where id=@id", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDUsuario.Text;
            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeUsuario.Text;
            cm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEnderecoUsuario.Text;
            cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefoneUsuario.Text;
            cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmailUsuario.Text;
            cm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuarioUsuario.Text;
            cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaUsuario.Text;

            if (txtIDUsuario.Text != "" & txtNomeUsuario.Text != "" & txtEnderecoUsuario.Text != "" & txtTelefoneUsuario.Text != "" & txtEmailUsuario.Text != "" & txtUsuarioUsuario.Text != "" & txtSenhaUsuario.Text != "")
            {

                try
                {
                    conexao.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Usuario Alterado com sucesso", "Sistema PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIDUsuario.Text = "";
                    txtNomeUsuario.Text = "";
                    txtEnderecoUsuario.Text = "";
                    txtTelefoneUsuario.Text = "";
                    txtTelefoneUsuario.Text = "";
                    txtUsuarioUsuario.Text = "";
                    txtSenhaUsuario.Text = "";
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

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LARISSA; integrated security=SSPI;initial catalog=SISTEMAPDV");
            SqlCommand cm = new SqlCommand("Select * from tbUsuario where id like @id", conexao);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = txtIDUsuario.Text;


            try
            {
                conexao.Open();
                SqlDataReader consulta = cm.ExecuteReader();
                if (consulta.HasRows == false)
                {
                    throw new Exception("ID não encontrado");
                }
                consulta.Read();

                txtIDUsuario.Text = Convert.ToString(consulta["id"]);
                txtNomeUsuario.Text = Convert.ToString(consulta["nome"]);
                txtEnderecoUsuario.Text = Convert.ToString(consulta["endereco"]);
                txtTelefoneUsuario.Text = Convert.ToString(consulta["telefone"]);
                txtEmailUsuario.Text = Convert.ToString(consulta["email"]);
                txtUsuarioUsuario.Text = Convert.ToString(consulta["usuario"]);
                txtSenhaUsuario.Text = Convert.ToString(consulta["senha"]);

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

}

