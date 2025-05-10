using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString(); 

            string query = $"INSERT INTO Users (Login, Password, Role) VALUES ('{login}', '{password}', '{role}')";
            Database db = new Database();
            db.ExecuteNonQuery(query);

            MessageBox.Show("Пользователь зарегистрирован");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}