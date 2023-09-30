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
            Calendar = new MonthCalendar();
            textBox = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // Calendar
            // 
            Calendar.Location = new Point(555, 114);
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Location = new Point(201, 208);
            textBox.Name = "textBox";
            textBox.Size = new Size(299, 23);
            textBox.TabIndex = 1;
            textBox.TextChanged += TextBoxChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label.Location = new Point(201, 162);
            label.Name = "label";
            label.Size = new Size(299, 25);
            label.TabIndex = 2;
            label.Text = "Enter the date. Example: 15.01.1990";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(textBox);
            Controls.Add(Calendar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar Calendar;
        private TextBox textBox;
        private Label label;
    }
}