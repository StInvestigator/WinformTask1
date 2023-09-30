namespace Running_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 10)
            {
                string day = "", month = "", year = "";
                try
                {
                    day += textBox.Text[0];
                    day += textBox.Text[1];
                    month += textBox.Text[3];
                    month += textBox.Text[4];
                    year += textBox.Text[6];
                    year += textBox.Text[7];
                    year += textBox.Text[8];
                    year += textBox.Text[9];
                    DateTime d = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
                    Calendar.TodayDate = d;
                    Calendar.SelectionStart = d;
                    Calendar.SelectionEnd = d;
                }
                catch
                {
                    MessageBox.Show("Wrong input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = "";
                }
            }
        }
    }
}