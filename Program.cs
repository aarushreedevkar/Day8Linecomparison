namespace LineComparison2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Linecomparison1 linecomparison1 = new Linecomparison1();
            linecomparison1.LengthOfOneline();
           
            LineComparison2 lineComparison2 = new LineComparison2();
            lineComparison2.LengthOfTwoLines();

            LineComparison3 lineComparison3 = new LineComparison3();
            lineComparison3.CompareTwoLines();

            LineComparison4 lineComparison4 = new LineComparison4();
            lineComparison4.LineCompareEqualMethod();

        }
    }
}
