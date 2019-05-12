﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monitor.MonitorServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MonitorServer.IMonitorService")]
    public interface IMonitorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetRequestToVelib", ReplyAction="http://tempuri.org/IMonitorService/GetRequestToVelibResponse")]
        string GetRequestToVelib(string startTime, string endTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetRequestToVelib", ReplyAction="http://tempuri.org/IMonitorService/GetRequestToVelibResponse")]
        System.Threading.Tasks.Task<string> GetRequestToVelibAsync(string startTime, string endTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetRequestFromClient", ReplyAction="http://tempuri.org/IMonitorService/GetRequestFromClientResponse")]
        string GetRequestFromClient(string startTime, string endTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetRequestFromClient", ReplyAction="http://tempuri.org/IMonitorService/GetRequestFromClientResponse")]
        System.Threading.Tasks.Task<string> GetRequestFromClientAsync(string startTime, string endTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetCacheNumber", ReplyAction="http://tempuri.org/IMonitorService/GetCacheNumberResponse")]
        int GetCacheNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetCacheNumber", ReplyAction="http://tempuri.org/IMonitorService/GetCacheNumberResponse")]
        System.Threading.Tasks.Task<int> GetCacheNumberAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetDelay", ReplyAction="http://tempuri.org/IMonitorService/GetDelayResponse")]
        string GetDelay();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitorService/GetDelay", ReplyAction="http://tempuri.org/IMonitorService/GetDelayResponse")]
        System.Threading.Tasks.Task<string> GetDelayAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMonitorServiceChannel : Monitor.MonitorServer.IMonitorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MonitorServiceClient : System.ServiceModel.ClientBase<Monitor.MonitorServer.IMonitorService>, Monitor.MonitorServer.IMonitorService {
        
        public MonitorServiceClient() {
        }
        
        public MonitorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MonitorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetRequestToVelib(string startTime, string endTime) {
            return base.Channel.GetRequestToVelib(startTime, endTime);
        }
        
        public System.Threading.Tasks.Task<string> GetRequestToVelibAsync(string startTime, string endTime) {
            return base.Channel.GetRequestToVelibAsync(startTime, endTime);
        }
        
        public string GetRequestFromClient(string startTime, string endTime) {
            return base.Channel.GetRequestFromClient(startTime, endTime);
        }
        
        public System.Threading.Tasks.Task<string> GetRequestFromClientAsync(string startTime, string endTime) {
            return base.Channel.GetRequestFromClientAsync(startTime, endTime);
        }
        
        public int GetCacheNumber() {
            return base.Channel.GetCacheNumber();
        }
        
        public System.Threading.Tasks.Task<int> GetCacheNumberAsync() {
            return base.Channel.GetCacheNumberAsync();
        }
        
        public string GetDelay() {
            return base.Channel.GetDelay();
        }
        
        public System.Threading.Tasks.Task<string> GetDelayAsync() {
            return base.Channel.GetDelayAsync();
        }
    }
}