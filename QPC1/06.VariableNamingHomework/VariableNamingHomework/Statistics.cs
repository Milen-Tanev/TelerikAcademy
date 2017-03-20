namespace VariableNamingHomework
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] statisticData, int printCount)
        {
            double maxValueOfData = 0;
            for (int i = 0; i < printCount; i++)
            {
                if (statisticData[i] > maxValueOfData)
                {
                    maxValueOfData = statisticData[i];
                }
            }

            this.PrintMax(maxValueOfData);

            double minValueOfData = 0;
            for (int i = 0; i < printCount; i++)
            {
                if (statisticData[i] < minValueOfData)
                {
                    minValueOfData = statisticData[i];
                }
            }

            this.PrintMin(minValueOfData);

            double accumulatedValue = 0;
            double averageValueOfData = 0;
            for (int i = 0; i < printCount; i++)
            {
                accumulatedValue += statisticData[i];
            }

            averageValueOfData = accumulatedValue / printCount;
            this.PrintAvg(averageValueOfData);
        }

        private void PrintMax(double maxValueOfData)
        {
            Console.WriteLine(maxValueOfData);
        }

        private void PrintMin(double minValueOfData)
        {
            Console.WriteLine(minValueOfData);
        }

        private void PrintAvg(double averageValueOfData)
        {
            Console.WriteLine(averageValueOfData);
        }
    }
}
