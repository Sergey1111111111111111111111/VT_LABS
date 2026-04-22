namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PerformCalculation(string operation)
        {

            lblResult.ForeColor = Color.Black;

            try
            {
                double num1 = double.Parse(txtFirstNumber.Text);
                double num2 = double.Parse(txtSecondNumber.Text);
                double result = 0;

                switch (operation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":

                        if (num2 == 0)
                        {
                            ShowError("Ошибка: Деление на 0!");
                            return;
                        }
                        result = num1 / num2;
                        break;
                }

                lblResult.Text = result.ToString();
                lblResult.ForeColor = Color.Green;
            }
            catch (FormatException)
            {
                // Ошибка ввода (буквы или пустота)
                ShowError("Ошибка: Введите числа!");
            }
            catch (Exception ex)
            {
                // Любая другая системная ошибка
                ShowError("Ошибка: " + ex.Message);
            }
        }

        private void ShowError(string message)
        {
            lblResult.Text = message;
            lblResult.ForeColor = Color.Red;
        }

        private void btnAdd_Click(object sender, EventArgs e) => PerformCalculation("+");
        private void btnSub_Click(object sender, EventArgs e) => PerformCalculation("-");
        private void btnMul_Click(object sender, EventArgs e) => PerformCalculation("*");
        private void btnDiv_Click(object sender, EventArgs e) => PerformCalculation("/");

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            lblResult.Text = "0";
            lblResult.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}
