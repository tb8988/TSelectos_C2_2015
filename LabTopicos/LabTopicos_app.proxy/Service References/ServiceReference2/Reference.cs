﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabTopicos_app.proxy.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CalculaIntegrales", ReplyAction="http://tempuri.org/IService1/CalculaIntegralesResponse")]
        double CalculaIntegrales(double a, double b, double c, double Constante, int operacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CalculaIntegrales", ReplyAction="http://tempuri.org/IService1/CalculaIntegralesResponse")]
        System.Threading.Tasks.Task<double> CalculaIntegralesAsync(double a, double b, double c, double Constante, int operacion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : LabTopicos_app.proxy.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<LabTopicos_app.proxy.ServiceReference2.IService1>, LabTopicos_app.proxy.ServiceReference2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CalculaIntegrales(double a, double b, double c, double Constante, int operacion) {
            return base.Channel.CalculaIntegrales(a, b, c, Constante, operacion);
        }
        
        public System.Threading.Tasks.Task<double> CalculaIntegralesAsync(double a, double b, double c, double Constante, int operacion) {
            return base.Channel.CalculaIntegralesAsync(a, b, c, Constante, operacion);
        }
    }
}