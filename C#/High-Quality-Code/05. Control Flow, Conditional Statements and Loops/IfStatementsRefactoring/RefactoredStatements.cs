namespace IfStatementsRefactoring
{
    public class RefactoredStatements
    {
        public static void Main()
        {
            Potato potato;
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            if ((MIN_X <= x && x <= MAX_X) && (MIN_Y <= y && y <= MAX_Y) && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}
