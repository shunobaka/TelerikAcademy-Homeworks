﻿namespace Exceptions_Homework
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < CSharpExam.MinScore || value > CSharpExam.MaxScore)
                {
                    throw new ArgumentException(string.Format("The score must be between {0} and {1}.", CSharpExam.MinScore, CSharpExam.MaxScore));
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}