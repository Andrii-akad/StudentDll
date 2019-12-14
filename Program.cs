using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace StudentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();
            service.Add(new Student
            {
                Name = "Andrii",
                Age = 16,
                LastName = "Pashko",
            });
            service.Add(new Student
            {
                Name = "Petro",
                Age = 23,
                LastName = "Pavlov",
            });
            Random rnd = new Random();
            foreach (Student item in service.Students)
            {
                item.AddMark("C++", rnd.Next(1, 12));
                item.AddMark("C#", rnd.Next(1, 12));
            }
            foreach (var item in service.Students)
            {
                Console.WriteLine(item);
            }
            service.Save();
            service.Best();
        }
    }
}
