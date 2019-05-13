﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelibServer;

public partial class googleMap : System.Web.UI.Page
{
    private string result;
    private List<string> names = new List<string>();
    VelibServiceClient client = new VelibServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        //string n = String.Format("{0}", Request.Form["CityTextBox"]);
        if (!CityTextBox.ToString().Equals(""))
        {
            string res = "";
            res = client.GetAllStationsByCityAsync(CityTextBox.ToString()).Result;
            // responseFromServer = reader.ReadToEnd();
            //List<String> listStations = null;
            names = res.Split('\n').ToList();
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                ListBox1.Items.Add(names[i]);
            }
        }
    }



    protected async void OriginOption_SelectedIndexChanged(object sender, EventArgs e)
    {
        start.Text = "";
        if (OriginOption.SelectedItem.Text.Equals("From a Velib Station") && !CityTextBox.ToString().Equals(""))
        {

            string res = "";
            res = await client.GetAllStationsByCityAsync(CityTextBox.ToString());
            Console.WriteLine(res);
            Console.WriteLine(OriginOption.SelectedValue);
            // responseFromServer = reader.ReadToEnd();
            //List<String> listStations = null;
            names = res.Split('\n').ToList();
            names.Sort();

            for (int i = 0; i < names.Count; i++)
            {
                ListBox1.Items.Add(names[i]);
                ListBox2.Items.Add(names[i]);
            }
            ListBox1.Visible = true;
        }
        if (!OriginOption.SelectedItem.Text.Equals("From a Velib Station"))
        {
            ListBox1.Visible = false;

        }
    }

    protected async void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        end.Text = "";
        if (DropDownList2.SelectedIndex == 1 && !CityTextBox.ToString().Equals(""))
        {
            string res = "";
            res = await client.GetAllStationsByCityAsync(CityTextBox.ToString());
            // responseFromServer = reader.ReadToEnd();
            //List<String> listStations = null;
            names = res.Split('\n').ToList();
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                ListBox1.Items.Add(names[i]);
                ListBox2.Items.Add(names[i]);
            }
            ListBox2.Visible = true;
        }
        if (DropDownList2.SelectedIndex == 0)
        {
            ListBox2.Visible = false;
        }
    }



    protected async void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string text = ListBox1.SelectedItem.Text;
        string num = text.Split('-')[0].Replace(" ", "");
        if (num.Equals("0"))
            num = "555";
        string tmp = await client.GetInfomationsOfStationByNameAsync(CityTextBox.ToString(), num);
        if (tmp != "Not Found!")
        {
            result = tmp;
            List<string> res = new List<string>();
            res = result.Split('\n').ToList();
            string ordi = res[6] + "," + res[7];
            ordi = ordi.Replace(" ", "");
            start.Text = ordi;
        }
        else
        {
            Console.WriteLine("DoSomething!");
        }
    }

    protected async void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string text = ListBox2.SelectedItem.Text;
        end.Text = text;
        string num = text.Split('-')[0].Replace(" ", "");
        if (num.Equals("0"))
            num = "555";
        string tmp = await client.GetInfomationsOfStationByNameAsync(CityTextBox.ToString(), num);
        if (tmp != "Not Found!")
        {
            result = tmp;
            List<string> res = new List<string>();
            res = result.Split('\n').ToList();
            string ordi = res[6] + "," + res[7];
            ordi = ordi.Replace(" ", "");
            end.Text = ordi;
        }
        else
        {
            end.Text = "";
            Console.WriteLine("DoSomething!");
        }
    }

    protected async void start_TextChanged(object sender, EventArgs e)
    {
        if (OriginOption.SelectedIndex == 1 && !CityTextBox.ToString().Equals(""))
        {
            ListBox1.Items.Clear();
            string res = "";
            res = await client.GetAllStationsByCityAsync(CityTextBox.ToString());
            // responseFromServer = reader.ReadToEnd();
            //List<String> listStations = null;
            names = res.Split('\n').ToList();
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                if (!start.Text.Equals(""))
                {
                    if (names[i].IndexOf(start.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        ListBox1.Items.Add(names[i]);
                    }
                }
                else
                {
                    ListBox1.Items.Add(names[i]);
                }

            }
        }
    }

    protected async void end_TextChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedIndex == 1 && !CityTextBox.ToString().Equals(""))
        {
            ListBox2.Items.Clear();
            string res = "";
            res = await client.GetAllStationsByCityAsync(CityTextBox.ToString());
            names = res.Split('\n').ToList();
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                if (!end.Text.Equals(""))
                {
                    if (names[i].IndexOf(end.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        ListBox2.Items.Add(names[i]);
                    }
                }
                else
                {
                    ListBox2.Items.Add(names[i]);
                }

            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string url = "HomePage.aspx";
        Response.Redirect(url, false);
    }

    protected void btnclick_click(object sender, EventArgs e)
    {
        string url = "HomePage.aspx";
        Response.Redirect(url, false);
    }
}