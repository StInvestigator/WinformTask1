using System.Windows.Forms;

namespace Running_Button
{
    public partial class Form1 : Form
    {
        TimeSpan? time = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 10 || textBox.Text.Length == 16)
            {
                try
                {
                    string minute = "", hour = "", day = "", month = "", year = "";
                    day += textBox.Text[0];
                    day += textBox.Text[1];
                    month += textBox.Text[3];
                    month += textBox.Text[4];
                    year += textBox.Text[6];
                    year += textBox.Text[7];
                    year += textBox.Text[8];
                    year += textBox.Text[9];
                    if (textBox.Text.Length == 16)
                    {
                        hour += textBox.Text[11];
                        hour += textBox.Text[12];
                        minute += textBox.Text[14];
                        minute += textBox.Text[15];
                    }
                    else
                    {
                        hour = "0";
                        minute = "0";
                    }
                    DateTime date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day), Convert.ToInt32(hour), Convert.ToInt32(minute), 0);
                    if (date < DateTime.Now)
                    {
                        MessageBox.Show("You wrote time in the past!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        time = date - DateTime.Now;

                    }
                }
                catch
                {
                    MessageBox.Show("Wrong input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void YearsCheckedChange(object sender, EventArgs e)
        {
            if (YearsButton.Checked && time != null)
            {
                ResultLabelShow((double)time.Value.TotalDays/365.25, "Yars"); // “ут така€ же ситуаци€, как и с мес€цем
            }
        }

        private void MonthsCheckedChange(object sender, EventArgs e)
        {
            if (MonthsButton.Checked && time != null)
            {
                ResultLabelShow((double)time.Value.TotalDays/30.4, "Months"); // я бы мог написать огромную кучу проверок на то какие именно мес€цы прошли (28-31 дней в мес€це), но не думаю что это обходимо. ƒелю на среднее число

            }
        }

        private void DaysCheckedChange(object sender, EventArgs e)
        {
            if (DaysButton.Checked && time != null)
            {
                ResultLabelShow((int)time.Value.TotalDays, "Days");

            }
        }

        private void MinutesCheckedChange(object sender, EventArgs e)
        {
            if (MinutesButton.Checked && time != null)
            {
                ResultLabelShow((int)time.Value.TotalMinutes, "minutes");
            }
        }
        private void SecondsCheckedChange(object sender, EventArgs e)
        {
            if (SecondsButton.Checked && time != null)
            {
                ResultLabelShow((int)time.Value.TotalSeconds, "seconds");
            }
        }
        private void ResultLabelShow(double number, string variable)
        {
            ResultLabel.Text = number.ToString() + " " + variable;
        }
    }
}