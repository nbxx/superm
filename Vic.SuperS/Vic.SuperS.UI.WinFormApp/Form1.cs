using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vic.SuperS.Data.Model;
using Vic.SuperS.Service;

namespace Vic.SuperS.UI.WinFormApp
{
    public partial class Form1 : Form
    {
        private ShoppingService _shoppingService = new ShoppingService();
        private ShoppingCart _cart;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _shoppingService.GetAllProducts();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = (dataGridView1.DataSource as List<Product>)[e.RowIndex];

            if (_cart != null)
            {
                _shoppingService.BuyProduct(_cart.Id, product.Id);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = _cart.ShoppingItems;
                dataGridView2.Refresh();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_cart == null)
            {
                _cart = _shoppingService.CreateShoppingCart();
            }

            dataGridView2.DataSource = _cart.ShoppingItems;
            dataGridView2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var receipt = _shoppingService.CheckOut(_cart.Id);
            MessageBox.Show(receipt.ToString());
        }
    }
}
