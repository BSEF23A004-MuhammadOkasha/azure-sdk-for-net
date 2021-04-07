// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CheckinManifestInfo
    {
        /// <summary>
        /// Initializes a new instance of the CheckinManifestInfo class.
        /// </summary>
        public CheckinManifestInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckinManifestInfo class.
        /// </summary>
        public CheckinManifestInfo(bool isCheckedIn, string statusMessage, string pullRequest = default(string), string commitId = default(string))
        {
            IsCheckedIn = isCheckedIn;
            StatusMessage = statusMessage;
            PullRequest = pullRequest;
            CommitId = commitId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isCheckedIn")]
        public bool IsCheckedIn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pullRequest")]
        public string PullRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commitId")]
        public string CommitId { get; set; }

    }
}
