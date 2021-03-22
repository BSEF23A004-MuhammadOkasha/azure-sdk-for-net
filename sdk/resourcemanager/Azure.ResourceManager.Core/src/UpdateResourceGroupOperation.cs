﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Core
{
    internal class UpdateResourceGroupOperation : ValueArmOperation<ResourceGroup>, IOperationSource<ResourceGroup>
    {
        public UpdateResourceGroupOperation()
        {
        }
    }
}
