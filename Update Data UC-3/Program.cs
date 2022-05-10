using System;
namespace ADO.NET_Demo
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tutorial of ADO.NET Tutorial");
            Console.WriteLine("\n \n");
            EmployeeModel emp=new EmployeeModel();
            emp.EmployeeName = "Pawan";
            emp.EmployeeID = 1;
            emp.Address = "Rafiganj Aurangabad";
            emp.PhoneNumber = 9304314938;
            emp.BasicPay = 700000;
            emp.Gender = "M";
            

            EmployeeRepo empRepo = new EmployeeRepo();
            empRepo.GetAllEmployees();
           // empRepo.AddEmployee(emp);
              empRepo.UpdateEmployee(emp);
           
            Console.ReadLine();
        }
    }
}