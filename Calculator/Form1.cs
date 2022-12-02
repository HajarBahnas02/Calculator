namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private String operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }
        private List<Button> buttons = new List<Button>();

        private void ZeroClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }
        private void btnOneclick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void btnTowClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }
    

        private void btnThreeClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }
        private void btnFourClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void btnFiveClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        
    }

        private void btnSixClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void btnSevenClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void btnEightClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void btnNineClick(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }
        private void PlusClick(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "+";
            label.Text = valueFirst.ToString()   +   "+"    ;
        }       

        private void Cclick(object sender, EventArgs e)
        {
            this.textBox.Text = string.Empty;
        }

        private void CommaClick(object sender, EventArgs e)
        {
            if (! textBox.Text.Contains(","))
            {
                textBox.Text += ",";
            }
            
        }

        private void MoinsClick(object sender, EventArgs e)
        {
          valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "-";
            label.Text = valueFirst.ToString()  +   "-";
        }

        private void ProdClick(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "*";
            label.Text = valueFirst.ToString()   +   "*";
        }

        private void DivClick(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "/";
            label.Text = valueFirst.ToString()   +   "/";
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
           
            switch (operators)
            {
                case "+":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result=valueFirst+ valueSecond;
                    textBox.Text = Result.ToString(); 
                  
             
                    break;
                case "-":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result = valueFirst - valueSecond;
                    textBox.Text = Result.ToString(); break;
                case "*":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result = valueFirst * valueSecond;
                    textBox.Text = Result.ToString(); break;
                case "/":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result = valueFirst / valueSecond;
                    textBox.Text = Result.ToString(); break;
                default:
                    break;

            }
            label.Text = label.Text   +   valueSecond.ToString()   + "=";

        }

        private void SigneMoins(object sender, EventArgs e)
        {
            if( textBox.Text.Contains("-"))
            {
                textBox.Text = textBox.Text + "-";

            }
            else
            {
                textBox.Text= "-" +textBox.Text;
            }
        }

        private void mdlbtn(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);    
            textBox.Clear();
            operators = "%";

            label.Text = valueFirst.ToString() +"%";
        }

        private void form_Calcul_KeyPress(object sender, KeyPressEventArgs e)
        {
 
                foreach (Button button in buttons)
                {
                    if (char.ToString(e.KeyChar) == button.Text)
                    {
                        button.PerformClick();
                    }

                }
            if (char.ToString(e.KeyChar) == "c")
            {
                btnC.PerformClick();
            }
          
        }
    }
}