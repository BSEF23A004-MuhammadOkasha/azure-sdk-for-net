// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Result of a batch operation on a particular time series hierarchy. Hierarchy is set when operation is successful and error object is set when operation is unsuccessful. </summary>
    public partial class TimeSeriesHierarchyOperationResult
    {
        /// <summary> Initializes a new instance of <see cref="TimeSeriesHierarchyOperationResult"/>. </summary>
        internal TimeSeriesHierarchyOperationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesHierarchyOperationResult"/>. </summary>
        /// <param name="hierarchy"> Time series hierarchy object - set when the operation is successful. </param>
        /// <param name="error"> Error object - set when the operation is unsuccessful. </param>
        internal TimeSeriesHierarchyOperationResult(TimeSeriesHierarchy hierarchy, TimeSeriesOperationError error)
        {
            Hierarchy = hierarchy;
            Error = error;
        }

        /// <summary> Time series hierarchy object - set when the operation is successful. </summary>
        public TimeSeriesHierarchy Hierarchy { get; }
        /// <summary> Error object - set when the operation is unsuccessful. </summary>
        public TimeSeriesOperationError Error { get; }
    }
}
