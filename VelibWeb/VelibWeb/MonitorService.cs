using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VelibWeb
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“MonitorService”。
    public class MonitorService : IMonitorService
    {

        public int GetCacheNumber()
        {
            return MonitorStat.GetCacheInfo();
        }

        public string GetDelay()
        {
            return MonitorStat.GetDelay();
        }

        public string GetRequestFromClient(string startTime, string endTime)
        {
            double start;
            double end;
            try
            {
                start = Convert.ToDouble(startTime);
                end = Convert.ToDouble(endTime);
            }
            catch (Exception e)
            {
                return "Please input a valid number";
            }
            return "Number of requests from client: " + MonitorStat.GetRequestFromClient(start, end).ToString();
        }

        public string GetRequestToVelib(string startTime, string endTime)
        {
            double start;
            double end;
            try
            {
                start = Convert.ToDouble(startTime);
                end = Convert.ToDouble(endTime);
            }
            catch (Exception e)
            {
                return "Please input a valid number";
            }
            return "Number of requests to Velib: " + MonitorStat.GetRequestNumberToVelib(start, end).ToString();
        }
    }
}
