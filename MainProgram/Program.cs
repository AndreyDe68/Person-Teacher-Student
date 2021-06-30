using System;
using System.Collections.Generic;
using person;
using stud;
using teach;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teacher = new List<Teacher>();

            List<Student> students = new List<Student>();

            teacher.Add(new Teacher() { Age = 28, FirstName = "Валентин", LastName = "Кольцов" });
            teacher.Add(new Teacher() { Age = 53, FirstName = "Андрей", LastName = "Зинченко" });
            teacher.Add(new Teacher() { Age = 38, FirstName = "Мария", LastName = "Иванова" });
            teacher.Add(new Teacher() { Age = 65, FirstName = "Николай", LastName = "Степанов" });

            students.Add(new Student() { Age = 21, FirstName = "Илья", LastName = "Зайцев", Kurs = 2, Gruppa = "4309", Teacher = "Кольцов"});
            students.Add(new Student() { Age = 23, FirstName = "Андрей", LastName = "Павлов", Kurs = 3, Gruppa = "4509", Teacher = "Зинченко" });
            students.Add(new Student() { Age = 18, FirstName = "Алия", LastName = "Смирнова", Kurs = 1, Gruppa = "4108", Teacher = "Иванова" });
            students.Add(new Student() { Age = 20, FirstName = "Александра", LastName = "Каримова", Kurs = 2, Gruppa = "4212", Teacher = "Степанов" });
            students.Add(new Student() { Age = 22, FirstName = "Василий", LastName = "Попов", Kurs = 4, Gruppa = "4401", Teacher = "Зинченко" });
            students.Add(new Student() { Age = 24, FirstName = "Павел", LastName = "Васильев", Kurs = 5, Gruppa = "4812", Teacher = "Кольцов" });
            students.Add(new Student() { Age = 20, FirstName = "Екатерина", LastName = "Закирова", Kurs = 2, Gruppa = "1210", Teacher = "Иванова" });

            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < teacher.Count; j++)
                {
                    if (teacher[j].LastName == students[i].Teacher)
                    {
                        teacher[j].AddStudent(students[i]);
                    }
                }
            }

            foreach (var teacher1 in teacher)
            {
                teacher1.Print();
            }

            //сериализация объектов Student
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
                Console.WriteLine("Объекты сериализованы\n");
            }

            // десериализация
            using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
            {
                List<Student> newStudents = (List<Student>)formatter.Deserialize(fs);

                foreach (Student stud in newStudents)
                {
                    Console.WriteLine($"{stud.FirstName} {stud.LastName}, Возраст: {stud.Age}, курс: {stud.Kurs}, группа: {stud.Gruppa}");
                }
                Console.WriteLine("Объекты десериализованы");
            }
            Console.Read();
        }
    }
}

