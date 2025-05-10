using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
        }

       
        private void btnLoadSalesReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            LoadSalesReport(startDate, endDate);
        }

        private void btnLoadRevenueReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            LoadRevenueReport(startDate, endDate);
        }

        private void LoadSalesReport(DateTime startDate, DateTime endDate)
        {
            Database db = new Database();
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
                WHERE s.SaleDate BETWEEN @StartDate AND @EndDate
            ";

            MySqlDataReader reader = db.ExecuteReaderWithParams(query, new MySqlParameter("@StartDate", startDate), new MySqlParameter("@EndDate", endDate));

            dataGridViewSalesReport.Rows.Clear();
            while (reader.Read())
            {
                int saleID = reader.GetInt32("SaleID");
                DateTime saleDate = reader.GetDateTime("SaleDate");
                string itemName = reader.IsDBNull(reader.GetOrdinal("ItemName")) ? "Нет данных" : reader.GetString("ItemName");
                int quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? 0 : reader.GetInt32("Quantity");
                decimal price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal("Price");
                decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("TotalAmount")) ? 0 : reader.GetDecimal("TotalAmount");

                dataGridViewSalesReport.Rows.Add(saleID, saleDate, itemName, quantity, price, totalAmount);
            }
            reader.Close();
        }

        
        private void LoadRevenueReport(DateTime startDate, DateTime endDate)
        {
            Database db = new Database();
            string query = @"
                SELECT SUM(TotalAmount) AS TotalRevenue
                FROM Sales
                WHERE SaleDate BETWEEN @StartDate AND @EndDate
            ";

            MySqlDataReader reader = db.ExecuteReaderWithParams(query, new MySqlParameter("@StartDate", startDate), new MySqlParameter("@EndDate", endDate));

            decimal totalRevenue = 0;
            if (reader.Read())
            {
                totalRevenue = reader.IsDBNull(reader.GetOrdinal("TotalRevenue")) ? 0 : reader.GetDecimal("TotalRevenue");
            }
            reader.Close();

            labelTotalRevenue.Text = $"Общая выручка: {totalRevenue} руб.";
        }

        private void ReportsControl_Load(object sender, EventArgs e)
        {

        }
    }
}