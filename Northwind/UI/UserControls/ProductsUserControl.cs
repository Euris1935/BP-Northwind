using FluentValidation;
using Northwind.Domain.Models;
using Northwind.Infrastructure.Data;
using Northwind.UI.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.UserControls
{
    public partial class ProductsUserControl : UserControl
    {
        private readonly CreateProducts createProducts;
        private readonly IProductDataProvider productDataProvider;
        private readonly IValidator<Productsfromviewmodels> validator;

        public ProductsUserControl(CreateProducts createProducts, IProductDataProvider productDataProvider,
            IValidator<Productsfromviewmodels> validator)
        {
            InitializeComponent();
            this.createProducts = createProducts;
            this.productDataProvider = productDataProvider;
            this.validator = validator;
        }

        private void ProductsUserControl_Load(object sender, EventArgs e)
        {
            LoadProducts();

        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = new BindingList<Product>(productDataProvider.GetProducts());
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            createProducts.ShowDialog();
            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public void Updatebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var dataItem = (Product)dataGridView1.SelectedRows[0].DataBoundItem;
                // var createProducts = new CreateProducts(productDataProvider, validator);
                createProducts.Model.Title = "Edit/Update Products";
                createProducts.Model.ProductId = dataItem.ProductId;
                createProducts.Model.ProductName = dataItem.ProductName;
                createProducts.Model.SupplierId = dataItem.SupplierId;
                createProducts.Model.CategoryId = dataItem.CategoryId;
                createProducts.Model.QuantityPerUnit = dataItem.QuantityPerUnit;
                createProducts.Model.UnitPrice = dataItem.UnitPrice;
                createProducts.Model.UnitsInStock = dataItem.UnitsInStock;
                createProducts.Model.UnitsOnOrder = dataItem.UnitsOnOrder;
                createProducts.Model.ReorderLevel = dataItem.ReorderLevel;
                createProducts.Model.Discontinued = dataItem.Discontinued;
                if (createProducts.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();

                }


            }
            else
            {
                MessageBox.Show("Should Select a Row to Edit");



            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Are you sure about deleting this product?",
                    "Delete Product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var dataItem = (Product)dataGridView1.SelectedRows[0].DataBoundItem;
                    productDataProvider.DeleteProduct(dataItem.ProductId);

                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    //LoadProducts();

                }
            }
            else
            {
                MessageBox.Show("Should select a row to delete!");
            }
        }
                    
                    
                    
                    
            
            
            
            
        
    }
}
