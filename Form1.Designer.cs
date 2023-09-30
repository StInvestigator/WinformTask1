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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            TotalFuilPrice = new TextBox();
            TB_Volume = new TextBox();
            groupBox8 = new GroupBox();
            RB_Sum = new RadioButton();
            RB_Valume = new RadioButton();
            GB_Fuil = new GroupBox();
            FuilLabel = new Label();
            FuilVorMoneyLabel = new Label();
            label4 = new Label();
            StaticFuilPrice = new TextBox();
            label3 = new Label();
            label1 = new Label();
            comboBoxFuilChose = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            Price_Cola = new TextBox();
            Price_Hamburger = new TextBox();
            Price_HotDog = new TextBox();
            Price_IceCream = new TextBox();
            NUD_Cola = new NumericUpDown();
            NUD_Hamburger = new NumericUpDown();
            NUD_HotDog = new NumericUpDown();
            NUD_IceCream = new NumericUpDown();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            GB_Cafe = new GroupBox();
            CafePriceLabel = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            CancelButton = new Button();
            groupBox6 = new GroupBox();
            TotalSumLabel = new Label();
            label2 = new Label();
            PayButton = new Button();
            GetSumButton = new Button();
            groupBox1.SuspendLayout();
            groupBox8.SuspendLayout();
            GB_Fuil.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Cola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Hamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_HotDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_IceCream).BeginInit();
            GB_Cafe.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TotalFuilPrice);
            groupBox1.Controls.Add(TB_Volume);
            groupBox1.Controls.Add(groupBox8);
            groupBox1.Controls.Add(GB_Fuil);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(StaticFuilPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxFuilChose);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 465);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(329, 247);
            label6.Name = "label6";
            label6.Size = new Size(26, 25);
            label6.TabIndex = 11;
            label6.Text = "л.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(327, 299);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 10;
            label5.Text = "грн";
            // 
            // TotalFuilPrice
            // 
            TotalFuilPrice.Enabled = false;
            TotalFuilPrice.Location = new Point(180, 289);
            TotalFuilPrice.Name = "TotalFuilPrice";
            TotalFuilPrice.Size = new Size(143, 35);
            TotalFuilPrice.TabIndex = 9;
            TotalFuilPrice.TextChanged += FuilPriceTextChanged;
            // 
            // TB_Volume
            // 
            TB_Volume.Enabled = false;
            TB_Volume.Location = new Point(180, 237);
            TB_Volume.Name = "TB_Volume";
            TB_Volume.Size = new Size(143, 35);
            TB_Volume.TabIndex = 8;
            TB_Volume.TextChanged += ValumeTextChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(RB_Sum);
            groupBox8.Controls.Add(RB_Valume);
            groupBox8.Location = new Point(25, 215);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(149, 109);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            // 
            // RB_Sum
            // 
            RB_Sum.AutoSize = true;
            RB_Sum.Location = new Point(28, 63);
            RB_Sum.Name = "RB_Sum";
            RB_Sum.Size = new Size(80, 34);
            RB_Sum.TabIndex = 9;
            RB_Sum.TabStop = true;
            RB_Sum.Text = "Сума";
            RB_Sum.UseVisualStyleBackColor = true;
            RB_Sum.CheckedChanged += PriceChecked;
            // 
            // RB_Valume
            // 
            RB_Valume.AutoSize = true;
            RB_Valume.Location = new Point(28, 23);
            RB_Valume.Name = "RB_Valume";
            RB_Valume.Size = new Size(87, 34);
            RB_Valume.TabIndex = 8;
            RB_Valume.TabStop = true;
            RB_Valume.Text = "Об'єм";
            RB_Valume.UseVisualStyleBackColor = true;
            RB_Valume.CheckedChanged += ValumeChecked;
            // 
            // GB_Fuil
            // 
            GB_Fuil.Controls.Add(FuilLabel);
            GB_Fuil.Controls.Add(FuilVorMoneyLabel);
            GB_Fuil.Location = new Point(53, 342);
            GB_Fuil.Name = "GB_Fuil";
            GB_Fuil.Size = new Size(270, 117);
            GB_Fuil.TabIndex = 6;
            GB_Fuil.TabStop = false;
            GB_Fuil.Text = "До сплати";
            // 
            // FuilLabel
            // 
            FuilLabel.AutoSize = true;
            FuilLabel.Font = new Font("Segoe UI", 32.25F, FontStyle.Italic, GraphicsUnit.Point);
            FuilLabel.Location = new Point(49, 43);
            FuilLabel.Name = "FuilLabel";
            FuilLabel.Size = new Size(103, 59);
            FuilLabel.TabIndex = 14;
            FuilLabel.Text = "0,00";
            // 
            // FuilVorMoneyLabel
            // 
            FuilVorMoneyLabel.AutoSize = true;
            FuilVorMoneyLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            FuilVorMoneyLabel.Location = new Point(223, 77);
            FuilVorMoneyLabel.Name = "FuilVorMoneyLabel";
            FuilVorMoneyLabel.Size = new Size(41, 25);
            FuilVorMoneyLabel.TabIndex = 12;
            FuilVorMoneyLabel.Text = "грн";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(327, 155);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 5;
            label4.Text = "грн";
            // 
            // StaticFuilPrice
            // 
            StaticFuilPrice.Enabled = false;
            StaticFuilPrice.Location = new Point(136, 145);
            StaticFuilPrice.Name = "StaticFuilPrice";
            StaticFuilPrice.Size = new Size(187, 35);
            StaticFuilPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 145);
            label3.Name = "label3";
            label3.Size = new Size(56, 30);
            label3.TabIndex = 4;
            label3.Text = "Ціна";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 59);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 3;
            label1.Text = "Паливо";
            // 
            // comboBoxFuilChose
            // 
            comboBoxFuilChose.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFuilChose.Items.AddRange(new object[] { "Газ", "А-95", "А-92", "А-80", "Дизель" });
            comboBoxFuilChose.Location = new Point(136, 51);
            comboBoxFuilChose.Name = "comboBoxFuilChose";
            comboBoxFuilChose.Size = new Size(187, 38);
            comboBoxFuilChose.TabIndex = 2;
            comboBoxFuilChose.SelectedValueChanged += FuilSelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(392, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Price_Cola);
            groupBox3.Controls.Add(Price_Hamburger);
            groupBox3.Controls.Add(Price_HotDog);
            groupBox3.Controls.Add(Price_IceCream);
            groupBox3.Controls.Add(NUD_Cola);
            groupBox3.Controls.Add(NUD_Hamburger);
            groupBox3.Controls.Add(NUD_HotDog);
            groupBox3.Controls.Add(NUD_IceCream);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(GB_Cafe);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(403, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 465);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Міні-кафе";
            // 
            // Price_Cola
            // 
            Price_Cola.Enabled = false;
            Price_Cola.Location = new Point(150, 259);
            Price_Cola.Name = "Price_Cola";
            Price_Cola.Size = new Size(97, 35);
            Price_Cola.TabIndex = 23;
            Price_Cola.Text = "16,19";
            // 
            // Price_Hamburger
            // 
            Price_Hamburger.Enabled = false;
            Price_Hamburger.Location = new Point(150, 205);
            Price_Hamburger.Name = "Price_Hamburger";
            Price_Hamburger.Size = new Size(97, 35);
            Price_Hamburger.TabIndex = 22;
            Price_Hamburger.Text = "20,00";
            // 
            // Price_HotDog
            // 
            Price_HotDog.Enabled = false;
            Price_HotDog.Location = new Point(150, 155);
            Price_HotDog.Name = "Price_HotDog";
            Price_HotDog.Size = new Size(97, 35);
            Price_HotDog.TabIndex = 21;
            Price_HotDog.Text = "21,50";
            // 
            // Price_IceCream
            // 
            Price_IceCream.Enabled = false;
            Price_IceCream.Location = new Point(150, 111);
            Price_IceCream.Name = "Price_IceCream";
            Price_IceCream.Size = new Size(97, 35);
            Price_IceCream.TabIndex = 20;
            Price_IceCream.Text = "15,99";
            // 
            // NUD_Cola
            // 
            NUD_Cola.Location = new Point(264, 259);
            NUD_Cola.Name = "NUD_Cola";
            NUD_Cola.Size = new Size(106, 35);
            NUD_Cola.TabIndex = 19;
            NUD_Cola.ValueChanged += NUDValueChanged;
            // 
            // NUD_Hamburger
            // 
            NUD_Hamburger.Location = new Point(264, 205);
            NUD_Hamburger.Name = "NUD_Hamburger";
            NUD_Hamburger.Size = new Size(106, 35);
            NUD_Hamburger.TabIndex = 18;
            NUD_Hamburger.ValueChanged += NUDValueChanged;
            // 
            // NUD_HotDog
            // 
            NUD_HotDog.Location = new Point(264, 155);
            NUD_HotDog.Name = "NUD_HotDog";
            NUD_HotDog.Size = new Size(106, 35);
            NUD_HotDog.TabIndex = 17;
            NUD_HotDog.ValueChanged += NUDValueChanged;
            // 
            // NUD_IceCream
            // 
            NUD_IceCream.Location = new Point(264, 106);
            NUD_IceCream.Name = "NUD_IceCream";
            NUD_IceCream.Size = new Size(106, 35);
            NUD_IceCream.TabIndex = 16;
            NUD_IceCream.ValueChanged += NUDValueChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(27, 262);
            label17.Name = "label17";
            label17.Size = new Size(59, 30);
            label17.TabIndex = 15;
            label17.Text = "Кола";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 210);
            label16.Name = "label16";
            label16.Size = new Size(111, 30);
            label16.TabIndex = 14;
            label16.Text = "Гамбургер";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 160);
            label15.Name = "label15";
            label15.Size = new Size(94, 30);
            label15.TabIndex = 13;
            label15.Text = "Хот-дог";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 111);
            label14.Name = "label14";
            label14.Size = new Size(106, 30);
            label14.TabIndex = 12;
            label14.Text = "Морозиво";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(264, 36);
            label13.Name = "label13";
            label13.Size = new Size(106, 30);
            label13.TabIndex = 10;
            label13.Text = "Кількість";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(172, 36);
            label12.Name = "label12";
            label12.Size = new Size(56, 30);
            label12.TabIndex = 9;
            label12.Text = "Ціна";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 36);
            label11.Name = "label11";
            label11.Size = new Size(87, 30);
            label11.TabIndex = 8;
            label11.Text = "Позиція";
            // 
            // GB_Cafe
            // 
            GB_Cafe.Controls.Add(CafePriceLabel);
            GB_Cafe.Controls.Add(label8);
            GB_Cafe.Location = new Point(59, 342);
            GB_Cafe.Name = "GB_Cafe";
            GB_Cafe.Size = new Size(270, 117);
            GB_Cafe.TabIndex = 7;
            GB_Cafe.TabStop = false;
            GB_Cafe.Text = "До сплати";
            // 
            // CafePriceLabel
            // 
            CafePriceLabel.AutoSize = true;
            CafePriceLabel.Font = new Font("Segoe UI", 32.25F, FontStyle.Italic, GraphicsUnit.Point);
            CafePriceLabel.Location = new Point(50, 43);
            CafePriceLabel.Name = "CafePriceLabel";
            CafePriceLabel.Size = new Size(103, 59);
            CafePriceLabel.TabIndex = 5;
            CafePriceLabel.Text = "0,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(223, 77);
            label8.Name = "label8";
            label8.Size = new Size(41, 25);
            label8.TabIndex = 13;
            label8.Text = "грн";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(392, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(390, 267);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(CancelButton);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Controls.Add(PayButton);
            groupBox5.Controls.Add(GetSumButton);
            groupBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox5.Location = new Point(11, 483);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(768, 181);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Загальна сума до сплати";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.IndianRed;
            CancelButton.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            CancelButton.Location = new Point(6, 58);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(86, 80);
            CancelButton.TabIndex = 24;
            CancelButton.Text = "Відміна";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelClicked;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(TotalSumLabel);
            groupBox6.Controls.Add(label2);
            groupBox6.Location = new Point(451, 34);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(270, 115);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // TotalSumLabel
            // 
            TotalSumLabel.AutoSize = true;
            TotalSumLabel.Font = new Font("Segoe UI", 36F, FontStyle.Italic, GraphicsUnit.Point);
            TotalSumLabel.Location = new Point(37, 39);
            TotalSumLabel.Name = "TotalSumLabel";
            TotalSumLabel.Size = new Size(116, 65);
            TotalSumLabel.TabIndex = 3;
            TotalSumLabel.Text = "0,00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 74);
            label2.Name = "label2";
            label2.Size = new Size(45, 30);
            label2.TabIndex = 4;
            label2.Text = "грн";
            // 
            // PayButton
            // 
            PayButton.BackColor = SystemColors.GradientActiveCaption;
            PayButton.Enabled = false;
            PayButton.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point);
            PayButton.Location = new Point(266, 58);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(162, 81);
            PayButton.TabIndex = 1;
            PayButton.Text = "Сплатити";
            PayButton.UseVisualStyleBackColor = false;
            PayButton.Click += OnPayClicked;
            // 
            // GetSumButton
            // 
            GetSumButton.BackColor = SystemColors.Info;
            GetSumButton.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            GetSumButton.Location = new Point(98, 58);
            GetSumButton.Name = "GetSumButton";
            GetSumButton.Size = new Size(162, 81);
            GetSumButton.TabIndex = 0;
            GetSumButton.Text = "Видати суму";
            GetSumButton.UseVisualStyleBackColor = false;
            GetSumButton.Click += GetSumClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 693);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Fuel Station";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            GB_Fuil.ResumeLayout(false);
            GB_Fuil.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Cola).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Hamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_HotDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_IceCream).EndInit();
            GB_Cafe.ResumeLayout(false);
            GB_Cafe.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label TotalSumLabel;
        private Button PayButton;
        private Button GetSumButton;
        private ComboBox comboBoxFuilChose;
        private GroupBox groupBox8;
        private RadioButton RB_Sum;
        private RadioButton RB_Valume;
        private GroupBox GB_Fuil;
        private Label label4;
        private TextBox StaticFuilPrice;
        private Label label3;
        private Label label1;
        private GroupBox GB_Cafe;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox TotalFuilPrice;
        private TextBox TB_Volume;
        private Label FuilLabel;
        private Label FuilVorMoneyLabel;
        private Label CafePriceLabel;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label11;
        private NumericUpDown NUD_IceCream;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox Price_Cola;
        private TextBox Price_Hamburger;
        private TextBox Price_HotDog;
        private TextBox Price_IceCream;
        private NumericUpDown NUD_Cola;
        private NumericUpDown NUD_Hamburger;
        private NumericUpDown NUD_HotDog;
        private GroupBox groupBox6;
        private Button CancelButton;
    }
}