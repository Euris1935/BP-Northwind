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
    public partial class CreateSuppliers : Form
    {
        private Suppliersfromviewmodels model = new Suppliersfromviewmodels();
        private readonly ISupplierDataProvider supplierDataProvider;
        private readonly IValidator<Suppliersfromviewmodels> validator;

        public Suppliersfromviewmodels Model { get => model;}

        public CreateSuppliers(ISupplierDataProvider supplierDataProvider, IValidator<Suppliersfromviewmodels> validator)
        {
            InitializeComponent();
            this.supplierDataProvider = supplierDataProvider;
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
                if(model.SupplierId == 0)
                {
                    var supplier = new Supplier
                    {
                        CompanyName = model.CompanyName,
                        ContactName = model.ContactName,
                        ContactTitle = model.ContactTitle,
                        Address = model.Address,
                        City = model.City,
                        Region = model.Region,
                        PostalCode = model.PostalCode,
                        Country = model.Country,
                        Phone = model.Phone,
                        Fax = model.Fax,
                        HomePage = model.HomePage,

                    };
                    supplierDataProvider.Createsupplier(supplier);

                }
                else
                {
                 var supplier = supplierDataProvider.GetSupplierById(model.SupplierId);
                 supplier.CompanyName = model.CompanyName;
                 supplier.ContactName = model.ContactName;
                 supplier.ContactTitle = model.ContactTitle;
                 supplier.Address = model.Address;
                 supplier.City = model.City;
                 supplier.Region = model.Region;
                 supplier.PostalCode = model.PostalCode;
                 supplier.Country = model.Country;
                 supplier.Phone = model.Phone;
                 supplier.Fax = model.Fax;
                 supplier.HomePage = model.HomePage;

                 supplierDataProvider.UpdateSuppliers(supplier);


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

        

        private void CreateSuppliers_Load(object sender, EventArgs e)
        {
            SupplierIDcomboBox.DataSource = supplierDataProvider.GetSuppliers();
            SupplierIDcomboBox.ValueMember = nameof(Supplier.SupplierId);


            bindingSource1.Add(model);
        }


    }
}
