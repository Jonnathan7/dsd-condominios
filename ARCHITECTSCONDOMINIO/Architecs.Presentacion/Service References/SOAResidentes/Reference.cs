﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Architecs.Presentacion.SOAResidentes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResidenteBE", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
    [System.SerializableAttribute()]
    public partial class ResidenteBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool B_EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_ClaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_NumDocumeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime D_FecNacimiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdResidenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_TipoDocField;
        
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
        public string C_Apellidos {
            get {
                return this.C_ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.C_ApellidosField, value) != true)) {
                    this.C_ApellidosField = value;
                    this.RaisePropertyChanged("C_Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Clave {
            get {
                return this.C_ClaveField;
            }
            set {
                if ((object.ReferenceEquals(this.C_ClaveField, value) != true)) {
                    this.C_ClaveField = value;
                    this.RaisePropertyChanged("C_Clave");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Correo {
            get {
                return this.C_CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.C_CorreoField, value) != true)) {
                    this.C_CorreoField = value;
                    this.RaisePropertyChanged("C_Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Nombre {
            get {
                return this.C_NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.C_NombreField, value) != true)) {
                    this.C_NombreField = value;
                    this.RaisePropertyChanged("C_Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_NumDocume {
            get {
                return this.C_NumDocumeField;
            }
            set {
                if ((object.ReferenceEquals(this.C_NumDocumeField, value) != true)) {
                    this.C_NumDocumeField = value;
                    this.RaisePropertyChanged("C_NumDocume");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime D_FecNacimi {
            get {
                return this.D_FecNacimiField;
            }
            set {
                if ((this.D_FecNacimiField.Equals(value) != true)) {
                    this.D_FecNacimiField = value;
                    this.RaisePropertyChanged("D_FecNacimi");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_TipoDoc {
            get {
                return this.N_TipoDocField;
            }
            set {
                if ((this.N_TipoDocField.Equals(value) != true)) {
                    this.N_TipoDocField = value;
                    this.RaisePropertyChanged("N_TipoDoc");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
    [System.SerializableAttribute()]
    public partial class ValidationException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValidationErrorField;
        
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
        public string ValidationError {
            get {
                return this.ValidationErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ValidationErrorField, value) != true)) {
                    this.ValidationErrorField = value;
                    this.RaisePropertyChanged("ValidationError");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAResidentes.IResidenteService")]
    public interface IResidenteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/ListarResidentes", ReplyAction="http://tempuri.org/IResidenteService/ListarResidentesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/ListarResidentesValidationExceptionFault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        Architecs.Presentacion.SOAResidentes.ResidenteBE[] ListarResidentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/BuscarResidentes", ReplyAction="http://tempuri.org/IResidenteService/BuscarResidentesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/BuscarResidentesValidationExceptionFault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        Architecs.Presentacion.SOAResidentes.ResidenteBE[] BuscarResidentes(string nombre, string apellidos, string numDocumento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/ListarResidentesPaginado", ReplyAction="http://tempuri.org/IResidenteService/ListarResidentesPaginadoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/ListarResidentesPaginadoValidationExceptionF" +
            "ault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        Architecs.Presentacion.SOAResidentes.ResidenteBE[] ListarResidentesPaginado(int page, int size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/ObtenerResidentePorID", ReplyAction="http://tempuri.org/IResidenteService/ObtenerResidentePorIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/ObtenerResidentePorIDValidationExceptionFaul" +
            "t", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        Architecs.Presentacion.SOAResidentes.ResidenteBE ObtenerResidentePorID(int residente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/ObtenerResidentePorNroDocumento", ReplyAction="http://tempuri.org/IResidenteService/ObtenerResidentePorNroDocumentoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/ObtenerResidentePorNroDocumentoValidationExc" +
            "eptionFault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        Architecs.Presentacion.SOAResidentes.ResidenteBE ObtenerResidentePorNroDocumento(string numeroDocumento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/CrearResidente", ReplyAction="http://tempuri.org/IResidenteService/CrearResidenteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/CrearResidenteValidationExceptionFault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        int CrearResidente(Architecs.Presentacion.SOAResidentes.ResidenteBE prmResidente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/ActualizarResidente", ReplyAction="http://tempuri.org/IResidenteService/ActualizarResidenteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/ActualizarResidenteValidationExceptionFault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        Architecs.Presentacion.SOAResidentes.ValidationException ActualizarResidente(Architecs.Presentacion.SOAResidentes.ResidenteBE prmResidente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidenteService/EliminarResidente", ReplyAction="http://tempuri.org/IResidenteService/EliminarResidenteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Architecs.Presentacion.SOAResidentes.ValidationException), Action="http://tempuri.org/IResidenteService/EliminarResidenteValidationExceptionFault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/Architects.Dominio")]
        Architecs.Presentacion.SOAResidentes.ValidationException EliminarResidente(int residenteID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResidenteServiceChannel : Architecs.Presentacion.SOAResidentes.IResidenteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResidenteServiceClient : System.ServiceModel.ClientBase<Architecs.Presentacion.SOAResidentes.IResidenteService>, Architecs.Presentacion.SOAResidentes.IResidenteService {
        
        public ResidenteServiceClient() {
        }
        
        public ResidenteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ResidenteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResidenteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResidenteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Architecs.Presentacion.SOAResidentes.ResidenteBE[] ListarResidentes() {
            return base.Channel.ListarResidentes();
        }
        
        public Architecs.Presentacion.SOAResidentes.ResidenteBE[] BuscarResidentes(string nombre, string apellidos, string numDocumento) {
            return base.Channel.BuscarResidentes(nombre, apellidos, numDocumento);
        }
        
        public Architecs.Presentacion.SOAResidentes.ResidenteBE[] ListarResidentesPaginado(int page, int size) {
            return base.Channel.ListarResidentesPaginado(page, size);
        }
        
        public Architecs.Presentacion.SOAResidentes.ResidenteBE ObtenerResidentePorID(int residente) {
            return base.Channel.ObtenerResidentePorID(residente);
        }
        
        public Architecs.Presentacion.SOAResidentes.ResidenteBE ObtenerResidentePorNroDocumento(string numeroDocumento) {
            return base.Channel.ObtenerResidentePorNroDocumento(numeroDocumento);
        }
        
        public int CrearResidente(Architecs.Presentacion.SOAResidentes.ResidenteBE prmResidente) {
            return base.Channel.CrearResidente(prmResidente);
        }
        
        public Architecs.Presentacion.SOAResidentes.ValidationException ActualizarResidente(Architecs.Presentacion.SOAResidentes.ResidenteBE prmResidente) {
            return base.Channel.ActualizarResidente(prmResidente);
        }
        
        public Architecs.Presentacion.SOAResidentes.ValidationException EliminarResidente(int residenteID) {
            return base.Channel.EliminarResidente(residenteID);
        }
    }
}
