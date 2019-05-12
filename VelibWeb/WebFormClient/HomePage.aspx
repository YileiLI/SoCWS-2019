<%@ Page Async="true"  Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Velib</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/popper.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/jquery-3.0.0.slim.min.js"></script>
</head>
<body>
 
    <form id="form1" runat="server" style="background-color: #C8D2D9">
        <div style="display:block">
        <h1 aria-selected="undefined" style="font-family: Arial; text-align:center;font-size: 130px; font-weight: bold; color: #FFFFFF; background-color: #006699;">
            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" Height="103px" ImageUrl="~/Resource/question (1).png" Width="111px" OnClick="ImageButton2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/Resource/bicycle.png" Width="114px" />
            Velib&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="95px" ImageUrl="~/Resource/route.png" OnClick="ImageButton1_Click" Width="131px" />
        </h1>

            </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
&nbsp;<div style="text-align:center">   
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal">
            <img src="Resource/flag.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal1">
            <img src="Resource/spain.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal2">
            <img src="Resource/belgium.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal3">
            <img src="Resource/sweden.png" style="Height:90%; Width:80%"/></button>

         </div> 

                <div style="text-align:center">   
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal4">
            <img src="Resource/australia.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal5">
            <img src="Resource/ireland.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal6">
            <img src="Resource/norway.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal7">
            <img src="Resource/japan.png" style="Height:90%; Width:80%"/></button>

         </div> 

       

                <div style="text-align:center">   
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal8">
            <img src="Resource/lithuania.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal9">
            <img src="Resource/slovakia.png" style="Height:90%; Width:80%"/></button>
            <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal10">
            <img src="Resource/russia.png" style="Height:90%; Width:80%"/></button>
                                <button type="button" style="Height:150px;Width:200px" data-toggle="modal" data-target="#exampleModal11">
            <img src="Resource/luxembourg.png" style="Height:90%; Width:80%"/></button>
     
         </div> 

<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
      
  </button>
            
              <asp:Button class="list-group-item list-group-item-action" ID="Button11" runat="server" Text="Valence" OnClick="valence_Click"/>
<asp:Button class="list-group-item list-group-item-action" ID="Button14" runat="server" Text="Cergy-pontoise" OnClick="cergy_Click"/>
  <asp:Button class="list-group-item list-group-item-action" ID="Button5" runat="server" Text="Toulouse" OnClick="Button5_Click"/>
    <asp:Button class="list-group-item list-group-item-action" ID="Button2" runat="server" Text="Lyon" OnClick="Button2_Click"/>
  <asp:Button class="list-group-item list-group-item-action" ID="Button3" runat="server" Text="Marseille" OnClick="Button3_Click"/>
  <asp:Button class="list-group-item list-group-item-action" ID="Button4" runat="server" Text="Amiens" OnClick="Button4_Click"/>
                        <asp:Button class="list-group-item list-group-item-action" ID="Button15" runat="server" Text="Creteil" OnClick="creteil_Click"/>
                        <asp:Button class="list-group-item list-group-item-action" ID="Button16" runat="server" Text="Mulhouse" OnClick="mulhouse_Click"/>
                        <asp:Button class="list-group-item list-group-item-action" ID="Button18" runat="server" Text="Nancy" OnClick="nancy_Click"/>
                        <asp:Button class="list-group-item list-group-item-action" ID="Button19" runat="server" Text="Nantes" OnClick="nantes_Click"/>
                        <asp:Button class="list-group-item list-group-item-action" ID="Button20" runat="server" Text="Rouen" OnClick="rouen_Click"/>





            <asp:Button class="list-group-item list-group-item-action" ID="Button6" runat="server" Text="Besancon" OnClick="besancon_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

        <div class="modal fade" id="exampleModal1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel1">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
        
              <asp:Button class="list-group-item list-group-item-action" ID="Button8" runat="server" Text="Seville" OnClick="seville_Click"/>

  <asp:Button class="list-group-item list-group-item-action" ID="Button1" runat="server" Text="Santander" OnClick="santander_Click"/>
</div>
      </div>
    </div>
  </div>
</div>


        <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel2">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button9" runat="server" Text="Bruxelles" OnClick="bruxelles_Click"/>
    <asp:Button class="list-group-item list-group-item-action" ID="Button10" runat="server" Text="Namur" OnClick="namur_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

        <div class="modal fade" id="exampleModal3" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel3">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
            
  <asp:Button class="list-group-item list-group-item-action" ID="lund" runat="server" Text="Lund" OnClick="lund_Click"/>
              <asp:Button class="list-group-item list-group-item-action" ID="Button7" runat="server" Text="Goteborg" OnClick="goteborg_Click"/>

    <asp:Button class="list-group-item list-group-item-action" ID="stockholm" runat="server" Text="Stockholm" OnClick="stockholm_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

        <div class="modal fade" id="exampleModal4" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel4">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button17" runat="server" Text="Brisbane" OnClick="brisbane_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

        <div class="modal fade" id="exampleModal5" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel5">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button21" runat="server" Text="Dublin" OnClick="dublin_Click"/>

</div>
      </div>
    </div>
  </div>
</div>

        <div class="modal fade" id="exampleModal6" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel6">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button25" runat="server" Text="Lillestrom" OnClick="lillestrom_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

        <div class="modal fade" id="exampleModal7" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel7">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button29" runat="server" Text="Toyama" OnClick="toyama_Click"/>

</div>
      </div>
    </div>
  </div>
</div>

        <div class="modal fade" id="exampleModal8" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel8">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button33" runat="server" Text="Vilnius" OnClick="vilnius_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

                <div class="modal fade" id="exampleModal9" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel9">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button12" runat="server" Text="Ljubljana" OnClick="ljubljana_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

                        <div class="modal fade" id="exampleModal10" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel10">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button13" runat="server" Text="Kazan" OnClick="kazan_Click"/>
</div>
      </div>
    </div>
  </div>
</div>

     
                        <div class="modal fade" id="exampleModal11" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel11">Velib - City</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active">
    Choose a city
  </button>
  <asp:Button class="list-group-item list-group-item-action" ID="Button22" runat="server" Text="Luxembourg" OnClick="luxembourg_Click"/>
</div>
      </div>
    </div>
  </div>
</div>       


            </form>
 
</body>
</html>
