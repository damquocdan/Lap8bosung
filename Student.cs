using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap8bosung
{
     class Student
    {
        public string studentId { get; set; }
        public string studentName { get; set; }
        public int age { get; set; }
        public Boolean sex { get; set; }
        public string birthDate { get; set; }
        public string birthPlace { get; set; }
        public string address { get; set; }

        public override string ToString()
        {
            return studentId+ "|"+studentName+"|"+age+"|"+sex+"|"+birthDate+"|"+birthPlace+"|"+address;
        }
    }
}
