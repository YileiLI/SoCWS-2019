<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cityList.aspx.cs" Async="true" Inherits="cityList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
            <h1 aria-selected="undefined" style="font-family: Arial; text-align: center; font-size: 130px; font-weight: bold; color: #002537; background-color: #006699;">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="56px" ImageUrl="~/Resource/left-arrow.png" OnClick="ImageButton1_Click" Width="65px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/Resource/bicycle.png" Width="114px" />
                Velib&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h1>

            <div class="container">
                <div class="row" style="font-family: Calibri; font-size: 18px; color: #3A3A3A">
                    <div class="col-sm" style="width: 50%; height: 100%">
                        <asp:TextBox ID="search" runat="server" Width="535px" AutoPostBack="True" ontextchanged="search_TextChanged"></asp:TextBox>
                        <asp:ListBox ID="ListBox1" runat="server" Height="787px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="535px" AutoPostBack="True"></asp:ListBox>
                    </div>
                    <div class="col-sm" style="width: 50%; height: 100%; margin-top: 40px">
                        <div class="row" style="font-family: Calibri; font-size: 20px; color: #3A3A3A">
                            <div class="col-sm">Station:</div>
                            <div class="col-sm">
                                <asp:TextBox ID="TextBox1" runat="server" Width="395px"></asp:TextBox>
                            </div>
                        </div>
                        &nbsp;&nbsp;&nbsp;
                        <div class="row" style="font-family: Calibri; font-size: 20px; color: #3A3A3A">
                            <div class="col-sm">Bike stands:</div>
                            <div class="col-sm">
                                <asp:TextBox ID="TextBox2" runat="server" Width="395px"></asp:TextBox>
                            </div>
                        </div>
                        &nbsp;&nbsp;&nbsp;
                        <div class="row" style="font-family: Calibri; font-size: 20px; color: #3A3A3A">
                            <div class="col-sm">Available Bike Stands:</div>
                            <div class="col-sm">
                                <asp:TextBox ID="TextBox3" runat="server" Width="395px"></asp:TextBox>
                            </div>
                        </div>
                        &nbsp;&nbsp;&nbsp;
                        <div class="row" style="font-family: Calibri; font-size: 20px; color: #3A3A3A">
                            <div class="col-sm">Available Bikes:</div>
                            <div class="col-sm">
                                <asp:TextBox ID="TextBox4" runat="server" Width="395px"></asp:TextBox>
                            </div>
                        </div>
                        &nbsp;&nbsp;&nbsp;
                        <div class="row" style="font-family: Calibri; font-size: 20px; color: #3A3A3A">
                            <div class="col-sm">BankCard Payment:</div>
                            <div class="col-sm">
                                <asp:TextBox ID="TextBox5" runat="server" Width="395px"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>




    </form>
</body>
</html>
