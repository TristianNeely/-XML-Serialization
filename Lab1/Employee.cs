using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    [Serializable]
   public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SSNumber { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
