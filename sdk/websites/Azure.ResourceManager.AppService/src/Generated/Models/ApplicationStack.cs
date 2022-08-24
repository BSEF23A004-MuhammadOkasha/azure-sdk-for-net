// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Application stack.
    /// Serialized Name: ApplicationStack
    /// </summary>
    public partial class ApplicationStack
    {
        /// <summary> Initializes a new instance of ApplicationStack. </summary>
        public ApplicationStack()
        {
            MajorVersions = new ChangeTrackingList<StackMajorVersion>();
            Frameworks = new ChangeTrackingList<ApplicationStack>();
            IsDeprecated = new ChangeTrackingList<ApplicationStack>();
        }

        /// <summary> Initializes a new instance of ApplicationStack. </summary>
        /// <param name="name">
        /// Application stack name.
        /// Serialized Name: ApplicationStack.name
        /// </param>
        /// <param name="display">
        /// Application stack display name.
        /// Serialized Name: ApplicationStack.display
        /// </param>
        /// <param name="dependency">
        /// Application stack dependency.
        /// Serialized Name: ApplicationStack.dependency
        /// </param>
        /// <param name="majorVersions">
        /// List of major versions available.
        /// Serialized Name: ApplicationStack.majorVersions
        /// </param>
        /// <param name="frameworks">
        /// List of frameworks associated with application stack.
        /// Serialized Name: ApplicationStack.frameworks
        /// </param>
        /// <param name="isDeprecated">
        /// &lt;code&gt;true&lt;/code&gt; if this is the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: ApplicationStack.isDeprecated
        /// </param>
        internal ApplicationStack(string name, string display, string dependency, IList<StackMajorVersion> majorVersions, IList<ApplicationStack> frameworks, IList<ApplicationStack> isDeprecated)
        {
            Name = name;
            Display = display;
            Dependency = dependency;
            MajorVersions = majorVersions;
            Frameworks = frameworks;
            IsDeprecated = isDeprecated;
        }

        /// <summary>
        /// Application stack name.
        /// Serialized Name: ApplicationStack.name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Application stack display name.
        /// Serialized Name: ApplicationStack.display
        /// </summary>
        public string Display { get; set; }
        /// <summary>
        /// Application stack dependency.
        /// Serialized Name: ApplicationStack.dependency
        /// </summary>
        public string Dependency { get; set; }
        /// <summary>
        /// List of major versions available.
        /// Serialized Name: ApplicationStack.majorVersions
        /// </summary>
        public IList<StackMajorVersion> MajorVersions { get; }
        /// <summary>
        /// List of frameworks associated with application stack.
        /// Serialized Name: ApplicationStack.frameworks
        /// </summary>
        public IList<ApplicationStack> Frameworks { get; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if this is the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: ApplicationStack.isDeprecated
        /// </summary>
        public IList<ApplicationStack> IsDeprecated { get; }
    }
}
