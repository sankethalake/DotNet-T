using System;
using System.Collections.Generic;
using System.Text;

namespace AllFeatures
{
    class Emp
    {
        int empno;
        string ename;
        double salary;
        string address;
        string company_name;
        string design;
        int pincode;

        public void Emp_Profie(int empno, string ename, double salary, string address, string company_name="Cognizant", string design="Manager", int pincode=421202)
        {
            this.empno = empno;
            this.ename = ename;
            this.salary = salary;
            this.address = address;
            Console.WriteLine("The details are {0},{1},{2},{3},{4}", empno, ename, salary, address, company_name, design, pincode); 
        }
        public static void Main()
        {
            Emp obj = new Emp();
            obj.Emp_Profie(ename: "Sanket", empno: 101, salary: 10000, address:"PUne");
            Console.ReadLine();
        }
    }
}
