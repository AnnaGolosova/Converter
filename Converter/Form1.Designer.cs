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
            this.ExcelButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.HelloPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExcelPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.XMLPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenPage = new System.Windows.Forms.TabPage();
            this.LoadButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DBPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.OpeningBar = new System.Windows.Forms.ProgressBar();
            this.WaitLabel = new System.Windows.Forms.Label();
            this.ShowRecordsButton = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.HelloPage.SuspendLayout();
            this.ExcelPage.SuspendLayout();
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
            this.XMLButton.Text = "Экспорт в XML";
            this.XMLButton.UseVisualStyleBackColor = false;
            this.XMLButton.Click += new System.EventHandler(this.XMLButton_Click);
            // 
            // ExcelButton
            // 
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(176)))));
            this.ExcelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.ExcelButton.FlatAppearance.BorderSize = 3;
            this.ExcelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.ExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelButton.Location = new System.Drawing.Point(12, 79);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(150, 29);
            this.ExcelButton.TabIndex = 4;
            this.ExcelButton.Text = "Экспорт в Excel";
            this.ExcelButton.UseVisualStyleBackColor = false;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(176)))));
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.OpenButton.FlatAppearance.BorderSize = 3;
            this.OpenButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(12, 9);
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
            this.Tabs.Controls.Add(this.ExcelPage);
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
            // ExcelPage
            // 
            this.ExcelPage.Controls.Add(this.label3);
            this.ExcelPage.Location = new System.Drawing.Point(4, 14);
            this.ExcelPage.Name = "ExcelPage";
            this.ExcelPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExcelPage.Size = new System.Drawing.Size(672, 202);
            this.ExcelPage.TabIndex = 1;
            this.ExcelPage.Text = "tabPage2";
            this.ExcelPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сохранение информации в формате Excel";
            // 
            // XMLPage
            // 
            this.XMLPage.Controls.Add(this.label6);
            this.XMLPage.Location = new System.Drawing.Point(4, 14);
            this.XMLPage.Name = "XMLPage";
            this.XMLPage.Size = new System.Drawing.Size(672, 202);
            this.XMLPage.TabIndex = 2;
            this.XMLPage.Text = "tabPage1";
            this.XMLPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Сохранение информации в формате XML";
            // 
            // OpenPage
            // 
            this.OpenPage.Controls.Add(this.LoadButton);
            this.OpenPage.Controls.Add(this.checkBox1);
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
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(187, 101);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(238, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Добавить к существующим данным";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(176)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.WaitLabel.Location = new System.Drawing.Point(12, 238);
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
            this.ShowRecordsButton.Location = new System.Drawing.Point(12, 44);
            this.ShowRecordsButton.Name = "ShowRecordsButton";
            this.ShowRecordsButton.Size = new System.Drawing.Size(150, 29);
            this.ShowRecordsButton.TabIndex = 14;
            this.ShowRecordsButton.Text = "Просмотр базы";
            this.ShowRecordsButton.UseVisualStyleBackColor = false;
            this.ShowRecordsButton.Click += new System.EventHandler(this.ShowRecordsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 282);
            this.Controls.Add(this.ShowRecordsButton);
            this.Controls.Add(this.WaitLabel);
            this.Controls.Add(this.OpeningBar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XMLButton);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.OpenButton);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать!";
            this.Tabs.ResumeLayout(false);
            this.HelloPage.ResumeLayout(false);
            this.HelloPage.PerformLayout();
            this.ExcelPage.ResumeLayout(false);
            this.ExcelPage.PerformLayout();
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
        private System.Windows.Forms.Button ExcelButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage HelloPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ExcelPage;
        private System.Windows.Forms.TabPage XMLPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage OpenPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ProgressBar OpeningBar;
        public System.Windows.Forms.Label WaitLabel;
        private System.Windows.Forms.TabPage DBPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowRecordsButton;
    }
}

