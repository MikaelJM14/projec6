using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projec6
{
    public class Statistics
    {
        public double Total;
        public int Count;
        public double Total1;
        public int Count1;
        public double Total2;
        public int Count2;
        public double Total3;
        public int Count3;
        public double Total4;
        public int Count4;
        public double Total5;
        public int Count5;
        public double High;
        public double Low;
        public double High1;
        public double Low1;
        public double High2;
        public double Low2;
        public double High3;
        public double Low3; 
        public double High4;
        public double Low4;
        public double High5;
        public double Low5;


        public Statistics()
        {
            Count = 0;
            Total = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
            High1 = double.MinValue;
            Low1 = double.MaxValue;
            High2 = double.MinValue;
            Low2 = double.MaxValue;
            High3 = double.MinValue;
            Low3 = double.MaxValue;
            High4 = double.MinValue;
            Low4 = double.MaxValue;
            High5 = double.MinValue;
            Low5 = double.MaxValue;
        }

        public double Average
        {
            get
            {
                return Total / Count;
            }
        }

        public double Average1
        {
            get
            {
                return Total1 / Count1;
            }
        }

        public double Average2
        {
            get
            {
                return Total2 / Count2;
            }
        }

        public double Average3
        {
            get
            {
                return Total3 / Count3;
            }
        }

        public double Average4
        {
            get
            {
                return Total4 / Count4;
            }
        }

        public double Average5
        {
            get
            {
                return Total5 / Count5;
            }
        }

        public void Add(double number)
        {
            List<double> list = new List<double>();
            var Total6 = Total += number;
            var Count6 = Count += 1;
            list.Add(Total6);
            list.Add(Count6);
            list.Add(Average);
            list.Add(Low = Math.Min(number, Low));
            list.Add(High = Math.Max(number, High));                                                            
        }

        public void Add1(double number)
        {
            List<double> list = new List<double>();
            var Total6 = Total1 += number;
            var Count6 = Count1 += 1;
            list.Add(Total6);
            list.Add(Count6);
            list.Add(Average1);
            list.Add(Low1 = Math.Min(number, Low1));
            list.Add(High1 = Math.Max(number, High1));
        }
        public void Add2(double number)
        {
            List<double> list = new List<double>();
            var Total6 = Total2 += number;
            var Count6 = Count2 += 1;
            list.Add(Total6);
            list.Add(Count6);
            list.Add(Average2);
            list.Add(Low2 = Math.Min(number, Low2));
            list.Add(High2 = Math.Max(number, High2));
        }
        public void Add3(double number)
        {
            List<double> list = new List<double>();
            var Total6 = Total3 += number;
            var Count6 = Count3 += 1;
            list.Add(Total6);
            list.Add(Count6);
            list.Add(Average3);
            list.Add(Low3 = Math.Min(number, Low3));
            list.Add(High3 = Math.Max(number, High3));
        }
        public void Add4(double number)
        {
            List<double> list = new List<double>();
            var Total6 = Total4 += number;
            var Count6 = Count4 += 1;
            list.Add(Total6);
            list.Add(Count6);
            list.Add(Average4);
            list.Add(Low4 = Math.Min(number, Low4));
            list.Add(High4 = Math.Max(number, High4));
        }   

        public void Add5(double number)
        {
            List<double> list = new List<double>();
            var Total6 = Total += number;
            var Count6 = Count += 1;
            var Total7 = Total1 += number;
            var Count7 = Count1 += 1;
            var Total8 = Total2 += number;
            var Count8 = Count2 += 1;
            var Total9 = Total3 += number;
            var Count9 = Count3 += 1;
            var Total10 = Total4 += number;
            var Count10 = Count4 += 1;
            var Total11 = Total5 += number;
            var Count11 = Count5 += 1;
            list.Add(Total6);
            list.Add(Count6);
            list.Add(Total7);
            list.Add(Count7);
            list.Add(Total8);
            list.Add(Count8);
            list.Add(Total9);
            list.Add(Count9);
            list.Add(Total10);
            list.Add(Count10);
            list.Add(Total11);
            list.Add(Count11);
            list.Add(Average);
            list.Add(Low = Math.Min(number, Low));
            list.Add(High = Math.Max(number, High));
            list.Add(Average1);
            list.Add(Low1 = Math.Min(number, Low1));
            list.Add(High1 = Math.Max(number, High1));
            list.Add(Average2);
            list.Add(Low2 = Math.Min(number, Low2));
            list.Add(High2 = Math.Max(number, High2));
            list.Add(Average3);
            list.Add(Low3 = Math.Min(number, Low3));
            list.Add(High3 = Math.Max(number, High3));
            list.Add(Average);
            list.Add(Low4 = Math.Min(number, Low4));
            list.Add(High4 = Math.Max(number, High4));
            list.Add(Average);
            list.Add(Low5 = Math.Min(number, Low5));
            list.Add(High5 = Math.Max(number, High5));
        }
    }
}
