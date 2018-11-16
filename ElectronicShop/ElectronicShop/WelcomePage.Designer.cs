namespace ElectronicShop
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ShopOwnerLogin = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.WelcomePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.Cursor = System.Windows.Forms.Cursors.No;
            this.Welcomelbl.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(158, 48);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(337, 25);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "WELCOME TO ELECTROIC SHOP";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(177, 388);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.SupportES.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "For Enquires and Support:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ShopOwnerLogin
            // 
            this.ShopOwnerLogin.AutoSize = true;
            this.ShopOwnerLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShopOwnerLogin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopOwnerLogin.Location = new System.Drawing.Point(158, 138);
            this.ShopOwnerLogin.Name = "ShopOwnerLogin";
            this.ShopOwnerLogin.Size = new System.Drawing.Size(179, 25);
            this.ShopOwnerLogin.TabIndex = 4;
            this.ShopOwnerLogin.Text = "-> ShopOwnerLogin";
            this.ShopOwnerLogin.Click += new System.EventHandler(this.ShopOwnerLogin_Click);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(158, 199);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(110, 25);
            this.Customer.TabIndex = 5;
            this.Customer.Text = "-> Customer";
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // WelcomePictureBox
            // 
            this.WelcomePictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.WelcomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WelcomePictureBox.Image")));
            this.WelcomePictureBox.Location = new System.Drawing.Point(500, 138);
            this.WelcomePictureBox.Name = "WelcomePictureBox";
            this.WelcomePictureBox.Size = new System.Drawing.Size(269, 183);
            this.WelcomePictureBox.TabIndex = 6;
            this.WelcomePictureBox.TabStop = false;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomePictureBox);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.ShopOwnerLogin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Welcomelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroicShop Application";
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label ShopOwnerLogin;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.PictureBox WelcomePictureBox;
    }
}

