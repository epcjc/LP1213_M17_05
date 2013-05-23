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
    public partial class pesquisarselo : Form
    {
        public pesquisarselo()
        {
            InitializeComponent();
        }

        private void pesquisarselo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Selo' table. You can move, or remove it, as needed.
            this.seloTableAdapter.Fill(this.database1DataSet.Selo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // this.seloTableAdapter.Fill_NC(this.database1DataSet.selo, textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
