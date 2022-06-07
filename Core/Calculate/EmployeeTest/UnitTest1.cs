using NUnit.Framework;
using Employee;

namespace EmployeeTest
{

    public class EmployeeTests
    {
        [TestCase]
        public void When_AgeISGreaterAndEqualTo60_Expects_IsSeniorCitizenAsTrue()
        {
            Employee.Employee emp = new Employee.Employee();
            emp.Age = 50;
            Assert.That(emp.IsSeniorCitizen(), Throws.Exception);
        }

        //[TestCase(29,ExpectedResult = false)]
        //[TestCase(16, ExpectedResult = false)]
        //[TestCase(70, ExpectedResult = true)]
        //[TestCase(59, ExpectedResult = false)]
        //[TestCase(90, ExpectedResult = true)]
        //public bool When_AgeISGreaterAndEqualTo60_Expects_IsSeniorCitizenAsTrue(int age)
        //{
        //    Employee.Employee emp = new Employee.Employee();
        //    emp.Age = age;
        //    return emp.IsSeniorCitizen();

        //}

        //[TestCase]
        //public void When_EmployeeIsDeveloper_Expects_Salary_58500()
        //{
        //    Employee.Employee emp = new Employee.Employee();
        //    emp.Desig = Employee.Employee.Employee_position.Developer;

        //    Assert.AreEqual(emp.CalculateSalary(),58500);
        //}

    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}