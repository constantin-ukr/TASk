﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.DataT3Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Seminar", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class Seminar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MemoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Memo {
            get {
                return this.MemoField;
            }
            set {
                if ((object.ReferenceEquals(this.MemoField, value) != true)) {
                    this.MemoField = value;
                    this.RaisePropertyChanged("Memo");
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
        public string Tax {
            get {
                return this.TaxField;
            }
            set {
                if ((object.ReferenceEquals(this.TaxField, value) != true)) {
                    this.TaxField = value;
                    this.RaisePropertyChanged("Tax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataT3Service.IT3Interface")]
    public interface IT3Interface {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/GetSeminars", ReplyAction="http://tempuri.org/IT3Interface/GetSeminarsResponse")]
        System.Collections.Generic.List<Client.DataT3Service.Seminar> GetSeminars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/GetPersons", ReplyAction="http://tempuri.org/IT3Interface/GetPersonsResponse")]
        System.Collections.Generic.List<Client.DataT3Service.Person> GetPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/GetPersonsForSeminar", ReplyAction="http://tempuri.org/IT3Interface/GetPersonsForSeminarResponse")]
        System.Collections.Generic.List<Client.DataT3Service.Person> GetPersonsForSeminar(Client.DataT3Service.Seminar seminar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/GetSeminarsForPerson", ReplyAction="http://tempuri.org/IT3Interface/GetSeminarsForPersonResponse")]
        System.Collections.Generic.List<Client.DataT3Service.Seminar> GetSeminarsForPerson(Client.DataT3Service.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/AddPersons", ReplyAction="http://tempuri.org/IT3Interface/AddPersonsResponse")]
        void AddPersons(System.Collections.Generic.List<Client.DataT3Service.Person> newPersons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/RemovePersons", ReplyAction="http://tempuri.org/IT3Interface/RemovePersonsResponse")]
        void RemovePersons(System.Collections.Generic.List<Client.DataT3Service.Person> remPersons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/UpdatePersons", ReplyAction="http://tempuri.org/IT3Interface/UpdatePersonsResponse")]
        void UpdatePersons(System.Collections.Generic.List<Client.DataT3Service.Person> newPersons, System.Collections.Generic.List<Client.DataT3Service.Person> oldPersons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/AddAssociationSem_Per", ReplyAction="http://tempuri.org/IT3Interface/AddAssociationSem_PerResponse")]
        void AddAssociationSem_Per(Client.DataT3Service.Seminar sem, System.Collections.Generic.List<Client.DataT3Service.Person> persons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/AddAssociationPer_Sem", ReplyAction="http://tempuri.org/IT3Interface/AddAssociationPer_SemResponse")]
        void AddAssociationPer_Sem(Client.DataT3Service.Person person, System.Collections.Generic.List<Client.DataT3Service.Seminar> seminars);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/RemoveAssociationPer_Sem", ReplyAction="http://tempuri.org/IT3Interface/RemoveAssociationPer_SemResponse")]
        void RemoveAssociationPer_Sem(Client.DataT3Service.Person person, System.Collections.Generic.List<Client.DataT3Service.Seminar> seminars);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IT3Interface/IsRun", ReplyAction="http://tempuri.org/IT3Interface/IsRunResponse")]
        bool IsRun();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IT3InterfaceChannel : Client.DataT3Service.IT3Interface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class T3InterfaceClient : System.ServiceModel.ClientBase<Client.DataT3Service.IT3Interface>, Client.DataT3Service.IT3Interface {
        
        public T3InterfaceClient() {
        }
        
        public T3InterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public T3InterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public T3InterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public T3InterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Client.DataT3Service.Seminar> GetSeminars() {
            return base.Channel.GetSeminars();
        }
        
        public System.Collections.Generic.List<Client.DataT3Service.Person> GetPersons() {
            return base.Channel.GetPersons();
        }
        
        public System.Collections.Generic.List<Client.DataT3Service.Person> GetPersonsForSeminar(Client.DataT3Service.Seminar seminar) {
            return base.Channel.GetPersonsForSeminar(seminar);
        }
        
        public System.Collections.Generic.List<Client.DataT3Service.Seminar> GetSeminarsForPerson(Client.DataT3Service.Person person) {
            return base.Channel.GetSeminarsForPerson(person);
        }
        
        public void AddPersons(System.Collections.Generic.List<Client.DataT3Service.Person> newPersons) {
            base.Channel.AddPersons(newPersons);
        }
        
        public void RemovePersons(System.Collections.Generic.List<Client.DataT3Service.Person> remPersons) {
            base.Channel.RemovePersons(remPersons);
        }
        
        public void UpdatePersons(System.Collections.Generic.List<Client.DataT3Service.Person> newPersons, System.Collections.Generic.List<Client.DataT3Service.Person> oldPersons) {
            base.Channel.UpdatePersons(newPersons, oldPersons);
        }
        
        public void AddAssociationSem_Per(Client.DataT3Service.Seminar sem, System.Collections.Generic.List<Client.DataT3Service.Person> persons) {
            base.Channel.AddAssociationSem_Per(sem, persons);
        }
        
        public void AddAssociationPer_Sem(Client.DataT3Service.Person person, System.Collections.Generic.List<Client.DataT3Service.Seminar> seminars) {
            base.Channel.AddAssociationPer_Sem(person, seminars);
        }
        
        public void RemoveAssociationPer_Sem(Client.DataT3Service.Person person, System.Collections.Generic.List<Client.DataT3Service.Seminar> seminars) {
            base.Channel.RemoveAssociationPer_Sem(person, seminars);
        }
        
        public bool IsRun() {
            return base.Channel.IsRun();
        }
    }
}
