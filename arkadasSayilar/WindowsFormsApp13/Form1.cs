/***********************************************************************************************************************************
 SAKARYA ÜNİVERSİTESİ
 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 NESNEYE DAYALI PROGRAMLAMA DERSİ
 2019-2020 BAHAR DÖNEMİ
 ADI:ZEHRA BEGÜM  SOYADI:AKTOLGA   NUMARASI:B191210062   GRUP:1C GRUBU 1.ÖĞRETİM
/***********************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            double sayi1;
            double sonuc = 0;
            double sonuc1 = 0;
            ListBox listbox = new ListBox();
            listbox.Location = new Point(300,40);
            listbox.Size = new Size(100, 200);
            sayi = Convert.ToDouble(textBox1.Text);
            //GİRİLEN SAYININ ÇARPANLARINI BULMAYI SAĞLAR VE LİSTBOX'A EKLER.
            if (sayi > 0)
            {
                for (int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        listbox.Items.Add(i);
                    }
                    listbox.Items.Clear();//ARKADAŞ MI BUTONUNA BİR DAHA TIKLAYINCA KONTROLLERİN TEKRAR EKLENMESİ ENGELLENİR. 
                }
            }
            else
            {
                MessageBox.Show("POZİTİF BİR SAYI GİRİNİZ:");
            }
            Controls.Add(listbox);
            ListBox listbox1 = new ListBox();
            listbox1.Location = new Point(420, 40);
            listbox1.Size = new Size(100, 200);
            sayi1 = Convert.ToDouble(textBox2.Text);
            //GİRİLEN SAYININ ÇARPANLARINI BULMAYI SAĞLAR VE LİSTBOX1'E EKLER.
            if (sayi1 > 0)
            {
                for (int i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0)
                    {
                        listbox1.Items.Add(i);
                    }
                    listbox1.Items.Clear();//ARKADAŞ MI BUTONUNA BİR DAHA TIKLAYINCA KONTROLLERİN TEKRAR EKLENMESİ ENGELLENİR.
                }
            }
            else
            {
                MessageBox.Show("POZİTİF BİR SAYI GİRİNİZ:");
            }
            Controls.Add(listbox1);
            Label label = new Label();
            label.Location = new Point(340, 25);
            label.Text = "X";
            Controls.Add(label);
            Label label1 = new Label();
            label1.Location = new Point(460,25);
            label1.Text = "Y";
            Controls.Add(label1);
            Label label2 = new Label();
            label2.Location = new Point(200, 250);
            label2.Text = "TOPLAMLAR=";
            Controls.Add(label2);
            TextBox textbox = new TextBox();
            textbox.Location = new Point(300, 250);
            textbox.Size = new Size(100, 10);
            //TEXTBOX'TA SONUÇLARIN TOPLANMIŞ OLMASINI SAĞLAR.
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listbox.Items.Add(i);
                    sonuc += i;
                }
                textbox.Text = Convert.ToString(sonuc);
            }
            Controls.Add(textbox);
            TextBox textbox1 = new TextBox();
            textbox1.Location = new Point(420, 250);
            textbox1.Size = new Size(100, 10);
            //TEXTBOX1'DE SONUÇLARIN TOPLANMIŞ OLMASINI SAĞLAR.
            for (int i = 1; i < sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    listbox1.Items.Add(i);
                    sonuc1 += i;
                }
                textbox1.Text = Convert.ToString(sonuc1);
            }
            Controls.Add(textbox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
