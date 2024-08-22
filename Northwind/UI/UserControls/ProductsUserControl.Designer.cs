﻿namespace Northwind.UI.UserControls
{
    partial class ProductsUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Updatebutton = new Button();
            Deletebutton = new Button();
            Createbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(907, 448);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // Updatebutton
            // 
            Updatebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Updatebutton.Location = new Point(608, 41);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 29);
            Updatebutton.TabIndex = 2;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Deletebutton.Location = new Point(720, 41);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 29);
            Deletebutton.TabIndex = 3;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Createbutton
            // 
            Createbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Createbutton.Location = new Point(829, 41);
            Createbutton.Name = "Createbutton";
            Createbutton.Size = new Size(94, 29);
            Createbutton.TabIndex = 4;
            Createbutton.Text = "Create";
            Createbutton.UseVisualStyleBackColor = true;
            Createbutton.Click += Createbutton_Click;
            // 
            // ProductsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Createbutton);
            Controls.Add(Deletebutton);
            Controls.Add(Updatebutton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ProductsUserControl";
            Size = new Size(936, 539);
            Load += ProductsUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button Updatebutton;
        private Button Deletebutton;
        private Button Createbutton;
    }
}
