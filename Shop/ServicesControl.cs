using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class ServicesControl : UserControl
    {
        public ServicesControl()
        {
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            Database db = new Database();
            MySqlDataReader reader = db.GetServices();

            dataGridViewServices.Rows.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("ID");
                string name = reader.GetString("Name");
                decimal price = reader.GetDecimal("Price");
                dataGridViewServices.Rows.Add(id, name, price);
            }
            reader.Close();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();
            addServiceForm.ShowDialog();
            LoadServices();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите услугу для удаления.");
                return;
            }

            
            int id = Convert.ToInt32(dataGridViewServices.SelectedRows[0].Cells[0].Value);

            Database db = new Database();
            db.DeleteService(id);
            MessageBox.Show("Услуга удалена");
            LoadServices();
        }

        private void ServicesControl_Load(object sender, EventArgs e)
        {

        }
    }
}