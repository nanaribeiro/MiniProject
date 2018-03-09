using DifferenceBetweenDates.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferenceBetweenDates
{
    public partial class DateCalculation : Form
    {
        Dictionary<int, int> daysOfMonth = new Dictionary<int, int>();
        //To solve the LeapYear problem I multiplied 365.24 to the year instead os using 365 days
        const double tropicalYear = 365.24;

        public DateCalculation()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {          
            long finalResult;
            long daysOfFirstDate = CalculateDaysOfADate(FirstDate);
            long daysOfSecondDate = CalculateDaysOfADate(SecondDate);

            //Validate (if firstDate is smaller than secondDate)
            if (daysOfFirstDate > daysOfSecondDate)
            {
                MessageBox.Show("Inital date needs to be smaller than final date");
            }
            else
            {
                finalResult = daysOfSecondDate - daysOfFirstDate;
                ResultText.Text = finalResult.ToString() + " days";
            }            
        }

        private long CalculateDaysOfADate(DateTimePicker GivenDate)
        {            
            DateModel givenDateModel = new DateModel();
            List<string> dateSplit;

            dateSplit = GivenDate.Text.Split('/').ToList();
            givenDateModel.Day = Convert.ToInt16(dateSplit[0]);
            for (int i = 0; i < Convert.ToInt16(dateSplit[1]); i++)
            {
                givenDateModel.Month += daysOfMonth[i + 1];
            }
            givenDateModel.Year = Convert.ToInt16(dateSplit[2]) * tropicalYear;

            return (long)givenDateModel.Year + givenDateModel.Month + givenDateModel.Day;
        }

        #region Data initialization

        private void InitializeDaysOfMonth()
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

        private void DateCalculation_Load(object sender, EventArgs e)
        {
            InitializeDaysOfMonth();
        }

        #endregion
    }
}
