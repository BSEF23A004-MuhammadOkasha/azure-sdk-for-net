// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> An action that marks a job as cancelled. </summary>
    public partial class CancelExceptionAction : ExceptionAction
    {
        /// <summary> Initializes a new instance of CancelExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <param name="note">
        /// (Optional) A note that will be appended to the jobs' Notes collection with the
        /// current timestamp.
        /// </param>
        /// <param name="dispositionCode">
        /// (Optional) Indicates the outcome of the job, populate this field with your own
        /// custom values.
        /// </param>
        internal CancelExceptionAction(string id, string kind, string note, string dispositionCode) : base(id, kind)
        {
            Note = note;
            DispositionCode = dispositionCode;
        }
    }
}
