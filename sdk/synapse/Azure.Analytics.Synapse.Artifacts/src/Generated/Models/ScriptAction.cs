// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Custom script action to run on HDI ondemand cluster once it&apos;s up. </summary>
    public partial class ScriptAction
    {
        /// <summary> Initializes a new instance of ScriptAction. </summary>
        /// <param name="name"> The user provided name of the script action. </param>
        /// <param name="uri"> The URI for the script action. </param>
        /// <param name="roles"> The node types on which the script action should be executed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="uri"/> or <paramref name="roles"/> is null. </exception>
        public ScriptAction(string name, string uri, object roles)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (roles == null)
            {
                throw new ArgumentNullException(nameof(roles));
            }

            Name = name;
            Uri = uri;
            Roles = roles;
        }

        /// <summary> Initializes a new instance of ScriptAction. </summary>
        /// <param name="name"> The user provided name of the script action. </param>
        /// <param name="uri"> The URI for the script action. </param>
        /// <param name="roles"> The node types on which the script action should be executed. </param>
        /// <param name="parameters"> The parameters for the script action. </param>
        internal ScriptAction(string name, string uri, object roles, string parameters)
        {
            Name = name;
            Uri = uri;
            Roles = roles;
            Parameters = parameters;
        }

        /// <summary> The user provided name of the script action. </summary>
        public string Name { get; set; }
        /// <summary> The URI for the script action. </summary>
        public string Uri { get; set; }
        /// <summary> The node types on which the script action should be executed. </summary>
        public object Roles { get; set; }
        /// <summary> The parameters for the script action. </summary>
        public string Parameters { get; set; }
    }
}
