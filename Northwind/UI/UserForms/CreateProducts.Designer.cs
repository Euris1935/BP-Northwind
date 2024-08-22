namespace Northwind.UI.UserForms
{
    partial class CreateProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ProductNametextBox = new TextBox();
            bindingSource1 = new BindingSource(components);
            SupplierIDcomboBox = new ComboBox();
            QuantityperUnittextBox = new TextBox();
            UnitPricetextBox = new TextBox();
            UnitsinStocktextBox = new TextBox();
            UnitsOnOrdertextBox = new TextBox();
            ReorderleveltextBox = new TextBox();
            DiscontinuedcomboBox = new ComboBox();
            Cancelbutton = new Button();
            Acceptbutton = new Button();
            CategoryIDcomboBox = new ComboBox();
            label10 = new Label();
            ProductIDcomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "SupplierID";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 2;
            label3.Text = "CategoryID";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 268);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 3;
            label4.Text = "Quantity Per Unit";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 333);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 4;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 404);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 5;
            label6.Text = "Units in Stock";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 475);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 6;
            label7.Text = "Units on Order";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 544);
            label8.Name = "label8";
            label8.Size = new Size(115, 23);
            label8.TabIndex = 7;
            label8.Text = "Reorder Level";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 613);
            label9.Name = "label9";
            label9.Size = new Size(110, 23);
            label9.TabIndex = 8;
            label9.Text = "Discontinued";
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductNametextBox.DataBindings.Add(new Binding("Text", bindingSource1, "ProductName", true));
            ProductNametextBox.Location = new Point(12, 90);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(305, 27);
            ProductNametextBox.TabIndex = 9;
            ProductNametextBox.TextChanged += ProductNametextBox_TextChanged;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Productsfromviewmodels);
            // 
            // SupplierIDcomboBox
            // 
            SupplierIDcomboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SupplierIDcomboBox.DataBindings.Add(new Binding("Text", bindingSource1, "SupplierId", true));
            SupplierIDcomboBox.FormattingEnabled = true;
            SupplierIDcomboBox.Location = new Point(12, 156);
            SupplierIDcomboBox.Name = "SupplierIDcomboBox";
            SupplierIDcomboBox.Size = new Size(305, 28);
            SupplierIDcomboBox.TabIndex = 10;
            // 
            // QuantityperUnittextBox
            // 
            QuantityperUnittextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            QuantityperUnittextBox.DataBindings.Add(new Binding("Text", bindingSource1, "QuantityPerUnit", true));
            QuantityperUnittextBox.Location = new Point(12, 303);
            QuantityperUnittextBox.Name = "QuantityperUnittextBox";
            QuantityperUnittextBox.Size = new Size(305, 27);
            QuantityperUnittextBox.TabIndex = 12;
            // 
            // UnitPricetextBox
            // 
            UnitPricetextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UnitPricetextBox.DataBindings.Add(new Binding("Text", bindingSource1, "UnitPrice", true));
            UnitPricetextBox.Location = new Point(12, 374);
            UnitPricetextBox.Name = "UnitPricetextBox";
            UnitPricetextBox.Size = new Size(305, 27);
            UnitPricetextBox.TabIndex = 13;
            // 
            // UnitsinStocktextBox
            // 
            UnitsinStocktextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UnitsinStocktextBox.DataBindings.Add(new Binding("Text", bindingSource1, "UnitsInStock", true));
            UnitsinStocktextBox.Location = new Point(12, 430);
            UnitsinStocktextBox.Name = "UnitsinStocktextBox";
            UnitsinStocktextBox.Size = new Size(305, 27);
            UnitsinStocktextBox.TabIndex = 14;
            // 
            // UnitsOnOrdertextBox
            // 
            UnitsOnOrdertextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UnitsOnOrdertextBox.DataBindings.Add(new Binding("Text", bindingSource1, "UnitsOnOrder", true));
            UnitsOnOrdertextBox.Location = new Point(12, 514);
            UnitsOnOrdertextBox.Name = "UnitsOnOrdertextBox";
            UnitsOnOrdertextBox.Size = new Size(305, 27);
            UnitsOnOrdertextBox.TabIndex = 15;
            // 
            // ReorderleveltextBox
            // 
            ReorderleveltextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReorderleveltextBox.DataBindings.Add(new Binding("Text", bindingSource1, "ReorderLevel", true));
            ReorderleveltextBox.Location = new Point(12, 570);
            ReorderleveltextBox.Name = "ReorderleveltextBox";
            ReorderleveltextBox.Size = new Size(305, 27);
            ReorderleveltextBox.TabIndex = 16;
            // 
            // DiscontinuedcomboBox
            // 
            DiscontinuedcomboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DiscontinuedcomboBox.DataBindings.Add(new Binding("Text", bindingSource1, "Discontinued", true));
            DiscontinuedcomboBox.FormattingEnabled = true;
            DiscontinuedcomboBox.Location = new Point(12, 648);
            DiscontinuedcomboBox.Name = "DiscontinuedcomboBox";
            DiscontinuedcomboBox.Size = new Size(305, 28);
            DiscontinuedcomboBox.TabIndex = 17;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancelbutton.Location = new Point(147, 699);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(82, 28);
            Cancelbutton.TabIndex = 18;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = true;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // Acceptbutton
            // 
            Acceptbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Acceptbutton.Location = new Point(235, 699);
            Acceptbutton.Name = "Acceptbutton";
            Acceptbutton.Size = new Size(82, 28);
            Acceptbutton.TabIndex = 19;
            Acceptbutton.Text = "Accept";
            Acceptbutton.UseVisualStyleBackColor = true;
            Acceptbutton.Click += Acceptbutton_Click;
            // 
            // CategoryIDcomboBox
            // 
            CategoryIDcomboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryIDcomboBox.DataBindings.Add(new Binding("Text", bindingSource1, "CategoryId", true));
            CategoryIDcomboBox.FormattingEnabled = true;
            CategoryIDcomboBox.Location = new Point(12, 237);
            CategoryIDcomboBox.Name = "CategoryIDcomboBox";
            CategoryIDcomboBox.Size = new Size(297, 28);
            CategoryIDcomboBox.TabIndex = 20;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 9);
            label10.Name = "label10";
            label10.Size = new Size(87, 23);
            label10.TabIndex = 21;
            label10.Text = "ProductID";
            // 
            // ProductIDcomboBox
            // 
            ProductIDcomboBox.DataBindings.Add(new Binding("Text", bindingSource1, "ProductId", true));
            ProductIDcomboBox.FormattingEnabled = true;
            ProductIDcomboBox.Location = new Point(12, 33);
            ProductIDcomboBox.Name = "ProductIDcomboBox";
            ProductIDcomboBox.Size = new Size(305, 28);
            ProductIDcomboBox.TabIndex = 22;
            // 
            // CreateProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 739);
            Controls.Add(ProductIDcomboBox);
            Controls.Add(label10);
            Controls.Add(CategoryIDcomboBox);
            Controls.Add(Acceptbutton);
            Controls.Add(Cancelbutton);
            Controls.Add(DiscontinuedcomboBox);
            Controls.Add(ReorderleveltextBox);
            Controls.Add(UnitsOnOrdertextBox);
            Controls.Add(UnitsinStocktextBox);
            Controls.Add(UnitPricetextBox);
            Controls.Add(QuantityperUnittextBox);
            Controls.Add(SupplierIDcomboBox);
            Controls.Add(ProductNametextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateProducts";
            ShowInTaskbar = false;
            Text = "CreateProduct";
            Load += CreateProducts_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox ProductNametextBox;
        private ComboBox SupplierIDcomboBox;
        private TextBox QuantityperUnittextBox;
        private TextBox UnitPricetextBox;
        private TextBox UnitsinStocktextBox;
        private TextBox UnitsOnOrdertextBox;
        private TextBox ReorderleveltextBox;
        private ComboBox DiscontinuedcomboBox;
        private Button Cancelbutton;
        private Button Acceptbutton;
        private BindingSource bindingSource1;
        private ComboBox CategoryIDcomboBox;
        private Label label10;
        private ComboBox ProductIDcomboBox;
    }
}