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
    public partial class frmPesquisaDaTarefa : Form
    {
        public frmPesquisaDaTarefa()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
               
            }
        }
        private void pesquisarNomeTarefa()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "";
            comm.CommandType = CommandType.Text;


        }
     }
}
