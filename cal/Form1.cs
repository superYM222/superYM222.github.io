using System.Drawing.Text;

namespace cal
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        private double doubleResult = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStandard.Checked)
            {
                this.tabPage1.Size = new System.Drawing.Size(587, 540);
                this.tabCalculator.Size = new System.Drawing.Size(587, 540);
                this.ClientSize = new System.Drawing.Size(587, 540);
                this.txtBox.Size = new System.Drawing.Size(536, 77);
                this.btnClear.Size = new System.Drawing.Size(254, 80);
                this.btnEqual.Location = new System.Drawing.Point(475, 236);
                this.btnEqual.Size = new System.Drawing.Size(80, 250);
                this.btnPI.Visible = false;
                this.btnSine.Visible = false;
                this.btnCosine.Visible = false;
                this.btnFactorial.Visible = false;

            }
            else
            {
                this.btnPI.Visible = true;
                this.btnSine.Visible = true;
                this.btnCosine.Visible = true;
                this.btnFactorial.Visible = true;

            }
        }
        private void rdbScientific_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbScientific.Checked)
            {
                this.tabCalculator.Size = new System.Drawing.Size(669, 526);
                this.btnPI.Visible = true;
                this.btnSine.Visible = true;
                this.btnCosine.Visible = true;
                this.btnFactorial.Visible = true;
                this.txtBox.Size = new System.Drawing.Size(620, 77);
                this.tabPage1.Size = new System.Drawing.Size(669, 526);
                this.btnClear.Size = new System.Drawing.Size(338, 80);
                this.btnEqual.Location = new System.Drawing.Point(473, 406);
                this.btnEqual.Size = new System.Drawing.Size(166, 78);
                this.ClientSize = new System.Drawing.Size(669, 526);

            }
            else
            {
                this.btnPI.Visible = false;
                this.btnSine.Visible = false;
                this.btnCosine.Visible = false;
                this.btnFactorial.Visible = false;
            }


        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            txtBox.Text = "0";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "7";
            }
            else
            {
                txtBox.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "8";
            }
            else
            {
                txtBox.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "9";
            }
            else
            {
                txtBox.Text += "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "4";
            }
            else
            {
                txtBox.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "5";
            }
            else
            {
                txtBox.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "6";
            }
            else
            {
                txtBox.Text += "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "1";
            }
            else
            {
                txtBox.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "2";
            }
            else
            {
                txtBox.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "3";
            }
            else
            {
                txtBox.Text += "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "0";
            }
            else
            {
                txtBox.Text += "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Contains("-"))
            {
                txtBox.Text = txtBox.Text.Trim('-');
            }
            else
            {
                txtBox.Text = "-" + txtBox.Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "/";
        }

        private void btnRecip_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            result = 1 / valueFirst;
            txtBox.Text = result.ToString();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "%";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(txtBox.Text);
                    result = valueFirst - valueSecond;
                    txtBox.Text = result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(txtBox.Text);
                    result = valueFirst + valueSecond;
                    txtBox.Text = result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(txtBox.Text);
                    result = valueFirst * valueSecond;
                    txtBox.Text = result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(txtBox.Text);
                    result = valueFirst / valueSecond;
                    txtBox.Text = result.ToString();
                    break;
                case "%":
                    valueSecond = decimal.Parse(txtBox.Text);
                    result = valueFirst % valueSecond;
                    txtBox.Text = result.ToString();
                    break;

            }

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            // txtBox.Clear();
        }

        private void btnSine_Click(object sender, EventArgs e)
        {
            doubleResult = double.Parse(txtBox.Text);
            double angleInRadians = doubleResult * (Math.PI / 180);
            double result1 = Math.Cos(angleInRadians);
            txtBox.Text = result1.ToString();
        }

        private void btnCosine_Click(object sender, EventArgs e)
        {
            doubleResult = double.Parse(txtBox.Text);
            double angleInRadians = doubleResult * (Math.PI / 180);
            double result2 = Math.Sin(angleInRadians);
            txtBox.Text = result2.ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            double result = double.Parse(txtBox.Text);
            double result2 = 1;
            for (int i = 1; i <= result; i++)
            {
                result2 *= i;
            }
            txtBox.Text = result2.ToString();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            txtBox.Text = Math.PI.ToString();
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                this.BackColor = Color.DarkGray;
                tabCalculator.BackColor = Color.DarkGray;
                tabPage1.BackColor = Color.DarkGray;
            }
            else
            {
                this.BackColor = Color.White;
                this.tabPage1.BackColor = Color.White;
                this.tabCalculator.BackColor = Color.White;
            }
        }
    }
}