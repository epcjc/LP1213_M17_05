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
    public partial class editselo : Form
    {
        public editselo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editselo frm = new editselo();
            frm.Show();
        }

        private void editselo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Selo' table. You can move, or remove it, as needed.
            this.seloTableAdapter.Fill(this.database1DataSet.Selo);

        }
    }
}
