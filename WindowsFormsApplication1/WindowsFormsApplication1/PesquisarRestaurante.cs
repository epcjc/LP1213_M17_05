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
    public partial class PesquisarRestaurante : Form
    {
        public PesquisarRestaurante()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.restaurantesTableAdapter.Fill_NC(this.database1DataSet.Restaurantes, textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }

        }

        private void PesquisarRestaurante_Load(object sender, EventArgs e)
        {

            this.restaurantesTableAdapter.Fill(this.database1DataSet.Restaurantes);
        }
    }
}
