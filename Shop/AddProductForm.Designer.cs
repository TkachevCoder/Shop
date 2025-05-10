namespace Shop
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSpecifications;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSpecifications;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private PictureBox pictureBoxImage;
        private Button btnUploadImage;

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
            lblBrand = new Label();
            lblModel = new Label();
            lblSpecifications = new Label();
            lblPurchasePrice = new Label();
            lblSellingPrice = new Label();
            lblQuantity = new Label();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtSpecifications = new TextBox();
            txtPurchasePrice = new TextBox();
            txtSellingPrice = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            pictureBoxImage = new PictureBox();
            btnUploadImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(18, 19);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(46, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Марка:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(18, 56);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 1;
            lblModel.Text = "Модель:";
            // 
            // lblSpecifications
            // 
            lblSpecifications.AutoSize = true;
            lblSpecifications.Location = new Point(18, 94);
            lblSpecifications.Name = "lblSpecifications";
            lblSpecifications.Size = new Size(98, 15);
            lblSpecifications.TabIndex = 2;
            lblSpecifications.Text = "Характеристики:";
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Location = new Point(18, 131);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(83, 15);
            lblPurchasePrice.TabIndex = 3;
            lblPurchasePrice.Text = "Цена приема:";
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Location = new Point(18, 169);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(90, 15);
            lblSellingPrice.TabIndex = 4;
            lblSellingPrice.Text = "Цена продажи:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(18, 207);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Количество:";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(131, 19);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(176, 23);
            txtBrand.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(131, 56);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(176, 23);
            txtModel.TabIndex = 7;
            // 
            // txtSpecifications
            // 
            txtSpecifications.Location = new Point(131, 94);
            txtSpecifications.Name = "txtSpecifications";
            txtSpecifications.Size = new Size(176, 23);
            txtSpecifications.TabIndex = 8;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(131, 131);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(88, 23);
            txtPurchasePrice.TabIndex = 9;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(131, 169);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(88, 23);
            txtSellingPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(131, 207);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(88, 23);
            txtQuantity.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(289, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImage.Location = new Point(18, 236);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(150, 150);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(174, 268);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(133, 89);
            btnUploadImage.TabIndex = 1;
            btnUploadImage.Text = "Загрузить изображение";
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 466);
            Controls.Add(pictureBoxImage);
            Controls.Add(btnUploadImage);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtSellingPrice);
            Controls.Add(txtPurchasePrice);
            Controls.Add(txtSpecifications);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(lblQuantity);
            Controls.Add(lblSellingPrice);
            Controls.Add(lblPurchasePrice);
            Controls.Add(lblSpecifications);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Name = "AddProductForm";
            Text = "Добавить товар";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}