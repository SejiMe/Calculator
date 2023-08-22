using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextDisplay.Text = "0";
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn1.Text;
            else TextDisplay.Text += Btn1.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn2.Text;
            else TextDisplay.Text += Btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn3.Text;
            else TextDisplay.Text += Btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn4.Text;
            else TextDisplay.Text += Btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn5.Text;
            else TextDisplay.Text += Btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn6.Text;
            else TextDisplay.Text += Btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn7.Text;
            else TextDisplay.Text += Btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn8.Text;
            else TextDisplay.Text += Btn8.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") TextDisplay.Text = Btn9.Text;
            else TextDisplay.Text += Btn9.Text;
        }


        private void BtnSub_Click(object sender, EventArgs e)
        {
            TextDisplay.Text += BtnSub.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TextDisplay.Text += BtnAdd.Text;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            TextDisplay.Text += BtnDivide.Text;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            TextDisplay.Text += "*";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            string display = TextDisplay.Text;
            object results;
            try
            {
                results = new DataTable().Compute(display, null);
                TextDisplay.Text = results.ToString();
            }
            catch (Exception err)
            {

                TextDisplay.Text = err.Message;
            }

        }


        private void Btn0_Click(object sender, EventArgs e)
        {
            TextDisplay.Text += Btn0.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // safeguarding
            if (TextDisplay.Text.Length > 0)
            {
                TextDisplay.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0") return;
            TextDisplay.Text = TextDisplay.Text.Remove(TextDisplay.Text.Length - 1);

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEquals.PerformClick();
            }
        }
    }
}