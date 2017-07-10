using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Xml;
using System.Windows.Forms;

namespace Converter
{
    class XMLWriter
    {
        public string fileName;
        public bool[] selectedItems;
        public List<User> result;
        public bool useDateTime;

        public XMLWriter(string file)
        {
            fileName = file;
        }

        public void WriteXML()
        {
            XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);
            writer.WriteStartElement("TestProgram");
            writer.WriteEndElement();
            writer.Close();
            XmlDocument document = new XmlDocument();
            document.Load(fileName);

            

            foreach (User user in result.ToList())
            {
                XmlNode element = document.CreateElement("Record");
                document.DocumentElement.AppendChild(element);
                XmlAttribute attribute = document.CreateAttribute("id");
                attribute.Value = user.Id.ToString();
                element.Attributes.Append(attribute);
                if (selectedItems[0])
                {
                    XmlNode date = document.CreateElement("Date");
                    date.InnerText = user.date.ToString();
                    element.AppendChild(date);
                }
                if (selectedItems[1])
                {
                    XmlNode firstName = document.CreateElement("FirstName");
                    firstName.InnerText = user.firstName;
                    element.AppendChild(firstName);
                }
                if (selectedItems[2])
                {
                    XmlNode lastName = document.CreateElement("LastName");
                    lastName.InnerText = user.lastName;
                    element.AppendChild(lastName);
                }
                if (selectedItems[3])
                {
                    XmlNode surName = document.CreateElement("SurName");
                    surName.InnerText = user.surName;
                    element.AppendChild(surName);
                }
                if (selectedItems[4])
                {
                    XmlNode city = document.CreateElement("City");
                    city.InnerText = user.city;
                    element.AppendChild(city);
                }
                if (selectedItems[5])
                {
                    XmlNode country = document.CreateElement("Country");
                    country.InnerText = user.country;
                    element.AppendChild(country);
                }
            }
            document.Save(fileName);
        }
    }

    public static class New1
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        { 
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable("Users");
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
