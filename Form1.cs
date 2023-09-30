using System;
using System.DirectoryServices.ActiveDirectory;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Running_Button
{
    public partial class Form1 : Form
    {
        int X;
        int Y;
        int staticCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                X = e.Location.X;
                Y = e.Location.Y;
            }
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            int localX = e.Location.X;
            int localY = e.Location.Y;
            if (localX < X) { int tmp = X; X = localX; localX = tmp; }
            if (localY < Y) { int tmp = Y; Y = localY; localY = tmp; }
            if (e.Button == MouseButtons.Left)
            {
                if(localX - X<10 || localY - Y < 10)
                {
                    MessageBox.Show("Minimum Static`s size is 10x10!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Label Label = new Label();
                Label.Location = new Point(X, Y);
                Label.Size = new Size(localX - X, localY - Y);
                Label.Text = (++staticCount).ToString();
                Label.MouseClick += LabelRightMouseButtonClick;
                Label.MouseDoubleClick += LabelLeftMouseButtonDoubleClick;
                List<Color> Colors = typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
                                .Select(c => (Color)c.GetValue(null, null))
                                .ToList();
                Random random = new Random(DateTime.Now.Millisecond);
                Label.BackColor = Colors[random.Next(Colors.Count - 1)];
                Label.ForeColor = Colors[random.Next(Colors.Count - 1)];
                Controls.Add(Label);
            }
        }
        private void LabelRightMouseButtonClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                foreach (Label but in Controls)
                {
                    Point butXY = but.PointToScreen(new Point());
                    if (MousePosition.X > butXY.X && MousePosition.X < butXY.X + but.Width && MousePosition.Y > butXY.Y && MousePosition.Y < butXY.Y + but.Height)
                    {
                        Text = "S = " + (but.Height * but.Width).ToString() + "   X: " + but.Location.X.ToString() +" Y: " + but.Location.Y.ToString();
                    }
                }
            }
        }
        private void LabelLeftMouseButtonDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label but in Controls)
                {
                    Point butXY = but.PointToScreen(new Point());
                    if (MousePosition.X > butXY.X && MousePosition.X < butXY.X + but.Width && MousePosition.Y > butXY.Y && MousePosition.Y < butXY.Y + but.Height)
                    {
                        Controls.Remove(but);
                        but.MouseClick -= LabelRightMouseButtonClick;
                        but.MouseDoubleClick += LabelLeftMouseButtonDoubleClick;
                        return;
                    }
                }
            }
        }
    }
}