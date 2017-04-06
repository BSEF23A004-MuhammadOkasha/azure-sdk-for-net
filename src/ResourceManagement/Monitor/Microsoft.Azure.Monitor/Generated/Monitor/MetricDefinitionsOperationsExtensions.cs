// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights
{
    using Microsoft.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MetricDefinitionsOperations.
    /// </summary>
    public static partial class MetricDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Lists the metric definitions for the resource.&lt;br&gt;The **$filter**
            /// parameter is optional, and can be used to only retrieve certain metric
            /// definitions.&lt;br&gt;For example, get just the definition for the CPU
            /// percentage counter: $filter=name.value eq '\Processor(_Total)\% Processor
            /// Time'.&lt;br&gt;This **$filter** is very restricted and allows only clauses
            /// of the form **'name eq &lt;value&gt;'** separated by **or** logical
            /// operators.&lt;br&gt;**NOTE**: No other syntax is allowed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IEnumerable<MetricDefinition> List(this IMetricDefinitionsOperations operations, string resourceUri, ODataQuery<MetricDefinition> odataQuery = default(ODataQuery<MetricDefinition>))
            {
                return ((IMetricDefinitionsOperations)operations).ListAsync(resourceUri, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the metric definitions for the resource.&lt;br&gt;The **$filter**
            /// parameter is optional, and can be used to only retrieve certain metric
            /// definitions.&lt;br&gt;For example, get just the definition for the CPU
            /// percentage counter: $filter=name.value eq '\Processor(_Total)\% Processor
            /// Time'.&lt;br&gt;This **$filter** is very restricted and allows only clauses
            /// of the form **'name eq &lt;value&gt;'** separated by **or** logical
            /// operators.&lt;br&gt;**NOTE**: No other syntax is allowed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<MetricDefinition>> ListAsync(this IMetricDefinitionsOperations operations, string resourceUri, ODataQuery<MetricDefinition> odataQuery = default(ODataQuery<MetricDefinition>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceUri, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
