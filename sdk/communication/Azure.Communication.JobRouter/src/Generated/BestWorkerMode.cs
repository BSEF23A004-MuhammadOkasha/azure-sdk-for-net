// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> Jobs are distributed to the worker with the strongest abilities available. </summary>
    public partial class BestWorkerMode : DistributionMode
    {
        /// <summary> Initializes a new instance of BestWorkerMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors">
        /// (Optional)
        /// If set to true, then router will match workers to jobs even if they
        /// don't match label selectors.
        /// Warning: You may get workers that are not
        /// qualified for the job they are matched with if you set this
        /// variable to true.
        /// This flag is intended more for temporary usage.
        /// By default, set to false.
        /// </param>
        /// <param name="kind"> The type discriminator describing a sub-type of DistributionMode. </param>
        /// <param name="scoringRule">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule
        /// providing static rules that always return the same result, regardless of
        /// input.
        /// DirectMapRule:  A rule that return the same labels as the input
        /// labels.
        /// ExpressionRule: A rule providing inline expression
        /// rules.
        /// FunctionRule: A rule providing a binding to an HTTP Triggered Azure
        /// Function.
        /// WebhookRule: A rule providing a binding to a webserver following
        /// OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        /// <param name="scoringRuleOptions">
        /// Encapsulates all options that can be passed as parameters for scoring rule with
        /// BestWorkerMode
        /// </param>
        internal BestWorkerMode(int minConcurrentOffers, int maxConcurrentOffers, bool? bypassSelectors, string kind, RouterRule scoringRule, ScoringRuleOptions scoringRuleOptions) : base(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, kind)
        {
            ScoringRule = scoringRule;
            ScoringRuleOptions = scoringRuleOptions;
        }
    }
}
