// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Volume Export Policy Rule
    /// </summary>
    public partial class ExportPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the ExportPolicyRule class.
        /// </summary>
        public ExportPolicyRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportPolicyRule class.
        /// </summary>
        /// <param name="ruleIndex">Order index</param>
        /// <param name="unixReadOnly">Read only access</param>
        /// <param name="unixReadWrite">Read and write access</param>
        /// <param name="cifs">Allows CIFS protocol</param>
        /// <param name="nfsv3">Allows NFSv3 protocol</param>
        /// <param name="nfsv4">Allows NFSv4 protocol</param>
        /// <param name="allowedClients">Client ingress specification as comma
        /// seperated string with IPv4 CIDRs, IPv4 host addresses and host
        /// names</param>
        public ExportPolicyRule(int? ruleIndex = default(int?), bool? unixReadOnly = default(bool?), bool? unixReadWrite = default(bool?), bool? cifs = default(bool?), bool? nfsv3 = default(bool?), bool? nfsv4 = default(bool?), string allowedClients = default(string))
        {
            RuleIndex = ruleIndex;
            UnixReadOnly = unixReadOnly;
            UnixReadWrite = unixReadWrite;
            Cifs = cifs;
            Nfsv3 = nfsv3;
            Nfsv4 = nfsv4;
            AllowedClients = allowedClients;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets order index
        /// </summary>
        [JsonProperty(PropertyName = "ruleIndex")]
        public int? RuleIndex { get; set; }

        /// <summary>
        /// Gets or sets read only access
        /// </summary>
        [JsonProperty(PropertyName = "unixReadOnly")]
        public bool? UnixReadOnly { get; set; }

        /// <summary>
        /// Gets or sets read and write access
        /// </summary>
        [JsonProperty(PropertyName = "unixReadWrite")]
        public bool? UnixReadWrite { get; set; }

        /// <summary>
        /// Gets or sets allows CIFS protocol
        /// </summary>
        [JsonProperty(PropertyName = "cifs")]
        public bool? Cifs { get; set; }

        /// <summary>
        /// Gets or sets allows NFSv3 protocol
        /// </summary>
        [JsonProperty(PropertyName = "nfsv3")]
        public bool? Nfsv3 { get; set; }

        /// <summary>
        /// Gets or sets allows NFSv4 protocol
        /// </summary>
        [JsonProperty(PropertyName = "nfsv4")]
        public bool? Nfsv4 { get; set; }

        /// <summary>
        /// Gets or sets client ingress specification as comma seperated string
        /// with IPv4 CIDRs, IPv4 host addresses and host names
        /// </summary>
        [JsonProperty(PropertyName = "allowedClients")]
        public string AllowedClients { get; set; }

    }
}
