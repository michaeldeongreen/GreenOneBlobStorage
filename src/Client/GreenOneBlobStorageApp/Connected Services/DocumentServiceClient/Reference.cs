﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenOneBlobStorageApp.DocumentServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentServicePostRequest", Namespace="http://schemas.datacontract.org/2004/07/GreenOneBlobStorageService.Domain")]
    [System.SerializableAttribute()]
    public partial class DocumentServicePostRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<GreenOneBlobStorage.Common.Document> DocumentsField;
        
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
        public System.Collections.Generic.List<GreenOneBlobStorage.Common.Document> Documents {
            get {
                return this.DocumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentsField, value) != true)) {
                    this.DocumentsField = value;
                    this.RaisePropertyChanged("Documents");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentServicePostResponse", Namespace="http://schemas.datacontract.org/2004/07/GreenOneBlobStorageService.Domain")]
    [System.SerializableAttribute()]
    public partial class DocumentServicePostResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<System.Guid> DocumentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
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
        public System.Collections.Generic.List<System.Guid> Documents {
            get {
                return this.DocumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentsField, value) != true)) {
                    this.DocumentsField = value;
                    this.RaisePropertyChanged("Documents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentServiceDeleteRequest", Namespace="http://schemas.datacontract.org/2004/07/GreenOneBlobStorageService.Domain")]
    [System.SerializableAttribute()]
    public partial class DocumentServiceDeleteRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<GreenOneBlobStorage.Common.Document> DocumentsField;
        
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
        public System.Collections.Generic.List<GreenOneBlobStorage.Common.Document> Documents {
            get {
                return this.DocumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentsField, value) != true)) {
                    this.DocumentsField = value;
                    this.RaisePropertyChanged("Documents");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentServiceDeleteResponse", Namespace="http://schemas.datacontract.org/2004/07/GreenOneBlobStorageService.Domain")]
    [System.SerializableAttribute()]
    public partial class DocumentServiceDeleteResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<System.Guid> DocumentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
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
        public System.Collections.Generic.List<System.Guid> Documents {
            get {
                return this.DocumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentsField, value) != true)) {
                    this.DocumentsField = value;
                    this.RaisePropertyChanged("Documents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DocumentServiceClient.IDocumentService")]
    public interface IDocumentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/Post", ReplyAction="http://tempuri.org/IDocumentService/PostResponse")]
        GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostResponse Post(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/Post", ReplyAction="http://tempuri.org/IDocumentService/PostResponse")]
        System.Threading.Tasks.Task<GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostResponse> PostAsync(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/Get", ReplyAction="http://tempuri.org/IDocumentService/GetResponse")]
        GreenOneBlobStorage.Common.Document Get(GreenOneBlobStorage.Common.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/Get", ReplyAction="http://tempuri.org/IDocumentService/GetResponse")]
        System.Threading.Tasks.Task<GreenOneBlobStorage.Common.Document> GetAsync(GreenOneBlobStorage.Common.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/Delete", ReplyAction="http://tempuri.org/IDocumentService/DeleteResponse")]
        GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteResponse Delete(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/Delete", ReplyAction="http://tempuri.org/IDocumentService/DeleteResponse")]
        System.Threading.Tasks.Task<GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteResponse> DeleteAsync(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDocumentServiceChannel : GreenOneBlobStorageApp.DocumentServiceClient.IDocumentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentServiceClient : System.ServiceModel.ClientBase<GreenOneBlobStorageApp.DocumentServiceClient.IDocumentService>, GreenOneBlobStorageApp.DocumentServiceClient.IDocumentService {
        
        public DocumentServiceClient() {
        }
        
        public DocumentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocumentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostResponse Post(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostRequest request) {
            return base.Channel.Post(request);
        }
        
        public System.Threading.Tasks.Task<GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostResponse> PostAsync(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServicePostRequest request) {
            return base.Channel.PostAsync(request);
        }
        
        public GreenOneBlobStorage.Common.Document Get(GreenOneBlobStorage.Common.Document document) {
            return base.Channel.Get(document);
        }
        
        public System.Threading.Tasks.Task<GreenOneBlobStorage.Common.Document> GetAsync(GreenOneBlobStorage.Common.Document document) {
            return base.Channel.GetAsync(document);
        }
        
        public GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteResponse Delete(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteRequest request) {
            return base.Channel.Delete(request);
        }
        
        public System.Threading.Tasks.Task<GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteResponse> DeleteAsync(GreenOneBlobStorageApp.DocumentServiceClient.DocumentServiceDeleteRequest request) {
            return base.Channel.DeleteAsync(request);
        }
    }
}
