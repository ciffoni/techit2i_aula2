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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text=="Ciffoni" && txtSenha.Text == "Aula123")
            {
                //chama o formulario principal
                FrmPrincipal principal = new FrmPrincipal();
                //mostrar a janela principal
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalido!");
            }
        }
    }
}
