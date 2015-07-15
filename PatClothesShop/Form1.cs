using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatClothesShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patClothesShopDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patClothesShopDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.patClothesShopDataSet.customer);
            // TODO: This line of code loads data into the 'patClothesShopDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.patClothesShopDataSet.customer);

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patClothesShopDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
