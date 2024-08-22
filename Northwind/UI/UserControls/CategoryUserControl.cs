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
    public partial class CategoryUserControl : UserControl
    {
        private readonly CreateCategorys createCategorys;
        private readonly ICategoryDataProvider categoryDataProvider;


        public CategoryUserControl(CreateCategorys createCategorys, ICategoryDataProvider categoryDataProvider
           )
        {
            InitializeComponent();
            this.createCategorys = createCategorys;
            this.categoryDataProvider = categoryDataProvider;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            createCategorys.ShowDialog();
            LoadCategories();
        }

        private void CategoryUserControl_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dataGridView1.DataSource = new BindingList<Category>(categoryDataProvider.GetCategories());
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var dataItem = (Category)dataGridView1.SelectedRows[0].DataBoundItem;
                createCategorys.Model.Title = "Edit/Update Categories";
                createCategorys.Model.CategoryId = dataItem.CategoryId;
                createCategorys.Model.CategoryName = dataItem.CategoryName;
                createCategorys.Model.Description = dataItem.Description;
                if (createCategorys.ShowDialog() == DialogResult.OK)
                {
                    LoadCategories();

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
                    var dataItem = (Category)dataGridView1.SelectedRows[0].DataBoundItem;
                    categoryDataProvider.DeleteProduct(dataItem.CategoryId);

                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                    //LoadCategories();

                }
            }
            else
            {
                MessageBox.Show("Should select a row to delete!");
            }
        }
    }
}
