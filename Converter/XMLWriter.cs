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

namespace Converter
{
    class XMLWriter
    {
        public string fileName;

        public XMLWriter(string file)
        {
            fileName = file;
        }

        public void WriteXML()
        {
            UserContext context = new UserContext();
            XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);
            writer.WriteStartElement("TestProgram");
            writer.WriteEndElement();
            writer.Close();
            XmlDocument document = new XmlDocument();
            document.Load(fileName);

            foreach (User user in context.Users.ToList())
            {
                XmlNode element = document.CreateElement("Record");
                document.DocumentElement.AppendChild(element);
                XmlAttribute attribute = document.CreateAttribute("id");
                attribute.Value = user.Id.ToString();
                element.Attributes.Append(attribute);
                XmlNode date = document.CreateElement("Date");
                date.InnerText = user.date.ToString();
                element.AppendChild(date);
                XmlNode firstName = document.CreateElement("FirstName");
                firstName.InnerText = user.firstName;
                element.AppendChild(firstName);
                XmlNode lastName = document.CreateElement("LastName");
                lastName.InnerText = user.lastName;
                element.AppendChild(lastName);
                XmlNode surName = document.CreateElement("SurName");
                surName.InnerText = user.surName;
                element.AppendChild(surName);
                XmlNode city = document.CreateElement("City");
                city.InnerText = user.city;
                element.AppendChild(city);
                XmlNode country = document.CreateElement("Country");
                country.InnerText = user.country;
                element.AppendChild(country);
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
