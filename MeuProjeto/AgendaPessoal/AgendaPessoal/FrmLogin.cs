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

namespace AgendaPessoal
{
    public partial class FrmLogin : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome, senha;

            nome = txtNome.Text;
            senha = txtSenha.Text;

            if (autenticarNome(nome, senha))
            {
                frmAgenda abrir = new frmAgenda();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario e senha incorretos!!!","mesagem do sistema.",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool autenticarNome(string nome,string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuario where nome = @nome and senha = @senha;";
            comm.CommandType = CommandType.Text;
            
            comm.Parameters.Clear();
            comm.Parameters.Add ("@nome",MySqlDbType.VarChar,30).Value = nome;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = senha;
            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            bool validar = DR.HasRows;

            conexao.fecharConexao();
            return validar;
        }
       
    }
}
