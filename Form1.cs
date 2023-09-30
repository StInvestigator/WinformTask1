namespace Running_Button
{
    public partial class Form1 : Form
    {
        double totalEarn = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void FuilSelectionChanged(object sender, EventArgs e)
        {
            if (comboBoxFuilChose.SelectedIndex == 0)
            {
                StaticFuilPrice.Text = "23,40";
            }
            else if (comboBoxFuilChose.SelectedIndex == 1)
            {
                StaticFuilPrice.Text = "54,90";
            }
            else if (comboBoxFuilChose.SelectedIndex == 2)
            {
                StaticFuilPrice.Text = "48,39";
            }
            else if (comboBoxFuilChose.SelectedIndex == 3)
            {
                StaticFuilPrice.Text = "45,15";
            }
            else if (comboBoxFuilChose.SelectedIndex == 4)
            {
                StaticFuilPrice.Text = "16,99";
            }
            if (TB_Volume.Text != "" || TotalFuilPrice.Text != "")
            {
                try
                {
                    if (TB_Volume.Text != "")
                    {
                        FuilLabel.Text = Math.Round(Convert.ToDouble(TB_Volume.Text) * Convert.ToDouble(StaticFuilPrice.Text), 2).ToString();
                    }
                    if (TotalFuilPrice.Text != "")
                    {
                        FuilLabel.Text = Math.Round(Convert.ToDouble(TotalFuilPrice.Text) / Convert.ToDouble(StaticFuilPrice.Text), 2).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Wrong input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TB_Volume.Text = "";
                }
            }
        }

        private void ValumeChecked(object sender, EventArgs e)
        {
            if (RB_Valume.Checked == true)
            {
                GB_Fuil.Text = "До сплати";
                FuilVorMoneyLabel.Text = "грн";
                FuilLabel.Text = "0,00";
                TotalFuilPrice.Enabled = false;
                TotalFuilPrice.Text = "";
                TB_Volume.Enabled = true;
            }
        }

        private void PriceChecked(object sender, EventArgs e)
        {
            if (RB_Sum.Checked == true)
            {
                GB_Fuil.Text = "Отримаєте палива";
                FuilVorMoneyLabel.Text = "л.";
                FuilLabel.Text = "0,00";
                TB_Volume.Enabled = false;
                TB_Volume.Text = "";
                TotalFuilPrice.Enabled = true;

            }
        }

        private void ValumeTextChanged(object sender, EventArgs e)
        {
            try
            {
                if (StaticFuilPrice.Text != "" && TB_Volume.Text != "")
                {
                    FuilLabel.Text = Math.Round(Convert.ToDouble(TB_Volume.Text) * Convert.ToDouble(StaticFuilPrice.Text), 2).ToString();
                }
                else if (TB_Volume.Text == "")
                {
                    FuilLabel.Text = "0,00";
                }
            }
            catch
            {
                MessageBox.Show("Wrong input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_Volume.Text = "";
            }
        }

        private void FuilPriceTextChanged(object sender, EventArgs e)
        {
            try
            {
                if (StaticFuilPrice.Text != "" && TotalFuilPrice.Text != "")
                {
                    FuilLabel.Text = Math.Round(Convert.ToDouble(TotalFuilPrice.Text) / Convert.ToDouble(StaticFuilPrice.Text), 2).ToString();
                }
                else if (TotalFuilPrice.Text == "")
                {
                    FuilLabel.Text = "0,00";
                }
            }
            catch
            {
                MessageBox.Show("Wrong input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TotalFuilPrice.Text = "";
            }
        }

        private void NUDValueChanged(object sender, EventArgs e)
        {
            CafePriceLabel.Text = Math.Round(Convert.ToDouble(NUD_Cola.Value * Convert.ToDecimal(Price_Cola.Text)
                + NUD_Hamburger.Value * Convert.ToDecimal(Price_Hamburger.Text)
                + NUD_HotDog.Value * Convert.ToDecimal(Price_HotDog.Text)
                + NUD_IceCream.Value * Convert.ToDecimal(Price_IceCream.Text)), 2).ToString();
        }

        private void GetSumClick(object sender, EventArgs e)
        {
            TotalSumLabel.Text = Math.Round(Convert.ToDouble(FuilLabel.Text) + Convert.ToDouble(CafePriceLabel.Text), 2).ToString();
            PayButton.Enabled = true;
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void OnPayClicked(object sender, EventArgs e)
        {
            totalEarn += Convert.ToDouble(TotalSumLabel.Text);
            Text = "Please wait...";
            Thread.Sleep(3000);
            Text = "Fuel Station";
            var answ = MessageBox.Show($"You earned {totalEarn} today\nContinue working?", "Cash Register", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answ == DialogResult.Yes)
            {
                Controls.Clear();
                InitializeComponent();
            }
            else if (answ == DialogResult.No)
            {
                Close();
            }
        }
    }
}