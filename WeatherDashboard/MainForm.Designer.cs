namespace WeatherDashboard
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnToggleUnit;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnToggleUnit = new Button();
            comboCity = new ComboBox();
            pictureBoxWeatherIcon = new PictureBox();
            lblCityName = new Label();
            lblWeatherCondition = new Label();
            panel2 = new Panel();
            label1 = new Label();
            lblTemperature = new Label();
            panel3 = new Panel();
            lbltemp6 = new Label();
            picBoxHour6 = new PictureBox();
            lblHour6 = new Label();
            lbltemp5 = new Label();
            picBoxHour5 = new PictureBox();
            lblHour5 = new Label();
            lbltemp4 = new Label();
            picBoxHour4 = new PictureBox();
            lblHour4 = new Label();
            lbltemp3 = new Label();
            picBoxHour3 = new PictureBox();
            lblHour3 = new Label();
            lbltemp2 = new Label();
            picBoxHour2 = new PictureBox();
            lblHour2 = new Label();
            lbltemp1 = new Label();
            picBoxHour1 = new PictureBox();
            lblHour1 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblUV = new Label();
            lblChanceRain = new Label();
            lblWind = new Label();
            lblRealFeel = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            btnSaveSetting = new Button();
            btnRemovePreferred = new Button();
            dgvPreferred = new DataGridView();
            btnAddPreferred = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeatherIcon).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxHour6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreferred).BeginInit();
            SuspendLayout();
            // 
            // btnToggleUnit
            // 
            btnToggleUnit.BackColor = Color.FromArgb(1, 149, 255);
            btnToggleUnit.FlatAppearance.BorderSize = 0;
            btnToggleUnit.FlatStyle = FlatStyle.Flat;
            btnToggleUnit.ForeColor = Color.White;
            btnToggleUnit.Location = new Point(349, 10);
            btnToggleUnit.Margin = new Padding(0);
            btnToggleUnit.Name = "btnToggleUnit";
            btnToggleUnit.Size = new Size(79, 23);
            btnToggleUnit.TabIndex = 1;
            btnToggleUnit.Text = "Toggle Unit";
            btnToggleUnit.UseVisualStyleBackColor = false;
            btnToggleUnit.Click += btnToggleUnit_Click;
            // 
            // comboCity
            // 
            comboCity.FormattingEnabled = true;
            comboCity.Location = new Point(126, 6);
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(136, 23);
            comboCity.TabIndex = 3;
            comboCity.SelectedIndexChanged += comboCity_SelectedIndexChanged;
            // 
            // pictureBoxWeatherIcon
            // 
            pictureBoxWeatherIcon.Location = new Point(261, 47);
            pictureBoxWeatherIcon.Name = "pictureBoxWeatherIcon";
            pictureBoxWeatherIcon.Size = new Size(130, 130);
            pictureBoxWeatherIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWeatherIcon.TabIndex = 6;
            pictureBoxWeatherIcon.TabStop = false;
            // 
            // lblCityName
            // 
            lblCityName.AutoSize = true;
            lblCityName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCityName.ForeColor = Color.White;
            lblCityName.Location = new Point(29, 47);
            lblCityName.Name = "lblCityName";
            lblCityName.Size = new Size(0, 40);
            lblCityName.TabIndex = 7;
            // 
            // lblWeatherCondition
            // 
            lblWeatherCondition.AutoSize = true;
            lblWeatherCondition.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeatherCondition.ForeColor = Color.White;
            lblWeatherCondition.Location = new Point(33, 82);
            lblWeatherCondition.Name = "lblWeatherCondition";
            lblWeatherCondition.Size = new Size(0, 15);
            lblWeatherCondition.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 43, 59);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboCity);
            panel2.Location = new Point(15, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 37);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Search for cities:";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemperature.ForeColor = Color.White;
            lblTemperature.Location = new Point(29, 130);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(0, 47);
            lblTemperature.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 43, 59);
            panel3.Controls.Add(lbltemp6);
            panel3.Controls.Add(picBoxHour6);
            panel3.Controls.Add(lblHour6);
            panel3.Controls.Add(lbltemp5);
            panel3.Controls.Add(picBoxHour5);
            panel3.Controls.Add(lblHour5);
            panel3.Controls.Add(lbltemp4);
            panel3.Controls.Add(picBoxHour4);
            panel3.Controls.Add(lblHour4);
            panel3.Controls.Add(lbltemp3);
            panel3.Controls.Add(picBoxHour3);
            panel3.Controls.Add(lblHour3);
            panel3.Controls.Add(lbltemp2);
            panel3.Controls.Add(picBoxHour2);
            panel3.Controls.Add(lblHour2);
            panel3.Controls.Add(lbltemp1);
            panel3.Controls.Add(picBoxHour1);
            panel3.Controls.Add(lblHour1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(15, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 140);
            panel3.TabIndex = 6;
            // 
            // lbltemp6
            // 
            lbltemp6.AutoSize = true;
            lbltemp6.ForeColor = Color.White;
            lbltemp6.Location = new Point(394, 114);
            lbltemp6.Name = "lbltemp6";
            lbltemp6.Size = new Size(38, 15);
            lbltemp6.TabIndex = 18;
            lbltemp6.Text = "label8";
            // 
            // picBoxHour6
            // 
            picBoxHour6.Location = new Point(388, 61);
            picBoxHour6.Name = "picBoxHour6";
            picBoxHour6.Size = new Size(50, 50);
            picBoxHour6.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHour6.TabIndex = 17;
            picBoxHour6.TabStop = false;
            // 
            // lblHour6
            // 
            lblHour6.AutoSize = true;
            lblHour6.ForeColor = Color.White;
            lblHour6.Location = new Point(394, 43);
            lblHour6.Name = "lblHour6";
            lblHour6.Size = new Size(38, 15);
            lblHour6.TabIndex = 16;
            lblHour6.Text = "label8";
            // 
            // lbltemp5
            // 
            lbltemp5.AutoSize = true;
            lbltemp5.ForeColor = Color.White;
            lbltemp5.Location = new Point(320, 114);
            lbltemp5.Name = "lbltemp5";
            lbltemp5.Size = new Size(38, 15);
            lbltemp5.TabIndex = 15;
            lbltemp5.Text = "label8";
            // 
            // picBoxHour5
            // 
            picBoxHour5.Location = new Point(314, 61);
            picBoxHour5.Name = "picBoxHour5";
            picBoxHour5.Size = new Size(50, 50);
            picBoxHour5.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHour5.TabIndex = 14;
            picBoxHour5.TabStop = false;
            // 
            // lblHour5
            // 
            lblHour5.AutoSize = true;
            lblHour5.ForeColor = Color.White;
            lblHour5.Location = new Point(320, 43);
            lblHour5.Name = "lblHour5";
            lblHour5.Size = new Size(38, 15);
            lblHour5.TabIndex = 13;
            lblHour5.Text = "label8";
            // 
            // lbltemp4
            // 
            lbltemp4.AutoSize = true;
            lbltemp4.ForeColor = Color.White;
            lbltemp4.Location = new Point(243, 114);
            lbltemp4.Name = "lbltemp4";
            lbltemp4.Size = new Size(38, 15);
            lbltemp4.TabIndex = 12;
            lbltemp4.Text = "label8";
            // 
            // picBoxHour4
            // 
            picBoxHour4.Location = new Point(237, 61);
            picBoxHour4.Name = "picBoxHour4";
            picBoxHour4.Size = new Size(50, 50);
            picBoxHour4.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHour4.TabIndex = 11;
            picBoxHour4.TabStop = false;
            // 
            // lblHour4
            // 
            lblHour4.AutoSize = true;
            lblHour4.ForeColor = Color.White;
            lblHour4.Location = new Point(243, 43);
            lblHour4.Name = "lblHour4";
            lblHour4.Size = new Size(38, 15);
            lblHour4.TabIndex = 10;
            lblHour4.Text = "label8";
            // 
            // lbltemp3
            // 
            lbltemp3.AutoSize = true;
            lbltemp3.ForeColor = Color.White;
            lbltemp3.Location = new Point(166, 114);
            lbltemp3.Name = "lbltemp3";
            lbltemp3.Size = new Size(38, 15);
            lbltemp3.TabIndex = 9;
            lbltemp3.Text = "label8";
            // 
            // picBoxHour3
            // 
            picBoxHour3.Location = new Point(160, 61);
            picBoxHour3.Name = "picBoxHour3";
            picBoxHour3.Size = new Size(50, 50);
            picBoxHour3.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHour3.TabIndex = 8;
            picBoxHour3.TabStop = false;
            // 
            // lblHour3
            // 
            lblHour3.AutoSize = true;
            lblHour3.ForeColor = Color.White;
            lblHour3.Location = new Point(166, 43);
            lblHour3.Name = "lblHour3";
            lblHour3.Size = new Size(38, 15);
            lblHour3.TabIndex = 7;
            lblHour3.Text = "label8";
            // 
            // lbltemp2
            // 
            lbltemp2.AutoSize = true;
            lbltemp2.ForeColor = Color.White;
            lbltemp2.Location = new Point(89, 114);
            lbltemp2.Name = "lbltemp2";
            lbltemp2.Size = new Size(38, 15);
            lbltemp2.TabIndex = 6;
            lbltemp2.Text = "label8";
            // 
            // picBoxHour2
            // 
            picBoxHour2.Location = new Point(83, 61);
            picBoxHour2.Name = "picBoxHour2";
            picBoxHour2.Size = new Size(50, 50);
            picBoxHour2.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHour2.TabIndex = 5;
            picBoxHour2.TabStop = false;
            // 
            // lblHour2
            // 
            lblHour2.AutoSize = true;
            lblHour2.ForeColor = Color.White;
            lblHour2.Location = new Point(89, 43);
            lblHour2.Name = "lblHour2";
            lblHour2.Size = new Size(38, 15);
            lblHour2.TabIndex = 4;
            lblHour2.Text = "label8";
            // 
            // lbltemp1
            // 
            lbltemp1.AutoSize = true;
            lbltemp1.ForeColor = Color.White;
            lbltemp1.Location = new Point(13, 114);
            lbltemp1.Name = "lbltemp1";
            lbltemp1.Size = new Size(38, 15);
            lbltemp1.TabIndex = 3;
            lbltemp1.Text = "label8";
            // 
            // picBoxHour1
            // 
            picBoxHour1.Location = new Point(7, 61);
            picBoxHour1.Name = "picBoxHour1";
            picBoxHour1.Size = new Size(50, 50);
            picBoxHour1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHour1.TabIndex = 2;
            picBoxHour1.TabStop = false;
            // 
            // lblHour1
            // 
            lblHour1.AutoSize = true;
            lblHour1.ForeColor = Color.White;
            lblHour1.Location = new Point(13, 43);
            lblHour1.Name = "lblHour1";
            lblHour1.Size = new Size(38, 15);
            lblHour1.TabIndex = 1;
            lblHour1.Text = "label8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 7);
            label2.Name = "label2";
            label2.Size = new Size(103, 13);
            label2.TabIndex = 0;
            label2.Text = "TODAY'S FORCAST";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(32, 43, 59);
            panel4.Controls.Add(lblUV);
            panel4.Controls.Add(lblChanceRain);
            panel4.Controls.Add(lblWind);
            panel4.Controls.Add(lblRealFeel);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnToggleUnit);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(15, 332);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 140);
            panel4.TabIndex = 7;
            // 
            // lblUV
            // 
            lblUV.AutoSize = true;
            lblUV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUV.ForeColor = Color.White;
            lblUV.Location = new Point(286, 95);
            lblUV.Name = "lblUV";
            lblUV.Size = new Size(0, 21);
            lblUV.TabIndex = 13;
            // 
            // lblChanceRain
            // 
            lblChanceRain.AutoSize = true;
            lblChanceRain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChanceRain.ForeColor = Color.White;
            lblChanceRain.Location = new Point(32, 96);
            lblChanceRain.Name = "lblChanceRain";
            lblChanceRain.Size = new Size(0, 21);
            lblChanceRain.TabIndex = 12;
            // 
            // lblWind
            // 
            lblWind.AutoSize = true;
            lblWind.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWind.ForeColor = Color.White;
            lblWind.Location = new Point(287, 50);
            lblWind.Name = "lblWind";
            lblWind.Size = new Size(0, 21);
            lblWind.TabIndex = 11;
            // 
            // lblRealFeel
            // 
            lblRealFeel.AutoSize = true;
            lblRealFeel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRealFeel.ForeColor = Color.White;
            lblRealFeel.Location = new Point(31, 51);
            lblRealFeel.Name = "lblRealFeel";
            lblRealFeel.Size = new Size(0, 21);
            lblRealFeel.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.sun_icon;
            pictureBox3.Location = new Point(266, 82);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.wind_icon;
            pictureBox4.Location = new Point(266, 38);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(18, 18);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(285, 82);
            label6.Name = "label6";
            label6.Size = new Size(54, 13);
            label6.TabIndex = 7;
            label6.Text = "UV index";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(285, 36);
            label7.Name = "label7";
            label7.Size = new Size(35, 13);
            label7.TabIndex = 6;
            label7.Text = "Wind";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.drop_water_icon;
            pictureBox2.Location = new Point(12, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.temperature_icon;
            pictureBox1.Location = new Point(12, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(31, 82);
            label5.Name = "label5";
            label5.Size = new Size(82, 13);
            label5.TabIndex = 3;
            label5.Text = "Chance of rain";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 36);
            label4.Name = "label4";
            label4.Size = new Size(51, 13);
            label4.TabIndex = 2;
            label4.Text = "Real feel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 10);
            label3.Name = "label3";
            label3.Size = new Size(89, 13);
            label3.TabIndex = 1;
            label3.Text = "AIR CONDITION";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(32, 43, 59);
            panel5.Controls.Add(btnSaveSetting);
            panel5.Controls.Add(btnRemovePreferred);
            panel5.Controls.Add(dgvPreferred);
            panel5.Location = new Point(481, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(308, 425);
            panel5.TabIndex = 6;
            // 
            // btnSaveSetting
            // 
            btnSaveSetting.BackColor = Color.FromArgb(1, 149, 255);
            btnSaveSetting.FlatAppearance.BorderSize = 0;
            btnSaveSetting.FlatStyle = FlatStyle.Flat;
            btnSaveSetting.ForeColor = Color.White;
            btnSaveSetting.Location = new Point(93, 382);
            btnSaveSetting.Margin = new Padding(0);
            btnSaveSetting.Name = "btnSaveSetting";
            btnSaveSetting.Size = new Size(93, 23);
            btnSaveSetting.TabIndex = 3;
            btnSaveSetting.Text = "Save Setting";
            btnSaveSetting.UseVisualStyleBackColor = false;
            btnSaveSetting.Click += btnSaveSetting_Click;
            // 
            // btnRemovePreferred
            // 
            btnRemovePreferred.BackColor = Color.FromArgb(1, 149, 255);
            btnRemovePreferred.FlatAppearance.BorderSize = 0;
            btnRemovePreferred.FlatStyle = FlatStyle.Flat;
            btnRemovePreferred.ForeColor = Color.White;
            btnRemovePreferred.Location = new Point(199, 382);
            btnRemovePreferred.Margin = new Padding(0);
            btnRemovePreferred.Name = "btnRemovePreferred";
            btnRemovePreferred.Size = new Size(93, 23);
            btnRemovePreferred.TabIndex = 2;
            btnRemovePreferred.Text = "Remove City";
            btnRemovePreferred.UseVisualStyleBackColor = false;
            btnRemovePreferred.Click += btnRemovePreferred_Click;
            // 
            // dgvPreferred
            // 
            dgvPreferred.AllowUserToAddRows = false;
            dgvPreferred.AllowUserToDeleteRows = false;
            dgvPreferred.BackgroundColor = Color.FromArgb(32, 43, 59);
            dgvPreferred.BorderStyle = BorderStyle.None;
            dgvPreferred.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPreferred.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreferred.Location = new Point(3, 0);
            dgvPreferred.Name = "dgvPreferred";
            dgvPreferred.ReadOnly = true;
            dgvPreferred.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 43, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPreferred.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 43, 59);
            dgvPreferred.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPreferred.Size = new Size(302, 367);
            dgvPreferred.TabIndex = 0;
            dgvPreferred.CellContentClick += dgvPreferred_CellContentClick;
            // 
            // btnAddPreferred
            // 
            btnAddPreferred.BackColor = Color.FromArgb(1, 149, 255);
            btnAddPreferred.FlatAppearance.BorderSize = 0;
            btnAddPreferred.FlatStyle = FlatStyle.Flat;
            btnAddPreferred.ForeColor = Color.White;
            btnAddPreferred.Location = new Point(420, 146);
            btnAddPreferred.Margin = new Padding(0);
            btnAddPreferred.Name = "btnAddPreferred";
            btnAddPreferred.Size = new Size(40, 29);
            btnAddPreferred.TabIndex = 10;
            btnAddPreferred.Text = ">>";
            btnAddPreferred.UseVisualStyleBackColor = false;
            btnAddPreferred.Click += btnAddPreferred_Click;
            // 
            // MainForm
            // 
            BackColor = Color.FromArgb(11, 19, 30);
            ClientSize = new Size(802, 482);
            Controls.Add(btnAddPreferred);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(lblTemperature);
            Controls.Add(panel2);
            Controls.Add(lblWeatherCondition);
            Controls.Add(lblCityName);
            Controls.Add(pictureBoxWeatherIcon);
            Name = "MainForm";
            Text = "Weather Dashboard";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeatherIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxHour6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHour1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPreferred).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox comboCity;
        private PictureBox pictureBoxWeatherIcon;
        private Label lblCityName;
        private Label lblWeatherCondition;
        private Panel panel2;
        private Label label1;
        private Label lblTemperature;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label7;
        private Label lblWind;
        private Label lblRealFeel;
        private Label lblUV;
        private Label lblChanceRain;
        private Label lblHour1;
        private Label lbltemp6;
        private PictureBox picBoxHour6;
        private Label lblHour6;
        private Label lbltemp5;
        private PictureBox picBoxHour5;
        private Label lblHour5;
        private Label lbltemp4;
        private PictureBox picBoxHour4;
        private Label lblHour4;
        private Label lbltemp3;
        private PictureBox picBoxHour3;
        private Label lblHour3;
        private Label lbltemp2;
        private PictureBox picBoxHour2;
        private Label lblHour2;
        private Label lbltemp1;
        private PictureBox picBoxHour1;
        private DataGridView dgvPreferred;
        private Button btnAddPreferred;
        private Button btnRemovePreferred;
        private Button btnSaveSetting;
    }
}
