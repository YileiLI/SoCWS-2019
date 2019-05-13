using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibWeb
{
    class MonitorStat
    {
        private static List<double> requestsToVelib = new List<double>();
        private static List<double> requestFromClient = new List<double>();
        private static List<double> delays = new List<double>();
        private static int cacheSize = 0;
        private static int requestToJce = 0;

        public static void AddRequestToVelib()
        {
            requestsToVelib.Add(Convert.ToDouble(DateTime.Now.ToString("yyMMddHHmmss.ffff")));
        }

        public static int GetRequestNumberToVelib(double startTime, double endTime)
        {
            int numberOfRequest = 0;

            foreach (double request in requestsToVelib)
            {
                if (request < endTime && request > startTime)
                {
                    numberOfRequest++;
                }
            }

            return numberOfRequest;
        }

        public static void AddCacheInfo()
        {
            cacheSize++;
        }

        public static int GetCacheInfo()
        {
            return cacheSize;
        }

        public static void AddRequestFromClient()
        {
            requestFromClient.Add(Convert.ToDouble(DateTime.Now.ToString("yyMMddHHmmss.ffff")));

        }

        public static int GetRequestFromClient(double startTime, double endTime)
        {
            int numberOfRequest = 0;

            foreach (double request in requestFromClient)
            {
                if (request < endTime && request > startTime)
                {
                    numberOfRequest++;
                }
            }

            return numberOfRequest;
        }

        public static void AddDelay(double delay)
        {
            delays.Add(delay);
        }

        public static string GetDelay()
        {
            double sum = 0;
            foreach (double delay in delays)
            {
                sum += delay;
            }
            return (sum / delays.Count).ToString("f4");
        }
    }
}
