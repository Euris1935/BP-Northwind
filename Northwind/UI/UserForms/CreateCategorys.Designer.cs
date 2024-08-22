namespace Northwind.UI.UserForms
{
    partial class CreateCategorys
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
            bindingSource1 = new BindingSource(components);
            DescripciontextBox = new TextBox();
            Cancelbutton = new Button();
            Acceptbutton = new Button();
            label3 = new Label();
            CategoryIDcomboBox = new ComboBox();
            CategoryNamecomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "CategoryID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 179);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Categoriesfromviewmodels);
            // 
            // DescripciontextBox
            // 
            DescripciontextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescripciontextBox.DataBindings.Add(new Binding("Text", bindingSource1, "Description", true));
            DescripciontextBox.Location = new Point(21, 224);
            DescripciontextBox.Name = "DescripciontextBox";
            DescripciontextBox.Size = new Size(339, 27);
            DescripciontextBox.TabIndex = 3;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancelbutton.Location = new Point(223, 290);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(94, 29);
            Cancelbutton.TabIndex = 4;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = true;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // Acceptbutton
            // 
            Acceptbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Acceptbutton.Location = new Point(323, 290);
            Acceptbutton.Name = "Acceptbutton";
            Acceptbutton.Size = new Size(94, 29);
            Acceptbutton.TabIndex = 5;
            Acceptbutton.Text = "Accept";
            Acceptbutton.UseVisualStyleBackColor = true;
            Acceptbutton.Click += Acceptbutton_Click_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 97);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 6;
            label3.Text = "Category Name";
            // 
            // CategoryIDcomboBox
            // 
            CategoryIDcomboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryIDcomboBox.DataBindings.Add(new Binding("Text", bindingSource1, "CategoryId", true));
            CategoryIDcomboBox.FormattingEnabled = true;
            CategoryIDcomboBox.Location = new Point(19, 66);
            CategoryIDcomboBox.Name = "CategoryIDcomboBox";
            CategoryIDcomboBox.Size = new Size(346, 28);
            CategoryIDcomboBox.TabIndex = 7;
            // 
            // CategoryNamecomboBox
            // 
            CategoryNamecomboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryNamecomboBox.DataBindings.Add(new Binding("Text", bindingSource1, "CategoryName", true));
            CategoryNamecomboBox.FormattingEnabled = true;
            CategoryNamecomboBox.Location = new Point(19, 138);
            CategoryNamecomboBox.Name = "CategoryNamecomboBox";
            CategoryNamecomboBox.Size = new Size(346, 28);
            CategoryNamecomboBox.TabIndex = 8;
            // 
            // CreateCategorys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 339);
            Controls.Add(CategoryNamecomboBox);
            Controls.Add(CategoryIDcomboBox);
            Controls.Add(label3);
            Controls.Add(Acceptbutton);
            Controls.Add(Cancelbutton);
            Controls.Add(DescripciontextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateCategorys";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateCategory";
            Load += CreateCategorys_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox DescripciontextBox;
        private Button Cancelbutton;
        private Button Acceptbutton;
        private BindingSource bindingSource1;
        private Label label3;
        private ComboBox CategoryIDcomboBox;
        private ComboBox CategoryNamecomboBox;
    }
}