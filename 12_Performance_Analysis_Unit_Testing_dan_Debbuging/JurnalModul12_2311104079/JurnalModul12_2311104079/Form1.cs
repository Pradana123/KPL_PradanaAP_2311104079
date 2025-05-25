using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurnalModul12_2311104079
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtExponent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        public static int CariNilaiPangkat(int a, int b)
        {
            if (b == 0) return 1;
            if (b < 0) return -1;

            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                    if (b > 10 || a > 100) return -2;
                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a, b;

            bool isAValid = int.TryParse(txtBase.Text, out a);
            bool isBValid = int.TryParse(txtExponent.Text, out b);

            if (!isAValid || !isBValid)
            {
                lbloutput.Text = "Input tidak valid!";
                return;
            }

            int hasil = CariNilaiPangkat(a, b);
            lbloutput.Text = $"Hasil: {hasil}";
        }
    }
}
