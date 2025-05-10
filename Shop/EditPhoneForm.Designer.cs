namespace Shop
{
    partial class EditPhoneForm
    {


        private void InitializeComponent()
        {
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtSpecs = new TextBox();
            txtQuantity = new TextBox();
            txtSellingPrice = new TextBox();
            txtPurchasePrice = new TextBox();
            pictureBox = new PictureBox();
            btnUploadImage = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(108, 9);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(108, 48);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 1;
            // 
            // txtSpecs
            // 
            txtSpecs.Location = new Point(108, 92);
            txtSpecs.Name = "txtSpecs";
            txtSpecs.Size = new Size(100, 23);
            txtSpecs.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(108, 223);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 5;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(108, 179);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(100, 23);
            txtSellingPrice.TabIndex = 4;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(108, 140);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(100, 23);
            txtPurchasePrice.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(30, 252);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(149, 86);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(30, 344);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(159, 32);
            btnUploadImage.TabIndex = 7;
            btnUploadImage.Text = "Выбрать изображение";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Марка";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "Модель";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 11;
            label3.Text = "Хар-ки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 12;
            label4.Text = "Цена приема";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 182);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 13;
            label5.Text = "Цена продажи";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 226);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 14;
            label6.Text = "Кол-во";
            // 
            // EditPhoneForm
            // 
            ClientSize = new Size(230, 438);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnUploadImage);
            Controls.Add(pictureBox);
            Controls.Add(txtQuantity);
            Controls.Add(txtSellingPrice);
            Controls.Add(txtPurchasePrice);
            Controls.Add(txtSpecs);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Name = "EditPhoneForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtSpecs;
        private TextBox txtQuantity;
        private TextBox txtSellingPrice;
        private TextBox txtPurchasePrice;
        private PictureBox pictureBox;
        private Button btnUploadImage;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}