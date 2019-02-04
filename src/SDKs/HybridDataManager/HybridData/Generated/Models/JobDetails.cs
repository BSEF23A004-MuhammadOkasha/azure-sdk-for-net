// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job details.
    /// </summary>
    public partial class JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        public JobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        /// <param name="jobStages">List of stages that ran in the job</param>
        /// <param name="jobDefinition">JobDefinition at the time of the
        /// run</param>
        /// <param name="errorDetails">Error details for failure. This is
        /// optional.</param>
        /// <param name="itemDetailsLink">Item Details Link to download files
        /// or see details</param>
        public JobDetails(IList<JobStages> jobStages = default(IList<JobStages>), JobDefinition jobDefinition = default(JobDefinition), IList<ErrorDetails> errorDetails = default(IList<ErrorDetails>), string itemDetailsLink = default(string))
        {
            JobStages = jobStages;
            JobDefinition = jobDefinition;
            ErrorDetails = errorDetails;
            ItemDetailsLink = itemDetailsLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of stages that ran in the job
        /// </summary>
        [JsonProperty(PropertyName = "jobStages")]
        public IList<JobStages> JobStages { get; set; }

        /// <summary>
        /// Gets or sets jobDefinition at the time of the run
        /// </summary>
        [JsonProperty(PropertyName = "jobDefinition")]
        public JobDefinition JobDefinition { get; set; }

        /// <summary>
        /// Gets or sets error details for failure. This is optional.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public IList<ErrorDetails> ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets item Details Link to download files or see details
        /// </summary>
        [JsonProperty(PropertyName = "itemDetailsLink")]
        public string ItemDetailsLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (JobStages != null)
            {
                foreach (var element in JobStages)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (JobDefinition != null)
            {
                JobDefinition.Validate();
            }
        }
    }
}
