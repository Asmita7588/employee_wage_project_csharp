using System.ComponentModel.Design;


internal class Program
{
    private static void Main(string[] args)
    {
        const int wage_Per_Hours = 20;
        const int full_Day_Hours = 8;
        const int part_Time_Hours = 4;
        const int days_For_Month = 20;

        int full_Time = 1;
        int part_Time = 2;

        Random random = new Random();

        int daily_Employee_Wage = 0;
        int totalMonthlyEmployeeWage = 0;
        int work_Hours = 0;
        int total_working_hours = 100;
        int total_hours = 0;
        while (true)
        {
            if (total_hours == total_working_hours)
                break;

            for (int i = 1; i <= days_For_Month; i++)
            {
                int attendence = random.Next(0, 3);
                switch (attendence)
                {
                    case 1:

                        Console.WriteLine("Employee is Full Time");
                        work_Hours = full_Day_Hours;
                        daily_Employee_Wage = wage_Per_Hours * work_Hours;
                        Console.WriteLine($" Day {i} Employee Wage = " + daily_Employee_Wage);
                        break;

                    case 2:

                        Console.WriteLine("Employee is Part Time");
                        work_Hours = part_Time_Hours;
                        daily_Employee_Wage = wage_Per_Hours * work_Hours;
                        Console.WriteLine($" Day {i} Employee Wage = " + daily_Employee_Wage);
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        break;

                }
            }
            totalMonthlyEmployeeWage += daily_Employee_Wage;
            total_hours += work_Hours;
        }

     
                Console.WriteLine("Total hours Worked = " +total_hours);
                Console.WriteLine(" Total Mothly employee wage = " + totalMonthlyEmployeeWage);
                      
     } 
}

  

