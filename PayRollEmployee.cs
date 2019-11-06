using System;
using System.Collections.Generic;
using System.Text;
namespace PayRollCalculate

{

    class CalculatePay

    {

        private double salaryPay;

        private double hourlyPay;
        
        private double Bonus= 100;
        
        private double payRoll= 1000;

        private string employeeType;


        public CalculatePay()

        {

        }
        public CalculatePay(double s1, double h1)
        {
            salaryPay = s1;
            hourlyPay = h1;
        }
        public double SalaryPay
        {
            get
            {
                return salaryPay;
            }
            set
            {
                salaryPay = value;
            }
        }
        public double HourlyPay
        {
            get
            {
                return hourlyPay;
            }
            set
            {
                hourlyPay = value;
            }
        }
        class PartTimeEmployee()
        {
            return salaryPay - ((salaryPay* hourlyPay) - (salaryPay* Bonus);
        }
        class FullTimeEmployee()
        {
            return hourlyPay + ((hourlyPay* Payroll) + (hourlyPay* Bonus));
        }
        public double Pay()
        {
            if (employeeType == '1')
                hourlyPay = pay* hoursWorked;
                if (hoursWorked > 40)
                   hourlyPay = pay*
        }
    }
}
