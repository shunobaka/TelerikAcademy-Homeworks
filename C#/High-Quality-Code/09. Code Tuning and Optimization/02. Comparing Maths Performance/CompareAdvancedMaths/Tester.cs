namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public static class Tester
    {
        private const float FloatValue = 1.0F;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1.0M;
        private const int RepeatCount = 500000;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        public static void TestPerformance(Operation operation)
        {
            Console.WriteLine("Currently testing for operation: {0}", operation);

            float resultFloat = FloatValue;
            Stopwatch.Start();

            for (int i = 0; i < RepeatCount; i++)
            {
                switch (operation)
                {
                    case Operation.Sqrt:
                        resultFloat = (float)Math.Sqrt(FloatValue);
                        break;
                    case Operation.Log:
                        resultFloat = (float)Math.Log(FloatValue);
                        break;
                    case Operation.Sin:
                        resultFloat = (float)Math.Sin(FloatValue);
                        break;
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-10}:{1}", "Float", Stopwatch.Elapsed);
            Stopwatch.Reset();

            double resultDouble = DoubleValue;
            Stopwatch.Start();

            for (int i = 0; i < RepeatCount; i++)
            {
                switch (operation)
                {
                    case Operation.Sqrt:
                        resultDouble = Math.Sqrt(DoubleValue);
                        break;
                    case Operation.Log:
                        resultDouble = Math.Log(DoubleValue);
                        break;
                    case Operation.Sin:
                        resultDouble = Math.Sin(DoubleValue);
                        break;
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-10}:{1}", "Double", Stopwatch.Elapsed);
            Stopwatch.Reset();

            decimal resultDecimal = DecimalValue;
            Stopwatch.Start();

            for (int i = 0; i < RepeatCount; i++)
            {
                switch (operation)
                {
                    case Operation.Sqrt:
                        resultDecimal = (decimal)Math.Sqrt((double)DecimalValue);
                        break;
                    case Operation.Log:
                        resultDecimal = (decimal)Math.Log((double)DecimalValue);
                        break;
                    case Operation.Sin:
                        resultDecimal = (decimal)Math.Sin((double)DecimalValue);
                        break;
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-10}:{1}", "Decimal", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}
