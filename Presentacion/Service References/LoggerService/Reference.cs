﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentacion.LoggerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoggerService.IJobLoggerService")]
    public interface IJobLoggerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobLoggerService/SaveLogger", ReplyAction="http://tempuri.org/IJobLoggerService/SaveLoggerResponse")]
        Belatrix.Logger.Transversal.Response<bool> SaveLogger(Belatrix.Logger.Service.DTO.JobLoggerDTO logger);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobLoggerService/SaveLogger", ReplyAction="http://tempuri.org/IJobLoggerService/SaveLoggerResponse")]
        System.Threading.Tasks.Task<Belatrix.Logger.Transversal.Response<bool>> SaveLoggerAsync(Belatrix.Logger.Service.DTO.JobLoggerDTO logger);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobLoggerServiceChannel : Presentacion.LoggerService.IJobLoggerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobLoggerServiceClient : System.ServiceModel.ClientBase<Presentacion.LoggerService.IJobLoggerService>, Presentacion.LoggerService.IJobLoggerService {
        
        public JobLoggerServiceClient() {
        }
        
        public JobLoggerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobLoggerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobLoggerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobLoggerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Belatrix.Logger.Transversal.Response<bool> SaveLogger(Belatrix.Logger.Service.DTO.JobLoggerDTO logger) {
            return base.Channel.SaveLogger(logger);
        }
        
        public System.Threading.Tasks.Task<Belatrix.Logger.Transversal.Response<bool>> SaveLoggerAsync(Belatrix.Logger.Service.DTO.JobLoggerDTO logger) {
            return base.Channel.SaveLoggerAsync(logger);
        }
    }
}
