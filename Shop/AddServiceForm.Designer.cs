namespace Shop
{
    partial class AddServiceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;

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
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(18, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Название:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(18, 56);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(65, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Описание:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(18, 94);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Цена:";
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(105, 56);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(176, 23);
            txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(105, 94);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(88, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(105, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 28);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 188);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Name = "AddServiceForm";
            Text = "Добавить услугу";
            Load += AddServiceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}