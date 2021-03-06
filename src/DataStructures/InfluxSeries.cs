﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdysTech.InfluxDB.Client.Net
{
    /// <summary>
    /// Represents the results returned by Query end point of the InfluxDB engine
    /// </summary>

    public class InfluxSeries : IInfluxSeries
    {
        
        /// <summary>
        /// Name of the series. Usually its MeasurementName in case of select queries
        /// </summary>
        public string SeriesName { get; internal set; }

        /// <summary>
        /// Dictionary of tags, and their respective values.
        /// </summary>
        public IReadOnlyDictionary<string, string> Tags { get; internal set; }

        /// <summary>
        /// Indicates whether this Series has any entries or not
        /// </summary>
        public bool HasEntries { get; internal set; }

        /// <summary>
        /// Read only List of ExpandoObjects (in the form of dynamic) representing the entries in the query result 
        /// The objects will have columns as Peoperties with their current values
        /// </summary>
        public IReadOnlyList<dynamic> Entries { get; internal set; }
    }
}
