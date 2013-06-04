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
    public partial class listarcolecao : Form
    {
        public listarcolecao()
        {
            InitializeComponent();
        }

        private void listarcolecao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ligação' table. You can move, or remove it, as needed.
            this.ligaçãoTableAdapter.Fill(this.database1DataSet.ligação);
            // TODO: This line of code loads data into the 'database1DataSet.Correspondente' table. You can move, or remove it, as needed.
            this.correspondenteTableAdapter.Fill(this.database1DataSet.Correspondente);
            // TODO: This line of code loads data into the 'database1DataSet.Selo' table. You can move, or remove it, as needed.
            this.seloTableAdapter.Fill(this.database1DataSet.Selo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
