using projec6;

namespace projec6
{
    public class StudentManangeMentSystemSMS
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello & Welcome to the Student Manangement System(SMS) to grade students from Westfield");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("What do you what to do (1 or 2)?");
            Console.WriteLine("1. Add new grade?");
            Console.WriteLine("2. Check grade?");
            var text = Console.ReadLine();
        }
    }
}