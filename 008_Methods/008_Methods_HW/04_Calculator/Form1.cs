namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonDivide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            // Input values for X and Y
            string inputX = textBoxX.Text;
            string inputY = textBoxY.Text;

            if ((int.TryParse(inputX, out int numberX) && int.TryParse(inputY, out int numberY)))
            {
                if (radioButtonDivide.Checked)
                {
                    if (numberY == 0)
                    {
                        textBoxResult.Text = "You can't divide by 0";
                    }
                    else
                    {
                        textBoxResult.Text = ((double)numberX / numberY).ToString();
                    }
                }
                else if (radioButtonPower.Checked)
                {
                    textBoxResult.Text = (Math.Pow((double)numberX, numberY)).ToString();
                }
                else if (radioButtonConcatenate.Checked)
                {
                    textBoxResult.Text = numberX.ToString() + numberY.ToString();
                }
                else if (radioButtonModulo.Checked)
                {
                    if (numberY == 0)
                    {
                        textBoxResult.Text = "You can't divide by 0";
                    }
                    else
                    {
                        textBoxResult.Text = (numberX % numberY).ToString();
                    }
                }
                else
                {
                    textBoxResult.Text = ("Choose operation");
                }
            }
            else
            {
                textBoxResult.Text = "You should enter numbers";
            }
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPower_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonConcatenate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonModulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
