using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;


namespace KriptoParaBot
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }

        private void frmSet_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            if (comboblackList.Text!="")
            {
                listBox1.Items.Add(comboblackList.Text);
            }

            // ekleyen popup için kullanılan kod kümesi :
            PopupNotifier popp = new PopupNotifier(); 
            string veri;
            veri = comboblackList.Text;
            popp.ContentText = " "+veri + ",  has been added to the blacklist";

            popp.BodyColor = Color.FromArgb(23, 30, 38);
            popp.ContentColor =Color.White;
            popp.Popup();



        }
        public string atama;
        private void button1_Click(object sender, EventArgs e)
        {
            
            // silen popup için kullanılan kod kümesi :
            PopupNotifier popp = new PopupNotifier();
            string veri = atama;
            popp.ContentText = " "+veri + ",  has been removed from the blacklist.";

            popp.BodyColor = Color.DarkSlateBlue;
            popp.ContentColor = Color.White;
            popp.Popup();
           
            //MessageBox.Show(atama);
            if (listBox1.SelectedIndex.ToString()!="")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                

            }
         
        }
        

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                atama = listBox1.SelectedItem.ToString();
            }
            
        }
    }
}
