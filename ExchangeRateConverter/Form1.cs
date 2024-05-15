using System;
using System.Windows.Forms;
using System.Globalization;

namespace ExchangeRateConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            originalNumber = 1.0f;
        }

        string text;
        bool point = false;
        float number;
        float originalNumber;

        public float value()
        {
            try
            {
                string val = label1.Text;

                if (string.IsNullOrEmpty(val))
                {
                    throw new FormatException("Le contenu du label est vide.");
                }

                CultureInfo culture = CultureInfo.InvariantCulture;

                number = float.Parse(val, culture);

                originalNumber = number;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Le contenu est invalide: " + ex.Message);
            }

            return number;
        }

        public float convertDollar(float dol)
        {
            dol = originalNumber * 1.08f;

            return dol;
        }

        public float convertLivre(float liv)
        {
            liv = originalNumber * 0.86f;

            return liv;
        }

        public string drawPoint()
        {
            if (!point)
            {
                writeOnLabel(".");
                point = true;
            }

            return text;
        }

        public string writeOnLabel(string text)
        {
            label1.Text = label1.Text + text;

            return text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            writeOnLabel("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            writeOnLabel("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            writeOnLabel("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            writeOnLabel("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            writeOnLabel("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            writeOnLabel("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            writeOnLabel("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            writeOnLabel("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            writeOnLabel("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            writeOnLabel("0");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            point = false;
            originalNumber = 1.0f;
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            drawPoint();
        }

        private void btndollards_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = convertDollar(value()).ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("Le label est vide.");
            }
        }

        private void btnlivres_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = convertLivre(value()).ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("Le label est vide.");
            }
        }

        private void btneuros_Click(object sender, EventArgs e)
        {
            label1.Text = originalNumber.ToString(CultureInfo.InvariantCulture);
        }
    }
}
