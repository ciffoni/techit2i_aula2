﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form1 para quem nao trocou o nome
           FrmUsuario usuario = new FrmUsuario();
            usuario.MdiParent = this;//informar  que é janela filha
            usuario.Show(); //mostra a janela 
        }
    }
}
