﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.SOAPagosService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RetornaMensaje", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class RetornaMensaje : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoRetornoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ExitoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensageField;
        
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
        public string CodigoError {
            get {
                return this.CodigoErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoErrorField, value) != true)) {
                    this.CodigoErrorField = value;
                    this.RaisePropertyChanged("CodigoError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoRetorno {
            get {
                return this.CodigoRetornoField;
            }
            set {
                if ((this.CodigoRetornoField.Equals(value) != true)) {
                    this.CodigoRetornoField = value;
                    this.RaisePropertyChanged("CodigoRetorno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Exito {
            get {
                return this.ExitoField;
            }
            set {
                if ((this.ExitoField.Equals(value) != true)) {
                    this.ExitoField = value;
                    this.RaisePropertyChanged("Exito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensage {
            get {
                return this.MensageField;
            }
            set {
                if ((object.ReferenceEquals(this.MensageField, value) != true)) {
                    this.MensageField = value;
                    this.RaisePropertyChanged("Mensage");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPagosService.IPagosService")]
    public interface IPagosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagosService/ListarTipoPago", ReplyAction="http://tempuri.org/IPagosService/ListarTipoPagoResponse")]
        Architects.Dominio.TipoPago[] ListarTipoPago();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagosService/RegistrarTipoPago", ReplyAction="http://tempuri.org/IPagosService/RegistrarTipoPagoResponse")]
        Architects.Dominio.TipoPago RegistrarTipoPago(string Descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagosService/RegistrarCuota", ReplyAction="http://tempuri.org/IPagosService/RegistrarCuotaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Test.SOAPagosService.RetornaMensaje), Action="http://tempuri.org/IPagosService/RegistrarCuotaRetornaMensajeFault", Name="RetornaMensaje", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
        Test.SOAPagosService.RetornaMensaje RegistrarCuota(string C_Periodo, int N_IdVivienda, int N_IdTipoPago, decimal N_Importe, System.DateTime D_FecVncto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPagosServiceChannel : Test.SOAPagosService.IPagosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PagosServiceClient : System.ServiceModel.ClientBase<Test.SOAPagosService.IPagosService>, Test.SOAPagosService.IPagosService {
        
        public PagosServiceClient() {
        }
        
        public PagosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PagosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Architects.Dominio.TipoPago[] ListarTipoPago() {
            return base.Channel.ListarTipoPago();
        }
        
        public Architects.Dominio.TipoPago RegistrarTipoPago(string Descripcion) {
            return base.Channel.RegistrarTipoPago(Descripcion);
        }
        
        public Test.SOAPagosService.RetornaMensaje RegistrarCuota(string C_Periodo, int N_IdVivienda, int N_IdTipoPago, decimal N_Importe, System.DateTime D_FecVncto) {
            return base.Channel.RegistrarCuota(C_Periodo, N_IdVivienda, N_IdTipoPago, N_Importe, D_FecVncto);
        }
    }
}
