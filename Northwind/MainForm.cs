using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Northwind.Application.Products;
using Northwind.Domain;
using Northwind.Infrastructure.Data;
using Northwind.UI.UserControls;
using System.Data;
using System.Data.SqlTypes;

namespace Northwind
{
    public partial class MainForm : Form
    {
        private readonly ProductsUserControl productsUserControl;
        private readonly CategoryUserControl categoryUserControl;
        private readonly SuppliersUserControl suppliersUserControl;

        public MainForm(ProductsUserControl productsUserControl,
            CategoryUserControl categoryUserControl,
            SuppliersUserControl suppliersUserControl

            )
        {
            InitializeComponent();
            this.productsUserControl = productsUserControl;
            this.categoryUserControl = categoryUserControl;
            this.suppliersUserControl = suppliersUserControl;
        }





        private void MainForm_Load(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(productsUserControl);
            productsUserControl.Dock = DockStyle.Fill;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(categoryUserControl);
            categoryUserControl.Dock = DockStyle.Fill;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(suppliersUserControl);
            suppliersUserControl.Dock = DockStyle.Fill;
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
