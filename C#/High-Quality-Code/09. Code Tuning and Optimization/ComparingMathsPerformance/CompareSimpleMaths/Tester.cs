namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public static class Tester
    {
        private const int IntValue = 1;
        private const long LongValue = 1L;
        private const float FloatValue = 1.0F;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1.0M;
        private const int RepeatCount = 500000;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        public static void TestPerformance(Operation operation)
        {
            Console.WriteLine("Currently testing for operation: {0}", operation);

            int resultInt = IntValue;
            Stopwatch.Start();

            for (int i = 0; i < RepeatCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultInt += IntValue;
                        break;
                    case Operation.Subtract:
                        resultInt -= IntValue;
                        break;
                    case Operation.Multiply:
                        resultInt *= IntValue;
                        break;
                    case Operation.Divide:
                        resultInt /= IntValue;
                        break;
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-10}:{1}", "Int", Stopwatch.Elapsed);
            Stopwatch.Reset();

            long resultLong = LongValue;
            Stopwatch.Start();

            for (int i = 0; i < RepeatCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultLong += LongValue;
                        break;
                    case Operation.Subtract:
                        resultLong -= LongValue;
                        break;
                    case Operation.Multiply:
                        resultLong *= LongValue;
                        break;
                    case Operation.Divide:
                        resultLong /= LongValue;
                        break;
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-10}:{1}", "Long", Stopwatch.Elapsed);
            Stopwatch.Reset();

            float resultFloat = FloatValue;
            Stopwatch.Start();

            for (int i = 0; i < RepeatCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultFloat += FloatValue;
                        break;
                    case Operation.Subtract:
                        resultFloat -= FloatValue;
                        break;
                    case Operation.Multiply:
                        resultFloat *= FloatValue;
                        break;
                    case Operation.Divide:
                        resultFloat /= FloatValue;
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
                    case Operation.Add:
                        resultDouble += DoubleValue;
                        break;
                    case Operation.Subtract:
                        resultDouble -= DoubleValue;
                        break;
                    case Operation.Multiply:
                        resultDouble *= DoubleValue;
                        break;
                    case Operation.Divide:
                        resultDouble /= DoubleValue;
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
                    case Operation.Add:
                        resultDecimal += DecimalValue;
                        break;
                    case Operation.Subtract:
                        resultDecimal -= DecimalValue;
                        break;
                    case Operation.Multiply:
                        resultDecimal *= DecimalValue;
                        break;
                    case Operation.Divide:
                        resultDecimal /= DecimalValue;
                        break;
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-10}:{1}", "Decimal", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}
