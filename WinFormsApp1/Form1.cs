using System.Numerics;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bGenerujIBAN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIBANnieznany.Text)) { 
              String czteryPierwsze = tbIBANnieznany.Text.Substring(0, 4);
            czteryPierwsze = czteryPierwsze.Replace("P", "25");
            czteryPierwsze = czteryPierwsze.Replace("L", "21");
            tbCalyIBAN.Text= tbIBANnieznany.Text.Substring(4) +czteryPierwsze;
            }
        }

        private void bSprawdzPoprawnosc_Click(object sender, EventArgs e)
        {
            BigInteger suma = new BigInteger();
            try
            {
                suma = BigInteger.Parse(tbCalyIBAN.Text);
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.GetType().Name + " "+er.Message );
                return;
            }
            tbPoprawnosc.Text = suma.ToString();
            if (suma % 97 == 1)
            {
                tbPoprawnosc.Text = "IBAN jest poprawny";
            }
            else
            {
                tbPoprawnosc.Text = "IBAN jest nie poprawny";
            }
        }

        private void tbIBANnieznany_TextChanged(object sender, EventArgs e)
        {
            if (tbIBANnieznany.Text.Length == 28) {
                bGenerujIBAN.Enabled = true;
            }
        }

        private void tbIBANnieznany_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIBANnieznany.Text) && tbIBANnieznany.Text.Length<28)
            {
                MessageBox.Show("Podany numer jest zbyt krótki");
                bGenerujIBAN.Enabled = false;
            }
        }

        private void bGenerujIBAN_MouseHover(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIBANnieznany.Text) && tbIBANnieznany.Text.Length < 28)
            {
                MessageBox.Show("Podany numer jest zbyt krótki");
                bGenerujIBAN.Enabled = false;
            }
        }
    }
}