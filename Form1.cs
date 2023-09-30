namespace Running_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelMouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            if (Static.Location.X > Width / 2)
            {
                Static.Location = new Point(rand.Next(0+Static.Width+30, Width / 2),rand.Next(30+ Static.Height,Height- Static.Height-30));
            }
            else
            {
                Static.PointToScreen(Static.Location);
                Static.Location = new Point(rand.Next(Width/2, Width-Static.Width-30), rand.Next(30+ Static.Height,Height- Static.Height-30));
            }
        }
    }
}