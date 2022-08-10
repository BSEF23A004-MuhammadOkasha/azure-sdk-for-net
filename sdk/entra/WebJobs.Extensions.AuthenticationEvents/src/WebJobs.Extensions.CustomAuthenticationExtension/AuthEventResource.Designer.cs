﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AuthEventResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AuthEventResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.AuthEventResource", typeof(AuthEventResource).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action &apos;{0}&apos; is invalid, please use one of the following actions: &apos;{1}&apos;.
        /// </summary>
        internal static string Ex_Action_Invalid {
            get {
                return ResourceManager.GetString("Ex_Action_Invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comparable &apos;{0}&apos; cannot be match..
        /// </summary>
        internal static string Ex_Comparable_Not_Found {
            get {
                return ResourceManager.GetString("Ex_Comparable_Not_Found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ListenerFactoryContext is null.
        /// </summary>
        internal static string Ex_Context_Null {
            get {
                return ResourceManager.GetString("Ex_Context_Null", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot determine event from payload. (Error: {0}).
        /// </summary>
        internal static string Ex_Event_Missing {
            get {
                return ResourceManager.GetString("Ex_Event_Missing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; could not be written. Already exists..
        /// </summary>
        internal static string Ex_File_Exists {
            get {
                return ResourceManager.GetString("Ex_File_Exists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed.
        /// </summary>
        internal static string Ex_Gen_Failure {
            get {
                return ResourceManager.GetString("Ex_Gen_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid event type..
        /// </summary>
        internal static string Ex_Invalid_Event {
            get {
                return ResourceManager.GetString("Ex_Invalid_Event", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid schema event..
        /// </summary>
        internal static string Ex_Invalid_EventSchema {
            get {
                return ResourceManager.GetString("Ex_Invalid_EventSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type for Versioning needs to be derived from IEventRequest.
        /// </summary>
        internal static string Ex_Invalid_EventType {
            get {
                return ResourceManager.GetString("Ex_Invalid_EventType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find related listener for function: {0}, available functions: {1}.
        /// </summary>
        internal static string Ex_Invalid_Function {
            get {
                return ResourceManager.GetString("Ex_Invalid_Function", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An HttpRequestMessage is required.
        /// </summary>
        internal static string Ex_Invalid_Inbound {
            get {
                return ResourceManager.GetString("Ex_Invalid_Inbound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find json path set value.
        /// </summary>
        internal static string Ex_Invalid_JsonPath {
            get {
                return ResourceManager.GetString("Ex_Invalid_JsonPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Payload detected..
        /// </summary>
        internal static string Ex_Invalid_Payload {
            get {
                return ResourceManager.GetString("Ex_Invalid_Payload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response validation failed, see inner exceptions..
        /// </summary>
        internal static string Ex_Invalid_Response {
            get {
                return ResourceManager.GetString("Ex_Invalid_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Return type is invalid, please return either an AuthEventResponse, HttpResponse, HttpResponseMessage or string in your function return..
        /// </summary>
        internal static string Ex_Invalid_Return {
            get {
                return ResourceManager.GetString("Ex_Invalid_Return", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid version on Schema.
        /// </summary>
        internal static string Ex_Invalid_SchemaVersion {
            get {
                return ResourceManager.GetString("Ex_Invalid_SchemaVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the correct Event Metadata based on the input parameter: {0}.
        /// </summary>
        internal static string Ex_Missing_Def {
            get {
                return ResourceManager.GetString("Ex_Missing_Def", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please supply the function name via the query parameter: functionName, available functions: {0}.
        /// </summary>
        internal static string Ex_Missing_Function {
            get {
                return ResourceManager.GetString("Ex_Missing_Function", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the response on the request..
        /// </summary>
        internal static string Ex_Missing_Request_Response {
            get {
                return ResourceManager.GetString("Ex_Missing_Request_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Actions Found. Please supply atleast one action..
        /// </summary>
        internal static string Ex_No_Action {
            get {
                return ResourceManager.GetString("Ex_No_Action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot determine the validation path, missing version attribute on Version Enum..
        /// </summary>
        internal static string Ex_No_Attr {
            get {
                return ResourceManager.GetString("Ex_No_Attr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get exclusive lock to the resource..
        /// </summary>
        internal static string Ex_No_Lock {
            get {
                return ResourceManager.GetString("Ex_No_Lock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No associated open api document found for version..
        /// </summary>
        internal static string Ex_OpenApi_Missing {
            get {
                return ResourceManager.GetString("Ex_OpenApi_Missing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter on the function signature does not match the expected parameter type of &apos;{0}&apos;. Got: &apos;{1}&apos;.
        /// </summary>
        internal static string Ex_Parm_Mismatch {
            get {
                return ResourceManager.GetString("Ex_Parm_Mismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The response is expected to be of type: {0}.
        /// </summary>
        internal static string Ex_Response_Mismatch {
            get {
                return ResourceManager.GetString("Ex_Response_Mismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid token version {0}, supported versions are: {1}.
        /// </summary>
        internal static string Ex_Token_Version {
            get {
                return ResourceManager.GetString("Ex_Token_Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please supply both the TenantId and AudienceAppId in variables in your binding configuration. (Or app settings {0} and {1}).
        /// </summary>
        internal static string Ex_Trigger_Required_Attrs {
            get {
                return ResourceManager.GetString("Ex_Trigger_Required_Attrs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listener registered at: {0}.
        /// </summary>
        internal static string Log_EventHandler_Url {
            get {
                return ResourceManager.GetString("Log_EventHandler_Url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function name: .
        /// </summary>
        internal static string Out_Console_FunctName {
            get {
                return ResourceManager.GetString("Out_Console_FunctName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function url: .
        /// </summary>
        internal static string Out_Console_FunctUrl {
            get {
                return ResourceManager.GetString("Out_Console_FunctUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --------------------------.
        /// </summary>
        internal static string Out_Console_Seperator {
            get {
                return ResourceManager.GetString("Out_Console_Seperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ready.
        /// </summary>
        internal static string Status_Good {
            get {
                return ResourceManager.GetString("Status_Good", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; field is missing..
        /// </summary>
        internal static string Val_Non_Default {
            get {
                return ResourceManager.GetString("Val_Non_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; fields needs to contain one of the following values: .
        /// </summary>
        internal static string Val_One_Of {
            get {
                return ResourceManager.GetString("Val_One_Of", resourceCulture);
            }
        }
    }
}
