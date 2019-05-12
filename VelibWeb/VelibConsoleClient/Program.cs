using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibConsoleClient.VelibServer;

namespace VelibConsoleClient
{
    class Program
    {
        private static VelibServiceClient client = new VelibServiceClient();
        public static class GlobalVar
        {
            public static bool EndApp { get; set; }
        }
        

            static void Main(string[] args)
        {
            GlobalVar.EndApp = false;
            

            // Display title as the C# velib app
            Console.WriteLine("Velib Client in C#\r");
            Console.WriteLine("------------------------\n");

            while (!GlobalVar.EndApp)
            {

                // Ask the user to choose a function
                Console.WriteLine("Choose a function from the following list:");
                Console.WriteLine("\t1 - Get the list of velib stations for a given city");
                Console.WriteLine("\t2 - Get the number of the available Velib at a given station in a given city.");
                Console.WriteLine("\t3 - Get the route from one place to another");
                Console.WriteLine("\th - Help");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    switch (op)
                    {
                        case "1":
                            GetStationList();
                            break;
                        case "2":
                            GetStationInfo();
                            break;
                        case "3":
                            GetRoute();
                            break;
                        case "h":
                            GetHelp();
                            
                            break;

                        default:
                            GetRoute();
                            break;

                    }

     
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the search.\n - Details: " + e.Message);
                }


                End();
                
            }
            return;

        }

        private static void GetHelp()
        {
            Console.WriteLine(client.GetHelpAsync(0).Result);
        }

