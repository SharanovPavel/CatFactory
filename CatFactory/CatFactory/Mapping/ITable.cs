﻿using System.Collections.Generic;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents the model for user table
    /// </summary>
    public interface ITable : IReadableObject
    {
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        Identity Identity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        PrimaryKey PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets foreign keys constraints
        /// </summary>
        List<ForeignKey> ForeignKeys { get; set; }

        /// <summary>
        /// Gets or sets unique constraints
        /// </summary>
        List<Unique> Uniques { get; set; }
    }
}
