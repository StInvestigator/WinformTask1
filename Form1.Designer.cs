namespace Running_Button
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Static = new Label();
            SuspendLayout();
            // 
            // Static
            // 
            Static.AutoSize = true;
            Static.BackColor = SystemColors.ControlText;
            Static.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point);
            Static.ForeColor = Color.Snow;
            Static.Location = new Point(340, 176);
            Static.Name = "Static";
            Static.Size = new Size(95, 45);
            Static.TabIndex = 0;
            Static.Text = "Static";
            Static.MouseMove += LabelMouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Static);
            Name = "Form1";
            Text = "Running Static";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Static;
    }
}