        private static async void GetStationList()
        {
            // Declare variables and set to empty
            string cityInput = "";
            string stationInput = "";
            string result = "";
            List<string> names = new List<string>();

            Console.WriteLine("Type the city you wanna consult, and then press Enter: ");
            cityInput = Console.ReadLine();
            //wait for the result
            result = client.GetAllStationsByCityAsync(cityInput).Result;
            if (!result.Equals(""))
            {
                names = result.Split('\n').ToList();
                names.Sort();
                Console.WriteLine("Total " + names.Count.ToString() + "stations:");
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine(names[i]);
                }
                //continue searching number of available Velib at a given station
                Console.WriteLine("If you want to search the number of the available Velib at a given station in this city, please enter the number of the station. If not, please press Enter.");
                stationInput = Console.ReadLine();
                if (!stationInput.Equals(""))
                {
                    string tmp = client.GetInfomationsOfStationByNameAsync(cityInput, stationInput).Result;

                    if (tmp != "Not Found!")
                    {
                        result = tmp;
                        List<string> res = new List<string>();
                        res = result.Split('\n').ToList();
                        if (stationInput.Equals("555")) //if n. station is 555, the name needs to be traited differently.
                                                        //coz it is "0-555 - ATELIER VELO"
                        {
                            Console.WriteLine("Name of Station:" + res[1].Split('-')[2]);
                        }
                        else
                        {
                            Console.WriteLine("Name of Station:" + res[1].Split('-')[1]);
                        }
                        Console.WriteLine("No. Station: " + res[0]);
                        Console.WriteLine("Bike Stands: " + res[2]);
                        Console.WriteLine("Available Bikes: " + res[4]);
                        Console.WriteLine("Available Stands: " + res[3]);
                        if (res[5] == "true")
                        {
                            Console.WriteLine("Bank Card Payment: " + "Availble");
                        }
                        else
                        {
                            Console.WriteLine("Bank Card Payment: " + "Not availble");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Please return to main page to get the correct No.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Specified contract does not exist. ");
            }
            
        }

        private static async void GetStationInfo()
        {
            // Declare variables and set to empty
            string cityInput = "";
            string stationInput = "";
            string result = "";
            List<string> names = new List<string>();

            Console.WriteLine("Please enter the no. of the station and city seperated by space (e.g. 555 Lyon): ");
            List<string> input = new List<string>();
            input = Console.ReadLine().Split(' ').ToList();
            stationInput = input[0];
            if (input.Count == 2)
            {
                cityInput = input[1];
            }
            if (!stationInput.Equals("") && !cityInput.Equals(""))
            {
                string tmp = client.GetInfomationsOfStationByNameAsync(cityInput, stationInput).Result;

                if (tmp != "Not Found!")
                {
                    result = tmp;
                    List<string> res = new List<string>();
                    res = result.Split('\n').ToList();
                    if (stationInput.Equals("555")) //if n. station is 555, the name needs to be traited differently.
                                                    //coz it is "0-555 - ATELIER VELO"
                    {
                        Console.WriteLine("Name of Station:" + res[1].Split('-')[2]);
                    }
                    else
                    {
                        Console.WriteLine("Name of Station:" + res[1].Split('-')[1]);
                    }
                    Console.WriteLine("No. Station: " + res[0]);
                    Console.WriteLine("Bike Stands: " + res[2]);
                    Console.WriteLine("Available Bikes: " + res[4]);
                    Console.WriteLine("Available Stands: " + res[3]);
                    if (res[5] == "true")
                    {
                        Console.WriteLine("Bank Card Payment: " + "Availble");
                    }
                    else
                    {
                        Console.WriteLine("Bank Card Payment: " + "Not availble");
                    }


                }
                else
                {
                    Console.WriteLine("Please return to main page to get the correct No.");
                }
            }
            
        }

        private static async void GetRoute()
        {
            // Declare variables and set to empty
            string originInput = "";
            string destinationInput = "";
            string stationInput = "";
            string cityInput = "";
            string resu = "";
            List<string> names = new List<string>();

            Console.WriteLine("Choose the orgin place please, and then press Enter: ");
            Console.WriteLine("\t1 - From a velib station in a city");
            Console.WriteLine("\t2 - From any place you want.");

            string op = Console.ReadLine();

            try
            {
                switch (op)
                {
                    case "1":
                        Console.WriteLine("Please enter the no. of the station and city seperated by space (e.g. 555 Lyon): ");
                        List<string> input = new List<string>();
                        input = Console.ReadLine().Split(' ').ToList();
                        stationInput = input[0];
                        if (input.Count == 2)
                        {
                            cityInput = input[1];
                        }
                        if (!stationInput.Equals("") && !cityInput.Equals(""))
                        {
                            string tmp = client.GetInfomationsOfStationByNameAsync(cityInput, stationInput).Result;

                            if (tmp != "Not Found!")
                            {
                                resu = tmp;
                                List<string> res = new List<string>();
                                res = resu.Split('\n').ToList();
                                string ordi = res[6] + "," + res[7];
                                ordi = ordi.Replace(" ", "");
                                originInput = ordi;

                            }
                            else
                            {
                                Console.WriteLine("Please return to main page to get the correct No.");
                            }
                        }
                
                       
                        break;
                    case "2":
                        Console.WriteLine("Please enter your origin: ");
                        originInput = Console.ReadLine();
                        break;

                    default:
                        break;

                }


            }


            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the search.\n - Details: " + e.Message);
            }

            Console.WriteLine("Choose the destination place please, and then press Enter: ");
            Console.WriteLine("\t1 - To a velib station in a city");
            Console.WriteLine("\t2 - To any place you want.");

            op = Console.ReadLine();

            try
            {
                switch (op)
                {
                    case "1":
                        Console.WriteLine("Please enter the no. of the station and city seperated by space (e.g. 555 Lyon): ");
                        List<string> input = new List<string>();
                        input = Console.ReadLine().Split(' ').ToList();
                        stationInput = input[0];
                        if (input.Count == 2)
                        {
                            cityInput = input[1];
                        }
                        if (!stationInput.Equals("") && !cityInput.Equals(""))
                        {
                            string tmp = client.GetInfomationsOfStationByNameAsync(cityInput, stationInput).Result;

                            if (tmp != "Not Found!")
                            {
                                resu = tmp;
                                List<string> res = new List<string>();
                                res = resu.Split('\n').ToList();
                                string ordi = res[6] + "," + res[7];
                                ordi = ordi.Replace(" ", "");
                                destinationInput = ordi;

                            }
                            else
                            {
                                Console.WriteLine("Please return to main page to get the correct No.");
                            }
                        }


                        break;
                    case "2":
                        Console.WriteLine("Please enter your destination: ");
                        destinationInput = Console.ReadLine();
                        break;

                    default:
                        break;

                }


            }


            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the search.\n - Details: " + e.Message);
            }
            
            //wait for the result
            List<string> result = client.GetRouteAsync(originInput, destinationInput).Result.ToList<string>();
            foreach (var item in result)
            {
                string ins = item.Replace("<b>", "");
                ins = ins.Replace("</b>", "");
                ins = ins.Replace("</div>", "");
                ins = ins.Replace("<div style=\"font-size:0.9em\">", " ");
                Console.WriteLine(ins);
            }
            

        }

            private static void End()
        {
            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing
            Console.Write("Press 'x' and Enter to close the app, or press any other key and Enter to back to the main menu: ");
            if (Console.ReadLine() == "x") GlobalVar.EndApp = true;

            Console.WriteLine("\n"); // Friendly linespacing
        }
    }
}
