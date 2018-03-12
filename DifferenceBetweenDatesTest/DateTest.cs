using System;
using System.Globalization;
using DifferenceBetweenDates.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceBetweenDatesTest
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void TestInvalidString()
        {
            DateController d = new DateController();
            long t = d.CalculateDaysOfADate("140589");
            Assert.AreEqual(-1, t);
        }

        [TestMethod]
        public void TestDaysDifference()
        {
            /*
            According to Windows Calculator the difference of days between
            June 8, 1830
            and
            March 11, 2018
            is 68577
             */
            DateController d = new DateController();
            d.InitializeDaysOfMonth();
            /*
             The date format is based on the system date format, so if my machine is on MDY and
             it is sent a date using DMY the program will treat the date as MDY.
             */
            long firstDate = d.CalculateDaysOfADate("6/8/1830");
            long secondDate = d.CalculateDaysOfADate("3/11/2018");
            string sysDateFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //If the system date format is MDY
            if (sysDateFormat.Equals("M/d/yyyy"))
            {
                Assert.AreEqual(secondDate - firstDate, 68577);
            }
            else if(sysDateFormat.Equals("dd/MM/yyyy"))
            {
                Assert.AreEqual(secondDate - firstDate, 68755);
            }
            else
            {
                Assert.AreEqual(secondDate - firstDate, -1);
            }
        }

        [TestMethod]
        public void TestDaysDifferenceDMY()
        {
            /*
            According to Windows Calculator the difference of days between
            February 14, 1770
            and
            March 12, 2018
            is 90606
             */
            DateController d = new DateController();
            d.InitializeDaysOfMonth();
            string sysDateFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            /*
             The date format is based on the system date format, so if my machine is on MDY and
             it is sent a date using DMY the program will treat the date as MDY.
             */
            long firstDate = d.CalculateDaysOfADate("14/02/1770");
            long secondDate = d.CalculateDaysOfADate("12/03/2018");
            if (sysDateFormat.Equals("dd/MM/yyyy"))
            {
                Assert.AreEqual(secondDate - firstDate, 90606);
            }
            else if(sysDateFormat.Equals("M/d/yyyy"))
            {
                Assert.AreEqual(secondDate - firstDate, 737403);
            }
                
        }
    }
}
