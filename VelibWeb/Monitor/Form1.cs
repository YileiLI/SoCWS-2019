using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monitor.MonitorServer;

namespace Monitor
{
    public partial class Form1 : Form
    {
        string res = "";
        MonitorServiceClient client = new MonitorServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            res = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (res != "")
            {
                string choix = res.Split('.')[0];
                switch (choix)
                {
                    case "1":
                        string delay = client.GetDelay();
                        textBox1.Text = "The average of delay is: " + delay + " ms";
                        break;
                    case "2":
                        requestsToVelib f1 = new requestsToVelib(2);
                        f1.Show();
                        this.Hide();
                        break;
                    case "3":
                        requestsToVelib f2 = new requestsToVelib(3);
                        f2.Show();
                        this.Hide();
                        break;
                    case "4":
                        int quatity = client.GetCacheNumber();
                        textBox1.Text = "The quantity of cache is: " + client.GetCacheNumber();
                        break;
                }
            }
        }
    }
}
