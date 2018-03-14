using DifferenceBetweenDates.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DifferenceBetweenDates.Controller
{
    public class DateController
    {
        enum MDYDate : int { Month = 0, Day, Year };
        enum DMYDate : int { Day = 0, Month, Year };
        //Dictionary to track how many days every month has
        Dictionary<int, int> daysOfMonth = new Dictionary<int, int>();
        //To solve the LeapYear problem I multiplied 365.25 to the year instead os using 365 days
        const double tropicalYear = 365.25;
        // Number of days in a non-leap year
        private const int DaysPerYear = 365;
        // Number of days in 4 years
        private const int DaysPer4Years = DaysPerYear * 4 + 1;       // 1461
        // Number of days in 100 years
        private const int DaysPer100Years = DaysPer4Years * 25 - 1;  // 36524
        // Number of days in 400 years
        private const int DaysPer400Years = DaysPer100Years * 4 + 1; // 146097

        /// <summary>
        /// Checks if the input date is on MDY format
        /// </summary>
        /// <param name="dateInformed">the input date</param>
        /// <returns>If the date is on MDY format returns true, if not returns false</returns>
        private bool DateIsOnMDYFormat(string dateInformed)
        {
            string pattern = @"(0[1-9]|1[012]|^[1-9]?)[-\/.](0[1-9]|[12][0-9]|3[01]|[1-9]?)[-\/.]([0-9][0-9][0-9][0-9]|[0-9][0-9])";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(dateInformed);
            return m.Success;
        }

        /// <summary>
        /// The year is evenly divisible by 4;
        //If the year can be evenly divided by 100, it is NOT a leap year, unless;
        //The year is also evenly divisible by 400. Then it is a leap year.Why the year divided by 100 is not leap year.
        /// </summary>
        /// <param name="dateInformed"></param>
        /// <returns></returns>
        private bool DateIsOnDMYFormat(string dateInformed)
        {
            string pattern = @"(0[1-9]|[12][0-9]|3[01]|[1-9]?)[-\/.](0[1-9]|1[012]|[1-9]?)[-\/.]([0-9][0-9][0-9][0-9]|[0-9][0-9])";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(dateInformed);
            return m.Success;
        }

        private bool IsAValidDate(long day, long month, double year)
        {
            //If it is February 29 and the year is evenly divisible by 4 and divisible by 100 and 400
            if (month.Equals(2) && day.Equals(29))
            {
                if((year % 4 == 0) && (year % 100 == 0 && year % 400 == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            return true;
        }

        private int IsLeapYear(int year)
        {
            int divider = 1;
            int sumDays = 0;
            double remainingDays = 0;
            if(year >= 400)
            {
                divider = year / 400;
                remainingDays = Math.Round(((year / 400.0) - divider) * 400);
                sumDays += DaysPer400Years * divider;
                if(remainingDays >=100)
                {
                    divider = (int)remainingDays / 100;
                    remainingDays = Math.Round(((remainingDays / 100.0) - divider) * 100);
                    sumDays += DaysPer100Years * divider;
                }
                if(remainingDays >= 4)
                {
                    divider = (int)remainingDays / 4;
                    remainingDays = Math.Round(((remainingDays / 4.0) - divider) * 4);
                    sumDays += DaysPer4Years * divider;
                }
                if (remainingDays >= 1)
                {
                    divider = (int)remainingDays / 1;
                    remainingDays = Math.Round(((remainingDays / 1.0) - divider) * 1);
                    sumDays += DaysPerYear * divider;
                }
            }
            return sumDays;
        }

        /// <summary>
        /// This function calculates the amount os days of a given date
        /// </summary>
        /// <param name="GivenDate">The input date</param>
        /// <returns>Returns the number of days on the given date or -1 if the date is not valid</returns>
        public long CalculateDaysOfADate(string GivenDate)
        {
            //Model with Month Day and Year of date
            DateModel givenDateModel = new DateModel();
            //List to hold the result from Split method
            List<string> dateSplit;
            int day, month, year;
            //Get the system date format
            string sysDateFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //If the system date format is MDY
            if(sysDateFormat.Equals("M/d/yyyy"))
            {
                //It checks if the input date is on valid MDY format
                if (DateIsOnMDYFormat(GivenDate))
                {
                    //Splits the date using the allowed separators
                    dateSplit = GivenDate.Split('/', '-', '.').ToList();

                    day = Convert.ToInt16(dateSplit[(int)MDYDate.Day]);
                    month = Convert.ToInt16(dateSplit[(int)MDYDate.Month]);
                    year = Convert.ToInt16(dateSplit[(int)MDYDate.Year]);
                    //Validate February 29 on LeapYear
                    if (IsAValidDate(day, month, year)) {
                        //Calculate the amount of days of input date
                        givenDateModel.Day = day;
                        for (int i = 1; i < month; i++)
                        {
                            givenDateModel.Month += daysOfMonth[i];
                        }
                        givenDateModel.Year = IsLeapYear(year);

                        return (long)givenDateModel.Year + givenDateModel.Month + givenDateModel.Day;
                    }
                }
            }            
            //If the system date format is DMY
            else if(sysDateFormat.Equals("dd/MM/yyyy"))
            {
                //It checks if the input is on DMY format
                if (DateIsOnDMYFormat(GivenDate))
                {
                    //Splits the date using the allowed separators
                    dateSplit = GivenDate.Split('/', '-', '.').ToList();

                    day = Convert.ToInt16(dateSplit[(int)DMYDate.Day]);
                    month = Convert.ToInt16(dateSplit[(int)DMYDate.Month]);
                    year = Convert.ToInt16(dateSplit[(int)DMYDate.Year]);
                    //Validate February 29 on LeapYear
                    if (IsAValidDate(day, month, year))
                    {
                        //Calculate the amount of days of input date
                        givenDateModel.Day = day;
                        for (int i = 1; i < month; i++)
                        {
                            givenDateModel.Month += daysOfMonth[i];
                        }
                        givenDateModel.Year = IsLeapYear(year);

                        return (long)givenDateModel.Year + givenDateModel.Month + givenDateModel.Day;
                    }
                }
            }
            //If the date is not on a valid format it will return -1;
            return -1;
        }

        /// <summary>
        /// Initialize the Dictionary that stores the amount of days on each month
        /// </summary>
        public void InitializeDaysOfMonth()
        {
            daysOfMonth.Add(1, 31);
            daysOfMonth.Add(2, 28);
            daysOfMonth.Add(3, 31);
            daysOfMonth.Add(4, 30);
            daysOfMonth.Add(5, 31);
            daysOfMonth.Add(6, 30);
            daysOfMonth.Add(7, 31);
            daysOfMonth.Add(8, 31);
            daysOfMonth.Add(9, 30);
            daysOfMonth.Add(10, 31);
            daysOfMonth.Add(11, 30);
            daysOfMonth.Add(12, 31);
        }
    }
}
