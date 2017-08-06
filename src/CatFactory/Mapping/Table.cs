﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class Table : ITable
    {
        public Table()
        {
        }

        public String Schema { get; set; }

        public String Name { get; set; }

        public String FullName
            => String.IsNullOrEmpty(Schema) ? Name : String.Format("{0}.{1}", Schema, Name);

        public String Type { get; set; }

        public String Description { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        public List<Column> Columns
        {
            get
            {
                return m_columns ?? (m_columns = new List<Column>());
            }
            set
            {
                m_columns = value;
            }
        }

        public Identity Identity { get; set; }

        public PrimaryKey PrimaryKey { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ForeignKey> m_foreignKeys;

        public List<ForeignKey> ForeignKeys
        {
            get
            {
                return m_foreignKeys ?? (m_foreignKeys = new List<ForeignKey>());
            }
            set
            {
                m_foreignKeys = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Unique> m_uniques;

        public List<Unique> Uniques
        {
            get
            {
                return m_uniques ?? (m_uniques = new List<Unique>());
            }
            set
            {
                m_uniques = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Check> m_checks;

        public List<Check> Checks
        {
            get
            {
                return m_checks ?? (m_checks = new List<Check>());
            }
            set
            {
                m_checks = value;
            }
        }
    }
}
