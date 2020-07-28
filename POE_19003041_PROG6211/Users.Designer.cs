namespace POE_19003041_PROG6211
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.captureStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypeLoginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.ListBox();
            this.usersLabel = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userTypeBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showHidePasswordButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewStrip,
            this.logoutToolStripMenuItem,
            this.loginStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 131;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // viewStrip
            // 
            this.viewStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportStrip,
            this.captureStrip,
            this.updateStrip});
            this.viewStrip.Name = "viewStrip";
            this.viewStrip.Size = new System.Drawing.Size(44, 20);
            this.viewStrip.Text = "View";
            // 
            // reportStrip
            // 
            this.reportStrip.Name = "reportStrip";
            this.reportStrip.Size = new System.Drawing.Size(116, 22);
            this.reportStrip.Text = "Report";
            this.reportStrip.Click += new System.EventHandler(this.ReportStrip_Click);
            // 
            // captureStrip
            // 
            this.captureStrip.Name = "captureStrip";
            this.captureStrip.Size = new System.Drawing.Size(116, 22);
            this.captureStrip.Text = "Capture";
            this.captureStrip.Click += new System.EventHandler(this.CaptureStrip_Click);
            // 
            // updateStrip
            // 
            this.updateStrip.Name = "updateStrip";
            this.updateStrip.Size = new System.Drawing.Size(116, 22);
            this.updateStrip.Text = "Update";
            this.updateStrip.Click += new System.EventHandler(this.UpdateStrip_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // loginStrip
            // 
            this.loginStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userTypeLoginStrip});
            this.loginStrip.Name = "loginStrip";
            this.loginStrip.Size = new System.Drawing.Size(154, 20);
            this.loginStrip.Text = "Logged in as: Placeholder";
            // 
            // userTypeLoginStrip
            // 
            this.userTypeLoginStrip.Name = "userTypeLoginStrip";
            this.userTypeLoginStrip.Size = new System.Drawing.Size(184, 22);
            this.userTypeLoginStrip.Text = "User Type: Forecaster";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 166;
            this.label1.Text = "Click to select then edit on the left";
            // 
            // userBox
            // 
            this.userBox.FormattingEnabled = true;
            this.userBox.Location = new System.Drawing.Point(291, 122);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(197, 186);
            this.userBox.TabIndex = 165;
            this.userBox.SelectedIndexChanged += new System.EventHandler(this.UserBox_SelectedIndexChanged);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.BackColor = System.Drawing.Color.Transparent;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(193, 42);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(109, 39);
            this.usersLabel.TabIndex = 164;
            this.usersLabel.Text = "Users";
            // 
            // adminLabel
            // 
            this.adminLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(33, 225);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(69, 13);
            this.adminLabel.TabIndex = 172;
            this.adminLabel.Text = "User Type:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(37, 174);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 13);
            this.passwordLabel.TabIndex = 171;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(35, 125);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(67, 13);
            this.usernameLabel.TabIndex = 170;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordBox.Location = new System.Drawing.Point(107, 171);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(132, 20);
            this.passwordBox.TabIndex = 168;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameBox.Location = new System.Drawing.Point(107, 122);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(132, 20);
            this.usernameBox.TabIndex = 167;
            // 
            // userTypeBox
            // 
            this.userTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeBox.FormattingEnabled = true;
            this.userTypeBox.Items.AddRange(new object[] {
            "Forecaster",
            "Regular"});
            this.userTypeBox.Location = new System.Drawing.Point(107, 222);
            this.userTypeBox.Name = "userTypeBox";
            this.userTypeBox.Size = new System.Drawing.Size(132, 21);
            this.userTypeBox.TabIndex = 173;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(107, 285);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 174;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(26, 285);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 175;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // showHidePasswordButton
            // 
            this.showHidePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.showHidePasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showHidePasswordButton.BackgroundImage")));
            this.showHidePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showHidePasswordButton.Location = new System.Drawing.Point(255, 170);
            this.showHidePasswordButton.Name = "showHidePasswordButton";
            this.showHidePasswordButton.Size = new System.Drawing.Size(23, 23);
            this.showHidePasswordButton.TabIndex = 177;
            this.showHidePasswordButton.UseVisualStyleBackColor = false;
            this.showHidePasswordButton.Click += new System.EventHandler(this.ShowHidePasswordButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.ImageKey = "(none)";
            this.addButton.Location = new System.Drawing.Point(188, 285);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 176;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 342);
            this.Controls.Add(this.showHidePasswordButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.userTypeBox);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(522, 381);
            this.MinimumSize = new System.Drawing.Size(522, 381);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weather Forecaster - Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStrip;
        private System.Windows.Forms.ToolStripMenuItem reportStrip;
        private System.Windows.Forms.ToolStripMenuItem captureStrip;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginStrip;
        private System.Windows.Forms.ToolStripMenuItem userTypeLoginStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox userBox;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.ComboBox userTypeBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStripMenuItem updateStrip;
        private System.Windows.Forms.Button showHidePasswordButton;
    }
}