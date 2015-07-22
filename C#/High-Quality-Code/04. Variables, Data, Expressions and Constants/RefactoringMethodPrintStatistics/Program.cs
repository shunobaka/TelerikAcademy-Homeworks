namespace RefactoringMethodPrintStatistics
{
    public class Printer
    {
        public static void Main()
        {
        }

        public void PrintStatistics(double[] values, int count)
        {
            double maxValue = 0;
            for (int index = 0; index < count; index++)
            {
                if (values[index] > maxValue)
                {
                    maxValue = values[index];
                }
            }

            this.PrintMax(maxValue);

            double minValue = 0;
            for (int index = 0; index < count; index++)
            {
                if (values[index] < minValue)
                {
                    minValue = values[index];
                }
            }

            this.PrintMin(minValue);

            double averageValue = 0;
            for (int index = 0; index < count; index++)
            {
                averageValue += values[index];
            }

            this.PrintAverage(averageValue / count);
        }

        private void PrintMax(double max)
        {
            throw new System.NotImplementedException();
        }

        private void PrintMin(double max)
        {
            throw new System.NotImplementedException();
        }

        private void PrintAverage(double average)
        {
            throw new System.NotImplementedException();
        }
    }
}
