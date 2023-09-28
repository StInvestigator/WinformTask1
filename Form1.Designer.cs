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
            buttonNo = new Button();
            buttonYes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 123);
            label1.Name = "label1";
            label1.Size = new Size(527, 40);
            label1.TabIndex = 0;
            label1.Text = "Вы довольны своей зарплатой?";
            // 
            // buttonNo
            // 
            buttonNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonNo.AutoSize = true;
            buttonNo.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNo.Location = new Point(134, 252);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(181, 82);
            buttonNo.TabIndex = 1;
            buttonNo.Text = "Нет";
            buttonNo.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            buttonYes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonYes.AutoSize = true;
            buttonYes.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonYes.Location = new Point(496, 248);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(181, 82);
            buttonYes.TabIndex = 2;
            buttonYes.Text = "Да";
            buttonYes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonYes);
            Controls.Add(buttonNo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonNo;
        private Button buttonYes;
    }
}