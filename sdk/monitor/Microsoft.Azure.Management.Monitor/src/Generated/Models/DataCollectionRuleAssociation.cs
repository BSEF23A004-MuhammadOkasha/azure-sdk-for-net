// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of association of a data collection rule with a monitored
    /// Azure resource.
    /// </summary>
    public partial class DataCollectionRuleAssociation
    {
        /// <summary>
        /// Initializes a new instance of the DataCollectionRuleAssociation
        /// class.
        /// </summary>
        public DataCollectionRuleAssociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataCollectionRuleAssociation
        /// class.
        /// </summary>
        /// <param name="dataCollectionRuleId">The resource ID of the data
        /// collection rule that is to be associated.</param>
        /// <param name="description">Description of the association.</param>
        /// <param name="provisioningState">The resource provisioning state.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed'</param>
        public DataCollectionRuleAssociation(string dataCollectionRuleId, string description = default(string), string provisioningState = default(string))
        {
            Description = description;
            DataCollectionRuleId = dataCollectionRuleId;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the association.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the data collection rule that is to
        /// be associated.
        /// </summary>
        [JsonProperty(PropertyName = "dataCollectionRuleId")]
        public string DataCollectionRuleId { get; set; }

        /// <summary>
        /// Gets the resource provisioning state. Possible values include:
        /// 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataCollectionRuleId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataCollectionRuleId");
            }
        }
    }
}
