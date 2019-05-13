using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using VelibClient.VelibServer;

namespace VelibClient
{
    public partial class Form1 : Form
    {
        VelibServiceClient client = new VelibServiceClient();
        public Form1()
        {
            InitializeComponent();
            table.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
            string response = client.getAllStationsByCity(textBox1.Text);
           // responseFromServer = reader.ReadToEnd();
            List<RootObject> rb = JsonConvert.DeserializeObject<List<RootObject>>(response);
            RootObject root = null;
            Console.WriteLine(numStation.Text);

            foreach (RootObject ob in rb)
            {   

                //if((ob.name.Contains(numStation.Text)&& numStation.Text!="") || Convert.ToInt32(ob.available_bikes) == Convert.ToInt32(num_bikes.Text))
                //{
                    root = ob;
                   // break;
               // }
            }
            //{
            if (root != null)
            {
                Console.WriteLine(root.available_bikes);
                Console.WriteLine(root.bike_stands);
                Console.WriteLine(root.available_bike_stands);
                Console.WriteLine(root.banking);
                // }
                numOfStation.Text = root.number;
                string[] res = root.name.Split(new Char[] { '-' });
                numStation.Text = res[1];
                bikeStands.Text = root.bike_stands;
                available_bikes.Text = root.available_bikes;
                available_stands.Text =  root.available_bike_stands;
                if (root.banking == "true")
                {
                    bank.Text = "Available";
                }
                else
                {
                    bank.Text =  "Not available";

                }
            }
            else
            {
                no_res.Text = "No available station!";
            }

            table.Visible = true;
        }
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class Position
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class RootObject
    {
        public string number { get; set; }
        public string contract_name { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Position position { get; set; }
        public string banking { get; set; }
        public string bonus { get; set; }
        public string bike_stands { get; set; }
        public string available_bike_stands { get; set; }
        public string available_bikes { get; set; }
        public string status { get; set; }
        public string last_update { get; set; }
    }

    }
