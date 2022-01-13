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

namespace ExplicitMessaging01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string resultstr;
            ushort V40values;
            ushort V41values;

            EEIPClient eeipClient = new EEIPClient();
            eeipClient.RegisterSession("192.168.0.11");

            byte[] datavalues = eeipClient.AssemblyObject.getInstance(102);

            V40values = EEIPClient.ToUshort(new byte[] { datavalues[0], datavalues[1] });
            V41values = EEIPClient.ToUshort(new byte[] { datavalues[2], datavalues[3] });

            resultstr = V40values.ToString() + " " + V41values.ToString();

            textBox1.Text = resultstr;

            eeipClient.UnRegisterSession();

        }
    }
}
