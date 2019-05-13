using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        ObjectCache cacheOfRoute;
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
            cacheOfRoute = MemoryCache.Default;
            cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.SlidingExpiration = new TimeSpan(0, 40, 0);
        }

       
        public async Task<string> GetAllStationsByCityAsync(string nameOfCity)
        {
            DateTime start = DateTime.Now;
            MonitorStat.AddRequestFromClient();
            if (cacheOfCity[nameOfCity] != null)
            {
                MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
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
                MonitorStat.AddRequestToVelib();
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                List<RootObject> rb = JsonConvert.DeserializeObject<List<RootObject>>(responseFromServer);
                foreach (RootObject ob in rb)
                {
                    res = res + ob.name + "\n";
                }
                cacheOfCity.Set(nameOfCity, res, cacheItemPolicy);
                MonitorStat.AddCacheInfo();
                MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
            }
            catch (WebException wex)
            {
                MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
                Console.WriteLine("Web Exception" + wex);
            }
            return res;
        }

        public async Task<string> GetInfomationsOfStationByNameAsync(string nameOfCity,string numOfStation)
        {
            DateTime start = DateTime.Now;
            MonitorStat.AddRequestFromClient();
            if (cacheOfStation[numOfStation]!=null)
            {
                MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
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
                MonitorStat.AddRequestToVelib();
                responseFromServer = reader.ReadToEnd();
                if (responseFromServer.Length > 50)
                {
                    RootObject rb = JsonConvert.DeserializeObject<RootObject>(responseFromServer);
                    cacheOfStation.Set(numOfStation, rb.ToString(), cacheItemPolicy);
                    MonitorStat.AddCacheInfo();
                    MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
                    return rb.ToString();
                }
                else
                {
                    MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
                    return "Not Found!";
                }
            }
            catch (WebException wex)
            {
                Console.WriteLine("Web Exception" + wex);
                MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
                return "Not Found!";
            }

        }

        public async Task<List<string>> GetRouteAsync(string origin, string destination)
        {
            DateTime start = DateTime.Now;
            MonitorStat.AddRequestFromClient();
            string key = origin + destination;
            if (cacheOfRoute[key] != null)
            {
                MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
                return (List<string>)cacheOfRoute[key];
            }
            var res = new List<string>();
            string ways = "";
            try
            {
                
                JObject route = (JObject)(await GetArray("https://maps.googleapis.com/maps/api/directions/json?mode=bicycling&origin=" + 
                    origin + "&destination="+ destination +"&key=AIzaSyBx25Hq3Xadi0gqGIKVx8S7z9YfhJAp8gk"));
                
                if (((string)route["geocoded_waypoints"][0]["geocoder_status"]).Equals("OK") 
                    && ((string)route["geocoded_waypoints"][1]["geocoder_status"]).Equals("OK"))
                {

                    if (route["routes"].HasValues)
                    {
                        ways = "Distance: " + route["routes"][0]["legs"][0]["distance"]["text"] + "\nDuration: "
                            + route["routes"][0]["legs"][0]["duration"]["text"];
                        res.Add(ways);
                        int i = 1;
                        foreach (var step in route["routes"][0]["legs"][0]["steps"])
                        {
                        
                            ways = i + ". " + step["html_instructions"] + "\n\t" +step["distance"]["text"] 
                                + "\n\t" + step["duration"]["text"];
                            res.Add(ways);
                            i++;
                        }
                        
                    }
                    else
                    {
                        ways = "Couldn't find routes for you.";
                        res.Add(ways);
                    }
                }
                else
                {
                    ways = "Try Again";
                    res.Add(ways);
                }
                
            }
            catch (WebException wex)
            {
                Console.WriteLine("Web Exception");
                ways = "Not Found!";
                res.Add(ways);
            }
            cacheOfRoute.Set(key, res, cacheItemPolicy);
            MonitorStat.AddCacheInfo();
            MonitorStat.AddDelay(DateTime.Now.Subtract(start).TotalMilliseconds);
            return res;
        }
        private async Task<JObject> GetArray(string requestUrl)
        {
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(requestUrl);
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = await request.GetResponseAsync();
            // Display the status.
            // Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            MonitorStat.AddRequestToVelib();
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            return JObject.Parse(responseFromServer);
        }

        public async Task<string> GetHelpAsync(int plateform)
        {
            string str = "";
            switch (plateform)
            {
                case 0://console
                    str += "\tThis is a console client that allows to access to the IWS " +
                                "and request for the list of velib stations for a given city and the number of the available Velib at a given station. " +
                                "If you don't know the exact number of a station, please enter \'1\' to get the full list first.\n"
                                + "P.S. For now, we offer the service for the following cities: Rouen, Toulouse, Luxembourg, Dublin, Valence, Stockholm, " +
                                "Santander, Lund, Amiens, Mulhouse, Lillestrom, Lyon, Ljubljana, Seville, Nancy, Namur, Creteil, Cergy-Pontoise, Bruxelles-Capitale, Vilnius, " +
                                "Kazan, Toyama, Marseille, Nantes, Brisbane and Besancon.";
                    break;
                default:
                    str += "Press the flag of which country you want to know about the Velib Service and select the city." +
                        "Press the route icon to get the route information supported by Google Map. ";
                    break;
            }
            return str;
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
                banking + "\n" +
                position.lat + "\n" +
                position.lng;
        }
    }

}
