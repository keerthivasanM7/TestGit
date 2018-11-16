namespace ElectronicShop
{
    partial class CustomerEcommerce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEcommerce));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddToCartbtn = new System.Windows.Forms.Button();
            this.UPSAvailablelbl = new System.Windows.Forms.Label();
            this.dataGridViewItemsAvailable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.CartItemlbl = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DataSavebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientDetailstxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HomeAddressRichBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CompanyAddressRichBox = new System.Windows.Forms.RichTextBox();
            this.CompanyNametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HomeRadiobtn = new System.Windows.Forms.RadioButton();
            this.CompanyRadiobtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Proceedbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalPricelbl = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.MainMenubtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.loginBylbl = new System.Windows.Forms.Label();
            this.ShopOwnerNamelbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsAvailable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(15, 80);
            this.tabControl1.Location = new System.Drawing.Point(0, 84);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(7, 4);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1292, 700);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddToCartbtn);
            this.tabPage1.Controls.Add(this.UPSAvailablelbl);
            this.tabPage1.Controls.Add(this.dataGridViewItemsAvailable);
            this.tabPage1.Location = new System.Drawing.Point(84, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1204, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items Avaliable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddToCartbtn
            // 
            this.AddToCartbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddToCartbtn.BackgroundImage")));
            this.AddToCartbtn.Location = new System.Drawing.Point(492, 649);
            this.AddToCartbtn.Name = "AddToCartbtn";
            this.AddToCartbtn.Size = new System.Drawing.Size(137, 40);
            this.AddToCartbtn.TabIndex = 5;
            this.AddToCartbtn.Text = "ADD to CART";
            this.AddToCartbtn.UseVisualStyleBackColor = true;
            this.AddToCartbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UPSAvailablelbl
            // 
            this.UPSAvailablelbl.AutoSize = true;
            this.UPSAvailablelbl.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPSAvailablelbl.Location = new System.Drawing.Point(24, 9);
            this.UPSAvailablelbl.Name = "UPSAvailablelbl";
            this.UPSAvailablelbl.Size = new System.Drawing.Size(267, 24);
            this.UPSAvailablelbl.TabIndex = 4;
            this.UPSAvailablelbl.Text = "UPS Avaliable in our Electronic Shop";
            // 
            // dataGridViewItemsAvailable
            // 
            this.dataGridViewItemsAvailable.AllowUserToAddRows = false;
            this.dataGridViewItemsAvailable.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewItemsAvailable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewItemsAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItemsAvailable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewItemsAvailable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewItemsAvailable.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewItemsAvailable.Name = "dataGridViewItemsAvailable";
            this.dataGridViewItemsAvailable.Size = new System.Drawing.Size(1198, 604);
            this.dataGridViewItemsAvailable.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.CartItemlbl);
            this.tabPage2.Controls.Add(this.dataGridViewCart);
            this.tabPage2.Font = new System.Drawing.Font("Romantic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tabPage2.Location = new System.Drawing.Point(84, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1204, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CART";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("RomanC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(476, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "BUY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CartItemlbl
            // 
            this.CartItemlbl.AutoSize = true;
            this.CartItemlbl.Font = new System.Drawing.Font("Stylus BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartItemlbl.Location = new System.Drawing.Point(3, 25);
            this.CartItemlbl.Name = "CartItemlbl";
            this.CartItemlbl.Size = new System.Drawing.Size(206, 19);
            this.CartItemlbl.TabIndex = 1;
            this.CartItemlbl.Text = "Your Cart has Following Item";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToResizeColumns = false;
            this.dataGridViewCart.AllowUserToResizeRows = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(3, 47);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.Size = new System.Drawing.Size(1198, 277);
            this.dataGridViewCart.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.DataSavebtn);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.Proceedbtn);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.TotalPricelbl);
            this.tabPage3.Location = new System.Drawing.Point(84, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1204, 692);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(893, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 14);
            this.label14.TabIndex = 9;
            this.label14.Text = "--->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1135, 14);
            this.label13.TabIndex = 8;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Simplex", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(688, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Click the proceed button";
            // 
            // DataSavebtn
            // 
            this.DataSavebtn.Location = new System.Drawing.Point(487, 636);
            this.DataSavebtn.Name = "DataSavebtn";
            this.DataSavebtn.Size = new System.Drawing.Size(90, 35);
            this.DataSavebtn.TabIndex = 0;
            this.DataSavebtn.Text = "OK";
            this.DataSavebtn.UseVisualStyleBackColor = true;
            this.DataSavebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.ClientDetailstxt);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.HomeRadiobtn);
            this.groupBox1.Controls.Add(this.CompanyRadiobtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 458);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ClientDetailstxt
            // 
            this.ClientDetailstxt.Location = new System.Drawing.Point(338, 81);
            this.ClientDetailstxt.Name = "ClientDetailstxt";
            this.ClientDetailstxt.Size = new System.Drawing.Size(195, 26);
            this.ClientDetailstxt.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HomeAddressRichBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(585, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 192);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // HomeAddressRichBox
            // 
            this.HomeAddressRichBox.Location = new System.Drawing.Point(135, 46);
            this.HomeAddressRichBox.Name = "HomeAddressRichBox";
            this.HomeAddressRichBox.Size = new System.Drawing.Size(238, 125);
            this.HomeAddressRichBox.TabIndex = 8;
            this.HomeAddressRichBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CompanyAddressRichBox);
            this.groupBox2.Controls.Add(this.CompanyNametxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(101, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // CompanyAddressRichBox
            // 
            this.CompanyAddressRichBox.Location = new System.Drawing.Point(147, 90);
            this.CompanyAddressRichBox.Name = "CompanyAddressRichBox";
            this.CompanyAddressRichBox.Size = new System.Drawing.Size(195, 96);
            this.CompanyAddressRichBox.TabIndex = 7;
            this.CompanyAddressRichBox.Text = "";
            // 
            // CompanyNametxt
            // 
            this.CompanyNametxt.Location = new System.Drawing.Point(147, 46);
            this.CompanyNametxt.Name = "CompanyNametxt";
            this.CompanyNametxt.Size = new System.Drawing.Size(195, 26);
            this.CompanyNametxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Company Name";
            // 
            // HomeRadiobtn
            // 
            this.HomeRadiobtn.AutoSize = true;
            this.HomeRadiobtn.Location = new System.Drawing.Point(503, 174);
            this.HomeRadiobtn.Name = "HomeRadiobtn";
            this.HomeRadiobtn.Size = new System.Drawing.Size(68, 22);
            this.HomeRadiobtn.TabIndex = 2;
            this.HomeRadiobtn.TabStop = true;
            this.HomeRadiobtn.Text = "Home";
            this.HomeRadiobtn.UseVisualStyleBackColor = true;
            this.HomeRadiobtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CompanyRadiobtn
            // 
            this.CompanyRadiobtn.AutoSize = true;
            this.CompanyRadiobtn.Location = new System.Drawing.Point(206, 174);
            this.CompanyRadiobtn.Name = "CompanyRadiobtn";
            this.CompanyRadiobtn.Size = new System.Drawing.Size(93, 22);
            this.CompanyRadiobtn.TabIndex = 1;
            this.CompanyRadiobtn.TabStop = true;
            this.CompanyRadiobtn.Text = "Company";
            this.CompanyRadiobtn.UseVisualStyleBackColor = true;
            this.CompanyRadiobtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name :";
            // 
            // Proceedbtn
            // 
            this.Proceedbtn.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceedbtn.Location = new System.Drawing.Point(924, 68);
            this.Proceedbtn.Name = "Proceedbtn";
            this.Proceedbtn.Size = new System.Drawing.Size(101, 26);
            this.Proceedbtn.TabIndex = 5;
            this.Proceedbtn.Text = "Proceed";
            this.Proceedbtn.UseVisualStyleBackColor = true;
            this.Proceedbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 29);
            this.textBox1.TabIndex = 4;
            // 
            // TotalPricelbl
            // 
            this.TotalPricelbl.AutoSize = true;
            this.TotalPricelbl.Location = new System.Drawing.Point(78, 64);
            this.TotalPricelbl.Name = "TotalPricelbl";
            this.TotalPricelbl.Size = new System.Drawing.Size(102, 21);
            this.TotalPricelbl.TabIndex = 0;
            this.TotalPricelbl.Text = "Total Price :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Location = new System.Drawing.Point(84, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1204, 692);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Payment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 246);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(178, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(791, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thank You for Shoping....Have a nice Day... ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(484, 642);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 33);
            this.button5.TabIndex = 0;
            this.button5.Text = "Go Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainMenubtn
            // 
            this.MainMenubtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MainMenubtn.Location = new System.Drawing.Point(1161, 53);
            this.MainMenubtn.Name = "MainMenubtn";
            this.MainMenubtn.Size = new System.Drawing.Size(75, 23);
            this.MainMenubtn.TabIndex = 1;
            this.MainMenubtn.Text = "Main Menu";
            this.MainMenubtn.UseVisualStyleBackColor = true;
            this.MainMenubtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(511, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "WELCOME";
            // 
            // loginBylbl
            // 
            this.loginBylbl.AutoSize = true;
            this.loginBylbl.Location = new System.Drawing.Point(13, 50);
            this.loginBylbl.Name = "loginBylbl";
            this.loginBylbl.Size = new System.Drawing.Size(50, 13);
            this.loginBylbl.TabIndex = 3;
            this.loginBylbl.Text = "login By :";
            // 
            // ShopOwnerNamelbl
            // 
            this.ShopOwnerNamelbl.AutoSize = true;
            this.ShopOwnerNamelbl.Location = new System.Drawing.Point(70, 50);
            this.ShopOwnerNamelbl.Name = "ShopOwnerNamelbl";
            this.ShopOwnerNamelbl.Size = new System.Drawing.Size(91, 13);
            this.ShopOwnerNamelbl.TabIndex = 4;
            this.ShopOwnerNamelbl.Text = "ShopOwnerName";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(908, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CustomerEcommerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.MainMenubtn;
            this.ClientSize = new System.Drawing.Size(1293, 813);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ShopOwnerNamelbl);
            this.Controls.Add(this.loginBylbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MainMenubtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerEcommerce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerEcommerce";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsAvailable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button AddToCartbtn;
        private System.Windows.Forms.Label UPSAvailablelbl;
        private System.Windows.Forms.DataGridView dataGridViewItemsAvailable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CartItemlbl;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button DataSavebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ClientDetailstxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox HomeAddressRichBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CompanyNametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton HomeRadiobtn;
        private System.Windows.Forms.RadioButton CompanyRadiobtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Proceedbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TotalPricelbl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button MainMenubtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label loginBylbl;
        private System.Windows.Forms.Label ShopOwnerNamelbl;
        private System.Windows.Forms.RichTextBox CompanyAddressRichBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}