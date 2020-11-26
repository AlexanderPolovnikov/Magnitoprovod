using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magnit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblOne.Text = "Площадь всех пакетов:\t";
            lblKoef.Text = "Коэффициент заполнения:\t";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOne.ResetText();
            lblKoef.ResetText();

            int r; // радиус
            int n; // числов пакетов на половину сечения
            int maxl; // макимальная толщина сечения
            float lcount = 0;
            r = Convert.ToInt16(txtbRadius.Text);
            n = Convert.ToInt16(txtbN.Text);
            maxl = Convert.ToInt16(txtbMaxL.Text);
            Trans Transformer1 = new Trans(r, n, maxl / 2);
            Transformer1.search1(0);
            lblOne.Text = "Площадь всех пакетов:\t " + Math.Round(2 * Transformer1.maxS, 2) + " , мм^2";
            lblKoef.Text = "Коэффициент заполнения:" + Math.Round((2 * Transformer1.maxS) / (Math.PI * Transformer1.R * Transformer1.R), 2);

            for (int i = 0; i < Transformer1.N; i++)
            {
                lblPackets.Text += i + 1 + " пакет:\t Ширина = " + Math.Round(Transformer1.MAXpach[i], 2) + "мм" + ";" + "\t Толщина = " + Math.Round(Transformer1.MAXpacl[i], 2) + "мм" + ";" + "\n";
                lcount += Transformer1.MAXpacl[i]; ///////////// <-------
            }
            //Console.WriteLine("\t Толщина верхней половины пакетов ={0}", e); ///////////// <----
        }

        private void lblPackets_Click(object sender, EventArgs e)
        {

        }
    }
}
