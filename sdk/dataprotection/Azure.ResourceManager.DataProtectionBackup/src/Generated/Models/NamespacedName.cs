// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Class to refer resources which contains namespace and name. </summary>
    public partial class NamespacedName
    {
        /// <summary> Initializes a new instance of NamespacedName. </summary>
        public NamespacedName()
        {
        }

        /// <summary> Initializes a new instance of NamespacedName. </summary>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="namespace"> Namespace in which the resource exists. </param>
        internal NamespacedName(string name, string @namespace)
        {
            Name = name;
            Namespace = @namespace;
        }

        /// <summary> Name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Namespace in which the resource exists. </summary>
        public string Namespace { get; set; }
    }
}
