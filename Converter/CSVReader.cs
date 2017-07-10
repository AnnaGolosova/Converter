using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Converter
{
    class CSVReader
    {
        public Form1 currentForm;
        public int workState; 
        public string fileName;
        private FileStream stream;
        private StreamReader reader;

        public CSVReader(Form1 form, string name, int state)
        {
            fileName = name;
            currentForm = form;
            workState = state;
        }

        public delegate void IncBarInvoke();
        public delegate void SetBarInvoke(int count);
        public delegate void SetLabelInvoke(string text);

        public void ReadingFromFile()
        {
            try
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
                    FileInfo file = new FileInfo(fileName);
                    int linesCount = (int)(file.Length/68.5);
                    SetBarInvoke setBarInvoke = currentForm.SetBarSettings;
                    currentForm.OpeningBar.BeginInvoke(setBarInvoke, linesCount);

                    UserContext db = new UserContext();
                    User user = new User();
                    if (workState == 2)
                        db.Users.RemoveRange((from p in db.Users select p));
                    while (!reader.EndOfStream)
                    {
                        IncBarInvoke incBarInvoke = currentForm.IncOpeningBarValue;
                        curLine = reader.ReadLine();
                        fields = curLine.Split(';');
                        try
                        {
                            DateTime.Parse(fields[0]);
                            user.SetFields(DateTime.Parse(fields[0]), fields[1], fields[2], fields[3], fields[4], fields[5]);
                            db.Users.Add(user);
                            db.SaveChanges();
                            lineNumber++;
                        }
                        catch (FormatException)
                        {
                            if (MessageBox.Show(fields[0] + "\nНеверная дата в " + lineNumber + " строке. Загрузка будет остановлена. Сохранить загруженные ранее данные?",
                                            "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                db.SaveChanges();
                            }
                            incBarInvoke = currentForm.StopThread;
                            currentForm.BeginInvoke(incBarInvoke);
                        }
                        currentForm.OpeningBar.Invoke(new Action(() => { currentForm.OpeningBar.Value++; }));
                    }
                    db.SaveChanges();
                    setLabelInvoke = currentForm.SetWaitLabelValue;
                    currentForm.WaitLabel.BeginInvoke(setLabelInvoke, "Файл успешно загружен!");

                    reader.Close();
                    stream.Close();
                }
                catch (FileNotFoundException)
                {
                    throw (new Exception("Файл '" + fileName + "' не найден. Проверьте существование файла."));
                }
                catch (ThreadAbortException)
                {
                    throw (new Exception("Выполнено принудительное завершение работы потока."));
                }
                catch (Exception ex)
                {
                    throw (new Exception("Возникла ошибка. " + ex.Message +" " + ex.InnerException));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                IncBarInvoke incBarInvoke = currentForm.StopThread;
                currentForm.BeginInvoke(incBarInvoke);
            }
        }
    }
}
