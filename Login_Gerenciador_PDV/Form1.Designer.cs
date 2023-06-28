namespace Login_Gerenciador_PDV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            btnEntrar = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            pictureBox1 = new PictureBox();
            lblsISistemaPDV = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(133, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 0;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(263, 239);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 37);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += button2_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(88, 184);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(88, 210);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(134, 174);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(204, 25);
            txtLogin.TabIndex = 4;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(136, 202);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(201, 23);
            txtSenha.TabIndex = 8;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblsISistemaPDV
            // 
            lblsISistemaPDV.AutoSize = true;
            lblsISistemaPDV.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblsISistemaPDV.Location = new Point(132, 9);
            lblsISistemaPDV.Name = "lblsISistemaPDV";
            lblsISistemaPDV.Size = new Size(205, 43);
            lblsISistemaPDV.TabIndex = 7;
            lblsISistemaPDV.Text = "Sistema PDV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(474, 297);
            Controls.Add(lblsISistemaPDV);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(btnEntrar);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnEntrar;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private PictureBox pictureBox1;
        private Label lblsISistemaPDV;
    }
}