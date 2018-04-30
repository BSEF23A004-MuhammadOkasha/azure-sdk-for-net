
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_ServiceFabricManagementClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("ServiceFabric", "ApplicationTypeVersions", "2017-07-01-preview"),
                new Tuple<string, string, string>("ServiceFabric", "ApplicationTypes", "2017-07-01-preview"),
                new Tuple<string, string, string>("ServiceFabric", "Applications", "2017-07-01-preview"),
                new Tuple<string, string, string>("ServiceFabric", "ClusterVersions", "2018-02-01"),
                new Tuple<string, string, string>("ServiceFabric", "Clusters", "2018-02-01"),
                new Tuple<string, string, string>("ServiceFabric", "Operations", "2017-07-01-preview"),
                new Tuple<string, string, string>("ServiceFabric", "Operations", "2018-02-01"),
                new Tuple<string, string, string>("ServiceFabric", "Services", "2017-07-01-preview"),
            }.AsEnumerable();
        }
    }
}
