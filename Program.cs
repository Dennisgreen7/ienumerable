using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shior7Work
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * 10);
            }

            int j = 1;
            while (j != 11)
            {
                Console.WriteLine(j * 10);
                j++;
            }

            int[] mispar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var num in mispar)
            {
                Console.WriteLine(num * 10);
            }

            SidraAd100 s = new SidraAd100();
            foreach (var num in s)
            {
                Console.WriteLine(num);
            }

            var nums = new HezkaUntil10(10);
            foreach (long n in nums)
            {
                Console.WriteLine(n);
            }

            Student a = new Student(110, "Dennis");
            Student b = new Student(10, "Lionel");
            Student c = new Student(100, "Cristiano");
            Student d = new Student(1, "Dani");
            StudentsWhoPracticeAlot st = new StudentsWhoPracticeAlot();
            st.AddStudent(a);
            st.AddStudent(b);
            st.AddStudent(c);
            st.AddStudent(d);
            foreach (Student stu in st)
            {
                Console.WriteLine(stu.Name + " " + stu.Grade);
            }
            Console.ReadLine();
        }
    }
}
