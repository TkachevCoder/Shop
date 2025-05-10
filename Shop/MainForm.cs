using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.TabPage tabReports;
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            tabReports = new TabPage();
            tabReports.Text = "Отчеты";
            tabControlMain.Controls.Add(tabReports);

            ReportsControl reportsControl = new ReportsControl();
            tabReports.Controls.Add(reportsControl);
            reportsControl.Dock = DockStyle.Fill;
            
            ProductsControl productsControl = new ProductsControl();
            tabProducts.Controls.Add(productsControl);
            productsControl.Dock = DockStyle.Fill;

            ServicesControl servicesControl = new ServicesControl();
            tabServices.Controls.Add(servicesControl);
            servicesControl.Dock = DockStyle.Fill;

            SalesControl salesControl = new SalesControl();
            tabSales.Controls.Add(salesControl);
            salesControl.Dock = DockStyle.Fill;
        }

        private void tabProducts_Click(object sender, EventArgs e)
        {

        }
    }
}