using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class ProductsControl : UserControl
    {
        public ProductsControl()
        {
            InitializeComponent();
            LoadProducts();
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
        }

        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteReader($"SELECT * FROM Phones WHERE ID = {id}");

                if (reader.Read())
                {
                    // Текстовые данные
                    lblBrand.Text = "Марка: " + reader.GetString("Brand");
                    lblModel.Text = "Модель: " + reader.GetString("Model");

                    // Добавляем вывод характеристик и цен
                    lblSpecifications.Text = "Характеристики: " + reader.GetString("Specifications");
                    lblPurchasePrice.Text = "Цена приема: " + reader.GetDecimal("PurchasePrice").ToString("C");
                    lblSellingPrice.Text = "Цена продажи: " + reader.GetDecimal("SellingPrice").ToString("C");

                    // Изображение
                    if (!reader.IsDBNull(reader.GetOrdinal("Image")))
                    {
                        byte[] imageBytes = (byte[])reader["Image"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBoxProductImage.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBoxProductImage.Image = null;
                    }
                }
                reader.Close();
            }
        }


        private void btnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                
                if (dataGridViewProducts.SelectedRows[0].Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);

                
                    if (int.TryParse(txtQuantityChange.Text, out int quantity) && quantity > 0)
                    {
                        Database db = new Database();
                        db.IncreasePhoneQuantity(id, quantity);
                        LoadProducts(); 
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное количество.");
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось получить ID товара.");
                }
            }
            else
            {
                MessageBox.Show("Выберите товар.");
            }
        }

        private void btnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
               
                if (dataGridViewProducts.SelectedRows[0].Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);

                    if (int.TryParse(txtQuantityChange.Text, out int quantity) && quantity > 0)
                    {
                        Database db = new Database();
                        int currentQuantity = db.GetPhoneQuantity(id);

                        if (quantity <= currentQuantity)
                        {
                            db.DecreasePhoneQuantity(id, quantity);
                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно товара на складе.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное количество.");
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось получить ID товара.");
                }
            }
            else
            {
                MessageBox.Show("Выберите товар.");
            }
        }

        private void LoadProducts(string searchText = "")
        {
            Database db = new Database();
            MySqlDataReader reader;

            if (string.IsNullOrEmpty(searchText))
            {
                reader = db.GetPhones(); 
            }
            else
            {
                reader = db.SearchPhones(searchText);
            }

            dataGridViewProducts.Rows.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("ID");
                string brand = reader.GetString("Brand");
                string model = reader.GetString("Model");
                decimal sellingPrice = reader.GetDecimal("SellingPrice");
                int quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? 0 : reader.GetInt32("Quantity");

                dataGridViewProducts.Rows.Add(id, brand, model, sellingPrice, quantity);
            }
            reader.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);

                Database db = new Database();
                db.DeletePhone(id);

                MessageBox.Show("Товар удален");
                LoadProducts();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                LoadProducts(searchText); 
            }
            else
            {
                LoadProducts(); 
            }
        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
                EditPhoneForm editForm = new EditPhoneForm(id);
                editForm.ShowDialog();
                LoadProducts(); 
            }
            else
            {
                MessageBox.Show("Выберите товар для редактирования");
            }
        }
    }
}