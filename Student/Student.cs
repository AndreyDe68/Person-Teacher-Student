using System;
using person;

namespace stud
{
    class Program
    {
        static void Main() { }
    }
    public class Student : Person
      {
        private string _teacher;
        private string _gruppa;
        private byte _kurs;
        
        public string Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                _teacher = value;
            }
        }

        public string Gruppa
        {
            get
            {
                return _gruppa;
            }

            set
            {
                _gruppa = value;
            }
        }

        public byte Kurs
        {
            get
            {
                return _kurs;
            }            
            set
            {
                _kurs = value;
            }
        }

        public override void Print()
        {
            Console.Write(base.FirstName + " ");
            Console.Write(base.LastName + ", ");
            Console.Write("Возраст: " + base.Age + ", ");
            Console.Write("Курс " + _kurs + ", ");
            Console.Write("Группа: " + Gruppa + ". \n");
        }

        public override string ToString()
        {
            string s = "Имя: " + base.FirstName + "; " + "Фамилия: " + base.LastName + "; " + "Возраст: " + base.Age + "; " + "Курс: " + _kurs +
                "; " + "Группа: " + Gruppa;
            return s;
        }
    }
}