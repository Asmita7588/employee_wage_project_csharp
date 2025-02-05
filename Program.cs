using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        const int wage_Per_Hours = 20;
        const int full_Day_Hours = 8;
        const int part_Time_Hours = 4;

        int full_Time = 1;
        int part_Time = 2;

        Random random = new Random();

        int daily_Employee_Wage;
        int work_Hours;

        int attendence = random.Next(0, 3);
        if (attendence == full_Time)
        {
            Console.WriteLine("Employee is Full Time");
            work_Hours = full_Day_Hours;
            daily_Employee_Wage = wage_Per_Hours * work_Hours;
            Console.WriteLine("Daily Employee Wage = " + daily_Employee_Wage);
        }
        else if (attendence == part_Time)
        {

            Console.WriteLine("Employee is Part Time");
            work_Hours = part_Time_Hours;
            daily_Employee_Wage = wage_Per_Hours * work_Hours;
            Console.WriteLine("Daily Employee Wage = " + daily_Employee_Wage);

        }
        else
        {
            Console.WriteLine("Employee is Absent");
        }
    }
}   

