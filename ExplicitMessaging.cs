using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sres.Net.EEIP;
using System.Threading;


namespace ExplicitMessaging01
{


    public partial class ExplicitMessaging : Form
    {
        public ExplicitMessaging()
        {
            InitializeComponent();

         
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            ushort V40value;
            ushort V41value;
            string resultstr1;
            string resultstr2;


            EEIPClient eeipClient = new EEIPClient();
            eeipClient.RegisterSession("192.168.122.128");

            byte[] datavalues = eeipClient.AssemblyObject.getInstance(102);

            V40value = EEIPClient.ToUshort(new byte[] { datavalues[0], datavalues[1] });
            V41value = EEIPClient.ToUshort(new byte[] { datavalues[2], datavalues[3] });

            resultstr1 = V40value.ToString();
            resultstr2 = V41value.ToString();


            textBox1.Text = resultstr1;

            textBox2.Text = resultstr2;

            eeipClient.UnRegisterSession();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
