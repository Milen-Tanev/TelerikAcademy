namespace Exceptions_Homework
{
    internal class ExceptionMessages
    {
        internal const string CSharpExamScoreIsLessThanZero = 
            "The score of the CSharp exam cannot be less than 0!";
        internal const string CSharpExamScoreIsOutOfRange = 
            "The score of the CSharp exam cannot be less than 0 or bigger than 100!";
        internal const string ExamGradeIsLessThanZero = 
            "The grade cannot be less than 0!";
        internal const string ExamMinGradeIsLessThanZero = 
            "Minimum grade cannot be less than 0!";
        internal const string MaxGradeIsLessThanMinGrade = 
            "Maximum grade cannot be less or equal to the minimum grade!";
        internal const string CommentsCannotBeNull 
            = "There are no comments!";
        internal const string CountCannotBeLargerThanTheStringLength 
            = "Count is larger than the string length!";
        internal const string NotPrimeNumberGiven = 
            "The number is not prime!";
        internal const string SolvedProblemsCountIsOutOfRange = 
            "The count of solved problems cannot be less than 0 or larger than 10!";
        internal const string FirstNameCannotBeNull =
            "Invalid first name!!";
        internal const string LastNameCannotBeNull =
            "Invalid last name!";
        internal const string StudentHasNoExams =
            "This student has no exams!";
        internal const string ExamsArrayIsNull =
            "The exams array of this student is null!";
    }
}
