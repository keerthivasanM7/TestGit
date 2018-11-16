using System;
using System.Windows.Forms;

namespace ElectronicShop
{
    public partial class WelcomePage : Form
    {

        public WelcomePage()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShopOwnerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage form2 = new LoginPage(ShopOwnerLogin.Text);
            form2.ShowDialog();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage form2 = new LoginPage(Customer.Text);
            form2.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
