// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a set of worker selectors that will be attached if the given condition resolves to true. </summary>
    public partial class ConditionalWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of <see cref="ConditionalWorkerSelectorAttachment"/>. </summary>
        /// <param name="condition">
        /// The condition that must be true for the worker selectors to be attached.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="condition"/> or <paramref name="workerSelectors"/> is null. </exception>
        public ConditionalWorkerSelectorAttachment(RouterRule condition, IEnumerable<RouterWorkerSelector> workerSelectors)
        {
            Argument.AssertNotNull(condition, nameof(condition));
            Argument.AssertNotNull(workerSelectors, nameof(workerSelectors));

            Kind = WorkerSelectorAttachmentKind.Conditional;
            Condition = condition;
            WorkerSelectors = workerSelectors.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConditionalWorkerSelectorAttachment"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of WorkerSelectorAttachment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="condition">
        /// The condition that must be true for the worker selectors to be attached.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        internal ConditionalWorkerSelectorAttachment(WorkerSelectorAttachmentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, RouterRule condition, IList<RouterWorkerSelector> workerSelectors) : base(kind, serializedAdditionalRawData)
        {
            Condition = condition;
            WorkerSelectors = workerSelectors;
        }

        /// <summary> Initializes a new instance of <see cref="ConditionalWorkerSelectorAttachment"/> for deserialization. </summary>
        internal ConditionalWorkerSelectorAttachment()
        {
        }

        /// <summary>
        /// The condition that must be true for the worker selectors to be attached.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </summary>
        public RouterRule Condition { get; set; }
    }
}
