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
    public partial class Relatorio_Selos : Form
    {
        public Relatorio_Selos()
        {
            InitializeComponent();
        }

        private void Relatorio_Selos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Selo' table. You can move, or remove it, as needed.
            this.SeloTableAdapter.Fill(this.Database1DataSet.Selo);

            this.reportViewer1.RefreshReport();
        }
    }
}
