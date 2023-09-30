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
            label1 = new Label();
            textBox = new TextBox();
            YearsButton = new RadioButton();
            MonthsButton = new RadioButton();
            DaysButton = new RadioButton();
            MinutesButton = new RadioButton();
            SecondsButton = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            ResultLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter the date in the future.";
            // 
            // textBox
            // 
            textBox.Location = new Point(104, 102);
            textBox.Name = "textBox";
            textBox.Size = new Size(436, 23);
            textBox.TabIndex = 1;
            textBox.TextChanged += TextChanged;
            // 
            // YearsButton
            // 
            YearsButton.AutoSize = true;
            YearsButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            YearsButton.Location = new Point(104, 226);
            YearsButton.Name = "YearsButton";
            YearsButton.Size = new Size(75, 29);
            YearsButton.TabIndex = 2;
            YearsButton.TabStop = true;
            YearsButton.Text = "Years";
            YearsButton.UseVisualStyleBackColor = true;
            YearsButton.CheckedChanged += YearsCheckedChange;
            // 
            // MonthsButton
            // 
            MonthsButton.AutoSize = true;
            MonthsButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            MonthsButton.Location = new Point(185, 226);
            MonthsButton.Name = "MonthsButton";
            MonthsButton.Size = new Size(92, 29);
            MonthsButton.TabIndex = 3;
            MonthsButton.TabStop = true;
            MonthsButton.Text = "Months";
            MonthsButton.UseVisualStyleBackColor = true;
            MonthsButton.CheckedChanged += MonthsCheckedChange;
            // 
            // DaysButton
            // 
            DaysButton.AutoSize = true;
            DaysButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            DaysButton.Location = new Point(283, 226);
            DaysButton.Name = "DaysButton";
            DaysButton.Size = new Size(71, 29);
            DaysButton.TabIndex = 4;
            DaysButton.TabStop = true;
            DaysButton.Text = "Days";
            DaysButton.UseVisualStyleBackColor = true;
            DaysButton.CheckedChanged += DaysCheckedChange;
            // 
            // MinutesButton
            // 
            MinutesButton.AutoSize = true;
            MinutesButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            MinutesButton.Location = new Point(360, 226);
            MinutesButton.Name = "MinutesButton";
            MinutesButton.Size = new Size(96, 29);
            MinutesButton.TabIndex = 5;
            MinutesButton.TabStop = true;
            MinutesButton.Text = "Minutes";
            MinutesButton.UseVisualStyleBackColor = true;
            MinutesButton.CheckedChanged += MinutesCheckedChange;
            // 
            // SecondsButton
            // 
            SecondsButton.AutoSize = true;
            SecondsButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            SecondsButton.Location = new Point(462, 226);
            SecondsButton.Name = "SecondsButton";
            SecondsButton.Size = new Size(95, 29);
            SecondsButton.TabIndex = 6;
            SecondsButton.TabStop = true;
            SecondsButton.Text = "Seconds";
            SecondsButton.UseVisualStyleBackColor = true;
            SecondsButton.CheckedChanged += SecondsCheckedChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(104, 171);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 7;
            label2.Text = "Show the result in:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(104, 292);
            label3.Name = "label3";
            label3.Size = new Size(292, 32);
            label3.TabIndex = 8;
            label3.Text = "Left until the selected date:";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            ResultLabel.Location = new Point(104, 350);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(76, 32);
            ResultLabel.TabIndex = 9;
            ResultLabel.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(104, 56);
            label4.Name = "label4";
            label4.Size = new Size(590, 32);
            label4.TabIndex = 10;
            label4.Text = "Example: 15.01.1990 15:30 (hours:minutes are optional)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(ResultLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SecondsButton);
            Controls.Add(MinutesButton);
            Controls.Add(DaysButton);
            Controls.Add(MonthsButton);
            Controls.Add(YearsButton);
            Controls.Add(textBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private RadioButton YearsButton;
        private RadioButton MonthsButton;
        private RadioButton DaysButton;
        private RadioButton MinutesButton;
        private RadioButton SecondsButton;
        private Label label2;
        private Label label3;
        private Label ResultLabel;
        private Label label4;
    }
}