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
    public partial class requestsToVelib : Form
    {
        MonitorServiceClient client = new MonitorServiceClient();
        int choice;

        public requestsToVelib(int choice)
        {
            InitializeComponent();
            this.choice = choice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="" || textBox3.Text == "")
            {
                MessageBox.Show("Please input a time");
            }
            else
            {
                switch (choice)
                {
                    case 2:
                        textBox1.Text = client.GetRequestToVelib(textBox2.Text, textBox3.Text);
                        break;

                    case 3:
                        textBox1.Text = client.GetRequestFromClient(textBox2.Text, textBox3.Text);
                        break;
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void requestsToVelib_Load(object sender, EventArgs e)
        {

        }
    }
}
