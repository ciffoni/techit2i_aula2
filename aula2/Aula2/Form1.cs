using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text=="")
            {
                MessageBox.Show("campo nome está vazio!");
                txtNome.Focus();//recebe o curso do mouse no texto nome
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Campo email está vazio!");
                txtEmail.Focus();
            }
            else
            {


                MessageBox.Show("Ola usuário" + txtNome.Text +
                      "\n seu e-mai é:" + txtEmail.Text);
            }
        }
    }
}
