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
            OpeningBar.Value = 0;
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
            UserContext context = new UserContext();
            var firstNames = context.Users.Select(x => x.firstName).Distinct().ToArray();
            foreach (String u in firstNames)
            {
                FirstNamesCB.Items.Add(u);
            }
            var lastNames = context.Users.Select(x => x.lastName).Distinct().ToArray();
            foreach (String u in lastNames)
            {
                LastNamesCB.Items.Add(u);
            }
            var surNames = context.Users.Select(x => x.surName).Distinct().ToArray();
            foreach (String u in surNames)
            {
                SurNamesCB.Items.Add(u);
            }
            var cities = context.Users.Select(x => x.city).Distinct().ToArray();
            foreach (String u in cities)
            {
                CitiesCB.Items.Add(u);
            }
            var countries = context.Users.Select(x => x.country).Distinct().ToArray();
            foreach (String u in countries)
            {
                CountriesCB.Items.Add(u);
            }
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
                    Application.Exit();
                }
            }
            else
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
            try
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
            catch (DataException ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. "+ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<User> GetResult()
        {
            UserContext context = new UserContext();
            var result =
                from u in context.Users
                select u;
            // Needs optimization
            if (FirstNamesCB.Text != "")
            {
                result =
                    from u in result
                    where u.firstName == FirstNamesCB.Text
                    select u;
            }
            if (LastNamesCB.Text != "")
            {
                result =
                    from u in result
                    where u.lastName == LastNamesCB.Text
                    select u;
            }
            if (SurNamesCB.Text != "")
            {
                result =
                    from u in result
                    where u.surName == SurNamesCB.Text
                    select u;
            }
            if (CitiesCB.Text != "")
            {
                result =
                    from u in result
                    where u.city == CitiesCB.Text
                    select u;
            }
            if (CountriesCB.Text != "")
            {
                result =
                    from u in result
                    where u.country == CountriesCB.Text
                    select u;
            }
            // Учитывает время, а не должно
            if (!UseDateTime.Checked)
            {
                result =
                    from u in result
                    where u.date >= FromDate.Value && u.date <= ToDate.Value
                    select u;
            }
            return result.ToList();
        }

        private void XMLSaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WaitLabel.Visible = true;
                WaitLabel.Text = "Сохранение XML файла ...";
                XMLWriter writer = new XMLWriter(saveFileDialog1.FileName);
                bool[] selectedFields = new bool[6];
                for (int i = 0; i < 6; i++)
                    selectedFields[i] = SelectedFields.GetSelected(i);
                writer.selectedItems = selectedFields;
                writer.result = GetResult();
                if (writer.result.Count == 0)
                    MessageBox.Show("Внимание! Нет записей, соответствующих выбранным Вами настройкам. Возможная проблема: не выбрано ни одно поле для экспорта.",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread xmlThread = new Thread(writer.WriteXML);
                xmlThread.Start();
                WaitLabel.Text = "XML файл успешно сохранен!";
            }
        }

        private void ExcelSaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (workThread.IsAlive)
                    MessageBox.Show("Внимание! Дождитесь завершения предидущего процесса!", "Предыдущий процесс завершен не полностью!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ExcelWriter writer = new ExcelWriter(saveFileDialog1.FileName);
                    bool[] selectedFields = new bool[6];
                    for (int it = 0; it < 6; it++)
                        selectedFields[it] = SelectedFields.GetSelected(it);
                    writer.selectedFields = selectedFields;
                    writer.currentForm = this;
                    writer.result = GetResult();
                    if (writer.result.Count == 0)
                        MessageBox.Show("Внимание! Нет записей, соответствующих выбранным Вами настройкам. Возможная проблема: не выбрано ни одно поле для экспорта.",
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    workThread = new Thread(writer.WriteExcel);
                    workThread.Start();
                }
            }
        }
    }
}
