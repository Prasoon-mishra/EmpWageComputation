using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    public class EmployeeParttimefulltime
    {
        public int EmpPresent()
        {
            int EmpWagePerHour = 20;
            int DailyWage;
            int EmpHrs = 0;
            Random random = new Random();
            int ch = random.Next(0, 2);
            int EmpFullTime = 1;
            int EmpPartTime = 2;

           if (ch == EmpFullTime)
           {
            Console.WriteLine("Employee is full time Presnt");
            EmpHrs = 8;
           }
           else if (ch == EmpPartTime)
           {
            Console.WriteLine("Employee is Part time Present");
            EmpHrs = 4;
           }
           else
           {
            Console.WriteLine("Employee is absent");
            EmpHrs = 0;
           }
           DailyWage = EmpWagePerHour * EmpHrs;
           return DailyWage;

        }
    }
}
