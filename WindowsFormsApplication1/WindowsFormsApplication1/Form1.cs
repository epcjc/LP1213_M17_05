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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesquisarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarselo frm = new pesquisarselo();
            frm.Show();
        }

        private void listarCriticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarcolecao frm = new listarcolecao();
            frm.Show();
        }

        private void inserirAlterarEEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editselo frm = new editselo();
            frm.Show();
        }

        private void classificação5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarselo frm = new listarselo();
            frm.Show();
        }

        private void inserirCriticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inserirselo frm = new inserirselo();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_Selos frm = new Relatorio_Selos();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Coleção de Selos.chm");
        }
    }
}
