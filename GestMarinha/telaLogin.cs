using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestMarinha
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string loginCorreto = "admin";
            string senhaCorreta = "admin";

            if (textBoxLogin.Text == loginCorreto && textBoxSenha.Text == senhaCorreta)
            {
                // Criando o formulário principal
                telaPrincipal telaPrincipalForm = new telaPrincipal();

                // Mostra a nova tela
                telaPrincipalForm.Show();

                // Esconde o formulário de login
                this.Close();
            }
            else
            {
                // Exibe mensagem de erro
                MessageBox.Show(
                    "Login ou senha inválidos!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            telaPrincipal TelaPrincipal = new telaPrincipal();
            TelaPrincipal.Show();
            this.Hide();
            
        }
    }
}