namespace ElectronicShop
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Loginlbl = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CreateanAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Old English Text MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(193, 122);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(96, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(193, 186);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(307, 122);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.ShortcutsEnabled = false;
            this.Usernametxt.Size = new System.Drawing.Size(133, 20);
            this.Usernametxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(307, 186);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(133, 20);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // Loginlbl
            // 
            this.Loginlbl.AutoSize = true;
            this.Loginlbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlbl.Location = new System.Drawing.Point(265, 48);
            this.Loginlbl.Name = "Loginlbl";
            this.Loginlbl.Size = new System.Drawing.Size(80, 24);
            this.Loginlbl.TabIndex = 4;
            this.Loginlbl.Text = "LOGIN";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(270, 261);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "&Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.OK_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CreateanAccount
            // 
            this.CreateanAccount.AutoSize = true;
            this.CreateanAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateanAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateanAccount.Location = new System.Drawing.Point(266, 347);
            this.CreateanAccount.Name = "CreateanAccount";
            this.CreateanAccount.Size = new System.Drawing.Size(96, 13);
            this.CreateanAccount.TabIndex = 7;
            this.CreateanAccount.Text = "Create an Account";
            this.CreateanAccount.Click += new System.EventHandler(this.CreateanAccount_Click);
            this.CreateanAccount.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.CreateanAccount.MouseLeave += new System.EventHandler(this.CreateanAccount_MouseLeave);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 423);
            this.Controls.Add(this.CreateanAccount);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Loginlbl);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "ShopOwner Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Loginlbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label CreateanAccount;
    }
}