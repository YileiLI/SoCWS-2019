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
        static void Main(string[] args)
        {
            bool endApp = false;
            VelibServiceClient client = new VelibServiceClient();

            // Display title as the C# velib app
            Console.WriteLine("Velib Client in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty
                string cityInput = "";
                string stationInput = "";
                string result = "";
                List<string> names = new List<string>();

                // Ask the user to choose a function
                Console.WriteLine("Choose a function from the following list:");
                Console.WriteLine("\ta - Get the list of velib stations for a given city");
                Console.WriteLine("\tb - Get the number of the available Velib at a given station in a given city.");
                Console.WriteLine("\th - Help");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    switch (op)
                    {
                        case "a":
                            Console.WriteLine("Type the city you wanna consult, and then press Enter: ");
                            cityInput = Console.ReadLine();
                            result = client.GetAllStationsByCity(cityInput);
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
                                    string tmp = client.GetInfomationsOfStationByName(cityInput, stationInput);

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
                                        Console.WriteLine("DoSomething!");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Specified contract does not exist. ");
                            }
                            break;
                        case "b":
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
                                string tmp = client.GetInfomationsOfStationByName(cityInput, stationInput);

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
                                    Console.WriteLine("DoSomething!");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("\tThis is a console client that allows to access to the IWS " +
                                "and request for the list of velib stations for a given city and the number of the available Velib at a given station. " +
                                "If you don't know the exact number of a station, please enter \'a\' to get the full list first.");
                            Console.WriteLine("P.S. For now, we offer the service for the following cities: Rouen, Toulouse, Luxembourg, Dublin, Valence, Stockholm, " +
                                "Santander, Lund, Amiens, Mulhouse, Lillestrom, Lyon, Ljubljana, Seville, Nancy, Namur, Creteil, Cergy-Pontoise, Bruxelles-Capitale, Vilnius, " +
                                "Kazan, Toyama, Marseille, Nantes, Brisbane and Besancon.");
                            break;

                    }

     
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the search.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing
                Console.Write("Press 'x' and Enter to close the app, or press any other key and Enter to back to the main menu: ");
                if (Console.ReadLine() == "x") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing

                
            }
            return;

        }
    }
}
