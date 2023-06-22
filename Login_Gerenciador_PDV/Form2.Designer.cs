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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            CadastroCliente = new ToolStripMenuItem();
            CadastroProduto = new ToolStripMenuItem();
            CadastroUsuario = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            comercialToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            contatoToolStripMenuItem = new ToolStripMenuItem();
            lblSistemaPdvMenu = new Label();
            pictureBoxLogoMenu = new PictureBox();
            panelPrincipal = new Panel();
            lblData = new Label();
            lblHora = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoMenu).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, comercialToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(761, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CadastroCliente, CadastroProduto, CadastroUsuario, sairToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // CadastroCliente
            // 
            CadastroCliente.Name = "CadastroCliente";
            CadastroCliente.Size = new Size(117, 22);
            CadastroCliente.Text = "Cliente";
            CadastroCliente.Click += CadastroCliente_Click;
            // 
            // CadastroProduto
            // 
            CadastroProduto.Name = "CadastroProduto";
            CadastroProduto.Size = new Size(117, 22);
            CadastroProduto.Text = "Produto";
            CadastroProduto.Click += CadastroProduto_Click;
            // 
            // CadastroUsuario
            // 
            CadastroUsuario.Name = "CadastroUsuario";
            CadastroUsuario.Size = new Size(117, 22);
            CadastroUsuario.Text = "Usuário";
            CadastroUsuario.Click += CadastroUsuario_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(117, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // comercialToolStripMenuItem
            // 
            comercialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem });
            comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            comercialToolStripMenuItem.Size = new Size(73, 20);
            comercialToolStripMenuItem.Text = "Comercial";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(116, 22);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blocoDeNotasToolStripMenuItem, calculadoraToolStripMenuItem, contatoToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new Size(154, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            blocoDeNotasToolStripMenuItem.Click += blocoDeNotasToolStripMenuItem_Click;
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(154, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // contatoToolStripMenuItem
            // 
            contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            contatoToolStripMenuItem.Size = new Size(154, 22);
            contatoToolStripMenuItem.Text = "Contato";
            contatoToolStripMenuItem.Click += contatoToolStripMenuItem_Click;
            // 
            // lblSistemaPdvMenu
            // 
            lblSistemaPdvMenu.AutoSize = true;
            lblSistemaPdvMenu.BackColor = SystemColors.Highlight;
            lblSistemaPdvMenu.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSistemaPdvMenu.Location = new Point(12, 66);
            lblSistemaPdvMenu.Name = "lblSistemaPdvMenu";
            lblSistemaPdvMenu.Size = new Size(178, 35);
            lblSistemaPdvMenu.TabIndex = 2;
            lblSistemaPdvMenu.Text = "Sistema PDV";
            // 
            // pictureBoxLogoMenu
            // 
            pictureBoxLogoMenu.BackColor = SystemColors.Highlight;
            pictureBoxLogoMenu.Image = (Image)resources.GetObject("pictureBoxLogoMenu.Image");
            pictureBoxLogoMenu.Location = new Point(12, 118);
            pictureBoxLogoMenu.Name = "pictureBoxLogoMenu";
            pictureBoxLogoMenu.Size = new Size(178, 168);
            pictureBoxLogoMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoMenu.TabIndex = 3;
            pictureBoxLogoMenu.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Location = new Point(198, 27);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(551, 434);
            panelPrincipal.TabIndex = 1;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblData.Location = new Point(0, 435);
            lblData.Name = "lblData";
            lblData.Size = new Size(40, 15);
            lblData.TabIndex = 4;
            lblData.Text = "label1";
            lblData.Click += lblData_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = SystemColors.AppWorkspace;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(63, 315);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(45, 17);
            lblHora.TabIndex = 5;
            lblHora.Text = "label1";
            lblHora.Click += lblHora_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(761, 462);
            Controls.Add(lblHora);
            Controls.Add(lblData);
            Controls.Add(pictureBoxLogoMenu);
            Controls.Add(lblSistemaPdvMenu);
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Sistema PDV - Bem Vindo";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem CadastroCliente;
        private ToolStripMenuItem CadastroProduto;
        private ToolStripMenuItem CadastroUsuario;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem comercialToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private Label lblSistemaPdvMenu;
        private PictureBox pictureBoxLogoMenu;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private Panel panelPrincipal;
        private ToolStripMenuItem contatoToolStripMenuItem;
        private Label lblData;
        private Label lblHora;
    }
}