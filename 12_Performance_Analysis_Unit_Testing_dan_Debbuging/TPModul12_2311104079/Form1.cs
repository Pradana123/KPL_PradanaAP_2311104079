using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPModul12_2311104079
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(InputTextBox.Text, out input))
            {
                string hasil = CariTandaBilangan(input);
                OutputLabel.Text = "Hasil: " + hasil;
            }
            else
            {
                OutputLabel.Text = "Masukkan angka yang valid.";
            }
        }

        // ✅ Ini adalah satu-satunya method yang benar — simpan ini
        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
