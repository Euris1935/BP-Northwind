using FluentValidation;
using Northwind.Domain.Models;
using Northwind.Infrastructure.Data;
using Northwind.UI.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.UserControls
{
    public partial class SuppliersUserControl : UserControl
    {
        private readonly CreateSuppliers createSuppliers;
        private readonly ISupplierDataProvider supplierDataProvider;
        private readonly IValidator<Suppliersfromviewmodels> validator;

        public SuppliersUserControl(CreateSuppliers createSuppliers, ISupplierDataProvider supplierDataProvider,
            IValidator<Suppliersfromviewmodels> validator)
        {
            InitializeComponent();
            this.createSuppliers = createSuppliers;
            this.supplierDataProvider = supplierDataProvider;
            this.validator = validator;
        }

        private void SuppliersUserControl_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            dataGridView1.DataSource = new BindingList<Supplier>(supplierDataProvider.GetSuppliers());
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            createSuppliers.ShowDialog();
            LoadSuppliers() ;
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
                    var dataItem = (Supplier)dataGridView1.SelectedRows[0].DataBoundItem;
                    supplierDataProvider.DeleteProduct(dataItem.SupplierId);

                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                    // LoadSuppliers();

                }
            }
            else
            {
                MessageBox.Show("Should select a row to delete!");
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var dataItem = (Supplier)dataGridView1.SelectedRows[0].DataBoundItem;
               // var createSuppliers = new CreateSuppliers(supplierDataProvider, validator);
                createSuppliers.Model.Title = "Edit/Update Suppliers";
                createSuppliers.Model.CompanyName = dataItem.CompanyName;
                createSuppliers.Model.ContactName = dataItem.ContactName;
                createSuppliers.Model.ContactTitle = dataItem.ContactTitle;
                createSuppliers.Model.Address = dataItem.Address;
                createSuppliers.Model.City = dataItem.City;
                createSuppliers.Model.Region = dataItem.Region;
                createSuppliers.Model.PostalCode = dataItem.PostalCode;
                createSuppliers.Model.Country = dataItem.Country;
                createSuppliers.Model.Phone = dataItem.Phone;
                createSuppliers.Model.Fax = dataItem.Fax;
                createSuppliers.Model.HomePage = dataItem.HomePage;
                if (createSuppliers.ShowDialog() == DialogResult.OK)
                {
                    LoadSuppliers();

                }




            }
            else
            {
                MessageBox.Show("Should Select a Row to Edit");



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
