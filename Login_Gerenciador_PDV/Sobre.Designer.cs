namespace Login_Gerenciador_PDV
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            lblSobreSistemaPDV = new Label();
            lblContato = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSobreSistemaPDV
            // 
            lblSobreSistemaPDV.AutoSize = true;
            lblSobreSistemaPDV.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSobreSistemaPDV.Location = new Point(124, 19);
            lblSobreSistemaPDV.Name = "lblSobreSistemaPDV";
            lblSobreSistemaPDV.Size = new Size(168, 31);
            lblSobreSistemaPDV.TabIndex = 0;
            lblSobreSistemaPDV.Text = "Sistema PDV ";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContato.Location = new Point(1, 196);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(190, 21);
            lblContato.TabIndex = 1;
            lblContato.Text = "Contato: 47-98839-5381";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 217);
            label1.Name = "label1";
            label1.Size = new Size(433, 17);
            label1.TabIndex = 2;
            label1.Text = "Desenvolvido por: Larissa Bandeira de Jesus / larissaband13@gmail.com";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(442, 243);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblContato);
            Controls.Add(lblSobreSistemaPDV);
            Name = "Sobre";
            Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSobreSistemaPDV;
        private Label lblContato;
        private Label label1;
        private PictureBox pictureBox1;
    }
}