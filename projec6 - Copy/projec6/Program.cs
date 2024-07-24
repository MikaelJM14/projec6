using projec6;
using System.ComponentModel;
using System.Numerics;

namespace projec6
{ 
    public class StudentManangementSystemSMS
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
                            Console.WriteLine("insert Name:");
                            var text12 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text13 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text14 = Console.ReadLine();
                            new Student(text12, text13, text14);
                            Console.WriteLine($"Add a grade for {text12} {text13} {text14}");
                            double text4 = double.Parse(Console.ReadLine());
                            Statistics statistics = new Statistics();
                            statistics.Add(text4);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text12} {text13} {text14}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics.Add(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics.Average:N4}");
                            Console.WriteLine($"the max is: {statistics.High:N4}");
                            Console.WriteLine($"the min is: {statistics.Low:N4}");
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text15 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text16 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text17 = Console.ReadLine();
                            new Student(text15, text16, text17);
                            Console.WriteLine($"Add a grade for {text15} {text16} {text17}");
                            double text18 = double.Parse(Console.ReadLine());
                            Statistics statistics1 = new Statistics();
                            statistics1.Add1(text18);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text15} {text16} {text17}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics1.Add1(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics1.Average1:N4}");
                            Console.WriteLine($"the max is: {statistics1.High1:N4}");
                            Console.WriteLine($"the min is: {statistics1.Low1:N4}");
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text19 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text20 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text21 = Console.ReadLine();
                            new Student(text19, text20, text21);
                            Console.WriteLine($"Add a grade for {text19} {text20} {text21}");
                            double text22 = double.Parse(Console.ReadLine());
                            Statistics statistics2 = new Statistics();
                            statistics2.Add2(text22);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for  {text19} {text20} {text21}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics2.Add2(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics2.Average2:N4}");
                            Console.WriteLine($"the max is: {statistics2.High2:N4}");
                            Console.WriteLine($"the min is: {statistics2.Low2:N4}");
                            break;
                            case "4":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text23 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text24 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text25 = Console.ReadLine();
                            new Student(text23, text24, text25);
                            Console.WriteLine($"Add a grade for {text23} {text24} {text25}");
                            double text26 = double.Parse(Console.ReadLine());
                            Statistics statistics3 = new Statistics();
                            statistics3.Add3(text26);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for  {text23} {text24} {text25}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics3.Add3(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics3.Average3:N4}");
                            Console.WriteLine($"the max is: {statistics3.High3:N4}");
                            Console.WriteLine($"the min is: {statistics3.Low3:N4}");
                            break;
                            case "5":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text27 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text28 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text29 = Console.ReadLine();
                            new Student(text27, text28, text29);
                            Console.WriteLine($"Add a grade for {text27} {text28} {text29}");
                            double text30 = double.Parse(Console.ReadLine());
                            Statistics statistics4 = new Statistics();
                            statistics4.Add4(text30);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text27} {text28} {text29}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics4.Add4(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics4.Average4:N4}");
                            Console.WriteLine($"the max is: {statistics4.High4:N4}");
                            Console.WriteLine($"the min is: {statistics4.Low4:N4}");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text31 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text32 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text33 = Console.ReadLine();
                            new Student(text31, text32, text33);
                            Console.WriteLine($"Add a grade for {text31} {text32} {text33}");
                            double text34 = double.Parse(Console.ReadLine());
                            Statistics statistics5 = new Statistics();
                            statistics5.Add5(text34);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text31} {text32} {text33}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics5.Add5(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics5.Average5:N4}");
                            Console.WriteLine($"the max is: {statistics5.High5:N4}");
                            Console.WriteLine($"the min is: {statistics5.Low5:N4}");
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
                            Console.WriteLine("insert Name:");
                            var text12 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text13 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text14 = Console.ReadLine();
                            new Student(text12, text13, text14);
                            Console.WriteLine($"Add a grade for {text12} {text13} {text14}");
                            double text4 = double.Parse(Console.ReadLine());
                            Statistics statistics = new Statistics();
                            statistics.Add(text4);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text12} {text13} {text14}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics.Add(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics.Average:N4}");
                            Console.WriteLine($"the max is: {statistics.High:N4}");
                            Console.WriteLine($"the min is: {statistics.Low:N4}");
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text15 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text16 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text17 = Console.ReadLine();
                            new Student(text15, text16, text17);
                            Console.WriteLine($"Add a grade for {text15} {text16} {text17}");
                            double text18 = double.Parse(Console.ReadLine());
                            Statistics statistics1 = new Statistics();
                            statistics1.Add1(text18);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text15} {text16} {text17}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics1.Add1(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics1.Average1:N4}");
                            Console.WriteLine($"the max is: {statistics1.High1:N4}");
                            Console.WriteLine($"the min is: {statistics1.Low1:N4}");
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text19 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text20 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text21 = Console.ReadLine();
                            new Student(text19, text20, text21);
                            Console.WriteLine($"Add a grade for {text19} {text20} {text21}");
                            double text22 = double.Parse(Console.ReadLine());
                            Statistics statistics2 = new Statistics();
                            statistics2.Add2(text22);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for  {text19} {text20} {text21}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics2.Add2(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics2.Average2:N4}");
                            Console.WriteLine($"the max is: {statistics2.High2:N4}");
                            Console.WriteLine($"the min is: {statistics2.Low2:N4}");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text23 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text24 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text25 = Console.ReadLine();
                            new Student(text23, text24, text25);
                            Console.WriteLine($"Add a grade for {text23} {text24} {text25}");
                            double text26 = double.Parse(Console.ReadLine());
                            Statistics statistics3 = new Statistics();
                            statistics3.Add3(text26);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for  {text23} {text24} {text25}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics3.Add3(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics3.Average3:N4}");
                            Console.WriteLine($"the max is: {statistics3.High3:N4}");
                            Console.WriteLine($"the min is: {statistics3.Low3:N4}");
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text27 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text28 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text29 = Console.ReadLine();
                            new Student(text27, text28, text29);
                            Console.WriteLine($"Add a grade for {text27} {text28} {text29}");
                            double text30 = double.Parse(Console.ReadLine());
                            Statistics statistics4 = new Statistics();
                            statistics4.Add4(text30);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text27} {text28} {text29}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics4.Add4(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics4.Average4:N4}");
                            Console.WriteLine($"the max is: {statistics4.High4:N4}");
                            Console.WriteLine($"the min is: {statistics4.Low4:N4}");
                            break;
                        case "6":
                            Console.Clear();
                            Console.WriteLine("insert Name:");
                            var text31 = Console.ReadLine();
                            Console.WriteLine("insert Surname:");
                            var text32 = Console.ReadLine();
                            Console.WriteLine("insert Lastname:");
                            var text33 = Console.ReadLine();
                            new Student(text31, text32, text33);
                            Console.WriteLine($"Add a grade for {text31} {text32} {text33}");
                            double text34 = double.Parse(Console.ReadLine());
                            Statistics statistics5 = new Statistics();
                            statistics5.Add(text34);
                            statistics5.Add1(text34);
                            statistics5.Add2(text34);
                            statistics5.Add3(text34);
                            statistics5.Add3(text34);
                            statistics5.Add5(text34);
                            while (true)
                            {
                                Console.WriteLine($"Add a new grade for {text31} {text32} {text33}");
                                double text5 = double.Parse(Console.ReadLine());
                                statistics5.Add(text5);
                                statistics5.Add1(text5);
                                statistics5.Add2(text5);
                                statistics5.Add3(text5);
                                statistics5.Add3(text5);
                                statistics5.Add5(text5);
                                if (text5 > 100)
                                    break;
                            }
                            Console.WriteLine($"the average is: {statistics5.Average:N4}");
                            Console.WriteLine($"the max is: {statistics5.High:N4}");
                            Console.WriteLine($"the min is: {statistics5.Low:N4}");
                            Console.WriteLine($"the average is: {statistics5.Average1:N4}");
                            Console.WriteLine($"the max is: {statistics5.High1:N4}");
                            Console.WriteLine($"the min is: {statistics5.Low1:N4}");
                            Console.WriteLine($"the average is: {statistics5.Average2:N4}");
                            Console.WriteLine($"the max is: {statistics5.High2:N4}");
                            Console.WriteLine($"the min is: {statistics5.Low2:N4}");
                            Console.WriteLine($"the average is: {statistics5.Average3:N4}");
                            Console.WriteLine($"the max is: {statistics5.High3:N4}");
                            Console.WriteLine($"the min is: {statistics5.Low3:N4}");
                            Console.WriteLine($"the average is: {statistics5.Average4:N4}");
                            Console.WriteLine($"the max is: {statistics5.High4:N4}");
                            Console.WriteLine($"the min is: {statistics5.Low4:N4}");
                            Console.WriteLine($"the average is: {statistics5.Average5:N4}");
                            Console.WriteLine($"the max is: {statistics5.High5:N4}");
                            Console.WriteLine($"the min is: {statistics5.Low5:N4}");
                            break;
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("insert Name:");
                    var text2 = Console.ReadLine();
                    Console.WriteLine("insert Surname:");
                    var text3 = Console.ReadLine();
                    Console.WriteLine("insert Lastname:");
                    var text11 = Console.ReadLine();
                    new Student(text2, text3, text11);
                    break;
            }
        }
    }
}
