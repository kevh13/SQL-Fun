﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(patClothesShopDataSet1.customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bindingSource1.EndEdit();

            int result = 0;
            //return number of items updated
            result = customerTableAdapter1.Update(patClothesShopDataSet1.customer);
            //display the row has been updated
            MessageBox.Show(result.ToString());
        } 
            
    }
}
