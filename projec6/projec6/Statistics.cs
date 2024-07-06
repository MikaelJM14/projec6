namespace projec6
{
    public class Statistics
    {
        public double Total;
        public int Count;

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

        public void Add(double number)
        {
            Total += number;
            Count += 1;
        }
    }
}
