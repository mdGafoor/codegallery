﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sixeyed.OptimisticLockingSample.Client.CustomerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://Sixeyed.OptimisticLockingSample/2009")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float CreditLimitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] LogoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float CreditLimit {
            get {
                return this.CreditLimitField;
            }
            set {
                if ((this.CreditLimitField.Equals(value) != true)) {
                    this.CreditLimitField = value;
                    this.RaisePropertyChanged("CreditLimit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Logo {
            get {
                return this.LogoField;
            }
            set {
                if ((object.ReferenceEquals(this.LogoField, value) != true)) {
                    this.LogoField = value;
                    this.RaisePropertyChanged("Logo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Sixeyed.OptimisticLockingSample/2009", ConfigurationName="CustomerService.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Sixeyed.OptimisticLockingSample/2009/ICustomerService/GetCustomer", ReplyAction="http://Sixeyed.OptimisticLockingSample/2009/ICustomerService/GetCustomerResponse")]
        Sixeyed.OptimisticLockingSample.Client.CustomerService.Customer GetCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Sixeyed.OptimisticLockingSample/2009/ICustomerService/UpdateCustomer", ReplyAction="http://Sixeyed.OptimisticLockingSample/2009/ICustomerService/UpdateCustomerRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(Sixeyed.OptimisticLockingSample.ServiceModel.FaultDetail.ConcurrencyViolation), Action="http://Sixeyed.OptimisticLockingSample/2009/ICustomerService/UpdateCustomerConcur" +
            "rencyViolationFault", Name="ConcurrencyViolation")]
        [System.ServiceModel.FaultContractAttribute(typeof(Sixeyed.OptimisticLockingSample.ServiceModel.FaultDetail.NoDataSignature), Action="http://Sixeyed.OptimisticLockingSample/2009/ICustomerService/UpdateCustomerNoData" +
            "SignatureFault", Name="NoDataSignature")]
        void UpdateCustomer(Sixeyed.OptimisticLockingSample.Client.CustomerService.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICustomerServiceChannel : Sixeyed.OptimisticLockingSample.Client.CustomerService.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<Sixeyed.OptimisticLockingSample.Client.CustomerService.ICustomerService>, Sixeyed.OptimisticLockingSample.Client.CustomerService.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sixeyed.OptimisticLockingSample.Client.CustomerService.Customer GetCustomer(int id) {
            return base.Channel.GetCustomer(id);
        }
        
        public void UpdateCustomer(Sixeyed.OptimisticLockingSample.Client.CustomerService.Customer customer) {
            base.Channel.UpdateCustomer(customer);
        }
    }
}
