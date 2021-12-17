using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_mhetodes
{
    public class Persoane
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }
        public void SayHello(string introductionFormula)
        {
            Console.Write($"{introductionFormula} {FullName}");
        }
        public int GetAge()
        {
            return DateTime.Today.Year - DateOfBirth.Year;
        }
    }
}
