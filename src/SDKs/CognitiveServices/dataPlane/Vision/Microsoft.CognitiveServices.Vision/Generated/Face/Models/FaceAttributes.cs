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
    /// Face Attributes
    /// </summary>
    public partial class FaceAttributes
    {
        /// <summary>
        /// Initializes a new instance of the FaceAttributes class.
        /// </summary>
        public FaceAttributes()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceAttributes class.
        /// </summary>
        /// <param name="age">Age in years</param>
        /// <param name="gender">Gender: male or female. Possible values
        /// include: 'male', 'female'</param>
        /// <param name="smile">Smile intensity, a number between [0,1]
        /// </param>
        /// <param name="glasses">Glasses type. Possible values are
        /// 'noGlasses', 'readingGlasses', 'sunglasses', 'swimmingGoggles'.
        /// Possible values include: 'noGlasses', 'readingGlasses',
        /// 'sunglasses', 'swimmingGoggles'</param>
        public FaceAttributes(double? age = default(double?), string gender = default(string), double? smile = default(double?), string glasses = default(string), FacialHairProperties facialHair = default(FacialHairProperties), HeadPoseProperties headPose = default(HeadPoseProperties), EmotionProperties emotion = default(EmotionProperties))
        {
            Age = age;
            Gender = gender;
            Smile = smile;
            Glasses = glasses;
            FacialHair = facialHair;
            HeadPose = headPose;
            Emotion = emotion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets age in years
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public double? Age { get; set; }

        /// <summary>
        /// Gets or sets gender: male or female. Possible values include:
        /// 'male', 'female'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets smile intensity, a number between [0,1]
        /// </summary>
        [JsonProperty(PropertyName = "smile")]
        public double? Smile { get; set; }

        /// <summary>
        /// Gets or sets glasses type. Possible values are 'noGlasses',
        /// 'readingGlasses', 'sunglasses', 'swimmingGoggles'. Possible values
        /// include: 'noGlasses', 'readingGlasses', 'sunglasses',
        /// 'swimmingGoggles'
        /// </summary>
        [JsonProperty(PropertyName = "glasses")]
        public string Glasses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "facialHair")]
        public FacialHairProperties FacialHair { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "headPose")]
        public HeadPoseProperties HeadPose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emotion")]
        public EmotionProperties Emotion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Smile > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Smile", 1);
            }
            if (Smile < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Smile", 0);
            }
            if (FacialHair != null)
            {
                FacialHair.Validate();
            }
            if (Emotion != null)
            {
                Emotion.Validate();
            }
        }
    }
}
