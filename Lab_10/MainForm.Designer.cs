namespace Lab_10
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newTicket = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeBox = new MetroFramework.Controls.MetroComboBox();
            this.tripBox = new MetroFramework.Controls.MetroComboBox();
            this.FinishBox = new MetroFramework.Controls.MetroComboBox();
            this.AutoBusbox = new MetroFramework.Controls.MetroTextBox();
            this.TimeBox = new MetroFramework.Controls.MetroTextBox();
            this.Driverbox = new MetroFramework.Controls.MetroTextBox();
            this.FIObox = new MetroFramework.Controls.MetroTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.DateBox = new MetroFramework.Controls.MetroComboBox();
            this.PriceBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(102, 405);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(111, 36);
            this.prevButton.TabIndex = 17;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(813, 405);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(116, 36);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(621, 405);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 36);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newTicket
            // 
            this.newTicket.Location = new System.Drawing.Point(275, 405);
            this.newTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newTicket.Name = "newTicket";
            this.newTicket.Size = new System.Drawing.Size(117, 36);
            this.newTicket.TabIndex = 21;
            this.newTicket.Text = "Новый билет";
            this.newTicket.UseVisualStyleBackColor = true;
            this.newTicket.Click += new System.EventHandler(this.newTicket_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(559, 65);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(413, 304);
            this.metroGrid1.TabIndex = 29;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Населенный пункт";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 182;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Время прибытия";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Время отправления";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // placeBox
            // 
            this.placeBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.placeBox.FormattingEnabled = true;
            this.placeBox.ItemHeight = 24;
            this.placeBox.Location = new System.Drawing.Point(196, 177);
            this.placeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(346, 30);
            this.placeBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.placeBox.TabIndex = 30;
            this.placeBox.UseSelectable = true;
            this.placeBox.SelectedIndexChanged += new System.EventHandler(this.placeBox_SelectedIndexChanged);
            // 
            // tripBox
            // 
            this.tripBox.FormattingEnabled = true;
            this.tripBox.ItemHeight = 24;
            this.tripBox.Location = new System.Drawing.Point(196, 117);
            this.tripBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tripBox.Name = "tripBox";
            this.tripBox.Size = new System.Drawing.Size(346, 30);
            this.tripBox.TabIndex = 31;
            this.tripBox.UseSelectable = true;
            this.tripBox.SelectedIndexChanged += new System.EventHandler(this.tripBox_SelectedIndexChanged);
            // 
            // FinishBox
            // 
            this.FinishBox.FormattingEnabled = true;
            this.FinishBox.ItemHeight = 24;
            this.FinishBox.Location = new System.Drawing.Point(196, 235);
            this.FinishBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FinishBox.Name = "FinishBox";
            this.FinishBox.Size = new System.Drawing.Size(346, 30);
            this.FinishBox.TabIndex = 32;
            this.FinishBox.UseSelectable = true;
            this.FinishBox.SelectedIndexChanged += new System.EventHandler(this.FinishBox_SelectedIndexChanged);
            // 
            // AutoBusbox
            // 
            // 
            // 
            // 
            this.AutoBusbox.CustomButton.Image = null;
            this.AutoBusbox.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.AutoBusbox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AutoBusbox.CustomButton.Name = "";
            this.AutoBusbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AutoBusbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutoBusbox.CustomButton.TabIndex = 1;
            this.AutoBusbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutoBusbox.CustomButton.UseSelectable = true;
            this.AutoBusbox.CustomButton.Visible = false;
            this.AutoBusbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AutoBusbox.Lines = new string[0];
            this.AutoBusbox.Location = new System.Drawing.Point(196, 295);
            this.AutoBusbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AutoBusbox.MaxLength = 32767;
            this.AutoBusbox.Name = "AutoBusbox";
            this.AutoBusbox.PasswordChar = '\0';
            this.AutoBusbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutoBusbox.SelectedText = "";
            this.AutoBusbox.SelectionLength = 0;
            this.AutoBusbox.SelectionStart = 0;
            this.AutoBusbox.ShortcutsEnabled = true;
            this.AutoBusbox.Size = new System.Drawing.Size(346, 23);
            this.AutoBusbox.TabIndex = 33;
            this.AutoBusbox.UseSelectable = true;
            this.AutoBusbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutoBusbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TimeBox
            // 
            // 
            // 
            // 
            this.TimeBox.CustomButton.Image = null;
            this.TimeBox.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.TimeBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimeBox.CustomButton.Name = "";
            this.TimeBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TimeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TimeBox.CustomButton.TabIndex = 1;
            this.TimeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TimeBox.CustomButton.UseSelectable = true;
            this.TimeBox.CustomButton.Visible = false;
            this.TimeBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TimeBox.Lines = new string[0];
            this.TimeBox.Location = new System.Drawing.Point(559, 295);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimeBox.MaxLength = 32767;
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.PasswordChar = '\0';
            this.TimeBox.ReadOnly = true;
            this.TimeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TimeBox.SelectedText = "";
            this.TimeBox.SelectionLength = 0;
            this.TimeBox.SelectionStart = 0;
            this.TimeBox.ShortcutsEnabled = true;
            this.TimeBox.Size = new System.Drawing.Size(346, 23);
            this.TimeBox.TabIndex = 35;
            this.TimeBox.UseSelectable = true;
            this.TimeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TimeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Driverbox
            // 
            // 
            // 
            // 
            this.Driverbox.CustomButton.Image = null;
            this.Driverbox.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.Driverbox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Driverbox.CustomButton.Name = "";
            this.Driverbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Driverbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Driverbox.CustomButton.TabIndex = 1;
            this.Driverbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Driverbox.CustomButton.UseSelectable = true;
            this.Driverbox.CustomButton.Visible = false;
            this.Driverbox.Lines = new string[0];
            this.Driverbox.Location = new System.Drawing.Point(196, 354);
            this.Driverbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Driverbox.MaxLength = 32767;
            this.Driverbox.Name = "Driverbox";
            this.Driverbox.PasswordChar = '\0';
            this.Driverbox.ReadOnly = true;
            this.Driverbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Driverbox.SelectedText = "";
            this.Driverbox.SelectionLength = 0;
            this.Driverbox.SelectionStart = 0;
            this.Driverbox.ShortcutsEnabled = true;
            this.Driverbox.Size = new System.Drawing.Size(346, 23);
            this.Driverbox.TabIndex = 36;
            this.Driverbox.UseSelectable = true;
            this.Driverbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Driverbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FIObox
            // 
            // 
            // 
            // 
            this.FIObox.CustomButton.Image = null;
            this.FIObox.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.FIObox.CustomButton.Name = "";
            this.FIObox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FIObox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FIObox.CustomButton.TabIndex = 1;
            this.FIObox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FIObox.CustomButton.UseSelectable = true;
            this.FIObox.CustomButton.Visible = false;
            this.FIObox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FIObox.Lines = new string[0];
            this.FIObox.Location = new System.Drawing.Point(196, 65);
            this.FIObox.MaxLength = 32767;
            this.FIObox.Name = "FIObox";
            this.FIObox.PasswordChar = '\0';
            this.FIObox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FIObox.SelectedText = "";
            this.FIObox.SelectionLength = 0;
            this.FIObox.SelectionStart = 0;
            this.FIObox.ShortcutsEnabled = true;
            this.FIObox.Size = new System.Drawing.Size(346, 23);
            this.FIObox.TabIndex = 37;
            this.FIObox.UseSelectable = true;
            this.FIObox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FIObox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(440, 405);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 36);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(713, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 20);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "РАСПИСАНИЕ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 20);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "ФИО покупателя";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 177);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 20);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Место посадки";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(47, 235);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(127, 20);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Пункт назначения";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 117);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 20);
            this.metroLabel5.TabIndex = 43;
            this.metroLabel5.Text = "Рейс";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(47, 295);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 20);
            this.metroLabel6.TabIndex = 44;
            this.metroLabel6.Text = "Номер автобуса";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(933, 240);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 20);
            this.metroLabel7.TabIndex = 45;
            this.metroLabel7.Text = "Дата";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(922, 295);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 20);
            this.metroLabel8.TabIndex = 46;
            this.metroLabel8.Text = "Время";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(47, 357);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(106, 20);
            this.metroLabel9.TabIndex = 47;
            this.metroLabel9.Text = "ФИО водителя";
            // 
            // DateBox
            // 
            this.DateBox.FormattingEnabled = true;
            this.DateBox.ItemHeight = 24;
            this.DateBox.Location = new System.Drawing.Point(559, 235);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(346, 30);
            this.DateBox.TabIndex = 48;
            this.DateBox.UseSelectable = true;
            // 
            // PriceBox
            // 
            // 
            // 
            // 
            this.PriceBox.CustomButton.Image = null;
            this.PriceBox.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.PriceBox.CustomButton.Name = "";
            this.PriceBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PriceBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceBox.CustomButton.TabIndex = 1;
            this.PriceBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriceBox.CustomButton.UseSelectable = true;
            this.PriceBox.CustomButton.Visible = false;
            this.PriceBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PriceBox.Lines = new string[0];
            this.PriceBox.Location = new System.Drawing.Point(559, 354);
            this.PriceBox.MaxLength = 32767;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.PasswordChar = '\0';
            this.PriceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceBox.SelectedText = "";
            this.PriceBox.SelectionLength = 0;
            this.PriceBox.SelectionStart = 0;
            this.PriceBox.ShortcutsEnabled = true;
            this.PriceBox.Size = new System.Drawing.Size(346, 23);
            this.PriceBox.TabIndex = 49;
            this.PriceBox.UseSelectable = true;
            this.PriceBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(929, 357);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(43, 20);
            this.metroLabel10.TabIndex = 50;
            this.metroLabel10.Text = "Цена";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 454);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.FIObox);
            this.Controls.Add(this.Driverbox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.AutoBusbox);
            this.Controls.Add(this.FinishBox);
            this.Controls.Add(this.tripBox);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.newTicket);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 25);
            this.Text = "Билет";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newTicket;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroComboBox placeBox;
        private MetroFramework.Controls.MetroComboBox tripBox;
        private MetroFramework.Controls.MetroComboBox FinishBox;
        private MetroFramework.Controls.MetroTextBox AutoBusbox;
        private MetroFramework.Controls.MetroTextBox TimeBox;
        private MetroFramework.Controls.MetroTextBox Driverbox;
        private MetroFramework.Controls.MetroTextBox FIObox;
        private System.Windows.Forms.Button saveButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MetroFramework.Controls.MetroComboBox DateBox;
        private MetroFramework.Controls.MetroTextBox PriceBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}

