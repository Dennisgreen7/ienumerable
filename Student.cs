using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shior7Work
{
    public class Student
    {
        public int Grade { get; }
        public String Name { get; }
       
        public Student(int grade, string name)
        {
            Grade = grade;
            Name = name;
        }
    }
}
