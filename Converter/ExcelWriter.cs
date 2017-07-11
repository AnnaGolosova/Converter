using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Converter
{
    class ExcelWriter
    {
        public bool[] selectedFields;
        public string fileName;
        public List<User> result;
        public Form1 currentForm;

        public ExcelWriter(string name)
        {
            fileName = name;
        }

        public delegate void IncBarInvoke();
        public delegate void SetBarInvoke(int count);
        public delegate void SetLabelInvoke(string text);

        public void WriteExcel()
        {
            Excel.Application newApp = new Excel.Application();
            SetBarInvoke setBar = currentForm.SetBarSettings;
            currentForm.BeginInvoke(setBar, result.Count);

            try
            {
                newApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet currSheet = (Excel.Worksheet)newApp.Worksheets.Item[1];
                IncBarInvoke incBar = currentForm.IncOpeningBarValue;
                int i = 1;
                foreach(User u in result)
                {
                    int j = 1;
                    currSheet.Cells[i, j++] = u.Id;
                    if (selectedFields[0])
                        currSheet.Cells[i, j++] = u.date;
                    if (selectedFields[1])
                        currSheet.Cells[i, j++] = u.firstName;
                    if (selectedFields[2])
                        currSheet.Cells[i, j++] = u.lastName;
                    if (selectedFields[3])
                        currSheet.Cells[i, j++] = u.surName;
                    if (selectedFields[4])
                        currSheet.Cells[i, j++] = u.city;
                    if (selectedFields[5])
                        currSheet.Cells[i, j++] = u.country;
                    i++;
                    currentForm.Invoke(incBar);
                }
                currSheet.SaveAs(fileName);
                newApp.Quit();
            SetLabelInvoke setLabel = currentForm.SetWaitLabelValue;
            currentForm.BeginInvoke(setLabel, "Файл успешно записан!");
            }
            catch (ThreadAbortException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. "+ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newApp.Quit();
            }
        }

    }
}
