namespace POE_19003041_PROG6211
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.clearCitiesSelected = new System.Windows.Forms.Button();
            this.lowestMaxTemp = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.highestMaxTemp = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.highestWind = new System.Windows.Forms.Label();
            this.highestHumid = new System.Windows.Forms.Label();
            this.highestPrecip = new System.Windows.Forms.Label();
            this.highestMinTemp = new System.Windows.Forms.Label();
            this.lowestWind = new System.Windows.Forms.Label();
            this.lowestHumid = new System.Windows.Forms.Label();
            this.lowestPrecip = new System.Windows.Forms.Label();
            this.lowestMinTemp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportTable = new System.Windows.Forms.DataGridView();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precipitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WindSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.datesSelected = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDateBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cityReportBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypeLoginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.printReportButton = new System.Windows.Forms.Button();
            this.viewStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.captureStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.usersStrip = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearCitiesSelected
            // 
            this.clearCitiesSelected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearCitiesSelected.Location = new System.Drawing.Point(765, 102);
            this.clearCitiesSelected.Name = "clearCitiesSelected";
            this.clearCitiesSelected.Size = new System.Drawing.Size(46, 23);
            this.clearCitiesSelected.TabIndex = 166;
            this.clearCitiesSelected.Text = "Clear";
            this.clearCitiesSelected.UseVisualStyleBackColor = true;
            this.clearCitiesSelected.Click += new System.EventHandler(this.ClearCitiesSelected_Click);
            // 
            // lowestMaxTemp
            // 
            this.lowestMaxTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lowestMaxTemp.AutoSize = true;
            this.lowestMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lowestMaxTemp.Location = new System.Drawing.Point(903, 276);
            this.lowestMaxTemp.Name = "lowestMaxTemp";
            this.lowestMaxTemp.Size = new System.Drawing.Size(0, 13);
            this.lowestMaxTemp.TabIndex = 165;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(836, 276);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 164;
            this.label23.Text = "Max Temp:";
            // 
            // highestMaxTemp
            // 
            this.highestMaxTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.highestMaxTemp.AutoSize = true;
            this.highestMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.highestMaxTemp.Location = new System.Drawing.Point(1043, 276);
            this.highestMaxTemp.Name = "highestMaxTemp";
            this.highestMaxTemp.Size = new System.Drawing.Size(0, 13);
            this.highestMaxTemp.TabIndex = 163;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(977, 276);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 162;
            this.label21.Text = "Max Temp:";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(980, 252);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 161;
            this.label22.Text = "Min Temp:";
            // 
            // highestWind
            // 
            this.highestWind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.highestWind.AutoSize = true;
            this.highestWind.BackColor = System.Drawing.Color.Transparent;
            this.highestWind.Location = new System.Drawing.Point(1043, 350);
            this.highestWind.Name = "highestWind";
            this.highestWind.Size = new System.Drawing.Size(0, 13);
            this.highestWind.TabIndex = 160;
            // 
            // highestHumid
            // 
            this.highestHumid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.highestHumid.AutoSize = true;
            this.highestHumid.BackColor = System.Drawing.Color.Transparent;
            this.highestHumid.Location = new System.Drawing.Point(1043, 325);
            this.highestHumid.Name = "highestHumid";
            this.highestHumid.Size = new System.Drawing.Size(0, 13);
            this.highestHumid.TabIndex = 159;
            // 
            // highestPrecip
            // 
            this.highestPrecip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.highestPrecip.AutoSize = true;
            this.highestPrecip.BackColor = System.Drawing.Color.Transparent;
            this.highestPrecip.Location = new System.Drawing.Point(1043, 300);
            this.highestPrecip.Name = "highestPrecip";
            this.highestPrecip.Size = new System.Drawing.Size(0, 13);
            this.highestPrecip.TabIndex = 158;
            // 
            // highestMinTemp
            // 
            this.highestMinTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.highestMinTemp.AutoSize = true;
            this.highestMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.highestMinTemp.Location = new System.Drawing.Point(1043, 252);
            this.highestMinTemp.Name = "highestMinTemp";
            this.highestMinTemp.Size = new System.Drawing.Size(0, 13);
            this.highestMinTemp.TabIndex = 157;
            // 
            // lowestWind
            // 
            this.lowestWind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lowestWind.AutoSize = true;
            this.lowestWind.BackColor = System.Drawing.Color.Transparent;
            this.lowestWind.Location = new System.Drawing.Point(903, 350);
            this.lowestWind.Name = "lowestWind";
            this.lowestWind.Size = new System.Drawing.Size(0, 13);
            this.lowestWind.TabIndex = 156;
            // 
            // lowestHumid
            // 
            this.lowestHumid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lowestHumid.AutoSize = true;
            this.lowestHumid.BackColor = System.Drawing.Color.Transparent;
            this.lowestHumid.Location = new System.Drawing.Point(903, 325);
            this.lowestHumid.Name = "lowestHumid";
            this.lowestHumid.Size = new System.Drawing.Size(0, 13);
            this.lowestHumid.TabIndex = 155;
            // 
            // lowestPrecip
            // 
            this.lowestPrecip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lowestPrecip.AutoSize = true;
            this.lowestPrecip.BackColor = System.Drawing.Color.Transparent;
            this.lowestPrecip.Location = new System.Drawing.Point(903, 300);
            this.lowestPrecip.Name = "lowestPrecip";
            this.lowestPrecip.Size = new System.Drawing.Size(0, 13);
            this.lowestPrecip.TabIndex = 154;
            // 
            // lowestMinTemp
            // 
            this.lowestMinTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lowestMinTemp.AutoSize = true;
            this.lowestMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.lowestMinTemp.Location = new System.Drawing.Point(903, 252);
            this.lowestMinTemp.Name = "lowestMinTemp";
            this.lowestMinTemp.Size = new System.Drawing.Size(0, 13);
            this.lowestMinTemp.TabIndex = 153;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(968, 350);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 152;
            this.label18.Text = "Wind Speed:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(987, 325);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 151;
            this.label19.Text = "Humidity:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(969, 300);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 150;
            this.label20.Text = "Precipitation:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(827, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 149;
            this.label17.Text = "Wind Speed:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(846, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 148;
            this.label15.Text = "Humidity:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(828, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 147;
            this.label16.Text = "Precipitation:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(839, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 146;
            this.label14.Text = "Min Temp:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(972, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 18);
            this.label13.TabIndex = 145;
            this.label13.Text = "Highest";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(834, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 144;
            this.label12.Text = "Lowest";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 143;
            this.label11.Text = "Add or Remove Cities:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.Location = new System.Drawing.Point(146, 319);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 142;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // reportTable
            // 
            this.reportTable.AllowUserToAddRows = false;
            this.reportTable.AllowUserToDeleteRows = false;
            this.reportTable.AllowUserToResizeColumns = false;
            this.reportTable.AllowUserToResizeRows = false;
            this.reportTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.Date,
            this.MinTemp,
            this.MaxTemp,
            this.Precipitation,
            this.Humidity,
            this.WindSpeed});
            this.reportTable.Location = new System.Drawing.Point(241, 182);
            this.reportTable.Name = "reportTable";
            this.reportTable.ReadOnly = true;
            this.reportTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.reportTable.Size = new System.Drawing.Size(574, 222);
            this.reportTable.TabIndex = 141;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.City.Width = 90;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 70;
            // 
            // MinTemp
            // 
            this.MinTemp.HeaderText = "Min Temp";
            this.MinTemp.MaxInputLength = 3;
            this.MinTemp.MinimumWidth = 3;
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.ReadOnly = true;
            this.MinTemp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MinTemp.Width = 79;
            // 
            // MaxTemp
            // 
            this.MaxTemp.HeaderText = "Max Temp";
            this.MaxTemp.MaxInputLength = 3;
            this.MaxTemp.MinimumWidth = 3;
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.ReadOnly = true;
            this.MaxTemp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaxTemp.Width = 80;
            // 
            // Precipitation
            // 
            this.Precipitation.HeaderText = "Precipitation";
            this.Precipitation.MaxInputLength = 3;
            this.Precipitation.MinimumWidth = 3;
            this.Precipitation.Name = "Precipitation";
            this.Precipitation.ReadOnly = true;
            this.Precipitation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precipitation.Width = 70;
            // 
            // Humidity
            // 
            this.Humidity.HeaderText = "Humidity";
            this.Humidity.MaxInputLength = 3;
            this.Humidity.MinimumWidth = 3;
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
            this.Humidity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Humidity.Width = 50;
            // 
            // WindSpeed
            // 
            this.WindSpeed.HeaderText = "Wind Speed";
            this.WindSpeed.MaxInputLength = 3;
            this.WindSpeed.MinimumWidth = 3;
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.ReadOnly = true;
            this.WindSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WindSpeed.Width = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 39);
            this.label6.TabIndex = 140;
            this.label6.Text = "Report";
            // 
            // datesSelected
            // 
            this.datesSelected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datesSelected.AutoSize = true;
            this.datesSelected.BackColor = System.Drawing.Color.Transparent;
            this.datesSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesSelected.Location = new System.Drawing.Point(363, 152);
            this.datesSelected.Name = "datesSelected";
            this.datesSelected.Size = new System.Drawing.Size(139, 16);
            this.datesSelected.TabIndex = 139;
            this.datesSelected.Text = "1/01/2020 - 30/09/2020";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "Dates Selected:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Ending Date:";
            // 
            // endDateBox
            // 
            this.endDateBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDateBox.Location = new System.Drawing.Point(10, 262);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(211, 20);
            this.endDateBox.TabIndex = 136;
            this.endDateBox.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.endDateBox.ValueChanged += new System.EventHandler(this.EndDateBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 135;
            this.label2.Text = "Starting Date:";
            // 
            // startDateBox
            // 
            this.startDateBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDateBox.Location = new System.Drawing.Point(10, 188);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(211, 20);
            this.startDateBox.TabIndex = 134;
            this.startDateBox.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.startDateBox.ValueChanged += new System.EventHandler(this.StartDateBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 133;
            this.label1.Text = "Cities Selected:";
            // 
            // cityReportBox
            // 
            this.cityReportBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cityReportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityReportBox.Location = new System.Drawing.Point(359, 93);
            this.cityReportBox.MaximumSize = new System.Drawing.Size(400, 4);
            this.cityReportBox.MinimumSize = new System.Drawing.Size(400, 39);
            this.cityReportBox.Multiline = true;
            this.cityReportBox.Name = "cityReportBox";
            this.cityReportBox.ReadOnly = true;
            this.cityReportBox.Size = new System.Drawing.Size(400, 39);
            this.cityReportBox.TabIndex = 132;
            this.cityReportBox.Text = "Cape Town, Johannesburg";
            // 
            // cityComboBox
            // 
            this.cityComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(10, 114);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(211, 21);
            this.cityComboBox.TabIndex = 131;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.CityComboBox_SelectedIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 167;
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
            // printReportButton
            // 
            this.printReportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.printReportButton.Location = new System.Drawing.Point(10, 319);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(75, 23);
            this.printReportButton.TabIndex = 168;
            this.printReportButton.Text = "Print Report";
            this.printReportButton.UseVisualStyleBackColor = true;
            this.printReportButton.Click += new System.EventHandler(this.PrintReportButton_Click);
            // 
            // viewStrip
            // 
            this.viewStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureStrip,
            this.updateStrip,
            this.usersStrip});
            this.viewStrip.Name = "viewStrip";
            this.viewStrip.Size = new System.Drawing.Size(44, 20);
            this.viewStrip.Text = "View";
            // 
            // captureStrip
            // 
            this.captureStrip.Name = "captureStrip";
            this.captureStrip.Size = new System.Drawing.Size(180, 22);
            this.captureStrip.Text = "Capture";
            this.captureStrip.Click += new System.EventHandler(this.CaptureStrip_Click);
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
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 443);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.clearCitiesSelected);
            this.Controls.Add(this.lowestMaxTemp);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.highestMaxTemp);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.highestWind);
            this.Controls.Add(this.highestHumid);
            this.Controls.Add(this.highestPrecip);
            this.Controls.Add(this.highestMinTemp);
            this.Controls.Add(this.lowestWind);
            this.Controls.Add(this.lowestHumid);
            this.Controls.Add(this.lowestPrecip);
            this.Controls.Add(this.lowestMinTemp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reportTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datesSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityReportBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1114, 482);
            this.MinimumSize = new System.Drawing.Size(1114, 482);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weather Forecaster - Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearCitiesSelected;
        private System.Windows.Forms.Label lowestMaxTemp;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label highestMaxTemp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label highestWind;
        private System.Windows.Forms.Label highestHumid;
        private System.Windows.Forms.Label highestPrecip;
        private System.Windows.Forms.Label highestMinTemp;
        private System.Windows.Forms.Label lowestWind;
        private System.Windows.Forms.Label lowestHumid;
        private System.Windows.Forms.Label lowestPrecip;
        private System.Windows.Forms.Label lowestMinTemp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView reportTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label datesSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityReportBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginStrip;
        private System.Windows.Forms.ToolStripMenuItem userTypeLoginStrip;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precipitation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn WindSpeed;
        private System.Windows.Forms.ToolStripMenuItem viewStrip;
        private System.Windows.Forms.ToolStripMenuItem captureStrip;
        private System.Windows.Forms.ToolStripMenuItem updateStrip;
        private System.Windows.Forms.ToolStripMenuItem usersStrip;
    }
}