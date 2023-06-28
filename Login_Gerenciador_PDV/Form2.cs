using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Login_Gerenciador_PDV
{
    public partial class Form2 : Form
    {
        DateTime data_hora;

        [DllImport("user32.dll")]

        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndParent);
        private Process app;
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
            // cadastroDeCliente.ShowDialog();
            cadastroDeCliente.TopLevel = false;
            panelPrincipal.Controls.Add(cadastroDeCliente);
            cadastroDeCliente.Show();



        }

        private void CadastroProduto_Click(object sender, EventArgs e)
        {
            Form3 cadastrDeProduto = new Form3();
            //cadastrDeProduto.ShowDialog();
            cadastrDeProduto.TopLevel = false;
            panelPrincipal.Controls.Add(cadastrDeProduto);
            cadastrDeProduto.Show();








        }

        private void CadastroUsuario_Click(object sender, EventArgs e)
        {
            CadastroDeUsuario cadastroDeUsuario = new CadastroDeUsuario();
            //cadastroDeUsuario.ShowDialog();
            cadastroDeUsuario.TopLevel = false;
            panelPrincipal.Controls.Add(cadastroDeUsuario);
            cadastroDeUsuario.Show();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            this.Hide();
            formLogin.Show();



        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNotepad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            app = Process.Start("notepad.exe");
            Thread.Sleep(1000);
            SetParent(app.MainWindowHandle, Handle);
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            app = Process.Start("calc.exe");
            Thread.Sleep(1000);
            SetParent(app.MainWindowHandle, Handle);
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre contatoSobre = new Sobre();
            contatoSobre.TopLevel = false;
            panelPrincipal.Controls.Add(contatoSobre);
            contatoSobre.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lblData.Text = data_hora.ToLongDateString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lblHora.Text = data_hora.ToLongTimeString(); ;
        }


    }
}
