namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        decimal firstNumber = 0;
        string currentOperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        public void btnNumbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtResult.Text += button.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                firstNumber = Convert.ToDecimal(txtResult.Text);
                currentOperator = button.Text;
                txtResult.Text = "";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            decimal secondNumber = 0;
            if (!string.IsNullOrEmpty(txtResult.Text))
                secondNumber = Convert.ToDecimal(txtResult.Text);

            switch (currentOperator)
            {
                case "+":
                    txtResult.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    txtResult.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "X":
                    txtResult.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if(secondNumber != 0)
                    txtResult.Text = (firstNumber / secondNumber).ToString();
                    else
                    {
                        MessageBox.Show("You can't divide by zero!","DontBeDumb:)");
                        txtResult.Text = "";
                    }
                    break;
            }
        }

        private void btnEraseOne_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            txtResult.Text += ",";
        }
        private void btnWarning_Click(object sender, EventArgs e)
        {
            frmWarning frm = new frmWarning();
            frm.Show();
        }
    }
}
