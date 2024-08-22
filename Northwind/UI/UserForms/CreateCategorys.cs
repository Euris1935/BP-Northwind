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
    public partial class CreateCategorys : Form
    {
        private Categoriesfromviewmodels model = new Categoriesfromviewmodels();
        private readonly ICategoryDataProvider categoryDataProvider;
        private readonly IValidator<Categoriesfromviewmodels> validator;

        public Categoriesfromviewmodels Model { get => model;}

        public CreateCategorys(ICategoryDataProvider categoryDataProvider, IValidator<Categoriesfromviewmodels> validator)
        {
            InitializeComponent();
            this.categoryDataProvider = categoryDataProvider;
            this.validator = validator;
        }
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void Acceptbutton_Click(object sender, EventArgs e)
        {
          
        }
        private void CreateCategorys_Load(object sender, EventArgs e)
        {
            CategoryIDcomboBox.DataSource = categoryDataProvider.GetCategories();
            CategoryIDcomboBox.ValueMember = nameof(Category.CategoryId);
            CategoryNamecomboBox.DataSource = categoryDataProvider.GetCategories();
            CategoryNamecomboBox.DisplayMember = nameof(Category.CategoryName);





            bindingSource1.Add(model);
        }

        private void Acceptbutton_Click_1(object sender, EventArgs e)
        {
            var ValidationResult = validator.Validate(model);
            if (ValidationResult.IsValid)
            {
                if (model.CategoryId == 0)
                {
                    var categories = (new Category
                    {
                        CategoryName = model.CategoryName,
                        Description = model.Description,

                    });
                    categoryDataProvider.CrateCategories(categories);

                }
                else
                {
                    var category = categoryDataProvider.GetCategoryById(model.CategoryId);
                    category.CategoryName = model.CategoryName;
                    category.Description = model.Description;




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
    }
}
