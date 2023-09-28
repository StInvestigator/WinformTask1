namespace Running_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что Вы так !");
        }

        private void mouseRun(object sender, MouseEventArgs e)
        {
            buttonNo.Top -= e.Y;
            buttonNo.Left -= e.Y;
            if (buttonNo.Top < -10 || buttonNo.Top > 100) buttonNo.Top = 60;
            if (buttonNo.Left < -80 || buttonNo.Left > 250) buttonNo.Left = 120;
        }
    }
}