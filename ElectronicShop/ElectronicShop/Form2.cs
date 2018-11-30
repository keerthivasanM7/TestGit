using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;


namespace ElectronicShop
{
    public partial class Form2 : Form
    {
        string Options;
        string username;
        public Form2(string Options)
        {
            this.Options = Options;
           InitializeComponent();
            Form1 form1 = new Form1();
            form1.Close();
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            CreateanAccount.Font = new Font(CreateanAccount.Font.Name, CreateanAccount.Font.SizeInPoints, FontStyle.Underline);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void CreateanAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void CreateanAccount_MouseLeave(object sender, EventArgs e)
        {
            CreateanAccount.Font = new Font(CreateanAccount.Font.Name, CreateanAccount.Font.SizeInPoints, FontStyle.Regular);
        }
        private void OK_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            if (File.Exists(@"D:\\testxml\\" + textBox1.Text + ".xml"))
            {
                XDocument doc = XDocument.Load("D:\\testxml\\" + textBox1.Text + ".xml");
                var data = doc.Descendants("id")
                   .Where(id => id.Attribute("userName").Value == textBox1.Text
                          && id.Attribute("passWord").Value == textBox2.Text).ToArray()
                    .Any();
                if (data == false)
                {
                    MessageBox.Show( "Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                }
                else
                {
                    this.Close();
                    if (String.Equals(Options, "-> ShopOwnerLogin"))
                    {
                        this.Hide();
                        ShopOwnerPage form4 = new ShopOwnerPage(username);
                        form4.Show();
                    }
                    else
                    {
                        this.Hide();
                        CustomerEcommerce customerEcommerce = new CustomerEcommerce(username);
                        customerEcommerce.Show();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
