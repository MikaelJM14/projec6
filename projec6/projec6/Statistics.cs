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


        public Statistics()
        {
            Count = 0;
            Total = 0.0;
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
            Total += number;
            Count += 1;
        }

        public void Add1(double number)
        {
            Total1 += number;
            Count1 += 1;
        }
        public void Add2(double number)
        {
            Total2 += number;
            Count2 += 1;
        }
        public void Add3(double number)
        {
            Total3 += number;
            Count3 += 1;
        }
        public void Add4(double number)
        {
            Total4 += number;
            Count4 += 1;
        }

        public void Add5(double number)
        {
            Total5 += number;
            Count5 += 1;
        }
    }
}
