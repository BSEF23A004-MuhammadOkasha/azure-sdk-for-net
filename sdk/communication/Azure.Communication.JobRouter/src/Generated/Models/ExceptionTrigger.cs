// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// The trigger for this exception rule
    /// Please note <see cref="ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownExceptionTrigger))]
    public abstract partial class ExceptionTrigger
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExceptionTrigger"/>. </summary>
        protected ExceptionTrigger()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExceptionTrigger"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionTrigger. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExceptionTrigger(string kind, Dictionary<string, BinaryData> rawData)
        {
            Kind = kind;
            _rawData = rawData;
        }
    }
}
