// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.CognitiveServices;
    using Microsoft.Azure.CognitiveServices.Vision;
    using Microsoft.Azure.CognitiveServices.Vision.Face;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Person group object.
    /// </summary>
    public partial class PersonGroupResult
    {
        /// <summary>
        /// Initializes a new instance of the PersonGroupResult class.
        /// </summary>
        public PersonGroupResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PersonGroupResult class.
        /// </summary>
        /// <param name="personGroupId">faceListId of the target face
        /// list.</param>
        /// <param name="name">Face list's display name.</param>
        /// <param name="userData">User-provided data attached to this face
        /// list.</param>
        public PersonGroupResult(string personGroupId, string name = default(string), string userData = default(string))
        {
            PersonGroupId = personGroupId;
            Name = name;
            UserData = userData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets faceListId of the target face list.
        /// </summary>
        [JsonProperty(PropertyName = "personGroupId")]
        public string PersonGroupId { get; set; }

        /// <summary>
        /// Gets or sets face list's display name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets user-provided data attached to this face list.
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PersonGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PersonGroupId");
            }
            if (PersonGroupId != null)
            {
                if (PersonGroupId.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PersonGroupId", 128);
                }
            }
            if (Name != null)
            {
                if (Name.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 128);
                }
            }
            if (UserData != null)
            {
                if (UserData.Length > 16384)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserData", 16384);
                }
            }
        }
    }
}
