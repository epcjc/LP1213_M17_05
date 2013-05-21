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
    public partial class Classificacao : Form
    {
        public Classificacao()
        {
            InitializeComponent();
        }

        private void Classificacao5_Load(object sender, EventArgs e)
        {
            

        }
      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.restaurantesTableAdapter.FillByClassificacao(this.database1DataSet.Restaurantes, Convert.ToInt16(listBox1.SelectedItem));
        }
    }
}
