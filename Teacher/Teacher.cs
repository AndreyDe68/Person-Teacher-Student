using System;
using System.Collections.Generic;
using person;
using stud;

namespace teach
{
    class Program
    {
        static void Main(string[] args) { }
    }
    public class Teacher : Person
    {
        List<Student> listOfStudents = new List<Student>();
        public void AddStudent(Student student)
        {
            listOfStudents.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
            if (listOfStudents.Contains(student))
            {
                return listOfStudents.Remove(student);
            }
            else
                return false;
        }
    
        public override void Print()
        {
            Console.WriteLine("Преподаватель: " + base.FirstName + " " + base.LastName);
            Console.WriteLine("Возраст: " + base.Age);
            Console.WriteLine("Студенты, обучающиеся у данного учителя: ");
            int count = 1;
            foreach (var student in listOfStudents)
            {
                Console.WriteLine(count + ":");
                student.Print();
                count++;
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = "Имя: " + base.FirstName + "; " + "Фамилия: " + base.LastName + "; " + "Возраст: " + base.Age;
            return s;
        }
    }
}
