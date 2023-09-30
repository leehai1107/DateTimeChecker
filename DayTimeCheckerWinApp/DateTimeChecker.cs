using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DayTimeCheckerWinApp
{
    public partial class DateTimeChecker : Form
    {
        byte day, month;
        short year;
        public DateTimeChecker()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDay.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtYear.Text = string.Empty;
        }


        private void DateTimeChecker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure to exit?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the form closing event
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            byte.TryParse(txtDay.Text, out day);
            byte.TryParse(txtMonth.Text, out month);
            short.TryParse(txtYear.Text, out year);

            if (isCorrectFormat(day, month, year))
            {
                if (isValidRange(day, month, year))
                {
                    if (IsValidDate(day, month, year) == true)
                    {
                        DialogResult dialog = MessageBox.Show($"{day}/{month}/{year} is correct date time!", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show($"{day}/{month}/{year} is NOT correct date time!", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        //check format
        public bool isCorrectFormat(byte day, byte month, short year)
        {

            if (string.IsNullOrEmpty(txtDay.Text) || !byte.TryParse(txtDay.Text, out day))
            {
                DialogResult dialog = MessageBox.Show("Input data for Day is incorrect format!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtMonth.Text) || !byte.TryParse(txtMonth.Text, out month))
            {
                DialogResult dialog = MessageBox.Show("Input data for Month is incorrect format!",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtYear.Text) || !short.TryParse(txtYear.Text, out year))
            {
                DialogResult dialog = MessageBox.Show("Input data for Year is incorrect format!",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //check textbox out of range
        public bool isValidRange(byte day, byte month, short year)
        {

            if (day < 1 || day > 31)
            {
                DialogResult dialog = MessageBox.Show("Input data for Day is out of range!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (month < 1 || month > 12)
            {
                DialogResult dialog = MessageBox.Show("Input data for Month is out of range!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (year < 1000 || year > 3000)
            {
                DialogResult dialog = MessageBox.Show("Input data for Year is out of range!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        //check Day in Month
        public byte DayInMonth(short Year, byte Month)
        {
            byte Day = 0;
            if (Month == 1 || Month == 3 || Month == 5 || Month == 8 || Month == 7 || Month == 10
                || Month == 12)
            {
                Day = 31;
            }
            else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                Day = 30;
            }
            else if (Month == 2)
            {
                if ((Year % 400) == 0)
                {
                    Day = 29;
                }
                else if ((Year % 100) == 0)
                {
                    Day = 28;
                }
                else if ((Year % 4) == 0)
                {
                    Day = 29;
                }
                else
                {
                    Day = 28;
                }
            }
            return Day;
        }

            //check valid date
            public bool IsValidDate(byte Day, byte Month, short Year)
        {
            if (Month >= 1 && Month <= 12)
            {
                if (Day >= 1)
                {
                    if (Day <= DayInMonth(Year, Month))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
