namespace Exceptions_Homework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;
        private const int BadGradeMaxProblems = 2;
        private const int AverageGradeMaxProblems = 5;
        private const int GoodGradeMaxProblems = 8;
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < SimpleMathExam.MinProblemsSolved)
                {
                    this.problemsSolved = SimpleMathExam.MinProblemsSolved;
                }
                else if (value > SimpleMathExam.MaxProblemsSolved)
                {
                    this.problemsSolved = SimpleMathExam.MaxProblemsSolved;
                }
                else
                {
                    this.problemsSolved = value;
                }
            }
        }

        public override ExamResult Check()
        {
            string comment;

            if (this.ProblemsSolved <= SimpleMathExam.BadGradeMaxProblems)
            {
                comment = "Bad result: Stop doing math.";
            }
            else if (this.ProblemsSolved <= SimpleMathExam.AverageGradeMaxProblems)
            {
                comment = "Average result: Could be better.";
            }
            else if (this.ProblemsSolved <= SimpleMathExam.GoodGradeMaxProblems)
            {
                comment = "Average result: Not bad at all.";
            }
            else
            {
                comment = "Excellent result: Give this person a cookie!";
            }

            return new ExamResult(this.ProblemsSolved, SimpleMathExam.MinProblemsSolved, SimpleMathExam.MaxProblemsSolved, comment);
        }
    }
}
