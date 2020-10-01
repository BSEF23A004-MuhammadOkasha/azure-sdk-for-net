// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ComplianceState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ComplianceStateConverter))]
    public struct ComplianceState : System.IEquatable<ComplianceState>
    {
        private ComplianceState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ComplianceState Pending = "Pending";

        public static readonly ComplianceState Compliant = "Compliant";

        public static readonly ComplianceState Noncompliant = "Noncompliant";


        /// <summary>
        /// Underlying value of enum ComplianceState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ComplianceState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ComplianceState
        /// </summary>
        public bool Equals(ComplianceState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ComplianceState
        /// </summary>
        public static implicit operator ComplianceState(string value)
        {
            return new ComplianceState(value);
        }

        /// <summary>
        /// Implicit operator to convert ComplianceState to string
        /// </summary>
        public static implicit operator string(ComplianceState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ComplianceState
        /// </summary>
        public static bool operator == (ComplianceState e1, ComplianceState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ComplianceState
        /// </summary>
        public static bool operator != (ComplianceState e1, ComplianceState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ComplianceState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ComplianceState && Equals((ComplianceState)obj);
        }

        /// <summary>
        /// Returns for hashCode ComplianceState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
