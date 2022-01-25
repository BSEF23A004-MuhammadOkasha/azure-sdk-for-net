// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Patch
    /// </summary>
    public partial class SharedGalleryFragment : Tags
    {
        /// <summary>
        /// Initializes a new instance of the SharedGalleryFragment class.
        /// </summary>
        public SharedGalleryFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedGalleryFragment class.
        /// </summary>
        /// <param name="tagsProperty">Resource tags</param>
        public SharedGalleryFragment(IDictionary<string, string> tagsProperty = default(IDictionary<string, string>))
            : base(tagsProperty)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
