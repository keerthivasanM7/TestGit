namespace ElectronicShop
{
    partial class ShopOwnerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopOwnerPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddItems = new System.Windows.Forms.TabPage();
            this.Addbtn = new System.Windows.Forms.Button();
            this.AddColoumntxt = new System.Windows.Forms.TextBox();
            this.AddFeaturesbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAddItems = new System.Windows.Forms.DataGridView();
            this.ModelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PowerOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberofBattery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabViewItems = new System.Windows.Forms.TabPage();
            this.ErrorMsglbl = new System.Windows.Forms.Label();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewViewItems = new System.Windows.Forms.DataGridView();
            this.tabClientDetails = new System.Windows.Forms.TabPage();
            this.dataGridViewSelectedUPS = new System.Windows.Forms.DataGridView();
            this.dataGridViewClientDetails = new System.Windows.Forms.DataGridView();
            this.WelcomeShopPagelbl = new System.Windows.Forms.Label();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAddItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItems)).BeginInit();
            this.tabViewItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewItems)).BeginInit();
            this.tabClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedUPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabAddItems);
            this.tabControl1.Controls.Add(this.tabViewItems);
            this.tabControl1.Controls.Add(this.tabClientDetails);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Handwriting", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 742);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabAddItems
            // 
            this.tabAddItems.Controls.Add(this.Addbtn);
            this.tabAddItems.Controls.Add(this.AddColoumntxt);
            this.tabAddItems.Controls.Add(this.AddFeaturesbtn);
            this.tabAddItems.Controls.Add(this.label2);
            this.tabAddItems.Controls.Add(this.dataGridViewAddItems);
            this.tabAddItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabAddItems.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddItems.Location = new System.Drawing.Point(4, 35);
            this.tabAddItems.Name = "tabAddItems";
            this.tabAddItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddItems.Size = new System.Drawing.Size(1246, 703);
            this.tabAddItems.TabIndex = 1;
            this.tabAddItems.Text = "Add Items";
            this.tabAddItems.UseVisualStyleBackColor = true;
            this.tabAddItems.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(531, 668);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(71, 26);
            this.Addbtn.TabIndex = 8;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AddColoumntxt
            // 
            this.AddColoumntxt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddColoumntxt.Location = new System.Drawing.Point(1095, 58);
            this.AddColoumntxt.Name = "AddColoumntxt";
            this.AddColoumntxt.Size = new System.Drawing.Size(125, 23);
            this.AddColoumntxt.TabIndex = 7;
            // 
            // AddFeaturesbtn
            // 
            this.AddFeaturesbtn.Location = new System.Drawing.Point(943, 55);
            this.AddFeaturesbtn.Name = "AddFeaturesbtn";
            this.AddFeaturesbtn.Size = new System.Drawing.Size(128, 27);
            this.AddFeaturesbtn.TabIndex = 6;
            this.AddFeaturesbtn.Text = "Add Features";
            this.AddFeaturesbtn.UseVisualStyleBackColor = true;
            this.AddFeaturesbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the Details of UPS";
            // 
            // dataGridViewAddItems
            // 
            this.dataGridViewAddItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelNumber,
            this.Brand,
            this.Type,
            this.PowerOutput,
            this.Warranty,
            this.NumberofBattery,
            this.Price});
            this.dataGridViewAddItems.Location = new System.Drawing.Point(0, 105);
            this.dataGridViewAddItems.Name = "dataGridViewAddItems";
            this.dataGridViewAddItems.Size = new System.Drawing.Size(1246, 557);
            this.dataGridViewAddItems.TabIndex = 1;
            // 
            // ModelNumber
            // 
            this.ModelNumber.HeaderText = "Model Number";
            this.ModelNumber.Name = "ModelNumber";
            this.ModelNumber.ToolTipText = "Enter your Model Number";
            this.ModelNumber.Width = 120;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.Width = 120;
            // 
            // Type
            // 
            this.Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "Offline",
            "StandBy"});
            this.Type.Name = "Type";
            // 
            // PowerOutput
            // 
            this.PowerOutput.HeaderText = "Power Output";
            this.PowerOutput.Name = "PowerOutput";
            this.PowerOutput.Width = 80;
            // 
            // Warranty
            // 
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            this.Warranty.Width = 80;
            // 
            // NumberofBattery
            // 
            this.NumberofBattery.HeaderText = "Battery";
            this.NumberofBattery.Name = "NumberofBattery";
            this.NumberofBattery.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 120;
            // 
            // tabViewItems
            // 
            this.tabViewItems.Controls.Add(this.ErrorMsglbl);
            this.tabViewItems.Controls.Add(this.Refreshbtn);
            this.tabViewItems.Controls.Add(this.label4);
            this.tabViewItems.Controls.Add(this.dataGridViewViewItems);
            this.tabViewItems.Font = new System.Drawing.Font("TechnicBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tabViewItems.Location = new System.Drawing.Point(4, 35);
            this.tabViewItems.Name = "tabViewItems";
            this.tabViewItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewItems.Size = new System.Drawing.Size(1246, 703);
            this.tabViewItems.TabIndex = 2;
            this.tabViewItems.Text = "View Items";
            this.tabViewItems.UseVisualStyleBackColor = true;
            // 
            // ErrorMsglbl
            // 
            this.ErrorMsglbl.AutoSize = true;
            this.ErrorMsglbl.Font = new System.Drawing.Font("TechnicBold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ErrorMsglbl.Location = new System.Drawing.Point(499, 46);
            this.ErrorMsglbl.Name = "ErrorMsglbl";
            this.ErrorMsglbl.Size = new System.Drawing.Size(49, 17);
            this.ErrorMsglbl.TabIndex = 5;
            this.ErrorMsglbl.Text = "label1";
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(1165, 46);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 4;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available UPS in our ElectronicShop";
            // 
            // dataGridViewViewItems
            // 
            this.dataGridViewViewItems.AllowUserToAddRows = false;
            this.dataGridViewViewItems.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewItems.Location = new System.Drawing.Point(0, 75);
            this.dataGridViewViewItems.Name = "dataGridViewViewItems";
            this.dataGridViewViewItems.Size = new System.Drawing.Size(1243, 628);
            this.dataGridViewViewItems.TabIndex = 2;
            this.dataGridViewViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabClientDetails
            // 
            this.tabClientDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabClientDetails.Controls.Add(this.Viewbtn);
            this.tabClientDetails.Controls.Add(this.dataGridViewSelectedUPS);
            this.tabClientDetails.Controls.Add(this.dataGridViewClientDetails);
            this.tabClientDetails.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientDetails.Location = new System.Drawing.Point(4, 35);
            this.tabClientDetails.Name = "tabClientDetails";
            this.tabClientDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientDetails.Size = new System.Drawing.Size(1246, 703);
            this.tabClientDetails.TabIndex = 3;
            this.tabClientDetails.Text = "Client Details";
            // 
            // dataGridViewSelectedUPS
            // 
            this.dataGridViewSelectedUPS.AllowUserToAddRows = false;
            this.dataGridViewSelectedUPS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewSelectedUPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedUPS.Location = new System.Drawing.Point(598, 114);
            this.dataGridViewSelectedUPS.Name = "dataGridViewSelectedUPS";
            this.dataGridViewSelectedUPS.ReadOnly = true;
            this.dataGridViewSelectedUPS.Size = new System.Drawing.Size(642, 586);
            this.dataGridViewSelectedUPS.TabIndex = 2;
            // 
            // dataGridViewClientDetails
            // 
            this.dataGridViewClientDetails.AllowUserToAddRows = false;
            this.dataGridViewClientDetails.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewClientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientDetails.Location = new System.Drawing.Point(0, 114);
            this.dataGridViewClientDetails.Name = "dataGridViewClientDetails";
            this.dataGridViewClientDetails.ReadOnly = true;
            this.dataGridViewClientDetails.Size = new System.Drawing.Size(601, 586);
            this.dataGridViewClientDetails.TabIndex = 0;
            // 
            // WelcomeShopPagelbl
            // 
            this.WelcomeShopPagelbl.AutoSize = true;
            this.WelcomeShopPagelbl.Cursor = System.Windows.Forms.Cursors.No;
            this.WelcomeShopPagelbl.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeShopPagelbl.Location = new System.Drawing.Point(358, 28);
            this.WelcomeShopPagelbl.Name = "WelcomeShopPagelbl";
            this.WelcomeShopPagelbl.Size = new System.Drawing.Size(338, 32);
            this.WelcomeShopPagelbl.TabIndex = 1;
            this.WelcomeShopPagelbl.Text = "Welcome ShopOwner";
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.AutoSize = true;
            this.MainMenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MainMenuBtn.Location = new System.Drawing.Point(1169, 49);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.MainMenuBtn.TabIndex = 2;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(918, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Viewbtn
            // 
            this.Viewbtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.Location = new System.Drawing.Point(544, 61);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(103, 37);
            this.Viewbtn.TabIndex = 3;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click_1);
            // 
            // ShopOwnerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.MainMenuBtn;
            this.ClientSize = new System.Drawing.Size(1256, 819);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.WelcomeShopPagelbl);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopOwnerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopOwnerPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewBtn_Click);
            this.tabControl1.ResumeLayout(false);
            this.tabAddItems.ResumeLayout(false);
            this.tabAddItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItems)).EndInit();
            this.tabViewItems.ResumeLayout(false);
            this.tabViewItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewItems)).EndInit();
            this.tabClientDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedUPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddItems;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox AddColoumntxt;
        private System.Windows.Forms.Button AddFeaturesbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAddItems;
        private System.Windows.Forms.Label WelcomeShopPagelbl;
        private System.Windows.Forms.TabPage tabViewItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewViewItems;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberofBattery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.TabPage tabClientDetails;
        private System.Windows.Forms.DataGridView dataGridViewClientDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ErrorMsglbl;
        private System.Windows.Forms.DataGridView dataGridViewSelectedUPS;
        private System.Windows.Forms.Button Viewbtn;
    }
}