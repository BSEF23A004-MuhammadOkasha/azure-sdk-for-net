﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Azure.Messaging.EventHubs
{
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Azure.Messaging.EventHubs.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The message (id:{0}, size:{1} bytes) is larger than is currently allowed ({2} bytes)..
        /// </summary>
        internal static string MessageSizeExceeded
        {
            get
            {
                return ResourceManager.GetString("MessageSizeExceeded", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; may not be null or empty..
        /// </summary>
        internal static string ArgumentNullOrEmpty
        {
            get
            {
                return ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; may not be null or white space..
        /// </summary>
        internal static string ArgumentNullOrWhiteSpace
        {
            get
            {
                return ResourceManager.GetString("ArgumentNullOrWhiteSpace", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; may not be empty or white space, though it may be null.
        /// </summary>
        internal static string ArgumentEmptyOrWhiteSpace
        {
            get
            {
                return ResourceManager.GetString("ArgumentEmptyOrWhiteSpace", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; cannot exceed {1} characters..
        /// </summary>
        internal static string ArgumentStringTooLong
        {
            get
            {
                return ResourceManager.GetString("ArgumentStringTooLong", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A producer created for a specific partition cannot send events using a partition key.  This producer is associated with partition &apos;{0}&apos;..
        /// </summary>
        internal static string CannotSendWithPartitionIdAndPartitionKey
        {
            get
            {
                return ResourceManager.GetString("CannotSendWithPartitionIdAndPartitionKey", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The connection string could not be parsed; either it was malformed or contains no well-known tokens..
        /// </summary>
        internal static string InvalidConnectionString
        {
            get
            {
                return ResourceManager.GetString("InvalidConnectionString", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The string has an invalid encoding format..
        /// </summary>
        internal static string InvalidEncoding
        {
            get
            {
                return ResourceManager.GetString("InvalidEncoding", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The shared access signature could not be parsed; it was either malformed or incorrectly encoded..
        /// </summary>
        internal static string InvalidSharedAccessSignature
        {
            get
            {
                return ResourceManager.GetString("InvalidSharedAccessSignature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The time period may not be Zero or Infinite..
        /// </summary>
        internal static string InvalidTimePeriod
        {
            get
            {
                return ResourceManager.GetString("InvalidTimePeriod", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The requested transport type, &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string InvalidTransportType
        {
            get
            {
                return ResourceManager.GetString("InvalidTransportType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The connection string used for an Event Hub client must specify the Event Hubs namespace host, and a Shared Access Signature (both the name and value) to be valid.  The path to an Event Hub must be included in the connection string or specified separately..
        /// </summary>
        internal static string MissingConnectionInformation
        {
            get
            {
                return ResourceManager.GetString("MissingConnectionInformation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The path to an Event Hub may be specified as part of the connection string or as a separate value, but not both.
        /// </summary>
        internal static string OnlyOneEventHubNameMayBeSpecified
        {
            get
            {
                return ResourceManager.GetString("OnlyOneEventHubNameMayBeSpecified", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to System property &apos;{0}&apos; is missing in the event..
        /// </summary>
        internal static string MissingSystemProperty
        {
            get
            {
                return ResourceManager.GetString("MissingSystemProperty", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A proxy may only be used for a websockets connection..
        /// </summary>
        internal static string ProxyMustUseWebsockets
        {
            get
            {
                return ResourceManager.GetString("ProxyMustUseWebsockets", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;identifier&apos; parameter exceeds the maximum allowed size of {0} characters..
        /// </summary>
        internal static string ConsumerIdentifierOverMaxValue
        {
            get
            {
                return ResourceManager.GetString("ConsumerIdentifierOverMaxValue", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The requested resource, &apos;{0}&apos;, does not match the resource of the shared access signature, &apos;{1}&apos;. A token cannot be issued..
        /// </summary>
        internal static string ResourceMustMatchSharedAccessSignature
        {
            get
            {
                return ResourceManager.GetString("ResourceMustMatchSharedAccessSignature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retry options must be specified; if no retry is desired, please set the maximum number of retries to 0. To provide a custom retry policy, please assign it on the client directly..
        /// </summary>
        internal static string RetryOptionsMustBeSet
        {
            get
            {
                return ResourceManager.GetString("RetryOptionsMustBeSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to In order to update the signature, a shared access key must have been provided when the shared access signature was created..
        /// </summary>
        internal static string SharedAccessKeyIsRequired
        {
            get
            {
                return ResourceManager.GetString("SharedAccessKeyIsRequired", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A timeout value must be positive.  To request using the default timeout, please use TimeSpan.Zero or null..
        /// </summary>
        internal static string TimeoutMustBePositive
        {
            get
            {
                return ResourceManager.GetString("TimeoutMustBePositive", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a non-negative timespan value. The provided value was {1}..
        /// </summary>
        internal static string TimeSpanMustBeNonNegative
        {
            get
            {
                return ResourceManager.GetString("TimeSpanMustBeNonNegative", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The specified connection type, &quot;{0}&quot;, is not recognized as valid in this context..
        /// </summary>
        internal static string UnknownConnectionType
        {
            get
            {
                return ResourceManager.GetString("UnknownConnectionType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The value supplied must be between {0} and {1}..
        /// </summary>
        internal static string ValueOutOfRange
        {
            get
            {
                return ResourceManager.GetString("ValueOutOfRange", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The credential is not a known and supported credential type.  Please use a JWT credential or shared key credential..
        /// </summary>
        internal static string UnsupportedCredential
        {
            get
            {
                return ResourceManager.GetString("UnsupportedCredential", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to >A shared key credential is unable to generate a token directly.  Please use this credential when creating an Event Hub Client, for proper generation of shared key tokens..
        /// </summary>
        internal static string SharedKeyCredentialCannotGenerateTokens
        {
            get
            {
                return ResourceManager.GetString("SharedKeyCredentialCannotGenerateTokens", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} value is expected to be a {1} bit signed integer. Actual value: '{2}'..
        /// </summary>
        internal static string CannotParseIntegerType
        {
            get
            {
                return ResourceManager.GetString("CannotParseIntegerType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The requested retry mode, '{0}' is not known; a retry delay canot be determined..
        /// </summary>
        internal static string UnknownRetryMode
        {
            get
            {
                return ResourceManager.GetString("UnknownRetryMode", resourceCulture);
            }
        }
    }
}
