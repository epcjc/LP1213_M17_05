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
    public partial class InserirCritica : Form
    {
        public InserirCritica()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InserirCritica_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet.Restaurantes' table. You can move, or remove it, as needed.
            this.restaurantesTableAdapter.Fill(this.database1DataSet.Restaurantes);

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            try
            {
                int n =  Convert.ToInt16(textBox3.Text);


                if (n < 5)
                {
                    this.avaliacaoTableAdapter.Insert(dateTimePicker1.Value, textBox1.Text, textBox2.Text, Convert.ToInt16(textBox3.Text), Convert.ToInt16(comboBox1.SelectedValue));
                    MessageBox.Show("Dados Inseridos com exito !!!");
                }
                else
                {
                    MessageBox.Show("Erro Classificação Superior a 5");
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro !!!");
            }
        }
    }
}