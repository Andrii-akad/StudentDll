using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    [Serializable]
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Mark> Marks { get; set; }
        public Student()
        {
            Marks = new List<Mark>();
        }
        public override string ToString()
        {
            string rating = String.Empty;
            foreach (var item in Marks)
            {
                rating += Environment.NewLine/*"\n"*/ + item; 
            }
            return $"Name: {Name}, Last Name: {LastName}, Age: {Age}, Rating: {rating}";
        }
        public void AddMark(string subj,int mark)
        {
            Marks.Add(new Mark{ Rating = mark, Subject = subj });
        }
        public double AverageMark()
        {
            return Marks.Average(x => x.Rating);
        }
        public void SaveJSON()
        {

        }
    }
    [Serializable]
    public class Mark
    {
        public int Rating { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return $"{Subject} -------- {Rating}";
        }
    }
}//dopeek reflector
