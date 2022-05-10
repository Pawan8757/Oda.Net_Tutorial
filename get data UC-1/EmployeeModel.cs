using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Demo
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public long PhoneNumber { get; set; }
        public double BasicPay { get; set; }
        public string Address { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double TaxablePay { get; set; }
        public double NetPay { get; set; }
        public double IncomeTax { get; set; }
        public double Deduction { get; set; }
    }
}
