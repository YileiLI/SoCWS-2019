<%@ Page Async="true"  Language="C#" AutoEventWireup="true" CodeFile="googleMap.aspx.cs" Inherits="googleMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Map</title>
    <meta name="viewport" content="initial-scale=1.0"/>
    <meta charset="utf-8"/>
    <style>
        /* Always set the map height explicitly to define the size of the div
        * element that contains the map. */
        #map {
            height: 100%;
        }
        /* Optional: Makes the sample page fill the window. */
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
    </style>
    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBx25Hq3Xadi0gqGIKVx8S7z9YfhJAp8gk&callback=initMap"
           async defer ></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="city">

            <asp:Label ID="Label1" runat="server" Text="City:" Font-Names="Arial"></asp:Label>
            <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>

        </div>
        <div id="inputFROM" style="width: 330px; display: inline-block">
            <asp:DropDownList ID="OriginOption" runat="server" OnSelectedIndexChanged="OriginOption_SelectedIndexChanged" Width="308px" AutoPostBack="True">
                <asp:ListItem>From any place</asp:ListItem>
                <asp:ListItem>From a Velib Station</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="start" runat="server" Width="305px"></asp:TextBox>
            <asp:ListBox ID="ListBox1" runat="server" Width="308px" Visible="False" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>


        </div>
        <div id="inputTo" style="width: 330px; display: inline-block">
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="308px" AutoPostBack="True">
                <asp:ListItem>To any place</asp:ListItem>
                <asp:ListItem>To a Velib Station</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="end" runat="server" Width="305px"></asp:TextBox>
            <asp:ListBox ID="ListBox2" runat="server" Width="308px" Visible="False" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>


        </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClientClick="calculateAndDisplayRoute(); return false;" OnClick="Button1_Click" />
        <div id="map" style="float: left; width: 70%; height: 600px"></div>
        <div style="float: right; width: 30%; height: 600px; overflow: auto">

            <div id="directionsPanel" style="height: 600px; width: 100%"></div>
        </div>
        <script type="text/javascript">
            
            function initMap() {
                var directionsService = new google.maps.DirectionsService;
                var directionsDisplay = new google.maps.DirectionsRenderer;
                var map = new google.maps.Map(document.getElementById('map'), {
                    zoom: 8,
                    center: { lat: 43.6155521, lng: 7.0695895 }
                });
                directionsDisplay.setMap(map);

            }

            function calculateAndDisplayRoute() {
                var directionsService = new google.maps.DirectionsService;
                var directionsDisplay = new google.maps.DirectionsRenderer;
                var map = new google.maps.Map(document.getElementById('map'), {
                    zoom: 8,
                    center: { lat: 43.6155521, lng: 7.0695895 }
                });
                directionsDisplay.setMap(map);
                var start = document.getElementById('start').value;
                var end = document.getElementById('end').value;
           //     if (document.getElementById('OriginOption').value === 'From a Velib Station') {
                 //   start = document.getElementById('realStart').value;
              //  }
             //   if (document.getElementById('DropDownList2').value === 'To a Velib Station') {
                  //  end = document.getElementById('realEnd').value;
             //   }
                directionsService.route({
                    origin: start,
                    destination: end,
                    travelMode: 'BICYCLING'
                }, function (response, status) {
                    if (status === 'OK') {
                        directionsDisplay.setDirections(response);
                        var summaryPanel = document.getElementById('directionsPanel');
                        directionsDisplay.setPanel(document.getElementById("directionsPanel"));
                    } else {
                        window.alert('Directions request failed due to ' + status);
                    }
                });
            }
        </script>
        
        <asp:TextBox ID="realStart" runat="server" Visible="False" OnTextChanged="realStart_TextChanged"></asp:TextBox>
        <asp:TextBox ID="realEnd" runat="server" Visible="False" OnTextChanged="realEnd_TextChanged"></asp:TextBox>

        <p>

        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        
        </p>
        
    </form>
</body>
</html>
