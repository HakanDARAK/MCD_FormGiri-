using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_FormGiriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            double number1, number2, sonuc = 0;
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            sonuc = number1 + number2;
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnCıkarma_Click(object sender, EventArgs e)
        {
            double number1, number2, sonuc = 0;
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            if (number2 > number1)
            {
                DialogResult decision = new DialogResult();
               decision= MessageBox.Show("1. girdiğiniz sayı 2. sayıdan büyük 2. sayıdan birinci sayıyı çıkaralım mı", "Düzeltme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                

                if (decision == DialogResult.Yes)
                {
                    sonuc = number1 - number2;
                    txtSonuc.Text = Math.Abs(sonuc).ToString();
                }
               
            }
            else
            {
                sonuc = number1 - number2;
                txtSonuc.Text = sonuc.ToString();
            }



        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            double number1, number2, sonuc = 0;
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            sonuc = number1 * number2;
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            double number1, number2, sonuc = 0;
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            if (number2 == 0)
            {
                MessageBox.Show("HATA! Tanımsız ifade görünen o ki sıfıra bölmeye çalışmıssın düzelt!", "Tanımsız İfade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sonuc = number1 * number2;
                txtSonuc.Text = sonuc.ToString();
            }


        }
    }
}
