namespace Shop
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(18, 19);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(44, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(18, 56);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Пароль:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(18, 94);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(37, 15);
            lblRole.TabIndex = 2;
            lblRole.Text = "Роль:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(88, 19);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(132, 23);
            txtLogin.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(88, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(132, 23);
            txtPassword.TabIndex = 4;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Employee" });
            cmbRole.Location = new Point(88, 94);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(132, 23);
            cmbRole.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(88, 131);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 28);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 188);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Name = "RegisterForm";
            Text = "Регистрация";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}