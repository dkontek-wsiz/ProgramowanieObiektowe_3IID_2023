using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    internal class Person2
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Pesel { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSurname(string surname)
        {
            Surname = surname;
        }

        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        public string GetGender()
        {
            var g = int.Parse(Pesel[9].ToString());

            return g % 2 == 0 ? "Woman" : "Men";
        }

        public int GetAge()
        {
            var year = int.Parse(Pesel.Substring(0, 2));
            var month = int.Parse(Pesel.Substring(2, 2));
            if (month > 80)
            {
                year += 1800;
            }
            else if (month > 20)
            {
                year += 2000;
            }
            else
            {
                year += 1900;
            }

            return DateTime.Today.Year - year;
        }


        public virtual string GetEducationInfo()
        {
            return "";
        }

        public virtual string GetFullName() => $"{Name} {Surname}";

        public virtual bool CheckCanGoAloneToHome() => GetAge() > 12;
    }
}
