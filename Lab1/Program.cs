using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // using xml reader
using System.Xml.Serialization; // used to create the XML Serialization
using System.IO;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

           // emp.ID = 123;
           // emp.Name = "Tristian Neely";
          //  emp.SSNumber = 123456789;
           // emp.EntryDate = DateTime.Now;
          //  emp.JobRole = "Ninja";

            Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name}\nEmployee SS#: {emp.SSNumber} \nDate Created: {emp.EntryDate}");
            Console.ReadLine();

            string FilePath = "C:\\Users\\neely_tristian\\Documents\\";
            string FileName = "Samurai.xml";

            //TextWriter writer = new StreamWriter(FilePath + FileName);

            //XmlSerializer ser = new XmlSerializer(typeof(Employee));

            //ser.Serialize(writer, emp);
            //writer.Close();

            XmlSerializer des = new XmlSerializer(typeof(Employee));
            using (XmlReader reader = XmlReader.Create(FilePath + FileName))
            {
                emp = (Employee)des.Deserialize(reader);
                Console.WriteLine($"Employee ID {emp.ID} \nEmployee Name; {emp.Name}\nEmployee SS#: {emp.SSNumber} \nDate Created: {emp.EntryDate} ");
            }

            Console.ReadLine();


        }
    }
}
