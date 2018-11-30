using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;


namespace ElectronicShop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void OKRegistration_Click(object sender, EventArgs e)
        {
           
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    this.Hide();
        //    Form1 form1 = new Form1();
        //    form1.Show();
        //}
            private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameR.Text == "" && PasswordR.Text == "" && EmailR.Text == "" && CountryR.Text == "")
            {
                UserNameRegistrartion.ForeColor = Color.Red;
                PasswordRegistration.ForeColor = Color.Red;
                Email.ForeColor = Color.Red;
                Country.ForeColor = Color.Red;
            }
            else
            {
                string filename = @"D:\\testxml\\" + UsernameR.Text + ".xml";
                using (XmlTextWriter writer = new XmlTextWriter(@"D:\\testxml\\" + UsernameR.Text + ".xml", Encoding.UTF8))
                {
                    XmlDocument doc = new XmlDocument();
                    XmlElement root = doc.CreateElement("Login");
                    XmlElement id = doc.CreateElement("id");
                    id.SetAttribute("userName", UsernameR.Text);
                    id.SetAttribute("passWord", PasswordR.Text);
                    XmlElement name = doc.CreateElement("Name");
                    name.InnerText = UsernameR.Text;
                    XmlElement Emailob = doc.CreateElement("Email");
                    Emailob.InnerText = EmailR.Text;
                    XmlElement Countryob = doc.CreateElement("Country");
                    Countryob.InnerText = CountryR.Text;
                    id.AppendChild(name);
                    id.AppendChild(Emailob);
                    id.AppendChild(Countryob);
                    root.AppendChild(id);
                    doc.AppendChild(root);
                    writer.Close();
                    doc.Save("D:\\testxml\\" + UsernameR.Text + ".xml");

                    MessageBox.Show("Created SuccesFully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                this.Hide();
                Form2 form2 = new Form2("ShopOwnerLogin");
                form2.Show();
            }
        }
    }
}
