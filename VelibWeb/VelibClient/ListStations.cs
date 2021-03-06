﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using VelibClient.VelibServer;
using System.Linq;

namespace VelibClient
{
    public partial class ListStations : Form
    {
        private string _ville;
        private string result;
        private List<string> names = new List<string>();
        VelibServiceClient client = new VelibServiceClient();
        public ListStations(string ville)
        {
            InitializeComponent();
            table.Visible = false;
            _ville = ville;
            result = "";
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            
            string res = "";
            res = await client.GetAllStationsByCityAsync(_ville);
            // responseFromServer = reader.ReadToEnd();
            //List<String> listStations = null;
            Console.WriteLine(numStation.Text);
            names = res.Split('\n').ToList();
            names.Sort();
            total.Text = names.Count.ToString();
            for (int i = 0; i < names.Count; i++)
            {
                list.Items.Add(names[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {
            string res = list.SelectedItem.ToString().Split('-')[0];


            /*
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
            */

            //table.Visible = true;

        }


        private void submit_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            string res ="";
            res = client.GetAllStationsByCity(total.Text);
           // responseFromServer = reader.ReadToEnd();
            //List<String> listStations = null;
            Console.WriteLine(numStation.Text);
            names = res.Split('\n').ToList();
            for(int i=0; i< names.Count; i++) 
            {
                list.Items.Add(names[i]);
            }
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void num_bikes_TextChanged(object sender, EventArgs e)
        {

        }

        private async void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = list.GetItemText(list.SelectedItem);
            string num = text.Split('-')[0].Replace(" ", "");
            if (num.Equals("0"))
                num = "555";
            string tmp = await client.GetInfomationsOfStationByNameAsync(_ville, num);
            if(tmp!="Not Found!")
            {
                result = tmp;
                List<string> res = new List<string>();
                res = result.Split('\n').ToList();
                numOfStation.Text = res[0];
                bikeStands.Text = res[2];
                available_bikes.Text = res[4];
                available_stands.Text = res[3];
                if(res[5] == "true")
                {
                    bank.Text = "Availble";
                }
                else
                {
                    bank.Text = "Not availble";
                }
                if (num.Equals("555")) //if n. station is 555, the name needs to be traited differently.
                                       //coz it is "0-555 - ATELIER VELO"
                {
                    numStation.Text = res[1].Split('-')[2];
                }
                else
                {
                    numStation.Text = res[1].Split('-')[1];
                }
                
                table.Visible = true;
            }
            else
            {
                Console.WriteLine("DoSomething!");
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //update the listBox with the text of searchBox
            list.Items.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                if (!string.IsNullOrEmpty(searchBox.Text))
                {
                    if (names[i].IndexOf(searchBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        list.Items.Add(names[i]);
                    }
                }
                else
                {
                    list.Items.Add(names[i]);
                }

            }
        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //update the listBox with the text of searchBox
            list.Items.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                if (!string.IsNullOrEmpty(searchBox.Text))
                {
                    if (names[i].IndexOf(searchBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        list.Items.Add(names[i]);
                    }
                }
                else
                {
                    list.Items.Add(names[i]);
                }

            }
        }
    }



    }
