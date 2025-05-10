using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class EditPhoneForm : Form
    {
        private int phoneId;

        public EditPhoneForm(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            phoneId = id;
            LoadPhoneData();
        }

        private void LoadPhoneData()
        {
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteReader($"SELECT * FROM Phones WHERE ID = {phoneId}");

            if (reader.Read())
            {
                txtBrand.Text = reader.GetString("Brand");
                txtModel.Text = reader.GetString("Model");
                txtSpecs.Text = reader.GetString("Specifications");
                txtPurchasePrice.Text = reader.GetDecimal("PurchasePrice").ToString();
                txtSellingPrice.Text = reader.GetDecimal("SellingPrice").ToString();
                txtQuantity.Text = reader.GetInt32("Quantity").ToString();

                if (!reader.IsDBNull(reader.GetOrdinal("Image")))
                {
                    byte[] imageBytes = (byte[])reader["Image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            reader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }



        private void btnUploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
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
                byte[] imageBytes = null;
                if (pictureBox.Image != null)
                {
                    imageBytes = ImageToByteArray(pictureBox.Image);
                }

                Database db = new Database();
                db.ExecuteNonQueryWithParams(
                    @"UPDATE Phones SET 
                Brand = @Brand,
                Model = @Model,
                Specifications = @Specs,
                PurchasePrice = @PurchasePrice,
                SellingPrice = @SellingPrice,
                Quantity = @Quantity,
                Image = @Image
              WHERE ID = @PhoneID",
                    new MySqlParameter("@Brand", txtBrand.Text),
                    new MySqlParameter("@Model", txtModel.Text),
                    new MySqlParameter("@Specs", txtSpecs.Text),
                    new MySqlParameter("@PurchasePrice", purchasePrice),
                    new MySqlParameter("@SellingPrice", sellingPrice),
                    new MySqlParameter("@Quantity", quantity),
                    new MySqlParameter("@Image", imageBytes ?? (object)DBNull.Value),
                    new MySqlParameter("@PhoneID", phoneId)
                );

                MessageBox.Show("Данные товара успешно обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}