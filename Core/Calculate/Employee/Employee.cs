using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException(string msg) : base(msg){

        }
    }
    public class Employee
    {
        public enum Employee_position 
        { 
        Trainee,
        Developer,
        Tester
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee_position Desig { get; set; }

        public bool IsSeniorCitizen()
        {
            if (Age < 60)
            {
                throw new InvalidAgeException("invalid age");
            }
            return this.Age >= 60;
        }

        public double CalculateSalary()
        {
            double bs=0;
            if (this.Desig == Employee_position.Developer) bs = 45000;
            if (this.Desig == Employee_position.Tester) bs = 40000;
            if (this.Desig == Employee_position.Trainee) bs = 15000;

            this.Salary = bs + bs * 0.1 + bs * 0.2;
            return this.Salary;
        }
        
    }
}
