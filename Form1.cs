namespace Running_Button
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if((ModifierKeys & Keys.Control) == Keys.Control)
                {
                    Close();
                }
                string message;
                if (e.Location.X <= 11 && e.Location.Y >= 11 && e.Location.Y <= ClientSize.Height - 9 && e.Location.X >= 9)
                {
                    message = "You clicked at the border";
                }
                else if (e.Location.Y <= 11 && e.Location.X >=11 && e.Location.X <= ClientSize.Width - 9 && e.Location.Y >= 9)
                {
                    message = "You clicked at the border";
                }
                else if (e.Location.X >= ClientSize.Width - 11 && e.Location.Y >= 11 && e.Location.Y <= ClientSize.Height - 9 && e.Location.X <= ClientSize.Width - 9)
                {
                    message = "You clicked at the border";
                }
                else if (e.Location.Y <= ClientSize.Height - 9 && e.Location.X >= 11 && e.Location.X <= ClientSize.Width - 9 && e.Location.Y >= ClientSize.Height - 11)
                {
                    message = "You clicked at the border";
                }
                else if(e.Location.X>11 && e.Location.X< ClientSize.Width - 11 && e.Location.Y>11 && e.Location.Y < ClientSize.Height - 11)
                {
                    message = "You clicked inside of the area";
                }
                else
                {
                    message = "You clicked outside of the area";
                }

                MessageBox.Show(message, "Info");
            }
            else if (e.Button == MouseButtons.Right)
            {
                Text = "X: " + ClientSize.Width + " Y: " + ClientSize.Height;
                Thread.Sleep(1000);
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Text = "X: " +e.Location.X+ " Y: " + e.Location.Y;
        }
    }
}