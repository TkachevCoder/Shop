namespace Shop
{
    partial class ProductsControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQuantityChange;
        private System.Windows.Forms.Button btnIncreaseQuantity;
        private System.Windows.Forms.Button btnDecreaseQuantity;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSpecifications;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSellingPrice;

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
            txtQuantityChange = new TextBox();
            btnIncreaseQuantity = new Button();
            btnDecreaseQuantity = new Button();
            dataGridViewProducts = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnAddProduct = new Button();
            btnDeleteProduct = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblBrand = new Label();
            lblModel = new Label();
            lblSpecifications = new Label();
            lblPurchasePrice = new Label();
            lblSellingPrice = new Label();
            pictureBoxProductImage = new PictureBox();
            btnEditProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            SuspendLayout();
            // 
            // txtQuantityChange
            // 
            txtQuantityChange.Location = new Point(62, 458);
            txtQuantityChange.Name = "txtQuantityChange";
            txtQuantityChange.Size = new Size(100, 23);
            txtQuantityChange.TabIndex = 5;
            // 
            // btnIncreaseQuantity
            // 
            btnIncreaseQuantity.Location = new Point(168, 458);
            btnIncreaseQuantity.Name = "btnIncreaseQuantity";
            btnIncreaseQuantity.Size = new Size(88, 23);
            btnIncreaseQuantity.TabIndex = 6;
            btnIncreaseQuantity.Text = "Пополнить";
            btnIncreaseQuantity.UseVisualStyleBackColor = true;
            btnIncreaseQuantity.Click += btnIncreaseQuantity_Click;
            // 
            // btnDecreaseQuantity
            // 
            btnDecreaseQuantity.Location = new Point(262, 458);
            btnDecreaseQuantity.Name = "btnDecreaseQuantity";
            btnDecreaseQuantity.Size = new Size(88, 23);
            btnDecreaseQuantity.TabIndex = 7;
            btnDecreaseQuantity.Text = "Уменьшить";
            btnDecreaseQuantity.UseVisualStyleBackColor = true;
            btnDecreaseQuantity.Click += btnDecreaseQuantity_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewProducts.Location = new Point(62, 9);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(544, 376);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Бренд";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Модель";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Цена";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Кол-во";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(62, 391);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(105, 28);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Добавить товар";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(175, 391);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(105, 28);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Удалить товар";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(62, 428);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(218, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(286, 428);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(168, 523);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(46, 15);
            lblBrand.TabIndex = 8;
            lblBrand.Text = "Марка:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(168, 548);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 9;
            lblModel.Text = "Модель:";
            // 
            // lblSpecifications
            // 
            lblSpecifications.AutoSize = true;
            lblSpecifications.Location = new Point(168, 573);
            lblSpecifications.Name = "lblSpecifications";
            lblSpecifications.Size = new Size(98, 15);
            lblSpecifications.TabIndex = 10;
            lblSpecifications.Text = "Характеристики:";
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Location = new Point(168, 598);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(83, 15);
            lblPurchasePrice.TabIndex = 11;
            lblPurchasePrice.Text = "Цена приема:";
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Location = new Point(168, 623);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(90, 15);
            lblSellingPrice.TabIndex = 12;
            lblSellingPrice.Text = "Цена продажи:";
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProductImage.Location = new Point(408, 391);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(198, 115);
            pictureBoxProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProductImage.TabIndex = 13;
            pictureBoxProductImage.TabStop = false;
            pictureBoxProductImage.Click += pictureBox1_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(286, 391);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(96, 28);
            btnEditProduct.TabIndex = 14;
            btnEditProduct.Text = "Редактировать";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditProduct);
            Controls.Add(lblSellingPrice);
            Controls.Add(lblPurchasePrice);
            Controls.Add(lblSpecifications);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(txtQuantityChange);
            Controls.Add(btnIncreaseQuantity);
            Controls.Add(btnDecreaseQuantity);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(dataGridViewProducts);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(pictureBoxProductImage);
            Name = "ProductsControl";
            Size = new Size(681, 660);
            Load += ProductsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private PictureBox pictureBoxProductImage;
        private Button btnEditProduct;
    }
}