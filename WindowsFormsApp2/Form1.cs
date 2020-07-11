using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("data.txt");
            string dugumlerinDegerDosyasi = reader.ReadToEnd();
            string[] deger = dugumlerinDegerDosyasi.Split(' ');
            int elemansayisi = deger.Length;
            int[,] ilkRastgeleMevcutDugum=new int[elemansayisi,2];
            for (int i = 0; i < elemansayisi; i++)
                ilkRastgeleMevcutDugum[i,0] = -100;
            Random rnd = new Random();
            for (int i = 0; i < elemansayisi;)
            {
                int index = rnd.Next(0, elemansayisi);
                if (ilkRastgeleMevcutDugum[index,0] == -100)
                {
                    ilkRastgeleMevcutDugum[index,0] = Convert.ToInt32(deger[i]);
                    ilkRastgeleMevcutDugum[index, 1] = i;
                    i++;
                }
            }
            dugumSiraPuanHesapla(ilkRastgeleMevcutDugum,elemansayisi);
        }
        private void dugumSiraPuanHesapla(int[,] ilkMevcutDugum,int elemansayisi)
        {
            int yeniDugumSiraPuani=0;
            int mevcutDugumSiraPuani = dugumSiraPuan(ilkMevcutDugum);
            int[,] mevcutDugumSirasi = ilkMevcutDugum;
            int[,] yeniDugumSirasi = mevcutDugumSirasi;
            Random rnd = new Random();
            int index1, index2;
            for (int i = 0; i < 500; i++)
            {
                index1 = rnd.Next(0, elemansayisi);
                index2 = rnd.Next(0, elemansayisi);
                while(true)
                {
                    if (index1 == index2)
                        index2 = rnd.Next(0, elemansayisi);
                    else
                        break;
                }
                int gecici = yeniDugumSirasi[index1,0];
                int gecicidugum = yeniDugumSirasi[index1, 1];
                yeniDugumSirasi[index1,0] = yeniDugumSirasi[index2,0];
                yeniDugumSirasi[index1, 1] = yeniDugumSirasi[index2, 1];
                yeniDugumSirasi[index2,0] = gecici;
                yeniDugumSirasi[index2, 1] = gecicidugum;


                yeniDugumSiraPuani = dugumSiraPuan(yeniDugumSirasi);

                if (mevcutDugumSiraPuani < yeniDugumSiraPuani)
                    yeniDugumSirasi = mevcutDugumSirasi;
                else
                {
                    mevcutDugumSirasi = yeniDugumSirasi;
                    mevcutDugumSiraPuani = yeniDugumSiraPuani;
                    textBox1.Text = "";
                    for (int j = 0; j < elemansayisi; j++)
                        textBox1.Text += mevcutDugumSirasi[j,1] + "->";
                    label1.Text = "Sıranın Puanı : " + dugumSiraPuan(mevcutDugumSirasi).ToString();
                }
                    
            }

            int dugumSiraPuan(int[,] gelenSira)
            {
                int siraPuani = 0;
                int dugumPuani = 0;
                for (int i = 0; i < elemansayisi; i++)
                {
                    for (int j = i; j>=0; j--)
                    {
                        dugumPuani += gelenSira[j,0];
                    }
                    siraPuani += dugumPuani;
                    dugumPuani = 0;
                }
                return siraPuani;
            }
        }
    }
}
