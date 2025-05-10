using MySql.Data.MySqlClient;

namespace Shop
{
    partial class ServicesControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServicePrice;

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
            dataGridViewServices = new DataGridView();
            btnAddService = new Button();
            btnDeleteService = new Button();
            lblServiceName = new Label();
            lblServiceDescription = new Label();
            lblServicePrice = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewServices.Location = new Point(9, 9);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.ReadOnly = true;
            dataGridViewServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServices.Size = new Size(345, 808);
            dataGridViewServices.TabIndex = 0;
            dataGridViewServices.SelectionChanged += dataGridViewServices_SelectionChanged;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(429, 9);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(105, 50);
            btnAddService.TabIndex = 1;
            btnAddService.Text = "Добавить услугу";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Location = new Point(542, 9);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(105, 50);
            btnDeleteService.TabIndex = 2;
            btnDeleteService.Text = "Удалить услугу";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.Click += btnDeleteService_Click;
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Location = new Point(429, 100);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(38, 15);
            lblServiceName.TabIndex = 3;
            lblServiceName.Text = "Название:";
            // 
            // lblServiceDescription
            // 
            lblServiceDescription.AutoSize = true;
            lblServiceDescription.Location = new Point(429, 130);
            lblServiceDescription.Name = "lblServiceDescription";
            lblServiceDescription.Size = new Size(65, 15);
            lblServiceDescription.TabIndex = 4;
            lblServiceDescription.Text = "Описание:";
            // 
            // lblServicePrice
            // 
            lblServicePrice.AutoSize = true;
            lblServicePrice.Location = new Point(429, 160);
            lblServicePrice.Name = "lblServicePrice";
            lblServicePrice.Size = new Size(38, 15);
            lblServicePrice.TabIndex = 5;
            lblServicePrice.Text = "Цена:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Price";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ServicesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblServicePrice);
            Controls.Add(lblServiceDescription);
            Controls.Add(lblServiceName);
            Controls.Add(btnDeleteService);
            Controls.Add(btnAddService);
            Controls.Add(dataGridViewServices);
            Name = "ServicesControl";
            Size = new Size(1024, 835);
            Load += ServicesControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private void dataGridViewServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewServices.SelectedRows[0].Cells[0].Value);

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteReader($"SELECT * FROM Services WHERE ID = {id}");

                if (reader.Read())
                {
                    lblServiceName.Text = "Название: " + reader.GetString("Name");
                    lblServiceDescription.Text = "Описание: " + reader.GetString("Description");
                    lblServicePrice.Text = "Цена: " + reader.GetDecimal("Price").ToString("C");
                }
                reader.Close();
            }
        }
    }
}