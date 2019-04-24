using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelibClient
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        //private void rechercher_Click(object sender, EventArgs e)
        //{

        // }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ville.Text != null)
            {
                Form1 f1 = new Form1(ville.Text);
                f1.Show();
                this.Hide();
            }
        }
    }
}
