using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string str = "";
        private void btnOK_Click(object sender, EventArgs e)
        {
            List<CARD> listgCARD = new List<CARD>();
            for (int i = 0; i < 10; i++)
            {
                CARD card = new CARD($"段昱如{i+1}", "B0226497@ulive.pccu.edu.tw", $"05{i}{i/2}{i/3}{i/4}{i/5}{i/6}{i/7}", $"09{i/7}{i/8}{i}{i/4}{i/3}{i/6}{i/2}{i/5}", $"05{i/8}{i/2}{i/4}{i/3}{i/7}{i}{i/5}", rnd.Next(20, 60));
                str += card.getCARD();
            }
                lblRESULT.Text = str;

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
