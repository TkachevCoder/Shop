using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            string query = $"SELECT Role FROM Users WHERE Login = '{login}' AND Password = '{password}'";
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteReader(query);

            if (reader.HasRows)
            {
                reader.Read();
                string role = reader.GetString("Role");

                MessageBox.Show($"Авторизация успешна! Роль: {role}");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            reader.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}