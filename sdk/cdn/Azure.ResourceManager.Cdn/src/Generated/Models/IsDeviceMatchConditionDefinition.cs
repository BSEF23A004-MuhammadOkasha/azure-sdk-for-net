// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for IsDevice match conditions. </summary>
    public partial class IsDeviceMatchConditionDefinition
    {
        /// <summary> Initializes a new instance of IsDeviceMatchConditionDefinition. </summary>
        /// <param name="typeDefinition"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public IsDeviceMatchConditionDefinition(IsDeviceMatchConditionType typeDefinition, IsDeviceOperator @operator)
        {
            TypeDefinition = typeDefinition;
            Operator = @operator;
            MatchValues = new ChangeTrackingList<IsDeviceMatchConditionParametersMatchValuesItem>();
            Transforms = new ChangeTrackingList<TransformCategory>();
        }

        /// <summary> Initializes a new instance of IsDeviceMatchConditionDefinition. </summary>
        /// <param name="typeDefinition"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal IsDeviceMatchConditionDefinition(IsDeviceMatchConditionType typeDefinition, IsDeviceOperator @operator, bool? negateCondition, IList<IsDeviceMatchConditionParametersMatchValuesItem> matchValues, IList<TransformCategory> transforms)
        {
            TypeDefinition = typeDefinition;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the type definition. </summary>
        public IsDeviceMatchConditionType TypeDefinition { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public IsDeviceOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<IsDeviceMatchConditionParametersMatchValuesItem> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<TransformCategory> Transforms { get; }
    }
}
