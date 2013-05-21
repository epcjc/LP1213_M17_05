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
    public partial class ListarCriticas : Form
    {
        public ListarCriticas()
        {
            InitializeComponent();
        }

        private void ListarCriticas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Avaliacao' table. You can move, or remove it, as needed.
            this.avaliacaoTableAdapter.Fill(this.database1DataSet.Avaliacao);
            // TODO: This line of code loads data into the 'database1DataSet.Avaliacao' table. You can move, or remove it, as needed.
            this.avaliacaoTableAdapter.Fill(this.database1DataSet.Avaliacao);
            // TODO: This line of code loads data into the 'database1DataSet.Restaurantes' table. You can move, or remove it, as needed.
            this.restaurantesTableAdapter.Fill(this.database1DataSet.Restaurantes);

        }
    }
}
