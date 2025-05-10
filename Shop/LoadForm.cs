using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{

    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent(); 
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            lblMessage.Text = "Загрузка начата...";
            progressBar.Value = 0;

            
            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                System.Threading.Thread.Sleep(50); 
            }

            lblMessage.Text = "Загрузка завершена!";
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {

        }
    }

}
