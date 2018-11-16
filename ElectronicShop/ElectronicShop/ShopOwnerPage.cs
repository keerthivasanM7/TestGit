using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ElectronicShop
{
    public partial class ShopOwnerPage : Form
    {
        string pathUps = "D:\\testxml\\UPS\\";
        string pathClientDetails = "D:\\textxml\\ClientDetails\\";
        int iCount = 7;
        string username;
        public ShopOwnerPage(string username)
        {
            InitializeComponent();
            WelcomeShopPagelbl.Text = "Welcome " + username;
            this.username = username;
            ErrorMsglbl.Visible = false;
        }

        private void ShopOwnerPage_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ErrorMsglbl.Visible = false;
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewAddItems.Columns)
            {
                dt.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dataGridViewAddItems.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            Serialization serialization = new Serialization(pathUps, username);
            serialization.Serialize(ds);

            MessageBox.Show("Successfully data added", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewAddItems.Rows.Clear();
            dataGridViewAddItems.Refresh();
        }
        public void update()
        {
            dataGridViewAddItems.ColumnCount = iCount;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ++iCount;
            update();
            dataGridViewAddItems.Columns[iCount - 1].Name = AddColoumntxt.Text;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                Serialization serialization = new Serialization(pathUps, username);
                ds = serialization.DeSerialize();
                dataGridViewViewItems.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                ErrorMsglbl.Text = "Sorry data is Empty, Kindly add items";
                ErrorMsglbl.BackColor = Color.Red;
                ErrorMsglbl.Visible = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomePage form1 = new WelcomePage();
            form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void UpdateGridViewUPS()
        {
            DeleteCustomerSelected();

            DataTable dt1 = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewViewItems.Columns)
            {
                dt1.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dataGridViewViewItems.Rows)
            {
                DataRow dRow = dt1.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt1.Rows.Add(dRow);
            }
            DataSet ds1 = new DataSet();
            ds1.Tables.Add(dt1);

            if (File.Exists(@pathUps + username + ".xml"))
            {
                File.Delete(@pathUps + username + ".xml");
            }

            Serialization serialization = new Serialization(pathUps, username);
            serialization.Serialize(ds1);
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            UpdateGridViewUPS();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            //UpdateGridViewUPS();
        }

        private void DeleteCustomerSelected()
        {
            for (int i = 0; i < dataGridViewViewItems.RowCount - 1; i++)
            {
                if (dataGridViewViewItems.Rows[i].Cells[0] != null)
                {
                    string iTemp = dataGridViewViewItems.Rows[i].Cells["ModelNumber"].Value.ToString();
                    List<string> ob = CustomerEcommerce.ReturnList();
                    foreach (var item in ob)
                    {
                        if (iTemp.Equals(item))
                        {
                            dataGridViewViewItems.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        private void AddColoumntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Viewbtn_Click_1(object sender, EventArgs e)
        {
            string username1 = ClientDetails.Name;
            try
            {
                DataSet ds = new DataSet();
                Serialization serialization = new Serialization("D:\\testxml\\ClientDetails\\", username1);
                ds = serialization.DeSerialize();
                dataGridViewClientDetails.DataSource = ds.Tables[0];

                DataSet ds1 = new DataSet();
                Serialization serialization1 = new Serialization("D:\\testxml\\ClientUps\\", username);
                ds1 = serialization1.DeSerialize();
                dataGridViewSelectedUPS.DataSource = ds1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry Currently there are NO Customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
