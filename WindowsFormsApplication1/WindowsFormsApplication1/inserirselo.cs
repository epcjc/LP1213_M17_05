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
    public partial class inserirselo : Form
    {
        public inserirselo()
        {
            InitializeComponent();
        }

        private void seloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void inserirselo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Selo' table. You can move, or remove it, as needed.
            this.seloTableAdapter.Fill(this.database1DataSet.Selo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
