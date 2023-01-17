using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator___fördjupning
{   
    public partial class Form1 : Form 
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e) // fixar funktionaliteten av en reset knapp för beräkningar
        {
            txtbVikt.Clear();
            txtbHöjd.Clear();
            txtbNamn.Clear();
            txtbBMIRes.Clear();
        }

        private void btnSum_Click(object sender, EventArgs e)  // segmentet nedan används för "calculate" funktionen
        {
            string namn = Console.ReadLine();
            double vikt = Convert.ToDouble(txtbVikt.Text);
            double höjd = Convert.ToDouble(txtbHöjd.Text);
            double res = 0.0;

            res = vikt / (höjd * höjd);

            txtbBMIRes.Text = namn + "Your BMI value is: " + res.ToString("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // används för att BMI calc ska stängas av
        }

        private void btnModeSwitch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.ShowDialog();
            this.Close();
        }
    }
}