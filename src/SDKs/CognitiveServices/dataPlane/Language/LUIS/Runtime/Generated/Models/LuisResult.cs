// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Prediction, based on the input query, containing intent(s) and
    /// entities.
    /// </summary>
    public partial class LuisResult
    {
        /// <summary>
        /// Initializes a new instance of the LuisResult class.
        /// </summary>
        public LuisResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LuisResult class.
        /// </summary>
        /// <param name="query">The input utterance that was analyzed.</param>
        /// <param name="alteredQuery">The corrected utterance (when spell
        /// checking was enabled).</param>
        /// <param name="intents">All the intents (and their score) that were
        /// detected from utterance.</param>
        /// <param name="entities">The entities extracted from the
        /// utterance.</param>
        /// <param name="compositeEntities">The composite entities extracted
        /// from the utterance.</param>
        public LuisResult(string query = default(string), string alteredQuery = default(string), IntentModel topScoringIntent = default(IntentModel), IList<IntentModel> intents = default(IList<IntentModel>), IList<EntityModel> entities = default(IList<EntityModel>), IList<CompositeEntityModel> compositeEntities = default(IList<CompositeEntityModel>), Sentiment sentimentAnalysis = default(Sentiment), LuisResult connectedServiceResult = default(LuisResult))
        {
            Query = query;
            AlteredQuery = alteredQuery;
            TopScoringIntent = topScoringIntent;
            Intents = intents;
            Entities = entities;
            CompositeEntities = compositeEntities;
            SentimentAnalysis = sentimentAnalysis;
            ConnectedServiceResult = connectedServiceResult;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the input utterance that was analized.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the corrected utterance (when spell checking was
        /// enabled).
        /// </summary>
        [JsonProperty(PropertyName = "alteredQuery")]
        public string AlteredQuery { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "topScoringIntent")]
        public IntentModel TopScoringIntent { get; set; }

        /// <summary>
        /// Gets or sets all the intents (and their score) that were detected
        /// from utterance.
        /// </summary>
        [JsonProperty(PropertyName = "intents")]
        public IList<IntentModel> Intents { get; set; }

        /// <summary>
        /// Gets or sets the entities extracted from the utterance.
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<EntityModel> Entities { get; set; }

        /// <summary>
        /// Gets or sets the composite entities extracted from the utterance.
        /// </summary>
        [JsonProperty(PropertyName = "compositeEntities")]
        public IList<CompositeEntityModel> CompositeEntities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sentimentAnalysis")]
        public Sentiment SentimentAnalysis { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectedServiceResult")]
        public LuisResult ConnectedServiceResult { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TopScoringIntent != null)
            {
                TopScoringIntent.Validate();
            }
            if (Intents != null)
            {
                foreach (var element in Intents)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Entities != null)
            {
                foreach (var element1 in Entities)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (CompositeEntities != null)
            {
                foreach (var element2 in CompositeEntities)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
