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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // isMdi ile panel getimesi için method kullanıyoruz.
        void getirPanel(Form frm)
        {
            anaPanel.Controls.Clear(); // üst üste formlar gelmemesi için panelin içerisini her seferinde temizliyoruz.
            frm.MdiParent = this; // gelen formu yani açılacak olan formu burada açacağına dair Mdi=this; yapıyoruz.
            anaPanel.Controls.Add(frm);//formu nerede açacaksa o panelin controlune ekliyoruz.
            frm.Show(); // formu ekranda göster.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcMavi.BackColor = Color.FromArgb(23,30,38);
            pcPembe.BackColor = Color.FromArgb(23, 30, 38);
            pcTurkuaz.BackColor = Color.FromArgb(23, 30, 38);

            timer1.Start();
            timer2.Start();

            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pcPembe.BackColor = Color.Olive;
            pcMavi.BackColor = Color.FromArgb(23, 30, 38);
            pcTurkuaz.BackColor = Color.FromArgb(23, 30, 38);
            frmMain frMain = new frmMain();
            getirPanel(frMain);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pcPembe.BackColor = Color.FromArgb(23, 30, 38);
            pcMavi.BackColor = Color.Olive;
            pcTurkuaz.BackColor = Color.FromArgb(23, 30, 38);

            frmOperation fr = new frmOperation();
            getirPanel(fr);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pcPembe.BackColor = Color.FromArgb(23, 30, 38);
            pcMavi.BackColor = Color.FromArgb(23, 30, 38);
            pcTurkuaz.BackColor = Color.Olive;
            frmSet fset = new frmSet();
            getirPanel(fset);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dil = comboBox1.Text;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        int saniye = 0;
        int dakika = 0;
        int saat = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
                if (dakika == 60)
                {
                    dakika = 0;
                    saat++;
                    if (saat == 24)
                    {
                        saat = 0;
                    }
                }
            }
            lblSaat.Text = saat.ToString()+" :";
            lblDak.Text = dakika.ToString() + " :";
            lblSn.Text = saniye.ToString();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
