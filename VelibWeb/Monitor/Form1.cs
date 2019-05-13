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

        private void button1_Click(object sender, EventArgs e)
        {
            requestsToVelib f1;
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
                        f1 = new requestsToVelib(2);
                        f1.Show();
                        this.Hide();
                        break;
                    case "3":
                        f1 = new requestsToVelib(3);
                        f1.Show();
                        this.Hide();
                        break;
                    case "4":
                        int quatity = client.GetCacheNumber();
                        textBox1.Text = "The quantity of cache is: " + client.GetCacheNumber();
                        break;
                }
            }
        }

        private void check_Click(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }

            }
            res = checkedListBox1.Items[e.Index].ToString();
        }
    }
}
