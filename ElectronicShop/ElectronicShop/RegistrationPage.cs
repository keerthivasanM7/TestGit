using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ElectronicShop
{
    public partial class RegistrationPage : Form
    {
        string path = "D:\\testxml\\";
        public RegistrationPage()
        {
            InitializeComponent();
            DisplayDetailslbl.Visible = false;
        }

        private void OKRegistration_Click(object sender, EventArgs e)
        {

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameRtxt.Text == "" && PasswordRtxt.Text == "" && EmailRtxt.Text == "" && CountryRtxt.Text == "")
            {
                ChangeTextColor();
            }
            else
            {
                ToSerialize();
                this.Close();
                LoginPage form2 = new LoginPage("-> ShopOwnerLogin");
                form2.Show();
            }
        }

        void ChangeTextColor()
        {
            UserNameRegistrartionlbl.ForeColor = Color.Red;
            PasswordRegistrationlbl.ForeColor = Color.Red;
            EmailRegrationlbl.ForeColor = Color.Red;
            CountryRegistrationlbl.ForeColor = Color.Red;
            DisplayDetailslbl.Text = "Kindly enter the Details and Press OK";
            DisplayDetailslbl.Visible = true;
        }

        void ToSerialize()
        {
            using (XmlTextWriter writer = new XmlTextWriter(@path + UsernameRtxt.Text + ".xml", Encoding.UTF8))
            {
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.CreateElement("Login");
                XmlElement id = doc.CreateElement("id");
                id.SetAttribute("userName", UsernameRtxt.Text);
                id.SetAttribute("passWord", PasswordRtxt.Text);
                XmlElement name = doc.CreateElement("Name");
                name.InnerText = UsernameRtxt.Text;
                XmlElement Emailob = doc.CreateElement("Email");
                Emailob.InnerText = EmailRtxt.Text;
                XmlElement Countryob = doc.CreateElement("Country");
                Countryob.InnerText = CountryRtxt.Text;
                id.AppendChild(name);
                id.AppendChild(Emailob);
                id.AppendChild(Countryob);
                root.AppendChild(id);
                doc.AppendChild(root);
                writer.Close();
                doc.Save(path + UsernameRtxt.Text + ".xml");
                MessageBox.Show("Created SuccesFully!", "ThankYou", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
