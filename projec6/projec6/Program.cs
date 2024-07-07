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

            Console.WriteLine("What do you what to do (1 or 2 or 3)?");
            Console.WriteLine("1. Add new grade?");
            Console.WriteLine("2. Check grade?");
            Console.WriteLine("3. Add new student?");
            var text = Console.ReadLine();

            switch (text)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("What do you what to do (1 or 2 or 3 or 4 or 5)?");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("1. Maths");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("2. English");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("3. Science");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("4. Geography");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("5. Computer Science");
                    Console.ResetColor();
                    var text1 = Console.ReadLine();
                    switch (text1)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                Statistics statistics = new Statistics();
                                double text4 = double.Parse(Console.ReadLine());
                                statistics.Add(text4);
                                if (text4 > 100)
                                    break;
                                Console.WriteLine($"Average: {statistics.Average:N4}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                Statistics statistics = new Statistics();
                                double text4 = double.Parse(Console.ReadLine());
                                statistics.Add1(text4);
                                if (text4 > 100)
                                    break;
                                Console.WriteLine($"Average: {statistics.Average:N4}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                Statistics statistics = new Statistics();
                                double text4 = double.Parse(Console.ReadLine());
                                statistics.Add2(text4);
                                if (text4 > 100)
                                    break;
                                Console.WriteLine($"Average: {statistics.Average:N4}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                Statistics statistics = new Statistics();
                                double text4 = double.Parse(Console.ReadLine());
                                statistics.Add3(text4);
                                if (text4 > 100)
                                    break;
                                Console.WriteLine($"Average: {statistics.Average:N4}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                Statistics statistics = new Statistics();
                                double text4 = double.Parse(Console.ReadLine());
                                statistics.Add4(text4);
                                if (text4 > 100)
                                    break;
                                Console.WriteLine($"Average: {statistics.Average:N4}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                Statistics statistics = new Statistics();
                                double text4 = double.Parse(Console.ReadLine());
                                statistics.Add5(text4);
                                if (text4 > 100)
                                    break;
                                Console.WriteLine($"Average: {statistics.Average:N4}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("What do you what to do (1 or 2 or 3 or 4 or 5 or 6)?");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("1. Maths");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("2. English");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("3. Science");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("4. Geography");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("5. Computer Science");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("6. Total");
                    Console.ResetColor();
                    var text10 = Console.ReadLine();
                    switch (text10)
                    {
                        case "1":
                            Console.Clear();
                            break;
                        case "2":
                            Console.Clear();
                            break;
                        case "3":
                            Console.Clear();
                            break;
                        case "4":
                            Console.Clear();
                            break;
                        case "5":
                            Console.Clear();
                            break;
                        case "6":
                            Console.Clear();
                            break;
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("insert Name:");
                    var text2 = Console.ReadLine();
                    Console.WriteLine("insert Surname:");
                    var text3 = Console.ReadLine();
                    Console.WriteLine("insert Surname:");
                    var text11 = Console.ReadLine();
                    new Student(text2, text3, text11);
                    break;
            }
        }
    }
}
