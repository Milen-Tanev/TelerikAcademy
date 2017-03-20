namespace Exceptions_Homework
{
    using System.Linq;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Exam> Exams { get; set; }

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            if (firstName == null)
            {
                throw new NameIsNullException(ExceptionMessages.FirstNameCannotBeNull);
            }

            if (lastName == null)
            {
                throw new NameIsNullException(ExceptionMessages.LastNameCannotBeNull);
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                // This message is too perfect to be changed!
                throw new NullExamsException("Wow! Error happened!!!");
            }

            if (this.Exams.Count == 0)
            {
                throw new NoExamsException(ExceptionMessages.StudentHasNoExams);
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                throw new NullExamsException(ExceptionMessages.ExamsArrayIsNull);
            }

            if (this.Exams.Count == 0)
            {
                throw new NoExamsException(ExceptionMessages.StudentHasNoExams);
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}