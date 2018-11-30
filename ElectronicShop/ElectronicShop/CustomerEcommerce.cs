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
using System.Xml;
using System.Xml.Serialization;

namespace ElectronicShop
{
     
    public partial class CustomerEcommerce : Form
    {
        
        
        int iTotalPrice = 0;
        string username;
        DataSet ds = new DataSet();
        public CustomerEcommerce(string username)
        {
            InitializeComponent();
            label12.Text = username;
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            this.username = username;
            try
            {
                XmlReader xmlFile;
                DataSet ds = new DataSet();
                ds.ReadXml(@"D:\\testxml\\UPS\\" + username + ".xml");
                dataGridView22.DataSource = ds.Tables[0];
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Select UPS";
                checkColumn.HeaderText = "Select UPS";
                checkColumn.Width = 100;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 20;
                dataGridView22.Columns.Add(checkColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }
        public static List<string> ob = new List<string>();
        public static List<string> ReturnList()
        {
            return ob;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            foreach (DataGridViewColumn col in dataGridView22.Columns)
            {
                dt1.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dataGridView22.Rows)
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
            ds.Tables.Add(dt1);
            
            tabControl1_Click(sender, e);
            dataGridView11.DataSource = ds.Tables[0];
            dataGridView11.Columns.RemoveAt(0);
            for (int i = 0; i < dataGridView11.RowCount - 1; i++)
            {
                if (dataGridView11.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dataGridView11.Rows.RemoveAt(i);
                    i--;
                }
            }
           
            for (int i = 0; i < dataGridView11.RowCount - 1; i++)
            {
                if (dataGridView11.Rows[i].Cells[0].Value.ToString() != "")
                {
                    string deleteString = dataGridView11.Rows[i].Cells[0].Value.ToString();
                    
                    ob.Add(deleteString);
                    
                }
            }           
            tabControl1.SelectedTab = tabControl1.TabPages["tabpage2"];
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1;
            int iTemp = 0; 
            for (int rows = 0; rows < dataGridView11.Rows.Count-1; rows++)
            {
                 if(dataGridView11.Rows[rows].Cells[7].Value.ToString()!= "")
                {
                    s1 = dataGridView11.Rows[rows].Cells[7].Value.ToString();
                    iTemp = Convert.ToInt16(s1);
                    iTotalPrice = iTemp + iTotalPrice;
                }
  
            }
            string iTotalPriceString = Convert.ToString(iTotalPrice);
            textBox1.Text = iTotalPriceString;
            tabControl1.SelectedTab = tabControl1.TabPages["tabpage3"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientDetails clientDetails = new ClientDetails();
            clientDetails.Name = textBox2.Text;
            if(radioButton1.Checked)
            {
                clientDetails.Type = "Company";
                clientDetails.CompanyName = textBox3.Text;
                clientDetails.CompanyAddress = richTextBox1.Text.ToString();
            }
            if(radioButton2.Checked)
            {
                clientDetails.Type = "Home";
                clientDetails.HomeAddress = richTextBox2.Text.ToString();
            }
            string dsXml = ds.GetXml();
           
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClientDetails));
            using (StreamWriter writer = new StreamWriter(@"D:\\testxml\\ClientDetails\" + clientDetails.Name + ".xml")) 
                {
                    xmlSerializer.Serialize(writer, clientDetails);
                }
            tabControl1.SelectedTab = tabControl1.TabPages["tabpage4"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
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
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
