namespace Converter
{
    partial class Form1
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
            this.XMLButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.HelloPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XMLPage = new System.Windows.Forms.TabPage();
            this.XMLSaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenPage = new System.Windows.Forms.TabPage();
            this.AddNewRadio = new System.Windows.Forms.RadioButton();
            this.AddToExictingRadio = new System.Windows.Forms.RadioButton();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DBPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpeningBar = new System.Windows.Forms.ProgressBar();
            this.WaitLabel = new System.Windows.Forms.Label();
            this.ShowRecordsButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FirstNamesCB = new System.Windows.Forms.ComboBox();
            this.LastNamesCB = new System.Windows.Forms.ComboBox();
            this.SurNamesCB = new System.Windows.Forms.ComboBox();
            this.CitiesCB = new System.Windows.Forms.ComboBox();
            this.CountriesCB = new System.Windows.Forms.ComboBox();
            this.SelectedFields = new System.Windows.Forms.ListBox();
            this.ExcelSaveButton = new System.Windows.Forms.Button();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.UseDateTime = new System.Windows.Forms.CheckBox();
            this.Tabs.SuspendLayout();
            this.HelloPage.SuspendLayout();
            this.XMLPage.SuspendLayout();
            this.OpenPage.SuspendLayout();
            this.DBPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // XMLButton
            // 
            this.XMLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(176)))));
            this.XMLButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.XMLButton.FlatAppearance.BorderSize = 3;
            this.XMLButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.XMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XMLButton.Location = new System.Drawing.Point(12, 114);
            this.XMLButton.Name = "XMLButton";
            this.XMLButton.Size = new System.Drawing.Size(150, 29);
            this.XMLButton.TabIndex = 5;
            this.XMLButton.Text = "Экспорт данных";
            this.XMLButton.UseVisualStyleBackColor = false;
            this.XMLButton.Click += new System.EventHandler(this.XMLButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(176)))));
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.OpenButton.FlatAppearance.BorderSize = 3;
            this.OpenButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(12, 44);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(150, 29);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Открыть .csv файл";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // Tabs
            // 
            this.Tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tabs.Controls.Add(this.HelloPage);
            this.Tabs.Controls.Add(this.XMLPage);
            this.Tabs.Controls.Add(this.OpenPage);
            this.Tabs.Controls.Add(this.DBPage);
            this.Tabs.ItemSize = new System.Drawing.Size(10, 10);
            this.Tabs.Location = new System.Drawing.Point(168, 5);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(680, 220);
            this.Tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabs.TabIndex = 10;
            this.Tabs.TabStop = false;
            // 
            // HelloPage
            // 
            this.HelloPage.Controls.Add(this.textBox1);
            this.HelloPage.Controls.Add(this.label1);
            this.HelloPage.Location = new System.Drawing.Point(4, 14);
            this.HelloPage.Name = "HelloPage";
            this.HelloPage.Padding = new System.Windows.Forms.Padding(3);
            this.HelloPage.Size = new System.Drawing.Size(672, 202);
            this.HelloPage.TabIndex = 0;
            this.HelloPage.Text = "tabPage1";
            this.HelloPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(471, 91);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Приложение дает Вам возможность гибкой работы с данными о Ваших знакомых, родных " +
    "и близких.\r\n\r\nЕсть возможность загрузки .csv файлов с данными, сохранение их в ф" +
    "ормате Excel и XML.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добро пожаловать! ";
            // 
            // XMLPage
            // 
            this.XMLPage.Controls.Add(this.UseDateTime);
            this.XMLPage.Controls.Add(this.FromDate);
            this.XMLPage.Controls.Add(this.ExcelSaveButton);
            this.XMLPage.Controls.Add(this.SelectedFields);
            this.XMLPage.Controls.Add(this.CountriesCB);
            this.XMLPage.Controls.Add(this.CitiesCB);
            this.XMLPage.Controls.Add(this.SurNamesCB);
            this.XMLPage.Controls.Add(this.LastNamesCB);
            this.XMLPage.Controls.Add(this.FirstNamesCB);
            this.XMLPage.Controls.Add(this.label15);
            this.XMLPage.Controls.Add(this.label14);
            this.XMLPage.Controls.Add(this.label13);
            this.XMLPage.Controls.Add(this.label12);
            this.XMLPage.Controls.Add(this.label11);
            this.XMLPage.Controls.Add(this.label10);
            this.XMLPage.Controls.Add(this.label9);
            this.XMLPage.Controls.Add(this.label8);
            this.XMLPage.Controls.Add(this.ToDate);
            this.XMLPage.Controls.Add(this.label7);
            this.XMLPage.Controls.Add(this.XMLSaveButton);
            this.XMLPage.Controls.Add(this.label6);
            this.XMLPage.Location = new System.Drawing.Point(4, 14);
            this.XMLPage.Name = "XMLPage";
            this.XMLPage.Size = new System.Drawing.Size(672, 202);
            this.XMLPage.TabIndex = 2;
            this.XMLPage.Text = "tabPage1";
            this.XMLPage.UseVisualStyleBackColor = true;
            // 
            // XMLSaveButton
            // 
            this.XMLSaveButton.Location = new System.Drawing.Point(7, 150);
            this.XMLSaveButton.Name = "XMLSaveButton";
            this.XMLSaveButton.Size = new System.Drawing.Size(171, 23);
            this.XMLSaveButton.TabIndex = 1;
            this.XMLSaveButton.Text = "Сохранить в XML";
            this.XMLSaveButton.UseVisualStyleBackColor = true;
            this.XMLSaveButton.Click += new System.EventHandler(this.XMLSaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Сохранение информации";
            // 
            // OpenPage
            // 
            this.OpenPage.Controls.Add(this.AddNewRadio);
            this.OpenPage.Controls.Add(this.AddToExictingRadio);
            this.OpenPage.Controls.Add(this.LoadButton);
            this.OpenPage.Controls.Add(this.FileNameBox);
            this.OpenPage.Controls.Add(this.ViewButton);
            this.OpenPage.Controls.Add(this.label4);
            this.OpenPage.Controls.Add(this.label5);
            this.OpenPage.Location = new System.Drawing.Point(4, 14);
            this.OpenPage.Name = "OpenPage";
            this.OpenPage.Size = new System.Drawing.Size(672, 202);
            this.OpenPage.TabIndex = 3;
            this.OpenPage.Text = "tabPage1";
            this.OpenPage.UseVisualStyleBackColor = true;
            // 
            // AddNewRadio
            // 
            this.AddNewRadio.AutoSize = true;
            this.AddNewRadio.Location = new System.Drawing.Point(7, 83);
            this.AddNewRadio.Name = "AddNewRadio";
            this.AddNewRadio.Size = new System.Drawing.Size(169, 20);
            this.AddNewRadio.TabIndex = 8;
            this.AddNewRadio.Text = "Записать новые данные";
            this.AddNewRadio.UseVisualStyleBackColor = true;
            // 
            // AddToExictingRadio
            // 
            this.AddToExictingRadio.AutoSize = true;
            this.AddToExictingRadio.Checked = true;
            this.AddToExictingRadio.Location = new System.Drawing.Point(7, 57);
            this.AddToExictingRadio.Name = "AddToExictingRadio";
            this.AddToExictingRadio.Size = new System.Drawing.Size(237, 20);
            this.AddToExictingRadio.TabIndex = 7;
            this.AddToExictingRadio.TabStop = true;
            this.AddToExictingRadio.Text = "Добавить к существующим данным";
            this.AddToExictingRadio.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(273, 101);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(45, 28);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.ReadOnly = true;
            this.FileNameBox.Size = new System.Drawing.Size(362, 23);
            this.FileNameBox.TabIndex = 3;
            this.FileNameBox.Text = "Выберите файл...";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(413, 28);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "Обзор";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Путь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Загрузка нового файла ";
            // 
            // DBPage
            // 
            this.DBPage.Controls.Add(this.dataGridView1);
            this.DBPage.Location = new System.Drawing.Point(4, 14);
            this.DBPage.Name = "DBPage";
            this.DBPage.Size = new System.Drawing.Size(672, 202);
            this.DBPage.TabIndex = 4;
            this.DBPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(665, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(176)))));
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.ExitButton.FlatAppearance.BorderSize = 3;
            this.ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(12, 149);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 29);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpeningBar
            // 
            this.OpeningBar.Location = new System.Drawing.Point(9, 231);
            this.OpeningBar.Name = "OpeningBar";
            this.OpeningBar.Size = new System.Drawing.Size(651, 23);
            this.OpeningBar.TabIndex = 12;
            this.OpeningBar.Visible = false;
            // 
            // WaitLabel
            // 
            this.WaitLabel.AutoSize = true;
            this.WaitLabel.Location = new System.Drawing.Point(12, 235);
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(153, 16);
            this.WaitLabel.TabIndex = 13;
            this.WaitLabel.Text = "Идет открытие файла ...";
            this.WaitLabel.Visible = false;
            // 
            // ShowRecordsButton
            // 
            this.ShowRecordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(176)))));
            this.ShowRecordsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.ShowRecordsButton.FlatAppearance.BorderSize = 3;
            this.ShowRecordsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.ShowRecordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRecordsButton.Location = new System.Drawing.Point(15, 79);
            this.ShowRecordsButton.Name = "ShowRecordsButton";
            this.ShowRecordsButton.Size = new System.Drawing.Size(150, 29);
            this.ShowRecordsButton.TabIndex = 14;
            this.ShowRecordsButton.Text = "Просмотр базы";
            this.ShowRecordsButton.UseVisualStyleBackColor = false;
            this.ShowRecordsButton.Click += new System.EventHandler(this.ShowRecordsButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Выберите поля для отчета:";
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "d.MM.yyyy HH:m";
            this.ToDate.Location = new System.Drawing.Point(441, 45);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(157, 23);
            this.ToDate.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "С";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "По";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Выберите дополнительные настройки экспорта:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Имя";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Фамилия";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Отчество";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(487, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Город";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Страна";
            // 
            // FirstNamesCB
            // 
            this.FirstNamesCB.FormattingEnabled = true;
            this.FirstNamesCB.Location = new System.Drawing.Point(292, 104);
            this.FirstNamesCB.Name = "FirstNamesCB";
            this.FirstNamesCB.Size = new System.Drawing.Size(121, 24);
            this.FirstNamesCB.TabIndex = 18;
            // 
            // LastNamesCB
            // 
            this.LastNamesCB.FormattingEnabled = true;
            this.LastNamesCB.Location = new System.Drawing.Point(292, 134);
            this.LastNamesCB.Name = "LastNamesCB";
            this.LastNamesCB.Size = new System.Drawing.Size(121, 24);
            this.LastNamesCB.TabIndex = 19;
            // 
            // SurNamesCB
            // 
            this.SurNamesCB.FormattingEnabled = true;
            this.SurNamesCB.Location = new System.Drawing.Point(292, 164);
            this.SurNamesCB.Name = "SurNamesCB";
            this.SurNamesCB.Size = new System.Drawing.Size(121, 24);
            this.SurNamesCB.TabIndex = 20;
            // 
            // CitiesCB
            // 
            this.CitiesCB.FormattingEnabled = true;
            this.CitiesCB.Location = new System.Drawing.Point(543, 134);
            this.CitiesCB.Name = "CitiesCB";
            this.CitiesCB.Size = new System.Drawing.Size(121, 24);
            this.CitiesCB.TabIndex = 21;
            // 
            // CountriesCB
            // 
            this.CountriesCB.FormattingEnabled = true;
            this.CountriesCB.Location = new System.Drawing.Point(543, 104);
            this.CountriesCB.Name = "CountriesCB";
            this.CountriesCB.Size = new System.Drawing.Size(121, 24);
            this.CountriesCB.TabIndex = 22;
            // 
            // SelectedFields
            // 
            this.SelectedFields.FormattingEnabled = true;
            this.SelectedFields.ItemHeight = 16;
            this.SelectedFields.Items.AddRange(new object[] {
            "Дата",
            "Имя ",
            "Фамилия",
            "Отчество",
            "Город",
            "Страна"});
            this.SelectedFields.Location = new System.Drawing.Point(7, 46);
            this.SelectedFields.Name = "SelectedFields";
            this.SelectedFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SelectedFields.Size = new System.Drawing.Size(120, 100);
            this.SelectedFields.TabIndex = 23;
            // 
            // ExcelSaveButton
            // 
            this.ExcelSaveButton.Location = new System.Drawing.Point(7, 177);
            this.ExcelSaveButton.Name = "ExcelSaveButton";
            this.ExcelSaveButton.Size = new System.Drawing.Size(171, 23);
            this.ExcelSaveButton.TabIndex = 24;
            this.ExcelSaveButton.Text = "Сохранить в Excel";
            this.ExcelSaveButton.UseVisualStyleBackColor = true;
            this.ExcelSaveButton.Click += new System.EventHandler(this.ExcelSaveButton_Click);
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd.MM.yyyy HH:m";
            this.FromDate.Location = new System.Drawing.Point(221, 45);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(156, 23);
            this.FromDate.TabIndex = 25;
            // 
            // UseDateTime
            // 
            this.UseDateTime.AutoSize = true;
            this.UseDateTime.Location = new System.Drawing.Point(202, 74);
            this.UseDateTime.Name = "UseDateTime";
            this.UseDateTime.Size = new System.Drawing.Size(138, 20);
            this.UseDateTime.TabIndex = 26;
            this.UseDateTime.Text = "Не учитывать дату";
            this.UseDateTime.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 259);
            this.Controls.Add(this.ShowRecordsButton);
            this.Controls.Add(this.WaitLabel);
            this.Controls.Add(this.OpeningBar);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XMLButton);
            this.Controls.Add(this.OpenButton);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать!";
            this.Tabs.ResumeLayout(false);
            this.HelloPage.ResumeLayout(false);
            this.HelloPage.PerformLayout();
            this.XMLPage.ResumeLayout(false);
            this.XMLPage.PerformLayout();
            this.OpenPage.ResumeLayout(false);
            this.OpenPage.PerformLayout();
            this.DBPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XMLButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage HelloPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage XMLPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage OpenPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.ProgressBar OpeningBar;
        public System.Windows.Forms.Label WaitLabel;
        private System.Windows.Forms.TabPage DBPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowRecordsButton;
        private System.Windows.Forms.RadioButton AddNewRadio;
        private System.Windows.Forms.RadioButton AddToExictingRadio;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button XMLSaveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.ComboBox CountriesCB;
        private System.Windows.Forms.ComboBox CitiesCB;
        private System.Windows.Forms.ComboBox SurNamesCB;
        private System.Windows.Forms.ComboBox LastNamesCB;
        private System.Windows.Forms.ComboBox FirstNamesCB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox SelectedFields;
        private System.Windows.Forms.Button ExcelSaveButton;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.CheckBox UseDateTime;
    }
}

