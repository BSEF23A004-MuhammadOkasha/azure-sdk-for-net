// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The language extension object. </summary>
    public partial class KustoLanguageExtension
    {
        /// <summary> Initializes a new instance of KustoLanguageExtension. </summary>
        public KustoLanguageExtension()
        {
        }

        /// <summary> Initializes a new instance of KustoLanguageExtension. </summary>
        /// <param name="languageExtensionName"> The language extension name. </param>
        /// <param name="languageExtensionImageName"> The language extension image name. </param>
        /// <param name="languageExtensionCustomImageName"> The language extension custom image name. </param>
        internal KustoLanguageExtension(KustoLanguageExtensionName? languageExtensionName, KustoLanguageExtensionImageName? languageExtensionImageName, string languageExtensionCustomImageName)
        {
            LanguageExtensionName = languageExtensionName;
            LanguageExtensionImageName = languageExtensionImageName;
            LanguageExtensionCustomImageName = languageExtensionCustomImageName;
        }

        /// <summary> The language extension name. </summary>
        public KustoLanguageExtensionName? LanguageExtensionName { get; set; }
        /// <summary> The language extension image name. </summary>
        public KustoLanguageExtensionImageName? LanguageExtensionImageName { get; set; }
        /// <summary> The language extension custom image name. </summary>
        public string LanguageExtensionCustomImageName { get; set; }
    }
}
