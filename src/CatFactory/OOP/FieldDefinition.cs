﻿using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public class FieldDefinition
    {
        public FieldDefinition()
        {

        }

        public FieldDefinition(String type, String name, params MetadataAttribute[] attribs)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        public ModifierAccess ModifierAccess { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }

        private List<MetadataAttribute> m_attributes;

        public List<MetadataAttribute> Attributes
        {
            get
            {
                return m_attributes ?? (m_attributes = new List<MetadataAttribute>());
            }
            set
            {
                m_attributes = value;
            }
        }
    }
}
