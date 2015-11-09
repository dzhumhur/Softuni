﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Point", Namespace="http://schemas.datacontract.org/2004/07/System.Drawing")]
    [System.SerializableAttribute()]
    public partial struct Point : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int xField;
        
        private int yField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int x {
            get {
                return this.xField;
            }
            set {
                if ((this.xField.Equals(value) != true)) {
                    this.xField = value;
                    this.RaisePropertyChanged("x");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int y {
            get {
                return this.yField;
            }
            set {
                if ((this.yField.Equals(value) != true)) {
                    this.yField = value;
                    this.RaisePropertyChanged("y");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceDistanceCalculator")]
    public interface IServiceDistanceCalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDistanceCalculator/CalcDistance", ReplyAction="http://tempuri.org/IServiceDistanceCalculator/CalcDistanceResponse")]
        double CalcDistance(CalculatorClient.ServiceReference1.Point startPoint, CalculatorClient.ServiceReference1.Point endPoint);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDistanceCalculator/CalcDistance", ReplyAction="http://tempuri.org/IServiceDistanceCalculator/CalcDistanceResponse")]
        System.Threading.Tasks.Task<double> CalcDistanceAsync(CalculatorClient.ServiceReference1.Point startPoint, CalculatorClient.ServiceReference1.Point endPoint);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDistanceCalculatorChannel : CalculatorClient.ServiceReference1.IServiceDistanceCalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDistanceCalculatorClient : System.ServiceModel.ClientBase<CalculatorClient.ServiceReference1.IServiceDistanceCalculator>, CalculatorClient.ServiceReference1.IServiceDistanceCalculator {
        
        public ServiceDistanceCalculatorClient() {
        }
        
        public ServiceDistanceCalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDistanceCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDistanceCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDistanceCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CalcDistance(CalculatorClient.ServiceReference1.Point startPoint, CalculatorClient.ServiceReference1.Point endPoint) {
            return base.Channel.CalcDistance(startPoint, endPoint);
        }
        
        public System.Threading.Tasks.Task<double> CalcDistanceAsync(CalculatorClient.ServiceReference1.Point startPoint, CalculatorClient.ServiceReference1.Point endPoint) {
            return base.Channel.CalcDistanceAsync(startPoint, endPoint);
        }
    }
}