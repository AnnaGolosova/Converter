using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;


namespace Converter
{
    public partial class Form1 : Form
    {
        private CSVReader reader;
        private Thread workThread;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetBarSettings(int maxValue)
        {
            WaitLabel.Visible = false;
            OpeningBar.Maximum = maxValue;
            OpeningBar.Visible = true;
        }
        public void IncOpeningBarValue()
        {
            OpeningBar.Value++;
        }

        public void SetWaitLabelValue(string text)
        {
            OpeningBar.Visible = false;
            WaitLabel.Visible = true;
            WaitLabel.Text = text;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = "Открыть .csv файл";
            Tabs.SelectedTab = Tabs.TabPages["OpenPage"];
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = "Экспорт в Excel";
            Tabs.SelectedTab = Tabs.TabPages["ExcelPage"];
        }

        private void XMLButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = "Экспорт в XML";
            Tabs.SelectedTab = Tabs.TabPages["XMLPage"];

            /*
            DataTable table = new DataTable();
            UserContext context = new UserContext();
            List<User> list = context.Users.ToList();
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel.Worksheet activeSheet = excelApp.ActiveSheet;

            activeSheet.Cells[1, 1] = "Hello!";

            activeSheet.SaveAs("File.xls");
            excelApp.Quit();
            */
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileNameBox.Text = openFileDialog1.FileName;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpeningBar.Value = 0;
            reader = new CSVReader(this, FileNameBox.Text, AddToExictingRadio.Checked ? 1 : 2);
            workThread = new Thread(reader.ReadingFromFile)
            {
                IsBackground = true
            };
            workThread.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (workThread != null && workThread.IsAlive)
            {
                if (MessageBox.Show("Внимание! Идет загрузка файла. Вы уверены, что хотите прервать загрузку?", 
                                    "Завершение загрузки файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    workThread.Abort();
                }
            }
            Application.Exit();
        }

        public void StopThread()
        {
            WaitLabel.Visible = false;
            OpeningBar.Visible = false;
            workThread.Abort();
        }

        private void ShowRecordsButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = "Просмотр содержимого базы данных";
            Tabs.SelectedTab = Tabs.TabPages["DBPage"];
            UserContext context = new UserContext();
            var records =
                (from p in context.Users
                 select p
                );
            dataGridView1.DataSource = records.ToList();
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Фамилия";
            dataGridView1.Columns[4].HeaderText = "Отчество";
            dataGridView1.Columns[5].HeaderText = "Город";
            dataGridView1.Columns[6].HeaderText = "Страна";
        }

        private void XMLSaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WaitLabel.Visible = true;
                WaitLabel.Text = "Сохранение XML файла ...";
                    XMLWriter writer = new XMLWriter(saveFileDialog1.FileName);
                Thread xmlThread = new Thread(writer.WriteXML);
                xmlThread.Start();
                WaitLabel.Text = "XML файл успешно сохранен!";
            }
        }
    }
}
