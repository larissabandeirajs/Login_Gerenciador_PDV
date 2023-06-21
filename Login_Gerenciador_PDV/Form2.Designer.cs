namespace Login_Gerenciador_PDV
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            CadastroCliente = new ToolStripMenuItem();
            CadastroProduto = new ToolStripMenuItem();
            CadastroUsuario = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CadastroCliente, CadastroProduto, CadastroUsuario });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // CadastroCliente
            // 
            CadastroCliente.Name = "CadastroCliente";
            CadastroCliente.Size = new Size(180, 22);
            CadastroCliente.Text = "Cliente";
            CadastroCliente.Click += CadastroCliente_Click;
            // 
            // CadastroProduto
            // 
            CadastroProduto.Name = "CadastroProduto";
            CadastroProduto.Size = new Size(180, 22);
            CadastroProduto.Text = "Produto";
            CadastroProduto.Click += CadastroProduto_Click;
            // 
            // CadastroUsuario
            // 
            CadastroUsuario.Name = "CadastroUsuario";
            CadastroUsuario.Size = new Size(180, 22);
            CadastroUsuario.Text = "Usuário";
            CadastroUsuario.Click += CadastroUsuario_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Sistema PDV - Bem Vindo";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem CadastroCliente;
        private ToolStripMenuItem CadastroProduto;
        private ToolStripMenuItem CadastroUsuario;
    }
}