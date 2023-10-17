using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmPesquisaUsuario : Form
    {
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void PesquisaUsuario_Load(object sender, EventArgs e)
        {
         
        }
        public void pesquisarCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbfuncionarios where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;


            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();
            //carregando dados para o objeto da tabela
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbPesquisar.Items.Clear();
            ltbPesquisar.Items.Add(DR.GetString(0));

            Conexao.fecharConexao();
        }
        public void pesquisarNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbPesquisar.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(1));
            }


            Conexao.fecharConexao();

        }
        public void desabilitarCampos()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            txtDescricao.Enabled = false;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
        }
        public void HabilitarCampos()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();

        }
        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
            ltbPesquisar.Items.Clear();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                pesquisarCodigo(Convert.ToInt32(txtDescricao.Text));
            }
            if (rdbNome.Checked)
            {
                pesquisarNome((txtDescricao.Text));
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ltbPesquisar.SelectedItem == null)
            {
                MessageBox.Show("Favor selecionar um item.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                string nome = ltbPesquisar.SelectedItem.ToString();
                frmCadastroUsuario abrir = new frmCadastroUsuario (nome);
                abrir.Show();
                this.Hide();
            }
        }
    }
}
