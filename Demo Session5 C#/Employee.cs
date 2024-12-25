using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session5_C_
{
    internal class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }


        public Department Department { get; set; }
    }
    internal class  Department
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
