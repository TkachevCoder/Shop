using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Введите бренд телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Введите модель телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModel.Focus();
                return;
            }

            if (!decimal.TryParse(txtPurchasePrice.Text, out decimal purchasePrice) || purchasePrice <= 0)
            {
                MessageBox.Show("Введите корректную цену закупки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPurchasePrice.Focus();
                return;
            }

            if (!decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice) || sellingPrice <= 0)
            {
                MessageBox.Show("Введите корректную цену продажи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSellingPrice.Focus();
                return;
            }

            if (sellingPrice < purchasePrice)
            {
                MessageBox.Show("Цена продажи не может быть ниже цены закупки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSellingPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Введите корректное количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }

            try
            {
                Database db = new Database();
                db.AddPhoneWithImage(
                    brand: txtBrand.Text,
                    model: txtModel.Text,
                    specifications: txtSpecifications.Text,
                    purchasePrice: purchasePrice,
                    sellingPrice: sellingPrice,
                    quantity: quantity,
                    image: imageBytes
                );

                MessageBox.Show("Товар успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] imageBytes;

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                pictureBoxImage.Image = Image.FromStream(new MemoryStream(imageBytes));
            }
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}