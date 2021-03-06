﻿using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a view
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class View : IView
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.View"/> class
        /// </summary>
        public View()
        {
        }

        /// <summary>
        /// Gets or sets the schema
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets full name
        /// </summary>
        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index">Column's index</param>
        /// <returns>A <see cref="CatFactory.Mapping.Column"/> from current table</returns>
        public Column this[int index]
        {
            get
            {
                return Columns[index];
            }
            set
            {
                Columns[index] = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
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

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets row Guid column
        /// </summary>
        public RowGuidCol RowGuidCol { get; set; }
    }
}
