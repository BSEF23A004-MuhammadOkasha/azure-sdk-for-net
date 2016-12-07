// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{

    /// <summary>
    /// Defines values for CertificateOrderStatus.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CertificateOrderStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = "Pendingissuance")]
        Pendingissuance,
        [System.Runtime.Serialization.EnumMember(Value = "Issued")]
        Issued,
        [System.Runtime.Serialization.EnumMember(Value = "Revoked")]
        Revoked,
        [System.Runtime.Serialization.EnumMember(Value = "Canceled")]
        Canceled,
        [System.Runtime.Serialization.EnumMember(Value = "Denied")]
        Denied,
        [System.Runtime.Serialization.EnumMember(Value = "Pendingrevocation")]
        Pendingrevocation,
        [System.Runtime.Serialization.EnumMember(Value = "PendingRekey")]
        PendingRekey,
        [System.Runtime.Serialization.EnumMember(Value = "Unused")]
        Unused,
        [System.Runtime.Serialization.EnumMember(Value = "Expired")]
        Expired,
        [System.Runtime.Serialization.EnumMember(Value = "NotSubmitted")]
        NotSubmitted
    }
}
