namespace POE_19003041_PROG6211
{
    partial class Capture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capture));
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.minTempBox = new System.Windows.Forms.TextBox();
            this.maxTempBox = new System.Windows.Forms.TextBox();
            this.precipBox = new System.Windows.Forms.TextBox();
            this.humidBox = new System.Windows.Forms.TextBox();
            this.windBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.minTempLabel = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.precipLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.dateInputBox = new System.Windows.Forms.DateTimePicker();
            this.reportLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypeLoginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.usersStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cityBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Alexandra",
            "Bellville",
            "Benoni",
            "Bloemfontein",
            "Boksburg",
            "Botshabelo",
            "Cape Town",
            "Chatsworth",
            "Durban",
            "East London",
            "Empangeni",
            "Germiston",
            "Johannesburg",
            "Katlehong",
            "Kempton Park",
            "Khayelitsha",
            "Kimberley",
            "KwaMashu",
            "Newcastle",
            "Ntuzuma",
            "Pietermaritzburg",
            "Port Elizabeth",
            "Pretoria",
            "Roodepoort",
            "Springs",
            "Tembisa",
            "Umlazi",
            "Vereeniging"});
            this.cityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cityBox.Items.AddRange(new object[] {
            "Alexandra",
            "Bellville",
            "Benoni",
            "Bloemfontein",
            "Boksburg",
            "Botshabelo",
            "Cape Town",
            "Chatsworth",
            "Durban",
            "East London",
            "Empangeni",
            "Germiston",
            "Johannesburg",
            "Katlehong",
            "Kempton Park",
            "Khayelitsha",
            "Kimberley",
            "KwaMashu",
            "Newcastle",
            "Ntuzuma",
            "Pietermaritzburg",
            "Port Elizabeth",
            "Pretoria",
            "Roodepoort",
            "Springs",
            "Tembisa",
            "Umlazi",
            "Vereeniging"});
            this.cityBox.Location = new System.Drawing.Point(103, 114);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(157, 21);
            this.cityBox.TabIndex = 0;
            this.cityBox.Text = "Cape Town";
            this.cityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityBox_KeyPress);
            // 
            // minTempBox
            // 
            this.minTempBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minTempBox.Location = new System.Drawing.Point(103, 166);
            this.minTempBox.MaxLength = 3;
            this.minTempBox.Name = "minTempBox";
            this.minTempBox.Size = new System.Drawing.Size(39, 20);
            this.minTempBox.TabIndex = 2;
            this.minTempBox.Text = "56";
            this.minTempBox.TextChanged += new System.EventHandler(this.MinTempBox_TextChanged);
            this.minTempBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinTempBox_KeyPress);
            // 
            // maxTempBox
            // 
            this.maxTempBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxTempBox.Location = new System.Drawing.Point(103, 192);
            this.maxTempBox.MaxLength = 3;
            this.maxTempBox.Name = "maxTempBox";
            this.maxTempBox.Size = new System.Drawing.Size(39, 20);
            this.maxTempBox.TabIndex = 3;
            this.maxTempBox.Text = "56";
            this.maxTempBox.TextChanged += new System.EventHandler(this.MaxTempBox_TextChanged);
            this.maxTempBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxTempBox_KeyPress);
            // 
            // precipBox
            // 
            this.precipBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.precipBox.Location = new System.Drawing.Point(103, 218);
            this.precipBox.MaxLength = 3;
            this.precipBox.Name = "precipBox";
            this.precipBox.Size = new System.Drawing.Size(39, 20);
            this.precipBox.TabIndex = 4;
            this.precipBox.Text = "56";
            this.precipBox.TextChanged += new System.EventHandler(this.PrecipBox_TextChanged);
            this.precipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecipBox_KeyPress);
            // 
            // humidBox
            // 
            this.humidBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.humidBox.Location = new System.Drawing.Point(103, 244);
            this.humidBox.MaxLength = 3;
            this.humidBox.Name = "humidBox";
            this.humidBox.Size = new System.Drawing.Size(39, 20);
            this.humidBox.TabIndex = 5;
            this.humidBox.Text = "56";
            this.humidBox.TextChanged += new System.EventHandler(this.HumidBox_TextChanged);
            this.humidBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HumidBox_KeyPress);
            // 
            // windBox
            // 
            this.windBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.windBox.Location = new System.Drawing.Point(103, 270);
            this.windBox.MaxLength = 3;
            this.windBox.Name = "windBox";
            this.windBox.Size = new System.Drawing.Size(39, 20);
            this.windBox.TabIndex = 6;
            this.windBox.Text = "56";
            this.windBox.TextChanged += new System.EventHandler(this.WindBox_TextChanged);
            this.windBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WindBox_KeyPress);
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(65, 117);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(32, 13);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City:";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(59, 143);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 13);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Date:";
            // 
            // minTempLabel
            // 
            this.minTempLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minTempLabel.AutoSize = true;
            this.minTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.minTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTempLabel.Location = new System.Drawing.Point(31, 169);
            this.minTempLabel.Name = "minTempLabel";
            this.minTempLabel.Size = new System.Drawing.Size(66, 13);
            this.minTempLabel.TabIndex = 9;
            this.minTempLabel.Text = "Min Temp:";
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempLabel.Location = new System.Drawing.Point(28, 195);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(69, 13);
            this.maxTempLabel.TabIndex = 10;
            this.maxTempLabel.Text = "Max Temp:";
            // 
            // precipLabel
            // 
            this.precipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.precipLabel.AutoSize = true;
            this.precipLabel.BackColor = System.Drawing.Color.Transparent;
            this.precipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipLabel.Location = new System.Drawing.Point(15, 221);
            this.precipLabel.Name = "precipLabel";
            this.precipLabel.Size = new System.Drawing.Size(82, 13);
            this.precipLabel.TabIndex = 11;
            this.precipLabel.Text = "Precipitation:";
            // 
            // humidityLabel
            // 
            this.humidityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.Location = new System.Drawing.Point(38, 247);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(59, 13);
            this.humidityLabel.TabIndex = 12;
            this.humidityLabel.Text = "Humidity:";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.Location = new System.Drawing.Point(17, 273);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(80, 13);
            this.windSpeedLabel.TabIndex = 13;
            this.windSpeedLabel.Text = "Wind Speed:";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.submitButton.Location = new System.Drawing.Point(184, 310);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // dateInputBox
            // 
            this.dateInputBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateInputBox.Location = new System.Drawing.Point(103, 140);
            this.dateInputBox.Name = "dateInputBox";
            this.dateInputBox.Size = new System.Drawing.Size(200, 20);
            this.dateInputBox.TabIndex = 15;
            // 
            // reportLabel
            // 
            this.reportLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportLabel.AutoSize = true;
            this.reportLabel.BackColor = System.Drawing.Color.Transparent;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(90, 37);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(140, 39);
            this.reportLabel.TabIndex = 19;
            this.reportLabel.Text = "Capture";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(145, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "°C";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(145, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "°C";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(148, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(148, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(148, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "km/h";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.Location = new System.Drawing.Point(72, 310);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 129;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.loginStrip,
            this.viewStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 130;
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
            // viewStrip
            // 
            this.viewStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportStrip,
            this.updateStrip,
            this.usersStrip});
            this.viewStrip.Name = "viewStrip";
            this.viewStrip.Size = new System.Drawing.Size(44, 20);
            this.viewStrip.Text = "View";
            // 
            // reportStrip
            // 
            this.reportStrip.Name = "reportStrip";
            this.reportStrip.Size = new System.Drawing.Size(180, 22);
            this.reportStrip.Text = "Report";
            this.reportStrip.Click += new System.EventHandler(this.ReportStrip_Click);
            // 
            // updateStrip
            // 
            this.updateStrip.Name = "updateStrip";
            this.updateStrip.Size = new System.Drawing.Size(180, 22);
            this.updateStrip.Text = "Update";
            this.updateStrip.Click += new System.EventHandler(this.UpdateStrip_Click);
            // 
            // usersStrip
            // 
            this.usersStrip.Name = "usersStrip";
            this.usersStrip.Size = new System.Drawing.Size(180, 22);
            this.usersStrip.Text = "Users";
            this.usersStrip.Click += new System.EventHandler(this.UsersStrip_Click);
            // 
            // Capture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.dateInputBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.precipLabel);
            this.Controls.Add(this.maxTempLabel);
            this.Controls.Add(this.minTempLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.windBox);
            this.Controls.Add(this.humidBox);
            this.Controls.Add(this.precipBox);
            this.Controls.Add(this.maxTempBox);
            this.Controls.Add(this.minTempBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 390);
            this.MinimumSize = new System.Drawing.Size(340, 390);
            this.Name = "Capture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weather Forecaster - Capture";
            this.Load += new System.EventHandler(this.Capture_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.TextBox minTempBox;
        private System.Windows.Forms.TextBox maxTempBox;
        private System.Windows.Forms.TextBox precipBox;
        private System.Windows.Forms.TextBox humidBox;
        private System.Windows.Forms.TextBox windBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label minTempLabel;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.Label precipLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker dateInputBox;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginStrip;
        private System.Windows.Forms.ToolStripMenuItem userTypeLoginStrip;
        private System.Windows.Forms.ToolStripMenuItem viewStrip;
        private System.Windows.Forms.ToolStripMenuItem reportStrip;
        private System.Windows.Forms.ToolStripMenuItem updateStrip;
        private System.Windows.Forms.ToolStripMenuItem usersStrip;
    }
}

