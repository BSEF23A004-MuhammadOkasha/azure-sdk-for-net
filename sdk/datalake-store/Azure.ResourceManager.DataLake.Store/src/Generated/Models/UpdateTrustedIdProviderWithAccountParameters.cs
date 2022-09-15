// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLake.Store.Models
{
    /// <summary> The parameters used to update a trusted identity provider while updating a Data Lake Store account. </summary>
    public partial class UpdateTrustedIdProviderWithAccountParameters
    {
        /// <summary> Initializes a new instance of UpdateTrustedIdProviderWithAccountParameters. </summary>
        /// <param name="name"> The unique name of the trusted identity provider to update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public UpdateTrustedIdProviderWithAccountParameters(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> The unique name of the trusted identity provider to update. </summary>
        public string Name { get; }
        /// <summary> The URL of this trusted identity provider. </summary>
        public string IdProvider { get; set; }
    }
}
