// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.Iot.TimeSeriesInsights;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> Get Events query. Allows to retrieve raw events for a given Time Series ID and search span. </summary>
    public partial class GetEvents
    {
        /// <summary> Initializes a new instance of GetEvents. </summary>
        /// <param name="timeSeriesId"> A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null. </param>
        /// <param name="searchSpan"> The range of time on which the query is executed. Cannot be null. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesId"/> or <paramref name="searchSpan"/> is null. </exception>
        public GetEvents(IEnumerable<object> timeSeriesId, DateTimeRange searchSpan)
        {
            if (timeSeriesId == null)
            {
                throw new ArgumentNullException(nameof(timeSeriesId));
            }
            if (searchSpan == null)
            {
                throw new ArgumentNullException(nameof(searchSpan));
            }

            TimeSeriesId = timeSeriesId.ToList();
            SearchSpan = searchSpan;
            ProjectedProperties = new ChangeTrackingList<EventProperty>();
        }

        /// <summary> A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null. </summary>
        public IList<object> TimeSeriesId { get; }
        /// <summary> The range of time on which the query is executed. Cannot be null. </summary>
        public DateTimeRange SearchSpan { get; }
        /// <summary> Optional top-level filter for the query which will be applied to all the variables in the query. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;.  Can be null. </summary>
        public TimeSeriesExpression Filter { get; set; }
        /// <summary> Projected properties is an array of properties which you want to project. These properties must appear in the events; otherwise, they are not returned. </summary>
        public IList<EventProperty> ProjectedProperties { get; }
        /// <summary> Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000. </summary>
        public int? Take { get; set; }
    }
}
