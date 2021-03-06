﻿using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a Database Object (Table, View, Table Function, Scalar Function, Stored Procedure, etc)
    /// </summary>
    [DebuggerDisplay("Type={Type}, FullName={FullName}")]
    public class DbObject : IDbObject
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.DbObject"/> class
        /// </summary>
        public DbObject()
        {
        }

        /// <summary>
        /// Gets or sets the schema for current database object
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the name for current database object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the full name for current database object
        /// </summary>
        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        /// <summary>
        /// Gets or sets the type for current database object
        /// </summary>
        public string Type { get; set; }
    }
}
