using System.Windows.Forms;

namespace Shop
{
    partial class SalesControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.DataGridView dataGridViewSalesHistory;

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.TextBox txtQuantityPhone ;
            private System.Windows.Forms.TextBox txtQuantityService;
            private System.Windows.Forms.Button btnAddPhoneToCart ;
            private System.Windows.Forms.Button btnAddServiceToCart;

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
            dataGridViewSalesHistory = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewCart = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            cmbProducts = new ComboBox();
            cmbServices = new ComboBox();
            txtQuantityPhone = new TextBox();
            txtQuantityService = new TextBox();
            btnAddPhoneToCart = new Button();
            btnAddServiceToCart = new Button();
            btnSell = new Button();
            btnRemoveFromCart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSalesHistory
            // 
            dataGridViewSalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalesHistory.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewSalesHistory.Location = new Point(9, 368);
            dataGridViewSalesHistory.Name = "dataGridViewSalesHistory";
            dataGridViewSalesHistory.ReadOnly = true;
            dataGridViewSalesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSalesHistory.Size = new Size(820, 361);
            dataGridViewSalesHistory.TabIndex = 7;
            dataGridViewSalesHistory.CellContentClick += dataGridViewSalesHistory_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID продажи";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
           
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Дата продажи";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Товар/Услуга";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Количество";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Цена";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Общая сумма";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewCart.Location = new Point(9, 9);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.ReadOnly = true;
            dataGridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCart.Size = new Size(235, 350);
            dataGridViewCart.TabIndex = 0;
            dataGridViewCart.CellContentClick += dataGridViewCart_CellContentClick;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "ID";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Название";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Количество";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(250, 56);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(132, 23);
            cmbProducts.TabIndex = 1;
            // 
            // cmbServices
            // 
            cmbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(250, 116);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(132, 23);
            cmbServices.TabIndex = 2;
            // 
            // txtQuantityPhone
            // 
            txtQuantityPhone.Location = new Point(397, 56);
            txtQuantityPhone.Name = "txtQuantityPhone";
            txtQuantityPhone.Size = new Size(88, 23);
            txtQuantityPhone.TabIndex = 3;
            // 
            // txtQuantityService
            // 
            txtQuantityService.Location = new Point(397, 116);
            txtQuantityService.Name = "txtQuantityService";
            txtQuantityService.Size = new Size(88, 23);
            txtQuantityService.TabIndex = 4;
            // 
            // btnAddPhoneToCart
            // 
            btnAddPhoneToCart.Location = new Point(491, 52);
            btnAddPhoneToCart.Name = "btnAddPhoneToCart";
            btnAddPhoneToCart.Size = new Size(151, 28);
            btnAddPhoneToCart.TabIndex = 5;
            btnAddPhoneToCart.Text = "Добавить телефон";
            btnAddPhoneToCart.UseVisualStyleBackColor = true;
            btnAddPhoneToCart.Click += btnAddPhoneToCart_Click;
            // 
            // btnAddServiceToCart
            // 
            btnAddServiceToCart.Location = new Point(491, 112);
            btnAddServiceToCart.Name = "btnAddServiceToCart";
            btnAddServiceToCart.Size = new Size(151, 28);
            btnAddServiceToCart.TabIndex = 6;
            btnAddServiceToCart.Text = "Добавить услугу";
            btnAddServiceToCart.UseVisualStyleBackColor = true;
            btnAddServiceToCart.Click += btnAddServiceToCart_Click;
            // 
            // btnSell
            // 
            btnSell.Location = new Point(473, 146);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(169, 41);
            btnSell.TabIndex = 7;
            btnSell.Text = "Продать";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(250, 145);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(169, 42);
            btnRemoveFromCart.TabIndex = 8;
            btnRemoveFromCart.Text = "Удалить из корзины";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 38);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 9;
            label1.Text = "Телефон";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 38);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 10;
            label2.Text = "Количество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 98);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 11;
            label3.Text = "Услуга";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 98);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 12;
            label4.Text = "Количество";
            // 
            // SalesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnSell);
            Controls.Add(btnAddServiceToCart);
            Controls.Add(btnAddPhoneToCart);
            Controls.Add(txtQuantityService);
            Controls.Add(txtQuantityPhone);
            Controls.Add(cmbServices);
            Controls.Add(cmbProducts);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewSalesHistory);
            Name = "SalesControl";
            Size = new Size(832, 729);
            Load += SalesControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}