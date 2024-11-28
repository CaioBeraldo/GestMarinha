using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestMarinha
{
    public partial class paginaAdicionar : Form
    {
        public paginaAdicionar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Server=CAIOB_LC\SQLEXPRESS;Database=ControleMarinho;User Id=sa;Password=abacate03");
                SqlCommand cm = new SqlCommand();
                {
                    cm.Open();
                    string query = "INSERT INTO Animais (nome, especie_id, tanque_id, data_nascimento, sexo, data_entrada) " +
                                   "VALUES (@nome, @especie_id, @tanque_id, @data_nascimento, @sexo, @data_entrada)";
                    SqlCommand cmd = new SqlCommand(query, cm);

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@especie_id", Convert.ToInt32(txtEspecieID.Text));
                    cmd.Parameters.AddWithValue("@tanque_id", Convert.ToInt32(txtTanqueID.Text));
                    cmd.Parameters.AddWithValue("@data_nascimento", dtpDataNascimento.Value);
                    cmd.Parameters.AddWithValue("@sexo", cmbSexo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@data_entrada", dtpDataEntrada.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Animal cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Clear();
                    txtEspecieID.Clear();
                    txtTanqueID.Clear();
                    cmbSexo.SelectedIndex = -1;
                    dtpDataNascimento.Value = DateTime.Now;
                    dtpDataEntrada.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
