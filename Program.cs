internal class Program
{
    private static void Main(string[] args)
    {
        Random  random = new Random();

        int attendence = random.Next(0, 10);
        if (attendence == 0)
        {
            Console.WriteLine("Employee is Absent");
        }
        else
        {
            Console.WriteLine("Employee is Present");
        }
    }
}