// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Inner health error model. </summary>
    public partial class DataReplicationInnerHealthErrorInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataReplicationInnerHealthErrorInfo"/>. </summary>
        internal DataReplicationInnerHealthErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationInnerHealthErrorInfo"/>. </summary>
        /// <param name="code"> Gets or sets the error code. </param>
        /// <param name="healthCategory"> Gets or sets the health category. </param>
        /// <param name="category"> Gets or sets the error category. </param>
        /// <param name="severity"> Gets or sets the error severity. </param>
        /// <param name="source"> Gets or sets the error source. </param>
        /// <param name="createdOn"> Gets or sets the error creation time. </param>
        /// <param name="isCustomerResolvable"> Gets or sets a value indicating whether the error is customer resolvable. </param>
        /// <param name="summary"> Gets or sets the error summary. </param>
        /// <param name="message"> Gets or sets the error message. </param>
        /// <param name="causes"> Gets or sets possible causes of the error. </param>
        /// <param name="recommendation"> Gets or sets recommended action to resolve the error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationInnerHealthErrorInfo(string code, string healthCategory, string category, string severity, string source, DateTimeOffset? createdOn, bool? isCustomerResolvable, string summary, string message, string causes, string recommendation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            HealthCategory = healthCategory;
            Category = category;
            Severity = severity;
            Source = source;
            CreatedOn = createdOn;
            IsCustomerResolvable = isCustomerResolvable;
            Summary = summary;
            Message = message;
            Causes = causes;
            Recommendation = recommendation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the error code. </summary>
        public string Code { get; }
        /// <summary> Gets or sets the health category. </summary>
        public string HealthCategory { get; }
        /// <summary> Gets or sets the error category. </summary>
        public string Category { get; }
        /// <summary> Gets or sets the error severity. </summary>
        public string Severity { get; }
        /// <summary> Gets or sets the error source. </summary>
        public string Source { get; }
        /// <summary> Gets or sets the error creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets or sets a value indicating whether the error is customer resolvable. </summary>
        public bool? IsCustomerResolvable { get; }
        /// <summary> Gets or sets the error summary. </summary>
        public string Summary { get; }
        /// <summary> Gets or sets the error message. </summary>
        public string Message { get; }
        /// <summary> Gets or sets possible causes of the error. </summary>
        public string Causes { get; }
        /// <summary> Gets or sets recommended action to resolve the error. </summary>
        public string Recommendation { get; }
    }
}
