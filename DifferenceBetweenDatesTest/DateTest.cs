using System;
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
    }
}
