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

namespace AgendaPessoal
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmLogin abrir = new FrmLogin();
            abrir.Show();
            this.Hide();
        }


        public void limparcampos()
        {
            ltbPesquisar.Items.Clear();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        public void pesquisarTarefa()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "";
            
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
