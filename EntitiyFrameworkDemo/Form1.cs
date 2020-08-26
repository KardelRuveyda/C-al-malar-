using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (ETradeWorkContext context = new ETradeWorkContext())
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {

            dgwProducts.DataSource = _productDal.GetAll();

        }
        private void SearchProducts(string key)
        {

            dgwProducts.DataSource = _productDal.GetAll().Where(p=> p.Name.Contains(key)).ToList();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Add");

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString());
            product.Name = txtNameUpdate.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text);
            product.StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text);

            _productDal.Update(product);

            LoadProducts();
            MessageBox.Show("Güncellendi.");
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id =Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });

            LoadProducts();
            MessageBox.Show("Silindi.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearch.Text);
        }
    }
}
