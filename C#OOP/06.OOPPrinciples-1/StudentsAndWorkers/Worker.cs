﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be less than 0 (unless you are in Bulgaria)!");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Daily work hours cannot be less than 0 (again - unless you're in Bulgaria)!");
                }

                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour(double weekSalary, double workHoursPerDay)
        {
            double moneyPerHour = (this.weekSalary / 5) / this.workHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"First name:....{this.FirstName}\nLast Name:.....{this.LastName}\nWeekly Salary:.{this.WeekSalary}\nWork hours:....{this.WorkHoursPerDay}\n");
            return st.ToString();
        }
    }
}
