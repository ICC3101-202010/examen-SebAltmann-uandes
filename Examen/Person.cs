using System;
namespace Examen
{
    public class Person
    {
        private string Name;
        private int Age;
        private string Nationality;
        private int Salary;

        public Person(string name, int age, string nationality, int salary)
        {
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;
            this.Salary = salary;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetNationality()
        {
            return Nationality;
        }

        public int GetSalary()
        {
            return Salary;
        }
    }
}
