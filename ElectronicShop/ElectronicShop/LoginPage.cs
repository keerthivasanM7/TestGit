using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace ElectronicShop
{
    public partial class LoginPage : Form
    {
        string Options;
        string username;
        string path = "D:\\testxml\\";
        public LoginPage(string Options)
        {
            InitializeComponent();
            this.Options = Options;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            CreateanAccount.Font = new Font(CreateanAccount.Font.Name, CreateanAccount.Font.SizeInPoints, FontStyle.Underline);
        }

        private void CreateanAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrationPage form3 = new RegistrationPage();
            form3.Show();
        }

        private void CreateanAccount_MouseLeave(object sender, EventArgs e)
        {
            CreateanAccount.Font = new Font(CreateanAccount.Font.Name, CreateanAccount.Font.SizeInPoints, FontStyle.Regular);
        }
        private void OK_Click(object sender, EventArgs e)
        {
            username = Usernametxt.Text;
            if (username != "")
            {
                if (File.Exists(path + Usernametxt.Text + ".xml"))
                {
                    bool isValidUser = PasswordValidation();
                    if (isValidUser == false)
                    {
                        MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Passwordtxt.Clear();
                    }
                    else
                    {
                        ValidationPage();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Usernametxt.Clear();
                    Passwordtxt.Clear();
                }
            }
        }
        public bool PasswordValidation()
        {
            XDocument doc = XDocument.Load(path + Usernametxt.Text + ".xml");
            var data = doc.Descendants("id")
               .Where(id => id.Attribute("userName").Value == Usernametxt.Text
                      && id.Attribute("passWord").Value == Passwordtxt.Text).ToArray()
                .Any();
            return data;
        }

        public void ValidationPage()
        {
            this.Hide();
            if (String.Equals(Options, "-> ShopOwnerLogin"))
            {
                this.Close();
                ShopOwnerPage form4 = new ShopOwnerPage(username);
                form4.Show();
            }
            else
            {
                this.Close();
                CustomerEcommerce customerEcommerce = new CustomerEcommerce(username);
                customerEcommerce.Show();
            }
        }
    }
}
