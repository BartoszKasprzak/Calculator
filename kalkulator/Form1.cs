using org.mariuszgromada.math.mxparser;

namespace kalkulator
{
    public partial class Form1 : Form
    {

        string ans;
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.Hide();
            be.Hide();
            sin.Hide();
            cos.Hide();
            tan.Hide();
            EXP.Hide();
            pi.Hide();
            potega.Hide();
            lnaturalny.Hide();
            log.Hide();
            silnia.Hide();
            Ans.Hide();
            MessageBox.Show("INSTRUKCJA OBS£UGI \n 1. Nawiasy funkcji trzeba domkn¹æ rêcznie \n 2. Nie mo¿na wpisaæ równania z klawiatury \n 3. Po naciœniêciu 'ok' kalkulator uruchomi siê samoistnie");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                comboBox1.Show();
                be.Show();
                sin.Show(); 
                cos.Show(); 
                tan.Show();
                EXP.Show(); 
                pi.Show();
                potega.Show();
                lnaturalny.Show(); 
                log.Show();
                silnia.Show();
                Ans.Show();
            }
            else
            {
                comboBox1.Hide();
                be.Hide();
                sin.Hide();
                cos.Hide();
                tan.Hide();
                EXP.Hide();
                pi.Hide();
                potega.Hide();
                lnaturalny.Hide();
                log.Hide();
                silnia.Hide();
                Ans.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                mXparser.setRadiansMode();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mXparser.setDegreesMode();
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

       

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '+';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '-';
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '*';
        }

        private void button4_Click_1(object sender, EventArgs e)//dzielenie
        {
            textBox1.Text = textBox1.Text + '/';
        }

        private void pierw_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sqrt(";
        }

        private void AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void rownasie_Click(object sender, EventArgs e)
        {
            string r = textBox1.Text + '=';
            Expression rownanie = new Expression(textBox1.Text);
            textBox1.Text = rownanie.calculate().ToString();
            r = r + textBox1.Text;
            ans = textBox1.Text;
            listBox1.Items.Add(r);
        }

        private void kropka_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nawiasprawy_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ')';
        }

        private void log_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "lg(";
        }

        private void potega_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '^';
        }

        private void pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "pi";
        }

        private void nawiaslewy_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '(';
        }

        private void lnaturalny_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ln(";
        }

        private void be_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 'e';
        }

        private void EXP_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "exp(";
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ans;
        }

        private void silnia_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '!';
        }

        private void sin_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sin(";
        }

        private void cos_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "cos(";
        }

        private void tan_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "tg(";
        }

        private void procent_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '%';
        }
    }
}