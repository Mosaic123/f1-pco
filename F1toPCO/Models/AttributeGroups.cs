﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace F1toPCO.Model.F1 {

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRoot("attributeGroups")]
    public class attributeGroups {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "attributeGroup")]
        public List<attributeGroup> attributeGroup { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class attributeGroup {

        private object nameField;

        private List<attribute> attributeField;

        private string uriField;

        private string oldIDField;

        private bool oldIDFieldSpecified;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attribute")]
        public List<attribute> attribute {
            get {
                return this.attributeField;
            }
            set {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string oldID {
            get {
                return this.oldIDField;
            }
            set {
                this.oldIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool oldIDSpecified {
            get {
                return this.oldIDFieldSpecified;
            }
            set {
                this.oldIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}