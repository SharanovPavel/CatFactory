﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CatFactory.Mapping;

namespace CatFactory
{
    [DebuggerDisplay("Name={Name}, Features={Features.Count}")]
    public class Project
    {
        public Project()
        {
        }

        public String Name { get; set; }

        public Database Database { get; set; }

        public List<ProjectFeature> Features { get; set; }

        public String OutputDirectory { get; set; }

        private List<String> m_addExclusions;
        private List<String> m_updateExclusions;

        public List<String> AddExclusions
        {
            get
            {
                return m_addExclusions ?? (m_addExclusions = new List<String>());
            }
            set
            {
                m_addExclusions = value;
            }
        }

        public List<String> UpdateExclusions
        {
            get
            {
                return m_updateExclusions ?? (m_updateExclusions = new List<String>());
            }
            set
            {
                m_updateExclusions = value;
            }
        }

        public virtual void BuildFeatures()
        {
            if (Database == null)
            {
                return;
            }

            Features = Database
                .DbObjects
                .Select(item => item.Schema)
                .Distinct()
                .Select(item => new ProjectFeature(item, Database.DbObjects.Where(db => db.Schema == item).ToList(), Database))
                .ToList();
        }
    }
}
