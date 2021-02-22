﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Communication.Pipeline
{
    public class CommunicationIdentityClientRecordedTestSanitizer : CommunicationRecordedTestSanitizer
    {
        public CommunicationIdentityClientRecordedTestSanitizer()
        {
            JsonPathSanitizers.Add("$..token");
            JsonPathSanitizers.Add("$..urls");
            JsonPathSanitizers.Add("$..username");
            JsonPathSanitizers.Add("$..credential");
        }
    }
}
