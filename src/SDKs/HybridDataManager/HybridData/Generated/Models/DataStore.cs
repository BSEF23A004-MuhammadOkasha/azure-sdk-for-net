// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data store.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataStore : DmsBaseObject
    {
        /// <summary>
        /// Initializes a new instance of the DataStore class.
        /// </summary>
        public DataStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataStore class.
        /// </summary>
        /// <param name="state">State of the data source. Possible values
        /// include: 'Disabled', 'Enabled', 'Supported'</param>
        /// <param name="dataStoreTypeId">The arm id of the data store
        /// type.</param>
        /// <param name="name">Name of the object.</param>
        /// <param name="id">Id of the object.</param>
        /// <param name="type">Type of the object.</param>
        /// <param name="repositoryId">Arm Id for the manager resource to which
        /// the data source is associated. This is optional.</param>
        /// <param name="extendedProperties">A generic json used differently by
        /// each data source type.</param>
        /// <param name="customerSecrets">List of customer secrets containing a
        /// key identifier and key value. The key identifier is a way for the
        /// specific data source to understand the key. Value contains customer
        /// secret encrypted by the encryptionKeys.</param>
        public DataStore(State state, string dataStoreTypeId, string name = default(string), string id = default(string), string type = default(string), string repositoryId = default(string), object extendedProperties = default(object), IList<CustomerSecret> customerSecrets = default(IList<CustomerSecret>))
            : base(name, id, type)
        {
            RepositoryId = repositoryId;
            State = state;
            ExtendedProperties = extendedProperties;
            DataStoreTypeId = dataStoreTypeId;
            CustomerSecrets = customerSecrets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets arm Id for the manager resource to which the data
        /// source is associated. This is optional.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryId")]
        public string RepositoryId { get; set; }

        /// <summary>
        /// Gets or sets state of the data source. Possible values include:
        /// 'Disabled', 'Enabled', 'Supported'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public State State { get; set; }

        /// <summary>
        /// Gets or sets a generic json used differently by each data source
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.extendedProperties")]
        public object ExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets the arm id of the data store type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataStoreTypeId")]
        public string DataStoreTypeId { get; set; }

        /// <summary>
        /// Gets or sets list of customer secrets containing a key identifier
        /// and key value. The key identifier is a way for the specific data
        /// source to understand the key. Value contains customer secret
        /// encrypted by the encryptionKeys.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerSecrets")]
        public IList<CustomerSecret> CustomerSecrets { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataStoreTypeId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataStoreTypeId");
            }
            if (CustomerSecrets != null)
            {
                foreach (var element in CustomerSecrets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
