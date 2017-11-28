using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekYonluBagliListe_SingleLinkedList_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SingleLinked single = new SingleLinked();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                single.InstertLast();
            }
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            ErrorProvider err1 = new ErrorProvider();
            if (txtKoltuk.Text == "")
                err.SetError(txtKoltuk, "Bu alani doldurun.");
            if (txtKisi.Text == "")
                err1.SetError(txtKisi, "Bu alani doldurun.");

            int koltuk = Convert.ToInt16(txtKoltuk.Text);
            string kisiBilgisi = txtKisi.Text;
            if ((koltuk > 0 && koltuk <= 60)&&(kisiBilgisi!=null))
            {
                single.InsertPos(koltuk, kisiBilgisi);
                txtKoltuk.Text = null;
                txtKisi.Text = null;
                RenkDegistir(true, koltuk);
            }
            else if(koltuk<0||koltuk>60)
            {
                err.SetError(txtKoltuk, "1-60 arasi bir deger girmelisiniz");
                txtKoltuk.Text = null;
            }
           
        }
        private void RenkDegistir(bool a, int koltuk)
        {
            if (a == true)
            {
                switch (koltuk)
                {
                    case 1: label3.BackColor = Color.Red; break;
                    case 2: label4.BackColor = Color.Red; break;
                    case 3: label5.BackColor = Color.Red; break;
                    case 4: label6.BackColor = Color.Red; break;
                    case 5: label8.BackColor = Color.Red; break;
                    case 6: label7.BackColor = Color.Red; break;
                    case 7: label9.BackColor = Color.Red; break;
                    case 8: label10.BackColor = Color.Red; break;
                    case 9: label11.BackColor = Color.Red; break;
                    case 10: label12.BackColor = Color.Red; break;
                    case 11: label13.BackColor = Color.Red; break;
                    case 12: label14.BackColor = Color.Red; break;
                    case 13: label15.BackColor = Color.Red; break;
                    case 14: label16.BackColor = Color.Red; break;
                    case 15: label17.BackColor = Color.Red; break;
                    case 16: label18.BackColor = Color.Red; break;
                    case 17: label19.BackColor = Color.Red; break;
                    case 18: label20.BackColor = Color.Red; break;
                    case 19: label21.BackColor = Color.Red; break;
                    case 20: label22.BackColor = Color.Red; break;
                    case 21: label23.BackColor = Color.Red; break;
                    case 22: label24.BackColor = Color.Red; break;
                    case 23: label25.BackColor = Color.Red; break;
                    case 24: label26.BackColor = Color.Red; break;
                    case 25: label27.BackColor = Color.Red; break;
                    case 26: label28.BackColor = Color.Red; break;
                    case 27: label29.BackColor = Color.Red; break;
                    case 28: label30.BackColor = Color.Red; break;
                    case 29: label31.BackColor = Color.Red; break;
                    case 30: label32.BackColor = Color.Red; break;
                    case 31: label33.BackColor = Color.Red; break;
                    case 32: label34.BackColor = Color.Red; break;
                    case 33: label35.BackColor = Color.Red; break;
                    case 34: label36.BackColor = Color.Red; break;
                    case 35: label37.BackColor = Color.Red; break;
                    case 36: label38.BackColor = Color.Red; break;
                    case 37: label39.BackColor = Color.Red; break;
                    case 38: label40.BackColor = Color.Red; break;
                    case 39: label41.BackColor = Color.Red; break;
                    case 40: label42.BackColor = Color.Red; break;
                    case 41: label43.BackColor = Color.Red; break;
                    case 42: label44.BackColor = Color.Red; break;
                    case 43: label45.BackColor = Color.Red; break;
                    case 44: label46.BackColor = Color.Red; break;
                    case 45: label47.BackColor = Color.Red; break;
                    case 46: label48.BackColor = Color.Red; break;
                    case 47: label49.BackColor = Color.Red; break;
                    case 48: label50.BackColor = Color.Red; break;
                    case 49: label51.BackColor = Color.Red; break;
                    case 50: label61.BackColor = Color.Red; break;
                    case 51: label60.BackColor = Color.Red; break;
                    case 52: label59.BackColor = Color.Red; break;
                    case 53: label58.BackColor = Color.Red; break;
                    case 54: label57.BackColor = Color.Red; break;
                    case 55: label56.BackColor = Color.Red; break;
                    case 56: label55.BackColor = Color.Red; break;
                    case 57: label54.BackColor = Color.Red; break;
                    case 58: label53.BackColor = Color.Red; break;
                    case 59: label52.BackColor = Color.Red; break;
                    case 60: label51.BackColor = Color.Red; break;
                }
            }
            else
            {
                switch (koltuk)
                {
                    case 1: label3.BackColor = Color.Green; break;
                    case 2: label4.BackColor = Color.Green; break;
                    case 3: label5.BackColor = Color.Green; break;
                    case 4: label6.BackColor = Color.Green; break;
                    case 5: label8.BackColor = Color.Green; break;
                    case 6: label7.BackColor = Color.Green; break;
                    case 7: label9.BackColor = Color.Green; break;
                    case 8: label10.BackColor = Color.Green; break;
                    case 9: label11.BackColor = Color.Green; break;
                    case 10: label12.BackColor = Color.Green; break;
                    case 11: label13.BackColor = Color.Green; break;
                    case 12: label14.BackColor = Color.Green; break;
                    case 13: label15.BackColor = Color.Green; break;
                    case 14: label16.BackColor = Color.Green; break;
                    case 15: label17.BackColor = Color.Green; break;
                    case 16: label18.BackColor = Color.Green; break;
                    case 17: label19.BackColor = Color.Green; break;
                    case 18: label20.BackColor = Color.Green; break;
                    case 19: label21.BackColor = Color.Green; break;
                    case 20: label22.BackColor = Color.Green; break;
                    case 21: label23.BackColor = Color.Green; break;
                    case 22: label24.BackColor = Color.Green; break;
                    case 23: label25.BackColor = Color.Green; break;
                    case 24: label26.BackColor = Color.Green; break;
                    case 25: label27.BackColor = Color.Green; break;
                    case 26: label28.BackColor = Color.Green; break;
                    case 27: label29.BackColor = Color.Green; break;
                    case 28: label30.BackColor = Color.Green; break;
                    case 29: label31.BackColor = Color.Green; break;
                    case 30: label32.BackColor = Color.Green; break;
                    case 31: label33.BackColor = Color.Green; break;
                    case 32: label34.BackColor = Color.Green; break;
                    case 33: label35.BackColor = Color.Green; break;
                    case 34: label36.BackColor = Color.Green; break;
                    case 35: label37.BackColor = Color.Green; break;
                    case 36: label38.BackColor = Color.Green; break;
                    case 37: label39.BackColor = Color.Green; break;
                    case 38: label40.BackColor = Color.Green; break;
                    case 39: label41.BackColor = Color.Green; break;
                    case 40: label42.BackColor = Color.Green; break;
                    case 41: label43.BackColor = Color.Green; break;
                    case 42: label44.BackColor = Color.Green; break;
                    case 43: label45.BackColor = Color.Green; break;
                    case 44: label46.BackColor = Color.Green; break;
                    case 45: label47.BackColor = Color.Green; break;
                    case 46: label48.BackColor = Color.Green; break;
                    case 47: label49.BackColor = Color.Green; break;
                    case 48: label50.BackColor = Color.Green; break;
                    case 49: label51.BackColor = Color.Green; break;
                    case 50: label61.BackColor = Color.Green; break;
                    case 51: label60.BackColor = Color.Green; break;
                    case 52: label59.BackColor = Color.Green; break;
                    case 53: label58.BackColor = Color.Green; break;
                    case 54: label57.BackColor = Color.Green; break;
                    case 55: label56.BackColor = Color.Green; break;
                    case 56: label55.BackColor = Color.Green; break;
                    case 57: label54.BackColor = Color.Green; break;
                    case 58: label53.BackColor = Color.Green; break;
                    case 59: label52.BackColor = Color.Green; break;
                    case 60: label51.BackColor = Color.Green; break;
                }
            }
        }
            
        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            if (txtKoltuk.Text == "")
                err.SetError(txtKoltuk, "Bu alanı doldurun.");
            int koltuk = Convert.ToInt16(txtKoltuk.Text);
            if(koltuk>0&&koltuk<=60)
            {
                single.DeletePos(koltuk);
                txtKoltuk.Text = null;
                RenkDegistir(false, koltuk);
            }
            else
            {
                err.SetError(txtKoltuk, "1-60 arasi bir deger girmelisiniz");
                txtKoltuk.Text = null;
            }
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            if (txtKisi.Text == "")
                err.SetError(txtKoltuk, "Bu alanı doldurun.");
            string kisi = txtKisi.Text;
            MessageBox.Show(single.GetElement(kisi));
           
        }

        private void btnDoluluk_Click(object sender, EventArgs e)
        {
            Node tmpNode = single.Head;
            int say = 0;
            while(tmpNode.nextNode!=null)
            {
                if(tmpNode.Doluluk==true)
                {
                    say++;
                }
                tmpNode = tmpNode.nextNode;
            }
            MessageBox.Show("Salonda " + say + " kişi var");
        }

        private void btnBosKoltuk_Click(object sender, EventArgs e)
        {
            Node tmpNode = single.Head;
            string temp = "";
            int say = 0;
            while(tmpNode.nextNode!=null)
            {
                if (tmpNode.Doluluk == false)
                {
                    temp += tmpNode.KoltukNumarasi + " numaralı koltuk boş\n";
                    say++;
                }
                tmpNode = tmpNode.nextNode;
            }
            if (say == 0)
                temp = "Salon dolu";
            MessageBox.Show(temp);
        }

        private void btnDoluKoltuk_Click(object sender, EventArgs e)
        {
            Node tmpNode = single.Head;
            int say = 0;
            string temp = "";
            while (tmpNode.nextNode!=null)
            {
                if (tmpNode.Doluluk==true)
                {
                    temp += tmpNode.KoltukNumarasi + " numarali koltuk dolu\n";
                    say++;
                }
                tmpNode = tmpNode.nextNode;
            }
            if (say == 0)
                temp = "Salon Bos";
            MessageBox.Show(temp);
        }
    }
}
