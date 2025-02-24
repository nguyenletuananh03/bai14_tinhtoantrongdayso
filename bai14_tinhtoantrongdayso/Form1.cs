using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai14_tinhtoantrongdayso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            
            int nho = Convert.ToInt32(txtso1.Text);
            int lon = Convert.ToInt32(txtso2.Text);
            int chan = 0, le = 0;
            txtchan.Text = "";
            txtle.Text = "";

            
            


            
             for (int i = nho; i <= lon; i++)
             {
                 if (i % 2 == 0)
                 {
                     chan += i; 
                 }
                 else 
                 {
                     le += i;
                 }


             }
             txtchan.Text = chan.ToString();
             txtle.Text = le.ToString();
             txttong.Text = (chan + le ).ToString();
            
        }
           
    }
}
