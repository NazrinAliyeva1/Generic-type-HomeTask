using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Task.Models
{
    public class Student
    {
        public string Name;
        public bool IsPlagiated;
        public bool IsHelpedToPlagiate;
        public Student(string name)
        {
            Name = name;
            IsPlagiated = false;
            IsHelpedToPlagiate = false;
        }
    }
}
