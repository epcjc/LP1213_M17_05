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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void restaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserirAlterarEEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void classificação5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void críticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserirCriticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.login' table. You can move, or remove it, as needed.
           

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pesquisarseloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarselo frm = new pesquisarselo();
            frm.Show();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;
            res = (int) this.loginTableAdapter.CheckLogin(this.textBox1.Text, this.textBox3.Text);

            if (res != 1)
            {
                MessageBox.Show("Acesso negado", "Erro a fazer login", MessageBoxButtons.OK);
            }
            else 
            {
                Form1 frm = new Form1();
            frm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
