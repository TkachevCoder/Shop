using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
            LoadProducts();
            LoadServices();
            LoadCart();
        }

        private void LoadProducts()
        {
            Database db = new Database();
            MySqlDataReader reader = db.GetPhones();

            cmbProducts.Items.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("ID");
                string brand = reader.GetString("Brand");
                string model = reader.GetString("Model");
                cmbProducts.Items.Add(new ComboBoxItem($"{brand} {model}", id));
            }
            reader.Close();
        }

        private void LoadServices()
        {
            Database db = new Database();
            MySqlDataReader reader = db.GetServices();

            cmbServices.Items.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("ID");
                string name = reader.GetString("Name");
                cmbServices.Items.Add(new ComboBoxItem(name, id));
            }
            reader.Close();
        }

        private void LoadCart()
        {
            Database db = new Database();
            MySqlDataReader reader = db.GetCartItems();

            dataGridViewCart.Rows.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("ID");
                int phoneID = reader.IsDBNull(reader.GetOrdinal("PhoneID")) ? 0 : reader.GetInt32("PhoneID");
                int serviceID = reader.IsDBNull(reader.GetOrdinal("ServiceID")) ? 0 : reader.GetInt32("ServiceID");
                int quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? 0 : reader.GetInt32("Quantity");

                string itemName = phoneID != 0 ? db.GetPhoneName(phoneID) : db.GetServiceName(serviceID);
                dataGridViewCart.Rows.Add(id, itemName, quantity);
            }
            reader.Close();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int productID = cmbProducts.SelectedIndex != -1 ? ((ComboBoxItem)cmbProducts.SelectedItem).Value : 0;
            int serviceID = cmbServices.SelectedIndex != -1 ? ((ComboBoxItem)cmbServices.SelectedItem).Value : 0;
            int quantity = Convert.ToInt32(txtQuantity.Text);

           
            if (quantity <= 0)
            {
                MessageBox.Show("Количество должно быть больше 0.");
                return;
            }

            Database db = new Database();
            db.AddToCart(productID, serviceID, quantity);

            LoadCart();
        }

        private void LoadSalesHistory()
        {
            Database db = new Database();
            MySqlDataReader reader = db.GetSalesHistory();

            dataGridViewSalesHistory.Rows.Clear();
            while (reader.Read())
            {
                int saleID = reader.GetInt32("SaleID");
                DateTime saleDate = reader.GetDateTime("SaleDate");
                string itemName = reader.IsDBNull(reader.GetOrdinal("ItemName")) ? "Нет данных" : reader.GetString("ItemName");
                int quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? 0 : reader.GetInt32("Quantity");
                decimal price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal("Price");
                decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("TotalAmount")) ? 0 : reader.GetDecimal("TotalAmount");

                dataGridViewSalesHistory.Rows.Add(saleID, saleDate, itemName, quantity, price, totalAmount);
            }
            reader.Close();
        }

        private void SalesControl_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadServices();
            LoadCart();
            LoadSalesHistory(); 
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.CreateSaleFromCart();

            MessageBox.Show("Продажа зарегистрирована");
            LoadCart();
            LoadSalesHistory(); 
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
             
                int id = Convert.ToInt32(dataGridViewCart.SelectedRows[0].Cells[0].Value);

                Database db = new Database();

              
                MySqlDataReader reader = db.GetCartItemById(id);
                if (reader.Read())
                {
                    int phoneID = reader.IsDBNull(reader.GetOrdinal("PhoneID")) ? 0 : reader.GetInt32("PhoneID");
                    int quantity = reader.GetInt32("Quantity");

                    
                    if (phoneID != 0)
                    {
                        db.IncreasePhoneQuantity(phoneID, quantity);
                    }
                }
                reader.Close();

            
                db.RemoveFromCart(id);

              
                LoadCart();
            }
        }
        private void btnAddServiceToCart_Click(object sender, EventArgs e)
        {
            if (cmbServices.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите услугу.");
                return;
            }

            if (!int.TryParse(txtQuantityService.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество.");
                return;
            }

            int serviceID = ((ComboBoxItem)cmbServices.SelectedItem).Value;
            Database db = new Database();
            db.AddToCart(0, serviceID, quantity); 

            LoadCart();
        }
        private void btnAddPhoneToCart_Click(object sender, EventArgs e)
        {
            
            if (cmbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите телефон.");
                return;
            }

           
            if (!int.TryParse(txtQuantityPhone.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество.");
                return;
            }

            
            int phoneID = ((ComboBoxItem)cmbProducts.SelectedItem).Value;

            
            Database db = new Database();
            int availableQuantity = db.GetPhoneQuantity(phoneID);

            if (quantity > availableQuantity)
            {
                MessageBox.Show($"Недостаточно телефонов в наличии. Доступно: {availableQuantity}");
                return;
            }

           
            db.DecreasePhoneQuantity(phoneID, quantity);

           
            db.AddToCart(phoneID, 0, quantity); 

           
            LoadCart();
        }

        private void dataGridViewSalesHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}