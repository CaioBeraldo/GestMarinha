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

                telaPrincipal novoForm = new telaPrincipal();
                novoForm.Show();
                this.Hide();
            }
            else
            {
                lblErro.Text = "Login ou senha inválidos!";
                lblErro.ForeColor = System.Drawing.Color.Red;
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
    }
}