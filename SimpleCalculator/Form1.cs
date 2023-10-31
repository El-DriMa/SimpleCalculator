namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
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

            switch (button.Text)
            {
                case "0": txtResult.Text += "0"; break;
                case "1": txtResult.Text += "1"; break;
                case "2": txtResult.Text += "2"; break;
                case "3": txtResult.Text += "3"; break;
                case "4": txtResult.Text += "4"; break;
                case "5": txtResult.Text += "5"; break;
                case "6": txtResult.Text += "6"; break;
                case "7": txtResult.Text += "7"; break;
                case "8": txtResult.Text += "8"; break;
                case "9": txtResult.Text += "9"; break;
                default: txtResult.Text = ""; break;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtResult.Text+= "+";
        }
    }
}