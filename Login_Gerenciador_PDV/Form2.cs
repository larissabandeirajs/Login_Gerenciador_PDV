using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Gerenciador_PDV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroDeCliente cadastroDeCliente = new CadastroDeCliente();
            cadastroDeCliente.ShowDialog();
        }

        private void CadastroProduto_Click(object sender, EventArgs e)
        {
            Form3 abrirCadastroCliente = new Form3();
            abrirCadastroCliente.ShowDialog();
        }

        private void CadastroUsuario_Click(object sender, EventArgs e)
        {
            CadastroDeUsuario cadastroDeUsuario = new CadastroDeUsuario();
            cadastroDeUsuario.ShowDialog();
        }
    }
}
