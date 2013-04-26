using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;
            string hour = hours.ToString();
            string minute = minutes.ToString();
            string second = seconds.ToString();
            if (hours < 10)
                hour = "0" + hour;
            if (minutes < 10)
                minute = "0" + minute;
            if (seconds < 10)
                second = "0" + second;
            clock.Text = hour + ":" + minute + ":" + second;
        }
    }
}
