namespace Running_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int iter = 0,min = 1, max = 2000;
            DialogResult answ;
            do
            {
                answ = MessageBox.Show("Your number is " + (min+max)/2 + "?\nYes - It`s your number\nNo - Your number is lower\nCancel - Your number is bigger", ++iter + "# try", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(answ == DialogResult.No)
                {
                    max = (min + max) / 2;
                }
                if (answ == DialogResult.Cancel)
                {
                    min = (min + max) / 2;
                }
            } while (answ != DialogResult.Yes);
            MessageBox.Show("I won! It took me " + iter + " tries!", "End", MessageBoxButtons.OK);
        }
    }
}