﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Architecs.Test.SOAPJuntasService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Directivo", Namespace="http://schemas.datacontract.org/2004/07/Architecs.ReunionesService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Directivo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool B_EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_CargoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_NomPerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdDirectivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdResidenteField;
        
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
        public bool B_Estado {
            get {
                return this.B_EstadoField;
            }
            set {
                if ((this.B_EstadoField.Equals(value) != true)) {
                    this.B_EstadoField = value;
                    this.RaisePropertyChanged("B_Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Cargo {
            get {
                return this.C_CargoField;
            }
            set {
                if ((object.ReferenceEquals(this.C_CargoField, value) != true)) {
                    this.C_CargoField = value;
                    this.RaisePropertyChanged("C_Cargo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_NomPer {
            get {
                return this.C_NomPerField;
            }
            set {
                if ((object.ReferenceEquals(this.C_NomPerField, value) != true)) {
                    this.C_NomPerField = value;
                    this.RaisePropertyChanged("C_NomPer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdDirectivo {
            get {
                return this.N_IdDirectivoField;
            }
            set {
                if ((this.N_IdDirectivoField.Equals(value) != true)) {
                    this.N_IdDirectivoField = value;
                    this.RaisePropertyChanged("N_IdDirectivo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdResidente {
            get {
                return this.N_IdResidenteField;
            }
            set {
                if ((this.N_IdResidenteField.Equals(value) != true)) {
                    this.N_IdResidenteField = value;
                    this.RaisePropertyChanged("N_IdResidente");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RetornaMensaje", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListaJuntas", Namespace="http://schemas.datacontract.org/2004/07/Architecs.ReunionesService.Dominio")]
    [System.SerializableAttribute()]
    public partial class ListaJuntas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_AcuerdoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_CargoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_HoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_NomPerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_PREJUNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_TemaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string D_FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdJuntaField;
        
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
        public string C_Acuerdo {
            get {
                return this.C_AcuerdoField;
            }
            set {
                if ((object.ReferenceEquals(this.C_AcuerdoField, value) != true)) {
                    this.C_AcuerdoField = value;
                    this.RaisePropertyChanged("C_Acuerdo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Cargo {
            get {
                return this.C_CargoField;
            }
            set {
                if ((object.ReferenceEquals(this.C_CargoField, value) != true)) {
                    this.C_CargoField = value;
                    this.RaisePropertyChanged("C_Cargo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Hora {
            get {
                return this.C_HoraField;
            }
            set {
                if ((object.ReferenceEquals(this.C_HoraField, value) != true)) {
                    this.C_HoraField = value;
                    this.RaisePropertyChanged("C_Hora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_NomPer {
            get {
                return this.C_NomPerField;
            }
            set {
                if ((object.ReferenceEquals(this.C_NomPerField, value) != true)) {
                    this.C_NomPerField = value;
                    this.RaisePropertyChanged("C_NomPer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_PREJUN {
            get {
                return this.C_PREJUNField;
            }
            set {
                if ((object.ReferenceEquals(this.C_PREJUNField, value) != true)) {
                    this.C_PREJUNField = value;
                    this.RaisePropertyChanged("C_PREJUN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Tema {
            get {
                return this.C_TemaField;
            }
            set {
                if ((object.ReferenceEquals(this.C_TemaField, value) != true)) {
                    this.C_TemaField = value;
                    this.RaisePropertyChanged("C_Tema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string D_Fecha {
            get {
                return this.D_FechaField;
            }
            set {
                if ((object.ReferenceEquals(this.D_FechaField, value) != true)) {
                    this.D_FechaField = value;
                    this.RaisePropertyChanged("D_Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdJunta {
            get {
                return this.N_IdJuntaField;
            }
            set {
                if ((this.N_IdJuntaField.Equals(value) != true)) {
                    this.N_IdJuntaField = value;
                    this.RaisePropertyChanged("N_IdJunta");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPJuntasService.IJuntaService")]
    public interface IJuntaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJuntaService/listarDirectivos", ReplyAction="http://tempuri.org/IJuntaService/listarDirectivosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Test.SOAPJuntasService.RetornaMensaje), Action="http://tempuri.org/IJuntaService/listarDirectivosRetornaMensajeFault", Name="RetornaMensaje", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        System.Collections.Generic.List<Architecs.Test.SOAPJuntasService.Directivo> listarDirectivos(string C_NomPer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJuntaService/CreaJunta", ReplyAction="http://tempuri.org/IJuntaService/CreaJuntaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Test.SOAPJuntasService.RetornaMensaje), Action="http://tempuri.org/IJuntaService/CreaJuntaRetornaMensajeFault", Name="RetornaMensaje", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        int CreaJunta(System.DateTime D_Fecha, string C_Hora, string C_Tema, string C_Acuerdo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJuntaService/CreaJuntaDirectivos", ReplyAction="http://tempuri.org/IJuntaService/CreaJuntaDirectivosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Test.SOAPJuntasService.RetornaMensaje), Action="http://tempuri.org/IJuntaService/CreaJuntaDirectivosRetornaMensajeFault", Name="RetornaMensaje", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        int CreaJuntaDirectivos(int N_IdJunta, int N_IdDirectivo, string C_PreJun, bool B_Estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJuntaService/listarJuntas", ReplyAction="http://tempuri.org/IJuntaService/listarJuntasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Test.SOAPJuntasService.RetornaMensaje), Action="http://tempuri.org/IJuntaService/listarJuntasRetornaMensajeFault", Name="RetornaMensaje", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        System.Collections.Generic.List<Architecs.Test.SOAPJuntasService.ListaJuntas> listarJuntas(string fechaini, string fechafin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJuntaServiceChannel : Architecs.Test.SOAPJuntasService.IJuntaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JuntaServiceClient : System.ServiceModel.ClientBase<Architecs.Test.SOAPJuntasService.IJuntaService>, Architecs.Test.SOAPJuntasService.IJuntaService {
        
        public JuntaServiceClient() {
        }
        
        public JuntaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JuntaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JuntaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JuntaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Architecs.Test.SOAPJuntasService.Directivo> listarDirectivos(string C_NomPer) {
            return base.Channel.listarDirectivos(C_NomPer);
        }
        
        public int CreaJunta(System.DateTime D_Fecha, string C_Hora, string C_Tema, string C_Acuerdo) {
            return base.Channel.CreaJunta(D_Fecha, C_Hora, C_Tema, C_Acuerdo);
        }
        
        public int CreaJuntaDirectivos(int N_IdJunta, int N_IdDirectivo, string C_PreJun, bool B_Estado) {
            return base.Channel.CreaJuntaDirectivos(N_IdJunta, N_IdDirectivo, C_PreJun, B_Estado);
        }
        
        public System.Collections.Generic.List<Architecs.Test.SOAPJuntasService.ListaJuntas> listarJuntas(string fechaini, string fechafin) {
            return base.Channel.listarJuntas(fechaini, fechafin);
        }
    }
}
