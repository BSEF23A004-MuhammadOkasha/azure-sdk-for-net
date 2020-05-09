﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Reflection;
using System.Runtime.Versioning;

namespace Azure.Messaging.ServiceBus.Primitives
{
    internal static class ClientInfo
    {
        internal static readonly string Product;
        internal static readonly string Version;
        internal static readonly string Framework;
        internal static readonly string Platform;

        static ClientInfo()
        {
            try
            {
                var assembly = typeof(ClientInfo).GetTypeInfo().Assembly;
                Product = GetAssemblyAttributeValue<AssemblyProductAttribute>(assembly, p => p.Product);
                Version = GetAssemblyAttributeValue<AssemblyFileVersionAttribute>(assembly, v => v.Version);
                Framework = GetAssemblyAttributeValue<TargetFrameworkAttribute>(assembly, f => f.FrameworkName);
#if NETSTANDARD2_0
                Platform = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
#elif UAP10_0
                Platform = "UAP";
#elif NET461
                Platform = Environment.OSVersion.VersionString;
#else
                Platform = "Unknown";
#endif
            }
            catch
            {
                // ignored
            }
        }

        internal static string GetAssemblyAttributeValue<T>(Assembly assembly, Func<T, string> getter) where T : Attribute
        {
            return !(assembly.GetCustomAttribute(typeof(T)) is T attribute) ? null : getter(attribute);
        }
    }
}
