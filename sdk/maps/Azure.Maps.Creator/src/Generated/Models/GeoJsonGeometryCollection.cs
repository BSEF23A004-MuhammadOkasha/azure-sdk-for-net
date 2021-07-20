// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A valid `GeoJSON GeometryCollection` object type. Please refer to [RFC
    /// 7946](https://tools.ietf.org/html/rfc7946#section-3.1.8) for details.
    /// </summary>
    public partial class GeoJsonGeometryCollection
    {
        /// <summary>
        /// Initializes a new instance of the GeoJsonGeometryCollection class.
        /// </summary>
        public GeoJsonGeometryCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoJsonGeometryCollection class.
        /// </summary>
        /// <param name="geometries">Contains a list of valid `GeoJSON`
        /// geometry objects. **Note** that coordinates in GeoJSON are in x, y
        /// order (longitude, latitude).</param>
        public GeoJsonGeometryCollection(IList<GeoJsonGeometry> geometries)
        {
            Geometries = geometries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contains a list of valid `GeoJSON` geometry objects.
        /// **Note** that coordinates in GeoJSON are in x, y order (longitude,
        /// latitude).
        /// </summary>
        [JsonProperty(PropertyName = "geometries")]
        public IList<GeoJsonGeometry> Geometries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Geometries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Geometries");
            }
        }
    }
}
