namespace Calculator
{
    public partial class Calculator : Form
    {
        char op;
        Double resultValue = 0;
        String operatuionPerformed = "";
        public Calculator()
        {
            InitializeComponent();
        }
        private void ZeroClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "0";
        }
        private void btnOneclick(object sender, EventArgs e)
        {
            textBoxInput.Text= textBoxInput.Text+ "1"; 
        }

        private void btnTowClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text+ "2";
        }

        private void btnThreeClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "3";
        }

        private void btnFourClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "4";
        }

        private void btnFiveClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "5";
        }

        private void btnSixClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "6";
        }

        private void btnSevenClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "7";
        }

        private void btnEightClick(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "8";
        }

        private void btnNineClick(object sender, EventArgs e)
        {
            textBoxInput.Text += textBoxInput.Text + "9";
        }
        private void PlusClick(object sender, EventArgs e)
        {
            textBoxInput.Text +=  '+';
            op = '+';
        }


        private void CEclick(object sender, EventArgs e)
        {
            this.textBoxInput.Text = string.Empty;   
        }

        private void Cclick(object sender, EventArgs e)
        {
            this.textBoxInput.Text = string.Empty;
        }

        private void CommaClick(object sender, EventArgs e)
        {
            textBoxInput.Text +=".";
            
        }

        private void resultClick(object sender, EventArgs e)
        {

        }

        private void MoinsClick(object sender, EventArgs e)
        {
            textBoxInput.Text +="-";
            op = '-';

        }

        private void ProdClick(object sender, EventArgs e)
        {
            textBoxInput.Text +=  "*";
            op = '*';
        }

        private void DivClick(object sender, EventArgs e)
        {
            textBoxInput.Text += "/";
            op = '/';
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            double resultat = 0;
            String[] operation = textBoxInput.Text.Split(op);
            switch (operatuionPerformed)
            {
                case "+":
                    textBoxInput.Text = (resultat + Double.Parse(textBoxInput.Text)).ToString();
                    break;
                case "-":
                    textBoxInput.Text = (resultat - Double.Parse(textBoxInput.Text)).ToString();
                    break;
                case "*":
                    textBoxInput.Text = (resultat * Double.Parse(textBoxInput.Text)).ToString();
                    break;
                case "/":
                    textBoxInput.Text = (resultat / Double.Parse(textBoxInput.Text)).ToString();
                    break;
                default:
                    break;
            }

        }

        private void SigneMoins(object sender, EventArgs e)
        {
            int longeur=textBoxInput.Text.Length-1;
            String texte = textBoxInput.Text;
            textBoxInput.Text = "";
            for(int i=0;i<longeur;i++)
            {
                textBoxInput.Text+= texte[i];
            }
        }

    }
}