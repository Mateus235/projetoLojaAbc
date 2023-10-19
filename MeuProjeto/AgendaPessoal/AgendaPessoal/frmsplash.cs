using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AgendaPessoal
{
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                pgbCarregamento.Value = i;
            }

         
        }

          
        }
    }

