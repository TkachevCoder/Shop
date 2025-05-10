namespace Shop
{
    partial class ReportsControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btnLoadSalesReport;
        private System.Windows.Forms.Button btnLoadRevenueReport;
        private System.Windows.Forms.DataGridView dataGridViewSalesReport;
        private System.Windows.Forms.Label labelTotalRevenue;

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
            labelStartDate = new Label();
            labelEndDate = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            btnLoadSalesReport = new Button();
            btnLoadRevenueReport = new Button();
            dataGridViewSalesReport = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            labelTotalRevenue = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesReport).BeginInit();
            SuspendLayout();
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(10, 10);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(96, 15);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "Начальная дата:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(10, 40);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(89, 15);
            labelEndDate.TabIndex = 1;
            labelEndDate.Text = "Конечная дата:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(120, 10);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(120, 23);
            dateTimePickerStart.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(120, 40);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(120, 23);
            dateTimePickerEnd.TabIndex = 3;
            // 
            // btnLoadSalesReport
            // 
            btnLoadSalesReport.Location = new Point(250, 10);
            btnLoadSalesReport.Name = "btnLoadSalesReport";
            btnLoadSalesReport.Size = new Size(180, 23);
            btnLoadSalesReport.TabIndex = 4;
            btnLoadSalesReport.Text = "Загрузить отчет по продажам";
            btnLoadSalesReport.UseVisualStyleBackColor = true;
            btnLoadSalesReport.Click += btnLoadSalesReport_Click;
            // 
            // btnLoadRevenueReport
            // 
            btnLoadRevenueReport.Location = new Point(250, 40);
            btnLoadRevenueReport.Name = "btnLoadRevenueReport";
            btnLoadRevenueReport.Size = new Size(180, 23);
            btnLoadRevenueReport.TabIndex = 5;
            btnLoadRevenueReport.Text = "Загрузить отчет по выручке";
            btnLoadRevenueReport.UseVisualStyleBackColor = true;
            btnLoadRevenueReport.Click += btnLoadRevenueReport_Click;
            // 
            // dataGridViewSalesReport
            // 
            dataGridViewSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalesReport.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewSalesReport.Location = new Point(10, 78);
            dataGridViewSalesReport.Name = "dataGridViewSalesReport";
            dataGridViewSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSalesReport.Size = new Size(750, 505);
            dataGridViewSalesReport.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID продажи";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Дата продажи";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Товар/Услуга";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Количество";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Цена";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Общая сумма";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // labelTotalRevenue
            // 
            labelTotalRevenue.AutoSize = true;
            labelTotalRevenue.Location = new Point(436, 48);
            labelTotalRevenue.Name = "labelTotalRevenue";
            labelTotalRevenue.Size = new Size(134, 15);
            labelTotalRevenue.TabIndex = 7;
            labelTotalRevenue.Text = "Общая выручка: 0 руб.";
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTotalRevenue);
            Controls.Add(dataGridViewSalesReport);
            Controls.Add(btnLoadRevenueReport);
            Controls.Add(btnLoadSalesReport);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Name = "ReportsControl";
            Size = new Size(800, 623);
            Load += ReportsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

    }
}