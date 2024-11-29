namespace GestMarinha
{
    partial class telaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(444, 277);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(253, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(444, 353);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(253, 20);
            this.textBoxSenha.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Yu Gothic UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(500, 176);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(145, 40);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Faça Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(444, 410);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(253, 19);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(447, 243);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(48, 20);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(447, 312);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(56, 20);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(551, 491);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(38, 13);
            this.lblErro.TabIndex = 6;
            this.lblErro.Text = "ERRO";
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestMarinha.Properties.Resources.Cadastrar_Animais;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 643);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label lblErro;
    }
}

