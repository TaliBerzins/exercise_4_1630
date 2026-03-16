namespace exercise_4_1630
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(purchasePricetxt.Text))
            {
                MessageBox.Show("Please enter a value in the purchasePrice txt box before continuing.");

                purchasePricetxt.BackColor = Color.LightSalmon;
                return;
            }
            if (string.IsNullOrWhiteSpace(down_payment_txt.Text))
            {
                MessageBox.Show("Please enter a value in the downPayment txt box before continuing.");

                purchasePricetxt.BackColor = Color.LightSalmon;
                return;
            }
            if (string.IsNullOrWhiteSpace(intRateTxt.Text))
            {
                MessageBox.Show("Please enter a value in the intRate txt box before continuing.");

                purchasePricetxt.BackColor = Color.LightSalmon;
                return;
            }
            if (string.IsNullOrWhiteSpace(loanTermTxt.Text))
            {
                MessageBox.Show("Please enter a value in the loanTerm txt box before continuing.");

                purchasePricetxt.BackColor = Color.LightSalmon;
                return;
            }
            try
            {
                // Attempt to convert the textbox value to decimal
                decimal value = Convert.ToDecimal(purchasePricetxt.Text);
                purchasePricetxt.BackColor = Color.White;

                // Continue with normal logic...
            }
            catch (FormatException)
            {
                purchasePricetxt.BackColor = Color.LightSalmon;
                MessageBox.Show("Please enter a valid decimal number for the purchasePrice txtbox.",
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
            try
            {
                // Attempt to convert the textbox value to decimal
                decimal downPayment = Convert.ToDecimal(down_payment_txt.Text);
                down_payment_txt.BackColor = Color.White;

                // Continue with normal logic...
            }
            catch (FormatException)
            {
                down_payment_txt.BackColor = Color.LightSalmon;
                MessageBox.Show("Please enter a valid decimal number for the down payment textbox on the left.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            try
            {
                // Attempt to convert the textbox value to decimal
                decimal downPayment = Convert.ToDecimal(intRateTxt.Text);

                // Continue with normal logic...
            }
            catch (FormatException)
            {
                intRateTxt.BackColor = Color.LightSalmon;
                MessageBox.Show("Please enter a valid decimal number for the interest rate textbox on the left.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            try
            {
                // Attempt to convert the textbox value to decimal
                decimal downPayment = Convert.ToDecimal(loanTermTxt.Text);
                // Continue with normal logic...
            }
            catch (FormatException)
            {
                loanTermTxt.BackColor = Color.LightSalmon;
                MessageBox.Show("Please enter a valid decimal number for the loan term textbox on the left.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }



            decimal amtFinance = (Convert.ToDecimal(purchasePricetxt.Text)) - (Convert.ToDecimal(down_payment_txt.Text));
            amtFinanceTxt.Text = amtFinance.ToString("C");
            decimal interestRate = (Convert.ToDecimal(intRateTxt.Text)) / 100 / 12;
            double numOfMonths = Convert.ToDouble(loanTermTxt.Text);
            double intRateDouble = Convert.ToDouble(interestRate);
            decimal numerator = Convert.ToDecimal(Math.Pow((1 + intRateDouble), numOfMonths));
            decimal denominator = Convert.ToDecimal(Math.Pow((1 + intRateDouble), numOfMonths) - 1);
            decimal monPayment = interestRate * amtFinance * (numerator / denominator);
            monPaymentTxt.Text = monPayment.ToString("C");
            purchasePricetxt.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SendToBack();
        }
    }
}
