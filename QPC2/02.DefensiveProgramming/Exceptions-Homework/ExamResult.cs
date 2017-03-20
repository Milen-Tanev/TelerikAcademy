namespace Exceptions_Homework
{
    public class ExamResult
    {
        public int Grade { get; private set; }
        public int MinGrade { get; private set; }
        public int MaxGrade { get; private set; }
        public string Comments { get; private set; }

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new GradeLessThanZeroException(ExceptionMessages.ExamGradeIsLessThanZero);
            }
            if (minGrade < 0)
            {
                throw new GradeLessThanZeroException(ExceptionMessages.ExamMinGradeIsLessThanZero);
            }
            if (maxGrade <= minGrade)
            {
                throw new MaxGradeLessThanMinGradeException(ExceptionMessages.MaxGradeIsLessThanMinGrade);
            }
            if (comments == null || comments == "")
            {
                throw new CommentCannotBeNullException(ExceptionMessages.CommentsCannotBeNull);
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }
    }
}
