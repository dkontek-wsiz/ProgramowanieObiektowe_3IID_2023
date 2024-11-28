using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    internal class Student: Person2
    {
        public string School { get; private set; }
        public bool CanGoHomeAlone { get; set; }


        public void SetSchool(string school)
        {
            School = school;
        }

        public void CheckSchool(string school)
        {
            School = school;
        }

        public void SetCanGoHomeAlone(bool canGoHomeAlone)
        {
            CanGoHomeAlone = canGoHomeAlone;
        }

        public void Info()
        {
            Console.WriteLine(CheckCanGoAloneToHome() ? "Może isc sam" : "Nie może");
        }

        public override bool CheckCanGoAloneToHome()
        {
            return base.CheckCanGoAloneToHome() || CanGoHomeAlone;
        }

        public override string GetEducationInfo()
        {
            return School;
        }
    }
}
