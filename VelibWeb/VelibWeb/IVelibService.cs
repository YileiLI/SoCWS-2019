﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibWeb
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IVelibService”。
    [ServiceContract]
    public interface IVelibService
    {
        [OperationContract]
        Task<string> GetAllStationsByCityAsync(string nameOfCity);

        [OperationContract]
        Task<string> GetInfomationsOfStationByNameAsync(string nameOfCity,string numOfStation);

        [OperationContract]
        Task<List<string>> GetRouteAsync(string origin, string destination);

        [OperationContract]
        Task<string> GetHelpAsync(int plateform);

    }
}

