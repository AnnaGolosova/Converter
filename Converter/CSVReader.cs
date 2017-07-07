using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using UserClass;

namespace Converter
{
    class CSVReader
    {
        public Form1 currentForm;
        public string fileName;
        private FileStream stream;
        private StreamReader reader;

        public CSVReader(Form1 form, string name)
        {
            fileName = name;
            currentForm = form;
        }

        public delegate void IncBarInvoke();
        public delegate void SetBarInvoke(int count);
        public delegate void SetLabelInvoke(string text);

        public void ReadingFromFile()
        {
            try
            {
                SetLabelInvoke setLabelInvoke = currentForm.SetWaitLabelValue;
                currentForm.WaitLabel.BeginInvoke(setLabelInvoke, "Открытие файла ...");
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream, Encoding.GetEncoding(1251));
                string curLine;
                string[] fields;
                int lineNumber = 1;
                int linesCount = System.IO.File.ReadAllLines(fileName).Length;
                SetBarInvoke setBarInvoke = currentForm.SetBarSettings;
                currentForm.OpeningBar.BeginInvoke(setBarInvoke, linesCount);

                UserContext db = new UserContext();
                User user = new User();
                while (!reader.EndOfStream)
                {
                    curLine = reader.ReadLine();
                    MessageBox.Show(curLine);
                    IncBarInvoke incBarInvoke = currentForm.IncOpeningBarValue;
                    currentForm.OpeningBar.Invoke(new Action(() => { currentForm.OpeningBar.Value++; }));
                    fields = curLine.Split(';');
                    try
                    {
                        DateTime.Parse(fields[0]);
                        user.SetFields(DateTime.Parse(fields[0]), fields[1], fields[2], fields[3], fields[4], fields[5]);
                        db.Users.Add(user);
                        db.SaveChanges();
                        lineNumber++;
                    }
                    catch(FormatException)
                    {
                        if (MessageBox.Show(fields[0]+"\nНеверная дата в " + lineNumber + " строке. Загрузка будет остановлена. Сохранить загруженные ранее данные?",
                                        "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            db.SaveChanges();
                        }
                        incBarInvoke = currentForm.StopThread;
                        currentForm.BeginInvoke(incBarInvoke);
                    }
                }
                db.SaveChanges();
                setLabelInvoke = currentForm.SetWaitLabelValue;
                currentForm.WaitLabel.BeginInvoke(setLabelInvoke, "Файл успешно загружен!");

                reader.Close();
                stream.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Файл '" + fileName + "' не найден. Проверьте существование файла.", "Ошибка", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show("Выполнено принудительное завершение работы потока.", "Предупреждение", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка. " + ex.Message, "Ошибка", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                IncBarInvoke incBarInvoke = currentForm.StopThread;
                currentForm.BeginInvoke(incBarInvoke);
            }
        }
    }
}
