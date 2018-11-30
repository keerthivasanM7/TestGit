using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicShop
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShopOwnerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(ShopOwnerLogin.Text);
            form2.ShowDialog();
            
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(Customer.Text);
            form2.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
