namespace CompareAdvancedMaths
{
    public class PerformanceTests
    {
        private static void Main()
        {
            Tester.TestPerformance(Operation.Sqrt);
            Tester.TestPerformance(Operation.Log);
            Tester.TestPerformance(Operation.Sin);
        }
    }
}
