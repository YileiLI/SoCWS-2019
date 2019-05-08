using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace VelibWeb
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“VelibService”。
    public class VelibService : IVelibService
    {
        ObjectCache cacheOfCity;
        ObjectCache cacheOfStation;
        CacheItemPolicy cacheItemPolicy;
        WebRequest request;
        WebResponse response;
        Stream dataStream;
        StreamReader reader;
        string responseFromServer;

        public VelibService()
        {
            cacheOfCity = MemoryCache.Default;
            cacheOfStation = MemoryCache.Default;
            cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.SlidingExpiration = new TimeSpan(0, 40, 0);
        }

       
        public async Task<string> GetAllStationsByCityAsync(string nameOfCity)
        {
            if (cacheOfCity[nameOfCity] != null)
            {
                return (string)cacheOfCity[nameOfCity];
            }
        
            string res= "";
            request = WebRequest.Create(
                "https://api.jcdecaux.com/vls/v1/stations?contract="+nameOfCity+"&apiKey=3857a4c9c72e34c322bd73cd36dec39dd7d15dd9");
            try
            {
                response = await request.GetResponseAsync();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                List<RootObject> rb = JsonConvert.DeserializeObject<List<RootObject>>(responseFromServer);
                foreach (RootObject ob in rb)
                {
                    res = res + ob.name + "\n";
                }
                cacheOfCity.Set(nameOfCity, res, cacheItemPolicy);
            }
            catch (WebException wex)
            {
                Console.WriteLine("Web Exception");
            }
            return res;
        }

        public async Task<string> GetInfomationsOfStationByNameAsync(string nameOfCity,string numOfStation)
        {
            if (cacheOfStation[numOfStation]!=null)
            {
                return (string)cacheOfStation[numOfStation];
            }
            request = WebRequest.Create(
                "https://api.jcdecaux.com/vls/v1/stations/" + numOfStation + "?contract="+ nameOfCity + "&apiKey=3857a4c9c72e34c322bd73cd36dec39dd7d15dd9");
            Console.WriteLine(nameOfCity + numOfStation);
            try
            {
                response = await request.GetResponseAsync();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                if (responseFromServer.Length > 50)
                {
                    RootObject rb = JsonConvert.DeserializeObject<RootObject>(responseFromServer);
                    cacheOfStation.Set(numOfStation, rb.ToString(), cacheItemPolicy);
                    return rb.ToString();
                }
                else
                {
                    return "Not Found!";
                }
            }
            catch (WebException wex)
            {
                Console.WriteLine("Web Exception");
                return "Not Found!";
            }

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

        override
        public string ToString()
        {
            return number + "\n" +
                name + "\n" +
                bike_stands + "\n" +
                available_bike_stands + "\n" +
                available_bikes + "\n" +
                banking;
        }
    }

}
