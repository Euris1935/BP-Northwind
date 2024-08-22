namespace Northwind
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            productToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            ContentPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem, categoryToolStripMenuItem, supplierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1009, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            productToolStripMenuItem.ForeColor = Color.Blue;
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(83, 27);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            categoryToolStripMenuItem.ForeColor = Color.Red;
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(94, 27);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            supplierToolStripMenuItem.ForeColor = Color.FromArgb(0, 192, 0);
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(88, 27);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(0, 31);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1009, 471);
            ContentPanel.TabIndex = 1;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 502);
            Controls.Add(ContentPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private Panel ContentPanel;
    }
}
