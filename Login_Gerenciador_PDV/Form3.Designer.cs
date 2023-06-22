namespace Login_Gerenciador_PDV
{
    partial class Form3
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
            lblCadastroDeProduto = new Label();
            lblIDDoProduto = new Label();
            lblNomeDoProduto = new Label();
            lblValorDoProduto = new Label();
            btnSalvarProduto = new Button();
            btnAlterarProduto = new Button();
            btnExcluirProduto = new Button();
            txtIDProduto = new TextBox();
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            btnFecharCadastroProduto = new Button();
            SuspendLayout();
            // 
            // lblCadastroDeProduto
            // 
            lblCadastroDeProduto.AutoSize = true;
            lblCadastroDeProduto.Font = new Font("Arial Unicode MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeProduto.Location = new Point(126, 35);
            lblCadastroDeProduto.Name = "lblCadastroDeProduto";
            lblCadastroDeProduto.Size = new Size(286, 36);
            lblCadastroDeProduto.TabIndex = 0;
            lblCadastroDeProduto.Text = "Cadastro de Produto";
            // 
            // lblIDDoProduto
            // 
            lblIDDoProduto.AutoSize = true;
            lblIDDoProduto.Location = new Point(9, 103);
            lblIDDoProduto.Name = "lblIDDoProduto";
            lblIDDoProduto.Size = new Size(21, 15);
            lblIDDoProduto.TabIndex = 1;
            lblIDDoProduto.Text = "ID:";
            // 
            // lblNomeDoProduto
            // 
            lblNomeDoProduto.AutoSize = true;
            lblNomeDoProduto.Location = new Point(7, 141);
            lblNomeDoProduto.Name = "lblNomeDoProduto";
            lblNomeDoProduto.Size = new Size(43, 15);
            lblNomeDoProduto.TabIndex = 2;
            lblNomeDoProduto.Text = "Nome:";
            lblNomeDoProduto.Click += lblNomeDoProduto_Click;
            // 
            // lblValorDoProduto
            // 
            lblValorDoProduto.AutoSize = true;
            lblValorDoProduto.Location = new Point(344, 141);
            lblValorDoProduto.Name = "lblValorDoProduto";
            lblValorDoProduto.Size = new Size(36, 15);
            lblValorDoProduto.TabIndex = 3;
            lblValorDoProduto.Text = "Valor:";
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Location = new Point(325, 193);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(82, 32);
            btnSalvarProduto.TabIndex = 4;
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            // 
            // btnAlterarProduto
            // 
            btnAlterarProduto.Location = new Point(201, 193);
            btnAlterarProduto.Name = "btnAlterarProduto";
            btnAlterarProduto.Size = new Size(81, 32);
            btnAlterarProduto.TabIndex = 5;
            btnAlterarProduto.Text = "Alterar";
            btnAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.Location = new Point(87, 193);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(81, 32);
            btnExcluirProduto.TabIndex = 6;
            btnExcluirProduto.Text = "Excluir";
            btnExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // txtIDProduto
            // 
            txtIDProduto.Location = new Point(56, 103);
            txtIDProduto.Name = "txtIDProduto";
            txtIDProduto.Size = new Size(63, 23);
            txtIDProduto.TabIndex = 7;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(56, 138);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(282, 23);
            txtNomeProduto.TabIndex = 8;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(386, 138);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 9;
            // 
            // btnFecharCadastroProduto
            // 
            btnFecharCadastroProduto.Location = new Point(411, 95);
            btnFecharCadastroProduto.Name = "btnFecharCadastroProduto";
            btnFecharCadastroProduto.Size = new Size(75, 23);
            btnFecharCadastroProduto.TabIndex = 10;
            btnFecharCadastroProduto.Text = "Fechar";
            btnFecharCadastroProduto.UseVisualStyleBackColor = true;
            btnFecharCadastroProduto.Click += btnFecharCadastroProduto_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(517, 262);
            Controls.Add(btnFecharCadastroProduto);
            Controls.Add(txtValorProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtIDProduto);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnAlterarProduto);
            Controls.Add(btnSalvarProduto);
            Controls.Add(lblValorDoProduto);
            Controls.Add(lblNomeDoProduto);
            Controls.Add(lblIDDoProduto);
            Controls.Add(lblCadastroDeProduto);
            Name = "Form3";
            Text = "Cadastro de Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeProduto;
        private Label lblIDDoProduto;
        private Label lblNomeDoProduto;
        private Label lblValorDoProduto;
        private Button btnSalvarProduto;
        private Button btnAlterarProduto;
        private Button btnExcluirProduto;
        private TextBox txtIDProduto;
        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private Button btnFecharCadastroProduto;
    }
}