using FluentValidation;
using Northwind.Domain.Models;
using Northwind.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.UserForms
{
    public partial class CreateProducts : Form
    {
        private Productsfromviewmodels model = new Productsfromviewmodels();
        private readonly IProductDataProvider productDataProvider;
        private readonly IValidator<Productsfromviewmodels> validator;

        public Productsfromviewmodels Model { get => model; }

        public CreateProducts(IProductDataProvider productDataProvider, IValidator<Productsfromviewmodels> validator)
        {
            InitializeComponent();
            Load += CreateProducts_Load;
            this.productDataProvider = productDataProvider;
            this.validator = validator;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void Acceptbutton_Click(object sender, EventArgs e)
        {
            var ValidationResult = validator.Validate(model);
            if (ValidationResult.IsValid)
            {
               if(model.ProductId == 0) 
                {
                    var product = new Product
                    {
                        ProductName = model.ProductName,
                        SupplierId = model.SupplierId,
                        CategoryId = model.CategoryId,
                        QuantityPerUnit = model.QuantityPerUnit,
                        UnitPrice = model.UnitPrice,
                        UnitsInStock = model.UnitsInStock,
                        UnitsOnOrder = model.UnitsOnOrder,
                        ReorderLevel = model.ReorderLevel,
                        Discontinued = model.Discontinued,

                    };
                    productDataProvider.CraeteProduct(product);

                }
               else 
                {
                var product = productDataProvider.GetProductById(model.ProductId);
                product.ProductName = model.ProductName;
                product.SupplierId = model.SupplierId;
                product.CategoryId = model.CategoryId;
                product.QuantityPerUnit = model.QuantityPerUnit;
                product.UnitPrice = model.UnitPrice;
                product.UnitsInStock = model.UnitsInStock;
                product.UnitsOnOrder = model.UnitsOnOrder;
                product.ReorderLevel = model.ReorderLevel;
                product.Discontinued = model.Discontinued;
                
                productDataProvider.UpdateProducts(product);

                }

                DialogResult = DialogResult.OK;

            }
            else
            {
                var messages = new List<string>();
                foreach (var item in ValidationResult.Errors)
                {


                    messages.Add(item.ErrorMessage);
                }
                MessageBox.Show(string.Join('\n', messages), "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }

        private void CreateProducts_Load(object sender, EventArgs e)
        {
            CategoryIDcomboBox.DataSource = productDataProvider.GetCategories();
            CategoryIDcomboBox.ValueMember = nameof(Category.CategoryId);


            SupplierIDcomboBox.DataSource = productDataProvider.GetSuppliers();
            SupplierIDcomboBox.ValueMember = nameof(Supplier.SupplierId);

            DiscontinuedcomboBox.DataSource = productDataProvider.GetProducts();
            DiscontinuedcomboBox.ValueMember = nameof(Product.Discontinued);

            ProductIDcomboBox.DataSource = productDataProvider.GetProducts();
            ProductIDcomboBox.ValueMember = nameof(Product.ProductId);

            bindingSource1.Add(model);


        }

        private void ProductNametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
