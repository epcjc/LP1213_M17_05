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
    public partial class DetailsView : Form
    {
        public DetailsView()
        {
            InitializeComponent();
        }

        private void restaurantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restaurantesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void DetailsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Restaurantes' table. You can move, or remove it, as needed.
            this.restaurantesTableAdapter.Fill(this.database1DataSet.Restaurantes);

        }
    }
}
