﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ExceptionPolicy
    {
        /// <summary> (Optional) A dictionary collection of exception rules on the exception policy. Key is the Id of each exception rule. </summary>
        [CodeGenMember("ExceptionRules")]
#pragma warning disable CA2227 // Collection properties should be read only
        public IDictionary<string, ExceptionRule> ExceptionRules { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
