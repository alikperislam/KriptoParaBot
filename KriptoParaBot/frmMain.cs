using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptoParaBot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

            timer1.Start();
            timer2.Start();
        }


        public string dilSecenek;
        

        
        

        

        

        

        
        int x = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            if (x == 1)
            {
                lblTotal.Text = "USDT";
                lblTutar.Text = "314,89 USDT";

            }
            else if (x == 2)
            {
                lblTotal.Text = "BNB";
                lblTutar.Text = "0,92681 BNB";
            }
            else if (x == 3)
            {
                lblTotal.Text = "CREDİT";
                lblTutar.Text = "$ 540,47";
                x = -1;
            }
            else if (x == 0)
            {
                lblTotal.Text = "TOTAL";
                lblTutar.Text = "$ 979,08";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x--;

            if (x == 1 || x == -1)
            {
                lblTotal.Text = "USDT";
                lblTutar.Text = "314,89 USDT";
            }
            else if (x == 2 || x == -2)
            {
                lblTotal.Text = "BNB";
                lblTutar.Text = "0,92681 BNB";
            }
            else if (x == 3 || x == -3)
            {
                lblTotal.Text = "CREDİT";
                lblTutar.Text = "$ 540,47";
                x = 1;
            }
            else if (x == 0)
            {
                lblTotal.Text = "TOTAL";
                lblTutar.Text = "$ 979,08";
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
            }
        }

        private void lblSaat_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
