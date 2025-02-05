internal class Program
{
    private static void Main(string[] args)
    {
       const int wage_Per_Hours = 20;
       const int full_Day_Hours = 8;

        Random  random = new Random();

        int daily_Employee_Wage;

        int attendence = random.Next(0, 10);
        if (attendence == 0)
        {
            Console.WriteLine("Employee is Absent");
            daily_Employee_Wage = 0;
            Console.WriteLine("Daily Employee Wage = " + daily_Employee_Wage);
        }
        else
        {
            Console.WriteLine("Employee is Present");
            daily_Employee_Wage = wage_Per_Hours * full_Day_Hours;
            Console.WriteLine("Daily Employee Wage = " + daily_Employee_Wage);
        }
    }
}