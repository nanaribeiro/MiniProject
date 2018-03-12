using DifferenceBetweenDates.Controller;
using DifferenceBetweenDates.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferenceBetweenDates
{
    public partial class DateCalculation : Form
    {
        DateController controller = new DateController();

        public DateCalculation()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {            
            long finalResult;
            long daysOfFirstDate = controller.CalculateDaysOfADate(FirstDate.Text);
            long daysOfSecondDate = controller.CalculateDaysOfADate(SecondDate.Text);
            //If the function CalculateDaysOfADate returns -1 the date is not on a valid format
            if (daysOfFirstDate.Equals(-1))
            {
                MessageBox.Show("Initial date is not on a valid format", "Date Format");
                return;
            }
            if (daysOfSecondDate.Equals(-1))
            {
                MessageBox.Show("Final date is not on a valid format", "Date Format");
                return;
            }
            //Validate (if firstDate is smaller than secondDate)
            if (daysOfFirstDate > daysOfSecondDate)
            {
                MessageBox.Show("Inital date needs to be smaller than final date", "Invalid");
            }
            else
            {
                finalResult = (daysOfSecondDate - daysOfFirstDate)/86400;
                ResultText.Text = finalResult.ToString() + " days";
            }            
        }
        
        private void DateCalculation_Load(object sender, EventArgs e)
        {
            controller.InitializeDaysOfMonth();
        }
    }
}
