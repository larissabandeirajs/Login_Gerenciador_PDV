namespace Login_Gerenciador_PDV
{
    partial class CadastroDeCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeCliente));
            lblCadastroDeCliente = new Label();
            lblIDDoCadastroDeCliente = new Label();
            lblNomeDoCliente = new Label();
            lblCPF = new Label();
            lblCNPJ = new Label();
            lblEndereco = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtIDCliente = new TextBox();
            txtNomeCliente = new TextBox();
            txtCNPJCliente = new TextBox();
            txtEnderecoCliente = new TextBox();
            txtCPFCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            txtEmailCliente = new TextBox();
            btnSalvarCliente = new Button();
            btnAlterarCliente = new Button();
            btnExcluirCliente = new Button();
            btnFecharCadastroCliente = new Button();
            btnBuscarCliente = new Button();
            SuspendLayout();
            // 
            // lblCadastroDeCliente
            // 
            lblCadastroDeCliente.AutoSize = true;
            lblCadastroDeCliente.Font = new Font("Arial Unicode MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeCliente.Location = new Point(132, 27);
            lblCadastroDeCliente.Name = "lblCadastroDeCliente";
            lblCadastroDeCliente.Size = new Size(276, 36);
            lblCadastroDeCliente.TabIndex = 0;
            lblCadastroDeCliente.Text = "Cadastro de Cliente";
            // 
            // lblIDDoCadastroDeCliente
            // 
            lblIDDoCadastroDeCliente.AutoSize = true;
            lblIDDoCadastroDeCliente.Location = new Point(37, 92);
            lblIDDoCadastroDeCliente.Name = "lblIDDoCadastroDeCliente";
            lblIDDoCadastroDeCliente.Size = new Size(21, 15);
            lblIDDoCadastroDeCliente.TabIndex = 1;
            lblIDDoCadastroDeCliente.Text = "ID:";
            // 
            // lblNomeDoCliente
            // 
            lblNomeDoCliente.AutoSize = true;
            lblNomeDoCliente.Location = new Point(15, 140);
            lblNomeDoCliente.Name = "lblNomeDoCliente";
            lblNomeDoCliente.Size = new Size(43, 15);
            lblNomeDoCliente.TabIndex = 2;
            lblNomeDoCliente.Text = "Nome:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(274, 185);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF:";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(15, 185);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(37, 15);
            lblCNPJ.TabIndex = 4;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(15, 270);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 5;
            lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(15, 227);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(251, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(74, 92);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(76, 23);
            txtIDCliente.TabIndex = 8;
            txtIDCliente.TextChanged += txtIDCliente_TextChanged;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(74, 137);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(385, 23);
            txtNomeCliente.TabIndex = 9;
            // 
            // txtCNPJCliente
            // 
            txtCNPJCliente.Location = new Point(74, 182);
            txtCNPJCliente.Name = "txtCNPJCliente";
            txtCNPJCliente.Size = new Size(194, 23);
            txtCNPJCliente.TabIndex = 10;
            // 
            // txtEnderecoCliente
            // 
            txtEnderecoCliente.Location = new Point(74, 267);
            txtEnderecoCliente.Name = "txtEnderecoCliente";
            txtEnderecoCliente.Size = new Size(303, 23);
            txtEnderecoCliente.TabIndex = 11;
            // 
            // txtCPFCliente
            // 
            txtCPFCliente.Location = new Point(311, 182);
            txtCPFCliente.Name = "txtCPFCliente";
            txtCPFCliente.Size = new Size(199, 23);
            txtCPFCliente.TabIndex = 12;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(74, 224);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(171, 23);
            txtTelefoneCliente.TabIndex = 13;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(293, 224);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(217, 23);
            txtEmailCliente.TabIndex = 14;
            // 
            // btnSalvarCliente
            // 
            btnSalvarCliente.Location = new Point(373, 320);
            btnSalvarCliente.Name = "btnSalvarCliente";
            btnSalvarCliente.Size = new Size(75, 31);
            btnSalvarCliente.TabIndex = 15;
            btnSalvarCliente.Text = "Salvar";
            btnSalvarCliente.UseVisualStyleBackColor = true;
            btnSalvarCliente.Click += btnSalvarCliente_Click;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.Location = new Point(170, 320);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(75, 31);
            btnAlterarCliente.TabIndex = 16;
            btnAlterarCliente.Text = "Alterar";
            btnAlterarCliente.UseVisualStyleBackColor = true;
            btnAlterarCliente.Click += btnAlterarCliente_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(63, 320);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(75, 31);
            btnExcluirCliente.TabIndex = 17;
            btnExcluirCliente.Text = "Excluir";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // btnFecharCadastroCliente
            // 
            btnFecharCadastroCliente.Location = new Point(384, 92);
            btnFecharCadastroCliente.Name = "btnFecharCadastroCliente";
            btnFecharCadastroCliente.Size = new Size(75, 23);
            btnFecharCadastroCliente.TabIndex = 18;
            btnFecharCadastroCliente.Text = "Fechar";
            btnFecharCadastroCliente.UseVisualStyleBackColor = true;
            btnFecharCadastroCliente.Click += btnFecharCadastroCliente_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(274, 320);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(75, 31);
            btnBuscarCliente.TabIndex = 19;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // CadastroDeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(546, 380);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnFecharCadastroCliente);
            Controls.Add(btnExcluirCliente);
            Controls.Add(btnAlterarCliente);
            Controls.Add(btnSalvarCliente);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(txtCPFCliente);
            Controls.Add(txtEnderecoCliente);
            Controls.Add(txtCNPJCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtIDCliente);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblEndereco);
            Controls.Add(lblCNPJ);
            Controls.Add(lblCPF);
            Controls.Add(lblNomeDoCliente);
            Controls.Add(lblIDDoCadastroDeCliente);
            Controls.Add(lblCadastroDeCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroDeCliente";
            Text = "Cadastro De Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeCliente;
        private Label lblIDDoCadastroDeCliente;
        private Label lblNomeDoCliente;
        private Label lblCPF;
        private Label lblCNPJ;
        private Label lblEndereco;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtIDCliente;
        private TextBox txtNomeCliente;
        private TextBox txtCNPJCliente;
        private TextBox txtEnderecoCliente;
        private TextBox txtCPFCliente;
        private TextBox txtTelefoneCliente;
        private TextBox txtEmailCliente;
        private Button btnSalvarCliente;
        private Button btnAlterarCliente;
        private Button btnExcluirCliente;
        private Button btnFecharCadastroCliente;
        private Button btnBuscarCliente;
    }
}