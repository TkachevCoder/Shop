namespace Shop
{
    partial class LoadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMessage = new Label();
            progressBar = new ProgressBar();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(44, 47);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(108, 15);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Загрузка данных...";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(44, 94);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(262, 28);
            progressBar.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(131, 141);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 28);
            btnStart.TabIndex = 2;
            btnStart.Text = "Начать";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // LoadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 234);
            Controls.Add(btnStart);
            Controls.Add(progressBar);
            Controls.Add(lblMessage);
            Name = "LoadForm";
            Text = "Форма загрузки";
            Load += LoadForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStart;
    }
}