namespace CompareSimpleMaths
{
    public class PerformanceTests
    {
        private static void Main()
        {
            Tester.TestPerformance(Operation.Add);
            Tester.TestPerformance(Operation.Subtract);
            Tester.TestPerformance(Operation.Multiply);
            Tester.TestPerformance(Operation.Divide);
        }
    }
}
