// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> `GeoJSON` geometry, representing the area circle's center. </summary>
    public partial class AreaGeometry
    {
        /// <summary> Initializes a new instance of AreaGeometry. </summary>
        /// <param name="type"> `GeoJSON` geometry type. </param>
        /// <param name="coordinates">
        /// Coordinates of the area circle's center, represented according to the `GeoJSON` standard.
        /// This is an array of 2 decimal numbers, longitude and latitude (precisely in this order).
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public AreaGeometry(GeoJsonGeometryType type, IEnumerable<float> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Type = type;
            Coordinates = coordinates.ToList();
        }

        /// <summary> `GeoJSON` geometry type. </summary>
        public GeoJsonGeometryType Type { get; }
        /// <summary>
        /// Coordinates of the area circle's center, represented according to the `GeoJSON` standard.
        /// This is an array of 2 decimal numbers, longitude and latitude (precisely in this order).
        /// </summary>
        public IList<float> Coordinates { get; }
    }
}
