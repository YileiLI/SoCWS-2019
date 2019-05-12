using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelibServer;

public partial class HomePage : System.Web.UI.Page
{
    VelibServiceClient client = new VelibServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void flag_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("cityList.aspx");
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Toulouse";
        Response.Redirect(url);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Lyon";
        Response.Redirect(url);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Marseille";
        Response.Redirect(url);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Amiens";
        Response.Redirect(url);
    }

    protected void brisbane_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Brisbane";
        Response.Redirect(url);
    }

    protected void bruxelles_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Bruxelles";
        Response.Redirect(url);
    }

    protected void namur_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Namur";
        Response.Redirect(url);
    }

    protected void santander_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Santander";
        Response.Redirect(url);
    }

    protected void cergy_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Cergy-pontoise";
        Response.Redirect(url);
    }

    protected void creteil_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Creteil";
        Response.Redirect(url);
    }

    protected void mulhouse_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Mulhouse";
        Response.Redirect(url);
    }

    protected void nancy_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Nancy";
        Response.Redirect(url);
    }

    protected void nantes_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Nantes";
        Response.Redirect(url);
    }

    protected void rouen_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Rouen";
        Response.Redirect(url);
    }

    protected void dublin_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Dublin";
        Response.Redirect(url);
    }

    protected void toyama_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Toyama";
        Response.Redirect(url);
    }

    protected void vilnius_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Vilnius";
        Response.Redirect(url);
    }
    protected void luxembourg_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Luxembourg";
        Response.Redirect(url);
    }
    protected void lillestrom_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Lillestrom";
        Response.Redirect(url);
    }
    protected void besancon_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Besancon";
        Response.Redirect(url);
    }
    protected void goteborg_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Goteborg";
        Response.Redirect(url);
    }
    protected void seville_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Seville";
        Response.Redirect(url);
    }
    protected void valence_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Valence";
        Response.Redirect(url);
    }
    protected void kazan_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Kazan";
        Response.Redirect(url);
    }
    protected void lund_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Lund";
        Response.Redirect(url);
    }
    protected void stockholm_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Stockholm";
        Response.Redirect(url);
    }

    protected void ljubljana_Click(object sender, EventArgs e)
    {
        string url = "cityList.aspx?var1=" + "Ljubljana";
        Response.Redirect(url);
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("googleMap.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        string str = "";
        str = client.GetHelpAsync(2).Result;
        string js = "<script> confirm('" + str + "')</script>";
        Page.RegisterStartupScript("", js);
    }
}