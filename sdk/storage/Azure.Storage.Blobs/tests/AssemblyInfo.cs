﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("d78fd724-3d57-4ecd-ac71-7450e1280c3c")]

// Set per-test timeout to 20 minutes to prevent a single test from hanging the whole suite
[assembly: NUnit.Framework.Timeout(20 * 60 * 1000)]
