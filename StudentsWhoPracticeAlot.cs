using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shior7Work
{
    class StudentsWhoPracticeAlot: IEnumerable
    {
        List<Student> StudentsList = new List<Student>();
        public void AddStudent(Student s)
        {
            StudentsList.Add(s);
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (StudentsList[i].Grade >= 10)
                {
                    yield return StudentsList[i];
                }
            } 
        }
    }
}
