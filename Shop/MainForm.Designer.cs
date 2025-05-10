namespace Shop
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabSales;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabProducts = new TabPage();
            tabServices = new TabPage();
            tabSales = new TabPage();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabProducts);
            tabControlMain.Controls.Add(tabServices);
            tabControlMain.Controls.Add(tabSales);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(689, 730);
            tabControlMain.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Location = new Point(4, 24);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(681, 702);
            tabProducts.TabIndex = 0;
            tabProducts.Text = "Товары";
            tabProducts.UseVisualStyleBackColor = true;
            tabProducts.Click += tabProducts_Click;
            // 
            // tabServices
            // 
            tabServices.Location = new Point(4, 24);
            tabServices.Name = "tabServices";
            tabServices.Padding = new Padding(3);
            tabServices.Size = new Size(702, 702);
            tabServices.TabIndex = 1;
            tabServices.Text = "Услуги";
            tabServices.UseVisualStyleBackColor = true;
            // 
            // tabSales
            // 
            tabSales.Location = new Point(4, 24);
            tabSales.Name = "tabSales";
            tabSales.Padding = new Padding(3);
            tabSales.Size = new Size(702, 702);
            tabSales.TabIndex = 2;
            tabSales.Text = "Продажи";
            tabSales.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 730);
            Controls.Add(tabControlMain);
            Name = "MainForm";
            Text = "Магазин телефонов";
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}