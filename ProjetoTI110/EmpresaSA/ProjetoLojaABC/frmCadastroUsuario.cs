using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmCadastroUsuario : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadastroUsuario()
        {
            InitializeComponent();
            desabilitarCampos();

        }
          public  frmCadastroUsuario(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
            habilitarCampos();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }


        //cadastro Funcionario
        public void carregarFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lblFuncSemUsuario.Items.Clear();

            while (DR.Read())
            {
                lblFuncSemUsuario.Items.Add(DR.GetString(0));
            }
            Conexao.fecharConexao();
        }
        public void carragarCodFuncionario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigoFucionario.Text = Convert.ToString(DR.GetString(0));

            Conexao.fecharConexao();



        }

        //carregar codigo do usuario
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu+1 from tbUsuarios order by codUsu desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.fecharConexao();
             
        }

        //cadastro usuario
        public int cadastrarUsuario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios (usuario,senha,codFunc)values('@usuario','@senha',@codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value =
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value =
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            Conexao.fecharConexao();

            return res;

        }

        //carregar Usuario
        public void carregaUsuario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.usuario, usu.senha, func.codFunc from tbFuncionarios as func inner join tbUsuarios as usu on func.codFunc = usu.codFunc where func.nome = @nome";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            try
            {
                txtNome.Text = DR.GetString(0);
                txtSenha.Text = DR.GetString(1);

            }
            catch(MySqlException)
            {
                MessageBox.Show("funcionario não possui usuário.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

               


                txtNome.Clear();
                txtSenha.Clear();
                txtCodigo.Clear();
                txtNome.Focus();
                //carregar o codigo do funcionario
                carragarCodFuncionario(lblFuncSemUsuario.SelectedItem.ToString());
            }

         
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            carregarFuncionario();
            carregaCodigo();
           
        }
       
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtNome.Focus();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            txtCodigoFucionario.Clear();
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
          }
        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();
        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        private void lblFuncSemUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lblFuncSemUsuario.SelectedItem.ToString();

            carregaUsuario(nome);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
           
            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                if (cadastrarUsuario(Convert.ToInt32(txtCodigoFucionario.Text)) == 1)
                {
                    MessageBox.Show("Cadastro com sucesso!!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    desabilitarCamposNovo();
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                   
                }

            }

            else
            {
                MessageBox.Show("Senha não confere", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtSenha.Focus();
            }

      
        }
        public int AlterarUsuario(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update into tbUsuarios set usuario = @usuario , senha = @senha where codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario",MySqlDbType.VarChar,30).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;
            comm.Parameters.Add("@codUsu", MySqlDbType.VarChar, 10).Value = codigo;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (AlterarUsuario(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Usuario alterado com sucesso!!!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCamposNovo();
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario abrir = new frmPesquisaUsuario();
            abrir.Show();
            this.Hide();

        }
    }
}
