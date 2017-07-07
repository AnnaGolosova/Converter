using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UserClass;
using System.Threading;


namespace Converter
{
    public partial class Form1 : Form
    {
        private CSVReader reader;
        private Thread openFileThread;
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
            try
            {
                reader = new CSVReader(this, FileNameBox.Text);
                openFileThread = new Thread(reader.ReadingFromFile);
                openFileThread.IsBackground = true;
                //openFileThread.SetApartmentState(ApartmentState.STA);
                openFileThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("выамы");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileThread != null && openFileThread.IsAlive)
            {
                if (MessageBox.Show("Внимание! Идет загрузка файла. Вы уверены, что хотите прервать загрузку?", 
                                    "Завершение загрузки файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    openFileThread.Abort();
                }
            }
            Application.Exit();
        }

        public void StopThread()
        {
            WaitLabel.Visible = false;
            OpeningBar.Visible = false;
            openFileThread.Abort();
        }

        private void ShowRecordsButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = "Просмотр содержимого базы данных";
            Tabs.SelectedTab = Tabs.TabPages["DBPage"];
            
        }
    }
}
