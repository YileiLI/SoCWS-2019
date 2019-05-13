using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelibServer;

public partial class cityList : System.Web.UI.Page
{
    string res = "";
    string city = "";
    string result = "";

    List<string> names = new List<string>();
    VelibServiceClient client;

    protected async void Page_Load(object sender, EventArgs e)
    {
        client = new VelibServiceClient();
        city = Request.QueryString["var1"];
        res = await client.GetAllStationsByCityAsync(city);
        names = res.Split('\n').ToList();
        names.Sort();
        Console.WriteLine(names.Count);
        for (int i = 0; i < names.Count; i++)
        {
            ListBox1.Items.Add(names[i]);
        }
    }


    protected async void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string text = ListBox1.SelectedItem.ToString();
        TextBox1.Text = text;
        string num = text.Split('-')[0].Replace(" ", "");
        if (num.Equals("0"))
            num = "555";
        string tmp = await client.GetInfomationsOfStationByNameAsync(city, num);
        if (tmp != "Not Found!")
        {
            result = tmp;
            TextBox1.Text = result;
            List<string> res = new List<string>();
            res = result.Split('\n').ToList();
            TextBox2.Text = res[2];
            TextBox4.Text = res[4];
            TextBox3.Text = res[3];
            string ordi = res[6] + "," + res[7];
            ordi = ordi.Replace(" ", "");
            TextBox6.Text = ordi;
            if (res[5] == "true")
            {
                TextBox5.Text = "Availble";
            }
            else
            {
                TextBox5.Text = "Not availble";
            }

            if (num.Equals("555")) //if n. station is 555, the name needs to be traited differently.
                                   //coz it is "0-555 - ATELIER VELO"
            {
                TextBox1.Text = res[1].Split('-')[2];
            }
            else
            {
                TextBox1.Text = res[1].Split('-')[1];
            }

        }
        else
        {
            Console.WriteLine("DoSomething!");
        }
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string url = "HomePage.aspx";
        Response.Redirect(url, false);
    }

    protected async void search_TextChanged(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        string res = "";
        res = await client.GetAllStationsByCityAsync(city);
        // responseFromServer = reader.ReadToEnd();
        //List<String> listStations = null;
        names = res.Split('\n').ToList();
        names.Sort();
        for (int i = 0; i < names.Count; i++)
        {
            if (!search.Text.Equals(""))
            {
                if (names[i].IndexOf(search.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
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