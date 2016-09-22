﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.V2.Resource.Core
{
    public class Wrapper<InnerT> : IWrapper<InnerT>
    {
        public Wrapper(InnerT inner)
        {
            Inner = inner;
        }

        public InnerT Inner
        {
            get; private set;
        }
    }
}
