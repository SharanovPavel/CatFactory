﻿using System;
using System.Collections.Generic;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    public class ObjectDefinition : IObjectDefinition
    {
        public INamingConvention NamingConvention { get; protected set; }

        private List<String> m_namespaces;

        public List<String> Namespaces
        {
            get
            {
                return m_namespaces ?? (m_namespaces = new List<String>());
            }
            set
            {
                m_namespaces = value;
            }
        }

        public String Namespace { get; set; }

        public Metadata Documentation { get; set; }

        public String Name { get; set; }

        public String BaseClass { get; set; }

        private List<String> m_implements { get; set; }
        private List<FieldDefinition> m_fields;
        private List<PropertyDefinition> m_properties;
        private List<MethodDefinition> m_methods;

        public List<String> Implements
        {
            get
            {
                return m_implements ?? (m_implements = new List<String>());
            }
            set
            {
                m_implements = value;
            }
        }

        public List<FieldDefinition> Fields
        {
            get
            {
                return m_fields ?? (m_fields = new List<FieldDefinition>());
            }
            set
            {
                m_fields = new List<FieldDefinition>();
            }
        }

        public List<PropertyDefinition> Properties
        {
            get
            {
                return m_properties ?? (m_properties = new List<PropertyDefinition>());
            }
            set
            {
                m_properties = value;
            }
        }

        public List<MethodDefinition> Methods
        {
            get
            {
                return m_methods ?? (m_methods = new List<MethodDefinition>());
            }
            set
            {
                m_methods = value;
            }
        }

        public Boolean HasInheritance
        {
            get
            {
                return !String.IsNullOrEmpty(BaseClass) || Implements.Count > 0;
            }
        }
    }
}
