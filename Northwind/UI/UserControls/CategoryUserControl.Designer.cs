namespace Northwind.UI.UserControls
{
    partial class CategoryUserControl
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
            Createbutton = new Button();
            Updatebutton = new Button();
            Deletebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(880, 434);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Createbutton
            // 
            Createbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Createbutton.Location = new Point(804, 41);
            Createbutton.Name = "Createbutton";
            Createbutton.Size = new Size(94, 29);
            Createbutton.TabIndex = 2;
            Createbutton.Text = "Create";
            Createbutton.UseVisualStyleBackColor = true;
            Createbutton.Click += Createbutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Updatebutton.Location = new Point(573, 41);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 29);
            Updatebutton.TabIndex = 3;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Deletebutton.Location = new Point(692, 41);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 29);
            Deletebutton.TabIndex = 4;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // CategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Deletebutton);
            Controls.Add(Updatebutton);
            Controls.Add(Createbutton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CategoryUserControl";
            Size = new Size(916, 537);
            Load += CategoryUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button Createbutton;
        private Button Updatebutton;
        private Button Deletebutton;
    }
}
