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
                                Console.Clear();
                                Console.WriteLine("Add a grade");
                                Statistics statistics = new Statistics();
                                double text5 = double.Parse(Console.ReadLine());
                                //(text5);
                                Console.WriteLine($"Average: {statistics.Average:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Add a new grade");
                                double text6 = double.Parse(Console.ReadLine());
                                Add2(text6);
                                Statistics statistics = new Statistics();
                                Console.WriteLine($"Average: {statistics.Average:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                double text7 = double.Parse(Console.ReadLine());
                                Add3(text7);
                                Statistics statistics = new Statistics();
                                Console.WriteLine($"Average: {statistics.Average:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                        case "5":
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                double text8 = double.Parse(Console.ReadLine());
                                Add4(text8);
                                Statistics statistics = new Statistics();
                                Console.WriteLine($"Average: {statistics.Average:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                        default:
                            Console.Clear();
                            Console.WriteLine("Add a grade");
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Add a new grade");
                                double text9 = double.Parse(Console.ReadLine());
                                Add5(text9);
                                Statistics statistics = new Statistics();
                                Console.WriteLine($"Average: {statistics.Average:N2}");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
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

        public static void Add(double grade)
        {
            List<double> DoubleMaths = new List<double>();
            DoubleMaths.Add(grade);
        }

        public static void Add1(double grade)
        {
            List<double> DoublesEnglish = new List<double>();
            DoublesEnglish.Add(grade);
        }
        public static void Add2(double grade)
        {
            List<double> DoublesScience = new List<double>();
            DoublesScience.Add(grade);
        }
        public static void Add3(double grade)
        {
            List<double> DoublesGeography = new List<double>();
            DoublesGeography.Add(grade);
        }
        public static void Add4 (double grade)
        {
            List<double> DoublesComputerScience = new List<double>();
            DoublesComputerScience.Add(grade);
        }

        public static void Add5(double grade)
        {
            List<double> Totals = new List<double>();
            Totals.Add(grade);
        }
    }
}
