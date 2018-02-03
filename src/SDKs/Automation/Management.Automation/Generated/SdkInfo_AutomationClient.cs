
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_AutomationClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("Automation", "Activity", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "AgentRegistrationInformation", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "AutomationAccount", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Certificate", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Connection", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "ConnectionType", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Credential", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "DscCompilationJob", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "DscConfiguration", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "DscNode", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "DscNodeConfiguration", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Fields", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "HybridRunbookWorkerGroup", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Job", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "JobSchedule", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "JobStream", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Module", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "NodeReports", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "ObjectDataTypes", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Operations", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Runbook", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "RunbookDraft", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Schedule", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "SoftwareUpdateConfigurationMachineRuns", "2017-05-15-preview"),
                new Tuple<string, string, string>("Automation", "SoftwareUpdateConfigurationRuns", "2017-05-15-preview"),
                new Tuple<string, string, string>("Automation", "SoftwareUpdateConfigurations", "2017-05-15-preview"),
                new Tuple<string, string, string>("Automation", "Statistics", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "TestJobStreams", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "TestJobs", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Usages", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Variable", "2015-10-31"),
                new Tuple<string, string, string>("Automation", "Webhook", "2015-10-31"),
            }.AsEnumerable();
        }
    }
}
