<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cityList.aspx.cs" Inherits="cityList"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
    <form id="form1" runat="server">
        <div>
        Velib

            <div class="container">
  <div class="row">
    <div class="col-sm" style="width:50%; height:100%">
          <asp:ListBox ID="ListBox1" runat="server" Height="787px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="535px" AutoPostBack="True"></asp:ListBox>
    </div>
      <div class="col-sm" style="width:50%; height:100%">
          <div class="row">
              <div class="col-sm"> Station :</div>
              <div class="col-sm"> <asp:TextBox ID="TextBox1" runat="server" Width="395px"></asp:TextBox></div>
         </div>
                    <div class="row">
              <div class="col-sm"> Bike stands :</div>
              <div class="col-sm"> <asp:TextBox ID="TextBox2" runat="server" Width="395px"></asp:TextBox></div>
         </div>
                    <div class="row">
              <div class="col-sm"> Available Bike Stands :</div>
              <div class="col-sm"> <asp:TextBox ID="TextBox3" runat="server" Width="395px"></asp:TextBox></div>
         </div>
                    <div class="row">
              <div class="col-sm"> Available Bikes :</div>
              <div class="col-sm"> <asp:TextBox ID="TextBox4" runat="server" Width="395px"></asp:TextBox></div>
         </div>
                    <div class="row">
              <div class="col-sm"> BankCard Payment :</div>
              <div class="col-sm"> <asp:TextBox ID="TextBox5" runat="server" Width="395px"></asp:TextBox></div>
         </div>
    </div>
  </div>
</div>
            </div>
        
    
        
        
    </form>
</body>
</html>
