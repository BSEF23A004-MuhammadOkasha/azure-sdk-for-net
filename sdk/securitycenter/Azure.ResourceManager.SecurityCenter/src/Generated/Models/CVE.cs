// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> CVE details. </summary>
    public partial class CVE
    {
        /// <summary> Initializes a new instance of CVE. </summary>
        internal CVE()
        {
        }

        /// <summary> Initializes a new instance of CVE. </summary>
        /// <param name="title"> CVE title. </param>
        /// <param name="link"> Link url. </param>
        internal CVE(string title, string link)
        {
            Title = title;
            Link = link;
        }

        /// <summary> CVE title. </summary>
        public string Title { get; }
        /// <summary> Link url. </summary>
        public string Link { get; }
    }
}
