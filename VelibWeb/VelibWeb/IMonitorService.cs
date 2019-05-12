using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VelibWeb
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IMonitorService”。
    [ServiceContract]
    public interface IMonitorService
    {
        [OperationContract]
        string GetRequestToVelib(string startTime, string endTime);

        [OperationContract]
        string GetRequestFromClient(string startTime, string endTime);

        [OperationContract]
        int GetCacheNumber();

        [OperationContract]
        string GetDelay();
    }
}
