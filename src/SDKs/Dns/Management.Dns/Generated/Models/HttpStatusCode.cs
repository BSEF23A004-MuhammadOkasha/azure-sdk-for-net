// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Dns.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Dns;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for HttpStatusCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpStatusCode
    {
        [EnumMember(Value = "Continue")]
        Continue,
        [EnumMember(Value = "SwitchingProtocols")]
        SwitchingProtocols,
        [EnumMember(Value = "OK")]
        OK,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "NonAuthoritativeInformation")]
        NonAuthoritativeInformation,
        [EnumMember(Value = "NoContent")]
        NoContent,
        [EnumMember(Value = "ResetContent")]
        ResetContent,
        [EnumMember(Value = "PartialContent")]
        PartialContent,
        [EnumMember(Value = "MultipleChoices")]
        MultipleChoices,
        [EnumMember(Value = "Ambiguous")]
        Ambiguous,
        [EnumMember(Value = "MovedPermanently")]
        MovedPermanently,
        [EnumMember(Value = "Moved")]
        Moved,
        [EnumMember(Value = "Found")]
        Found,
        [EnumMember(Value = "Redirect")]
        Redirect,
        [EnumMember(Value = "SeeOther")]
        SeeOther,
        [EnumMember(Value = "RedirectMethod")]
        RedirectMethod,
        [EnumMember(Value = "NotModified")]
        NotModified,
        [EnumMember(Value = "UseProxy")]
        UseProxy,
        [EnumMember(Value = "Unused")]
        Unused,
        [EnumMember(Value = "TemporaryRedirect")]
        TemporaryRedirect,
        [EnumMember(Value = "RedirectKeepVerb")]
        RedirectKeepVerb,
        [EnumMember(Value = "BadRequest")]
        BadRequest,
        [EnumMember(Value = "Unauthorized")]
        Unauthorized,
        [EnumMember(Value = "PaymentRequired")]
        PaymentRequired,
        [EnumMember(Value = "Forbidden")]
        Forbidden,
        [EnumMember(Value = "NotFound")]
        NotFound,
        [EnumMember(Value = "MethodNotAllowed")]
        MethodNotAllowed,
        [EnumMember(Value = "NotAcceptable")]
        NotAcceptable,
        [EnumMember(Value = "ProxyAuthenticationRequired")]
        ProxyAuthenticationRequired,
        [EnumMember(Value = "RequestTimeout")]
        RequestTimeout,
        [EnumMember(Value = "Conflict")]
        Conflict,
        [EnumMember(Value = "Gone")]
        Gone,
        [EnumMember(Value = "LengthRequired")]
        LengthRequired,
        [EnumMember(Value = "PreconditionFailed")]
        PreconditionFailed,
        [EnumMember(Value = "RequestEntityTooLarge")]
        RequestEntityTooLarge,
        [EnumMember(Value = "RequestUriTooLong")]
        RequestUriTooLong,
        [EnumMember(Value = "UnsupportedMediaType")]
        UnsupportedMediaType,
        [EnumMember(Value = "RequestedRangeNotSatisfiable")]
        RequestedRangeNotSatisfiable,
        [EnumMember(Value = "ExpectationFailed")]
        ExpectationFailed,
        [EnumMember(Value = "UpgradeRequired")]
        UpgradeRequired,
        [EnumMember(Value = "InternalServerError")]
        InternalServerError,
        [EnumMember(Value = "NotImplemented")]
        NotImplemented,
        [EnumMember(Value = "BadGateway")]
        BadGateway,
        [EnumMember(Value = "ServiceUnavailable")]
        ServiceUnavailable,
        [EnumMember(Value = "GatewayTimeout")]
        GatewayTimeout,
        [EnumMember(Value = "HttpVersionNotSupported")]
        HttpVersionNotSupported
    }
    internal static class HttpStatusCodeEnumExtension
    {
        internal static string ToSerializedValue(this HttpStatusCode? value)  =>
            value == null ? null : ((HttpStatusCode)value).ToSerializedValue();

        internal static string ToSerializedValue(this HttpStatusCode value)
        {
            switch( value )
            {
                case HttpStatusCode.Continue:
                    return "Continue";
                case HttpStatusCode.SwitchingProtocols:
                    return "SwitchingProtocols";
                case HttpStatusCode.OK:
                    return "OK";
                case HttpStatusCode.Created:
                    return "Created";
                case HttpStatusCode.Accepted:
                    return "Accepted";
                case HttpStatusCode.NonAuthoritativeInformation:
                    return "NonAuthoritativeInformation";
                case HttpStatusCode.NoContent:
                    return "NoContent";
                case HttpStatusCode.ResetContent:
                    return "ResetContent";
                case HttpStatusCode.PartialContent:
                    return "PartialContent";
                case HttpStatusCode.MultipleChoices:
                    return "MultipleChoices";
                case HttpStatusCode.Ambiguous:
                    return "Ambiguous";
                case HttpStatusCode.MovedPermanently:
                    return "MovedPermanently";
                case HttpStatusCode.Moved:
                    return "Moved";
                case HttpStatusCode.Found:
                    return "Found";
                case HttpStatusCode.Redirect:
                    return "Redirect";
                case HttpStatusCode.SeeOther:
                    return "SeeOther";
                case HttpStatusCode.RedirectMethod:
                    return "RedirectMethod";
                case HttpStatusCode.NotModified:
                    return "NotModified";
                case HttpStatusCode.UseProxy:
                    return "UseProxy";
                case HttpStatusCode.Unused:
                    return "Unused";
                case HttpStatusCode.TemporaryRedirect:
                    return "TemporaryRedirect";
                case HttpStatusCode.RedirectKeepVerb:
                    return "RedirectKeepVerb";
                case HttpStatusCode.BadRequest:
                    return "BadRequest";
                case HttpStatusCode.Unauthorized:
                    return "Unauthorized";
                case HttpStatusCode.PaymentRequired:
                    return "PaymentRequired";
                case HttpStatusCode.Forbidden:
                    return "Forbidden";
                case HttpStatusCode.NotFound:
                    return "NotFound";
                case HttpStatusCode.MethodNotAllowed:
                    return "MethodNotAllowed";
                case HttpStatusCode.NotAcceptable:
                    return "NotAcceptable";
                case HttpStatusCode.ProxyAuthenticationRequired:
                    return "ProxyAuthenticationRequired";
                case HttpStatusCode.RequestTimeout:
                    return "RequestTimeout";
                case HttpStatusCode.Conflict:
                    return "Conflict";
                case HttpStatusCode.Gone:
                    return "Gone";
                case HttpStatusCode.LengthRequired:
                    return "LengthRequired";
                case HttpStatusCode.PreconditionFailed:
                    return "PreconditionFailed";
                case HttpStatusCode.RequestEntityTooLarge:
                    return "RequestEntityTooLarge";
                case HttpStatusCode.RequestUriTooLong:
                    return "RequestUriTooLong";
                case HttpStatusCode.UnsupportedMediaType:
                    return "UnsupportedMediaType";
                case HttpStatusCode.RequestedRangeNotSatisfiable:
                    return "RequestedRangeNotSatisfiable";
                case HttpStatusCode.ExpectationFailed:
                    return "ExpectationFailed";
                case HttpStatusCode.UpgradeRequired:
                    return "UpgradeRequired";
                case HttpStatusCode.InternalServerError:
                    return "InternalServerError";
                case HttpStatusCode.NotImplemented:
                    return "NotImplemented";
                case HttpStatusCode.BadGateway:
                    return "BadGateway";
                case HttpStatusCode.ServiceUnavailable:
                    return "ServiceUnavailable";
                case HttpStatusCode.GatewayTimeout:
                    return "GatewayTimeout";
                case HttpStatusCode.HttpVersionNotSupported:
                    return "HttpVersionNotSupported";
            }
            return null;
        }

        internal static HttpStatusCode? ParseHttpStatusCode(this string value)
        {
            switch( value )
            {
                case "Continue":
                    return HttpStatusCode.Continue;
                case "SwitchingProtocols":
                    return HttpStatusCode.SwitchingProtocols;
                case "OK":
                    return HttpStatusCode.OK;
                case "Created":
                    return HttpStatusCode.Created;
                case "Accepted":
                    return HttpStatusCode.Accepted;
                case "NonAuthoritativeInformation":
                    return HttpStatusCode.NonAuthoritativeInformation;
                case "NoContent":
                    return HttpStatusCode.NoContent;
                case "ResetContent":
                    return HttpStatusCode.ResetContent;
                case "PartialContent":
                    return HttpStatusCode.PartialContent;
                case "MultipleChoices":
                    return HttpStatusCode.MultipleChoices;
                case "Ambiguous":
                    return HttpStatusCode.Ambiguous;
                case "MovedPermanently":
                    return HttpStatusCode.MovedPermanently;
                case "Moved":
                    return HttpStatusCode.Moved;
                case "Found":
                    return HttpStatusCode.Found;
                case "Redirect":
                    return HttpStatusCode.Redirect;
                case "SeeOther":
                    return HttpStatusCode.SeeOther;
                case "RedirectMethod":
                    return HttpStatusCode.RedirectMethod;
                case "NotModified":
                    return HttpStatusCode.NotModified;
                case "UseProxy":
                    return HttpStatusCode.UseProxy;
                case "Unused":
                    return HttpStatusCode.Unused;
                case "TemporaryRedirect":
                    return HttpStatusCode.TemporaryRedirect;
                case "RedirectKeepVerb":
                    return HttpStatusCode.RedirectKeepVerb;
                case "BadRequest":
                    return HttpStatusCode.BadRequest;
                case "Unauthorized":
                    return HttpStatusCode.Unauthorized;
                case "PaymentRequired":
                    return HttpStatusCode.PaymentRequired;
                case "Forbidden":
                    return HttpStatusCode.Forbidden;
                case "NotFound":
                    return HttpStatusCode.NotFound;
                case "MethodNotAllowed":
                    return HttpStatusCode.MethodNotAllowed;
                case "NotAcceptable":
                    return HttpStatusCode.NotAcceptable;
                case "ProxyAuthenticationRequired":
                    return HttpStatusCode.ProxyAuthenticationRequired;
                case "RequestTimeout":
                    return HttpStatusCode.RequestTimeout;
                case "Conflict":
                    return HttpStatusCode.Conflict;
                case "Gone":
                    return HttpStatusCode.Gone;
                case "LengthRequired":
                    return HttpStatusCode.LengthRequired;
                case "PreconditionFailed":
                    return HttpStatusCode.PreconditionFailed;
                case "RequestEntityTooLarge":
                    return HttpStatusCode.RequestEntityTooLarge;
                case "RequestUriTooLong":
                    return HttpStatusCode.RequestUriTooLong;
                case "UnsupportedMediaType":
                    return HttpStatusCode.UnsupportedMediaType;
                case "RequestedRangeNotSatisfiable":
                    return HttpStatusCode.RequestedRangeNotSatisfiable;
                case "ExpectationFailed":
                    return HttpStatusCode.ExpectationFailed;
                case "UpgradeRequired":
                    return HttpStatusCode.UpgradeRequired;
                case "InternalServerError":
                    return HttpStatusCode.InternalServerError;
                case "NotImplemented":
                    return HttpStatusCode.NotImplemented;
                case "BadGateway":
                    return HttpStatusCode.BadGateway;
                case "ServiceUnavailable":
                    return HttpStatusCode.ServiceUnavailable;
                case "GatewayTimeout":
                    return HttpStatusCode.GatewayTimeout;
                case "HttpVersionNotSupported":
                    return HttpStatusCode.HttpVersionNotSupported;
            }
            return null;
        }
    }
}
