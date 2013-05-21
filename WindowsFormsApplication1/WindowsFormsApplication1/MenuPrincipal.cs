using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inserirAlterarEEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsView frm = new DetailsView();
            frm.Show();
        }

        private void pesquisarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarRestaurante frm = new PesquisarRestaurante();
            frm.Show();
        }

        private void classificação5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classificacao frm = new Classificacao();
            frm.Show();
        }

        private void listarCriticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCriticas frm = new ListarCriticas();
            frm.Show();
        }

        private void inserirCriticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirCritica frm = new InserirCritica();
            frm.Show();
        }
    }
}
