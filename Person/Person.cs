using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Program
    {
        static void Main(string[] args) { }
    }
    public class Person
    {
        private byte _age;

        private string _firstName;
        private string _lastName;

        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
               return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        virtual public void Print()
        {
            Console.WriteLine("Имя: " + _firstName);
            Console.WriteLine("Фамилия: " + _lastName);
            Console.WriteLine("Возраст: " + _age);
        }

        public override string ToString()
        {
            string s = "Имя: " + _firstName + "; " + "Фамилия: " + _lastName + "; " + "Возраст: " + _age;
            return s;
        }
    }
}
