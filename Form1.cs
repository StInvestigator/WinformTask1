namespace Running_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowResume(object sender, EventArgs e)
        {
            string f = "My name is Vlad", s = "I`m sixteen", t = "Its my first hometask";
            MessageBox.Show(f);
            MessageBox.Show(s);
            MessageBox.Show(t);
            MessageBox.Show("Average string length is " + ((f.Length+s.Length+t.Length)/3).ToString());
        }
    }
}