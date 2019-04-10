﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VelibWeb
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“VelibService”。
    public class VelibService : IVelibService
    {
        WebRequest request;
        WebResponse response;
        Stream dataStream;
        StreamReader reader;
        string responseFromServer;

        public void DoWork()
        {
        }

        public List<RootObject> getAllStationsByCity(string nameOfCity)
        {
            request = WebRequest.Create(
                "https://api.jcdecaux.com/vls/v1/stations?contract=Toulouse&apiKey=3857a4c9c72e34c322bd73cd36dec39dd7d15dd9");
            response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            reader = new StreamReader(dataStream);
            // Read the content.
            responseFromServer = reader.ReadToEnd();





            return null;

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