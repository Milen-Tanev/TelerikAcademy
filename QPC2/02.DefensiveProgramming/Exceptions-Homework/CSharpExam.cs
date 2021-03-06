﻿namespace Exceptions_Homework
{
    using System;
    
    public class CSharpExam : Exam
    {
        public int Score { get; private set; }

        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new ScoreLessThanZeroException(ExceptionMessages.CSharpExamScoreIsLessThanZero);
            }

            this.Score = score;
        }

        public override ExamResult Check()
        {
            if (Score < 0 || Score > 100)
            {
                throw new ArgumentOutOfRangeException(ExceptionMessages.CSharpExamScoreIsOutOfRange);
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}