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
            Assert.AreEqual(secondDate - firstDate, 68577);
        }
    }
}
