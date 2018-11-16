using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace ElectronicShop
{
    public partial class CustomerEcommerce : Form
    {
        string pathUps = "D:\\testxml\\UPS\\";
        string pathClientDetails = "D:\\testxml\\ClientDetails\\";
        string pathClientUps = "D:\\testxml\\ClientUPS\\";
        int iTotalPrice = 0;
        string username;
        public static List<string> ob = new List<string>();
        DataSet ds = new DataSet();

        public CustomerEcommerce(string username)
        {
            InitializeComponent();
            ShopOwnerNamelbl.Text = username;
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            this.username = username;
            LoadData();
        }

        public static List<string> ReturnList()
        {
            return ob;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewItemsAvailable.Columns)
            {
                dt1.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dataGridViewItemsAvailable.Rows)
            {
                DataRow dRow = dt1.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Select UPS"].Value);
                    if (isSelected)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                }
                dt1.Rows.Add(dRow);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt1);

            dataGridViewCart.DataSource = ds.Tables[0];
            dataGridViewCart.Columns.RemoveAt(0);
            dataGridViewCart.ReadOnly = true;
            if (File.Exists(@pathClientDetails + username + ".xml"))
            {
                File.Delete(@pathClientDetails + username + ".xml");
            }
            for (int i = 0; i < dataGridViewCart.RowCount - 1; i++)
            {
                if (dataGridViewCart.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dataGridViewCart.Rows.RemoveAt(i);
                    i--;
                }
            }

            AddToList();
            Serialization serialization = new Serialization(pathClientUps, username);
            serialization.Serialize(ds);

            tabControl1.SelectedTab = tabControl1.TabPages["tabpage2"];
        }
        private void AddToList()
        {
            for (int i = 0; i < dataGridViewCart.RowCount - 1; i++)
            {
                if (dataGridViewCart.Rows[i].Cells[0].Value.ToString() != "")
                {
                    string deleteString = dataGridViewCart.Rows[i].Cells[0].Value.ToString();

                    ob.Add(deleteString);

                }
            }
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatePrice();
            tabControl1.SelectedTab = tabControl1.TabPages["tabpage3"];
        }

        void CalculatePrice()
        {
            string s1;
            int iTemp = 0;
            for (int rows = 0; rows < dataGridViewCart.Rows.Count - 1; rows++)
            {
                if (dataGridViewCart.Rows[rows].Cells[7].Value.ToString() != "")
                {
                    s1 = dataGridViewCart.Rows[rows].Cells[7].Value.ToString();
                    iTemp = Convert.ToInt16(s1);
                    iTotalPrice = iTemp + iTotalPrice;
                }
            }
            string iTotalPriceString = Convert.ToString(iTotalPrice);
            textBox1.Text = iTotalPriceString;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientData();
            tabControl1.SelectedTab = tabControl1.TabPages["tabpage4"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form1 = new WelcomePage();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomePage form1 = new WelcomePage();
            form1.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox2.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //this.Hide();
            //WelcomePage form1 = new WelcomePage();
            //form1.Show();
        }

        private void ClientData()
        {
            ClientDetails clientDetails = new ClientDetails();
            ClientDetails.Name = ClientDetailstxt.Text;
            clientDetails.ClientName = ClientDetailstxt.Text;

            if (CompanyRadiobtn.Checked)
            {
                clientDetails.Type = "Company";
                clientDetails.CompanyName = CompanyNametxt.Text;
                clientDetails.CompanyAddress = CompanyAddressRichBox.Text.ToString();
            }
            if (HomeRadiobtn.Checked)
            {
                clientDetails.Type = "Home";
                clientDetails.HomeAddress = HomeAddressRichBox.Text.ToString();
            }
            Serialization serialization = new Serialization(pathClientDetails, "");
            serialization.XmlSerialize(clientDetails);

        }

        private void LoadData()
        {
            try
            {
                DataSet ds = new DataSet();
                Serialization serialization = new Serialization(pathUps, username);
                ds = serialization.DeSerialize();
                dataGridViewItemsAvailable.DataSource = ds.Tables[0];
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Select UPS";
                checkColumn.HeaderText = "Select UPS";
                checkColumn.Width = 100;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 20;
                dataGridViewItemsAvailable.Columns.Add(checkColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry Currently Store is Closed", "Visit Again");
            }
        }
    }
}
