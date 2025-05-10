using MySql.Data.MySqlClient;
using System;

namespace Shop
{
    public class Database
    {
        private string connectionString = "Server=localhost;Database=Shop;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader GetCartItemById(int cartID)
        {
            string query = $"SELECT * FROM Cart WHERE ID = {cartID}";
            return ExecuteReader(query);
        }

        public void DecreasePhoneQuantity(int phoneID, int quantity)
        {
            string query = $"UPDATE Phones SET Quantity = Quantity - {quantity} WHERE ID = {phoneID}";
            ExecuteNonQuery(query);
        }

        public void IncreasePhoneQuantity(int phoneID, int quantity)
        {
            string query = $"UPDATE Phones SET Quantity = Quantity + {quantity} WHERE ID = {phoneID}";
            ExecuteNonQuery(query);
        }

        public int GetPhoneQuantity(int phoneID)
        {
            string query = $"SELECT Quantity FROM Phones WHERE ID = {phoneID}";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }

        public MySqlDataReader ExecuteReaderWithParams(string query, params MySqlParameter[] parameters)
        {
            MySqlConnection conn = GetConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            foreach (var param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            return cmd.ExecuteReader();
        }
        public void ExecuteNonQueryWithParams(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                cmd.ExecuteNonQuery();
            }
        }
        public MySqlDataReader ExecuteReader(string query)
        {
            MySqlConnection conn = GetConnection();
             conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd.ExecuteReader();
        }

       
        public void AddPhone(string brand, string model, string specifications, decimal purchasePrice, decimal sellingPrice, int quantity)
        {
            string query = $"INSERT INTO Phones (Brand, Model, Specifications, PurchasePrice, SellingPrice, Quantity) " +
                           $"VALUES ('{brand}', '{model}', '{specifications}', {purchasePrice}, {sellingPrice}, {quantity})";
            ExecuteNonQuery(query);
        }

        public MySqlDataReader GetPhones()
        {
            string query = "SELECT * FROM Phones";
            return ExecuteReader(query);
        }

        //public void DeletePhone(int id)
        //{
        //    // Удаляем связанные записи из SaleItems
        //    string deleteSaleItemsQuery = $"DELETE FROM SaleItems WHERE PhoneID = {id}";
        //    ExecuteNonQuery(deleteSaleItemsQuery);

        //    // Удаляем запись из Phones
        //    string deletePhoneQuery = $"DELETE FROM Phones WHERE ID = {id}";
        //    ExecuteNonQuery(deletePhoneQuery);
        //}
        public void AddPhoneWithImage(string brand, string model, string specifications,
                            decimal purchasePrice, decimal sellingPrice,
                            int quantity, byte[] image)
        {
            string query = @"
        INSERT INTO Phones (Brand, Model, Specifications, PurchasePrice, 
                          SellingPrice, Quantity, Image) 
        VALUES (@Brand, @Model, @Specs, @PurchasePrice, 
               @SellingPrice, @Quantity, @Image)";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Specs", specifications);
                cmd.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Image", image ?? (object)DBNull.Value); 

                cmd.ExecuteNonQuery();
            }
        }
        public void DeletePhone(int id)
        {
            string query = "CALL DeletePhone(@PhoneID)";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneID", id);
                cmd.ExecuteNonQuery();
            }
        }
       
        public void AddService(string name, string description, decimal price)
        {
            string query = $"INSERT INTO Services (Name, Description, Price) VALUES ('{name}', '{description}', {price})";
            ExecuteNonQuery(query);
        }

        public MySqlDataReader GetServices()
        {
            string query = "SELECT * FROM Services";
            return ExecuteReader(query);
        }

        public void DeleteService(int id)
        {
            string query = $"DELETE FROM Services WHERE ID = {id}";
            ExecuteNonQuery(query);
        }

      
        public void AddToCart(int phoneID, int serviceID, int quantity)
        {
            string query = "INSERT INTO Cart (PhoneID, ServiceID, Quantity) VALUES (@PhoneID, @ServiceID, @Quantity)";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PhoneID", phoneID == 0 ? (object)DBNull.Value : phoneID);
                cmd.Parameters.AddWithValue("@ServiceID", serviceID == 0 ? (object)DBNull.Value : serviceID);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader GetSalesHistory()
        {
            string query = @"
                SELECT 
                    s.ID AS SaleID, 
                    s.SaleDate, 
                    IFNULL(p.Brand, sv.Name) AS ItemName, 
                    si.Quantity, 
                    si.Price, 
                    s.TotalAmount
                FROM Sales s
                LEFT JOIN SaleItems si ON s.ID = si.SaleID
                LEFT JOIN Phones p ON si.PhoneID = p.ID
                LEFT JOIN Services sv ON si.ServiceID = sv.ID
            ";
            return ExecuteReader(query);
        }

        public void RemoveFromCart(int id)
        {
            string query = $"DELETE FROM Cart WHERE ID = {id}";
            ExecuteNonQuery(query);
        }

        public MySqlDataReader GetCartItems()
        {
            string query = "SELECT * FROM Cart";
            return ExecuteReader(query);
        }

    
        public void CreateSaleFromCart()
        {
            string query = @"
                INSERT INTO Sales (SaleDate, TotalAmount)
                SELECT NOW(), SUM(IFNULL(p.SellingPrice, s.Price) * c.Quantity)
                FROM Cart c
                LEFT JOIN Phones p ON c.PhoneID = p.ID
                LEFT JOIN Services s ON c.ServiceID = s.ID;

                INSERT INTO SaleItems (SaleID, PhoneID, ServiceID, Quantity, Price)
                SELECT LAST_INSERT_ID(), c.PhoneID, c.ServiceID, c.Quantity, IFNULL(p.SellingPrice, s.Price)
                FROM Cart c
                LEFT JOIN Phones p ON c.PhoneID = p.ID
                LEFT JOIN Services s ON c.ServiceID = s.ID;

                DELETE FROM Cart;
            ";

            ExecuteNonQuery(query);
        }

        public MySqlDataReader GetSales()
        {
            string query = "SELECT * FROM Sales";
            return ExecuteReader(query);
        }

        public MySqlDataReader GetSaleItems(int saleID)
        {
            string query = $"SELECT * FROM SaleItems WHERE SaleID = {saleID}";
            return ExecuteReader(query);
        }

        public string GetPhoneName(int id)
        {
            string query = $"SELECT CONCAT(Brand, ' ', Model) AS Name FROM Phones WHERE ID = {id}";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteScalar().ToString();
            }
        }

        public MySqlDataReader SearchPhones(string searchText)
        {
            string query = $"SELECT * FROM Phones WHERE Brand LIKE '%{searchText}%' OR Model LIKE '%{searchText}%'";
            return ExecuteReader(query);
        }

        public string GetServiceName(int id)
        {
            string query = $"SELECT Name FROM Services WHERE ID = {id}";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteScalar().ToString();
            }
        }
    }
}