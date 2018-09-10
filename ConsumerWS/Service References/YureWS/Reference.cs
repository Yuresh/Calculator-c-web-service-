﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumerWS.YureWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://yuresh.org/webService", ConfigurationName="YureWS.Test2WebServiceSoap")]
    public interface Test2WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/add", ReplyAction="*")]
        int add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> addAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/mul", ReplyAction="*")]
        int mul(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mulAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/sub", ReplyAction="*")]
        int sub(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> subAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/div", ReplyAction="*")]
        int div(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://yuresh.org/webService/div", ReplyAction="*")]
        System.Threading.Tasks.Task<int> divAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Test2WebServiceSoapChannel : ConsumerWS.YureWS.Test2WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Test2WebServiceSoapClient : System.ServiceModel.ClientBase<ConsumerWS.YureWS.Test2WebServiceSoap>, ConsumerWS.YureWS.Test2WebServiceSoap {
        
        public Test2WebServiceSoapClient() {
        }
        
        public Test2WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Test2WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Test2WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Test2WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int add(int a, int b) {
            return base.Channel.add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int a, int b) {
            return base.Channel.addAsync(a, b);
        }
        
        public int mul(int a, int b) {
            return base.Channel.mul(a, b);
        }
        
        public System.Threading.Tasks.Task<int> mulAsync(int a, int b) {
            return base.Channel.mulAsync(a, b);
        }
        
        public int sub(int a, int b) {
            return base.Channel.sub(a, b);
        }
        
        public System.Threading.Tasks.Task<int> subAsync(int a, int b) {
            return base.Channel.subAsync(a, b);
        }
        
        public int div(int a, int b) {
            return base.Channel.div(a, b);
        }
        
        public System.Threading.Tasks.Task<int> divAsync(int a, int b) {
            return base.Channel.divAsync(a, b);
        }
    }
}
