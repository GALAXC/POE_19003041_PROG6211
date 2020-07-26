namespace POE_19003041_PROG6211
{
    partial class Update
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.updateLabel = new System.Windows.Forms.Label();
            this.editBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateInputBox = new System.Windows.Forms.DateTimePicker();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.precipLabel = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.minTempLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.windBox = new System.Windows.Forms.TextBox();
            this.humidBox = new System.Windows.Forms.TextBox();
            this.precipBox = new System.Windows.Forms.TextBox();
            this.maxTempBox = new System.Windows.Forms.TextBox();
            this.minTempBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypeLoginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.captureStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.usersStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.Location = new System.Drawing.Point(256, 37);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(128, 39);
            this.updateLabel.TabIndex = 141;
            this.updateLabel.Text = "Update";
            // 
            // editBox
            // 
            this.editBox.FormattingEnabled = true;
            this.editBox.Location = new System.Drawing.Point(343, 116);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(290, 316);
            this.editBox.TabIndex = 143;
            this.editBox.SelectedIndexChanged += new System.EventHandler(this.editBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(152, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 162;
            this.label10.Text = "km/h";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(152, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 161;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(152, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 160;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(149, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 159;
            this.label7.Text = "°C";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(149, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 158;
            this.label5.Text = "°C";
            // 
            // dateInputBox
            // 
            this.dateInputBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateInputBox.Location = new System.Drawing.Point(107, 205);
            this.dateInputBox.Name = "dateInputBox";
            this.dateInputBox.Size = new System.Drawing.Size(200, 20);
            this.dateInputBox.TabIndex = 157;
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.Location = new System.Drawing.Point(21, 338);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(80, 13);
            this.windSpeedLabel.TabIndex = 156;
            this.windSpeedLabel.Text = "Wind Speed:";
            // 
            // humidityLabel
            // 
            this.humidityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.Location = new System.Drawing.Point(42, 312);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(59, 13);
            this.humidityLabel.TabIndex = 155;
            this.humidityLabel.Text = "Humidity:";
            // 
            // precipLabel
            // 
            this.precipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.precipLabel.AutoSize = true;
            this.precipLabel.BackColor = System.Drawing.Color.Transparent;
            this.precipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipLabel.Location = new System.Drawing.Point(19, 286);
            this.precipLabel.Name = "precipLabel";
            this.precipLabel.Size = new System.Drawing.Size(82, 13);
            this.precipLabel.TabIndex = 154;
            this.precipLabel.Text = "Precipitation:";
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempLabel.Location = new System.Drawing.Point(32, 260);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(69, 13);
            this.maxTempLabel.TabIndex = 153;
            this.maxTempLabel.Text = "Max Temp:";
            // 
            // minTempLabel
            // 
            this.minTempLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minTempLabel.AutoSize = true;
            this.minTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.minTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTempLabel.Location = new System.Drawing.Point(35, 234);
            this.minTempLabel.Name = "minTempLabel";
            this.minTempLabel.Size = new System.Drawing.Size(66, 13);
            this.minTempLabel.TabIndex = 152;
            this.minTempLabel.Text = "Min Temp:";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(63, 208);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 13);
            this.dateLabel.TabIndex = 151;
            this.dateLabel.Text = "Date:";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(69, 182);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(32, 13);
            this.cityLabel.TabIndex = 150;
            this.cityLabel.Text = "City:";
            // 
            // windBox
            // 
            this.windBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.windBox.Location = new System.Drawing.Point(107, 335);
            this.windBox.MaxLength = 3;
            this.windBox.Name = "windBox";
            this.windBox.Size = new System.Drawing.Size(39, 20);
            this.windBox.TabIndex = 149;
            this.windBox.TextChanged += new System.EventHandler(this.windBox_TextChanged);
            this.windBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WindBox_KeyPress);
            // 
            // humidBox
            // 
            this.humidBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.humidBox.Location = new System.Drawing.Point(107, 309);
            this.humidBox.MaxLength = 3;
            this.humidBox.Name = "humidBox";
            this.humidBox.Size = new System.Drawing.Size(39, 20);
            this.humidBox.TabIndex = 148;
            this.humidBox.TextChanged += new System.EventHandler(this.humidBox_TextChanged);
            this.humidBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HumidBox_KeyPress);
            // 
            // precipBox
            // 
            this.precipBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.precipBox.Location = new System.Drawing.Point(107, 283);
            this.precipBox.MaxLength = 3;
            this.precipBox.Name = "precipBox";
            this.precipBox.Size = new System.Drawing.Size(39, 20);
            this.precipBox.TabIndex = 147;
            this.precipBox.TextChanged += new System.EventHandler(this.PrecipBox_TextChanged);
            this.precipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecipBox_KeyPress);
            // 
            // maxTempBox
            // 
            this.maxTempBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxTempBox.Location = new System.Drawing.Point(107, 257);
            this.maxTempBox.MaxLength = 3;
            this.maxTempBox.Name = "maxTempBox";
            this.maxTempBox.Size = new System.Drawing.Size(39, 20);
            this.maxTempBox.TabIndex = 146;
            this.maxTempBox.TextChanged += new System.EventHandler(this.maxTempBox_TextChanged);
            this.maxTempBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxTempBox_KeyPress);
            // 
            // minTempBox
            // 
            this.minTempBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minTempBox.Location = new System.Drawing.Point(107, 231);
            this.minTempBox.MaxLength = 3;
            this.minTempBox.Name = "minTempBox";
            this.minTempBox.Size = new System.Drawing.Size(39, 20);
            this.minTempBox.TabIndex = 145;
            this.minTempBox.TextChanged += new System.EventHandler(this.minTempBox_TextChanged);
            this.minTempBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinTempBox_KeyPress);
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
            this.cityBox.Location = new System.Drawing.Point(107, 179);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(157, 21);
            this.cityBox.TabIndex = 144;
            this.cityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 163;
            this.label1.Text = "Click to select then edit on the left";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(122, 395);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 164;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrip,
            this.logoutStrip,
            this.loginStrip,
            this.viewStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 168;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitStrip});
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(37, 20);
            this.fileStrip.Text = "File";
            // 
            // exitStrip
            // 
            this.exitStrip.Name = "exitStrip";
            this.exitStrip.Size = new System.Drawing.Size(93, 22);
            this.exitStrip.Text = "Exit";
            this.exitStrip.Click += new System.EventHandler(this.exitStrip_Click);
            // 
            // logoutStrip
            // 
            this.logoutStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutStrip.Name = "logoutStrip";
            this.logoutStrip.Size = new System.Drawing.Size(57, 20);
            this.logoutStrip.Text = "Logout";
            this.logoutStrip.Click += new System.EventHandler(this.logoutStrip_Click);
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
            this.captureStrip,
            this.usersStrip});
            this.viewStrip.Name = "viewStrip";
            this.viewStrip.Size = new System.Drawing.Size(44, 20);
            this.viewStrip.Text = "View";
            // 
            // reportStrip
            // 
            this.reportStrip.Name = "reportStrip";
            this.reportStrip.Size = new System.Drawing.Size(116, 22);
            this.reportStrip.Text = "Report";
            this.reportStrip.Click += new System.EventHandler(this.reportStrip_Click);
            // 
            // captureStrip
            // 
            this.captureStrip.Name = "captureStrip";
            this.captureStrip.Size = new System.Drawing.Size(116, 22);
            this.captureStrip.Text = "Capture";
            this.captureStrip.Click += new System.EventHandler(this.captureStrip_Click);
            // 
            // usersStrip
            // 
            this.usersStrip.Name = "usersStrip";
            this.usersStrip.Size = new System.Drawing.Size(116, 22);
            this.usersStrip.Text = "Users";
            this.usersStrip.Click += new System.EventHandler(this.usersStrip_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 441);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateInputBox);
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
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.updateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(659, 480);
            this.MinimumSize = new System.Drawing.Size(659, 480);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weather Forecaster - Update";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.ListBox editBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateInputBox;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label precipLabel;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.Label minTempLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox windBox;
        private System.Windows.Forms.TextBox humidBox;
        private System.Windows.Forms.TextBox precipBox;
        private System.Windows.Forms.TextBox maxTempBox;
        private System.Windows.Forms.TextBox minTempBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStrip;
        private System.Windows.Forms.ToolStripMenuItem exitStrip;
        private System.Windows.Forms.ToolStripMenuItem logoutStrip;
        private System.Windows.Forms.ToolStripMenuItem loginStrip;
        private System.Windows.Forms.ToolStripMenuItem userTypeLoginStrip;
        private System.Windows.Forms.ToolStripMenuItem viewStrip;
        private System.Windows.Forms.ToolStripMenuItem reportStrip;
        private System.Windows.Forms.ToolStripMenuItem captureStrip;
        private System.Windows.Forms.ToolStripMenuItem usersStrip;
    }
}