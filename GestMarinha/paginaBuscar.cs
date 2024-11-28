using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestMarinha
{
    public partial class paginaBuscar : Form
    {
        public paginaBuscar()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Server=CAIOB_LC\SQLEXPRESS;Database=ControleMarinho;User Id=sa;Password=abacate03");
        SqlCommand cm = new SqlCommand();

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void paginaBuscar_Load(object sender, EventArgs e)
        {
            CarregarDadosDataGrid1();
            CarregarDadosDataGrid2();
        }

        private void CarregarDadosDataGrid1()
        {
            try
            {
                string query1 = "SELECT * FROM dbo.Animais"; // Substitua com sua tabela
                DataTable tabela1 = new DataTable();

                cm.Connection = cn;
                cm.CommandText = query1;

                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(tabela1);

                dataGridView1.DataSource = tabela1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados para DataGridView1: " + ex.Message);
            }
        }

        private void CarregarDadosDataGrid2()
        {
            try
            {
                string query2 = "SELECT * FROM dbo.Tanques"; // Substitua com sua tabela
                DataTable tabela2 = new DataTable();

                cm.Connection = cn;
                cm.CommandText = query2;

                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(tabela2);

                dataGridView2.DataSource = tabela2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados para DataGridView2: " + ex.Message);
            }
        }

        private void PesquisarDataGrid1()
        {
            try
            {
                string termoPesquisa = textBox1.Text.Trim(); // Captura o texto da primeira TextBox
                string query = "SELECT * FROM dbo.Animais WHERE Nome LIKE @pesquisa"; // Altere "Nome" para a coluna desejada
                DataTable tabela = new DataTable();

                cm.Connection = cn;
                cm.CommandText = query;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@pesquisa", "%" + termoPesquisa + "%");

                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(tabela);

                dataGridView1.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados no DataGridView1: " + ex.Message);
            }
        }

        private void PesquisarDataGrid2()
        {
            try
            {
                string termoPesquisa = textBox2.Text.Trim(); // Captura o texto da segunda TextBox
                string query = "SELECT * FROM dbo.Tanques WHERE Descricao LIKE @pesquisa"; // Altere "Descricao" para a coluna desejada
                DataTable tabela = new DataTable();

                cm.Connection = cn;
                cm.CommandText = query;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@pesquisa", "%" + termoPesquisa + "%");

                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(tabela);

                dataGridView2.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados no DataGridView2: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesquisarDataGrid1(); // Executa a pesquisa no primeiro DataGridView
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisarDataGrid2(); // Executa a pesquisa no segundo DataGridView
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
