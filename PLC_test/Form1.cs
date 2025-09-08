using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACTMULTILib;

namespace PLC_test
{
    public partial class Form1 : Form
    {
        ActEasyIF PLC1 = new ActEasyIF();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLC1.ActLogicalStationNumber = 1;
            int conErr = 0;
            conErr = PLC1.Open();

            if (conErr == 0)
            {
                lblStatus.Text = "Connected";
                tmrUpdate.Start();
            }
            else
            {
                lblStatus.Text = "Connection Error" + conErr;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            PLC1.Close();
            lblStatus.Text = "Disconnected";
            tmrUpdate.Stop();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("M100", 1);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("M100", 0);
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            PLC1.GetDevice("Y20", out int Y20);
            
            if(Y20 == 1)
            {
                lamp1.BackColor = Color.Red;
            }
            else
            {
                lamp1.BackColor = Color.Gray; 
            }

            PLC1.GetDevice("D0", out int D0);
            tbData1.Text = D0.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("D10", int.Parse(tbData2.Text));
        }
    }
}
