namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double x1;
        double x2;
        double res;
        bool newNumber;
        string oper;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(Disp.Text);
            oper = btnPlus.Text;
            newNumber = true;

        }

        private void button7_Click(object sender, EventArgs e)
        { 
            x1 = Convert.ToDouble(Disp.Text);
            oper = btnMul.Text;
            newNumber = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
;
            Disp.Text += 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 8;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Click += buttonC_Click; 

            {
                Disp.Clear();
                newNumber = true;
            }
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 5;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                Disp.Clear();
                newNumber = false;
            }
            Disp.Text += 9;
        }

        private void Disp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(Disp.Text);
            oper = btnMinus.Text;
            newNumber = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(Disp.Text);
            oper = btnDiv.Text;
            newNumber = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x2 = Convert.ToDouble(Disp.Text);
            if ( oper=="+")
            {
                res = x1 + x2;
            }
            {
                if ( oper== "-")
                {
                    res = x1 - x2;
                }
                {
                    if ( oper == "*")
                    {
                        res = x1 * x2;
                    }
                    {
                        if ( oper == "/")
                        {
                            res = x1 / x2;
                        }
                        Disp.Text = Convert.ToString(res);
                        newNumber = true;
                    }                  
                }               
            }           
        }
    }
}