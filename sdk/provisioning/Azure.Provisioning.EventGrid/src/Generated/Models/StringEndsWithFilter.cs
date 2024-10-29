// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// StringEndsWith Filter.
/// </summary>
public partial class StringEndsWithFilter : EventGridFilter
{
    /// <summary>
    /// The set of filter values.
    /// </summary>
    public BicepList<string> Values 
    {
        get { Initialize(); return _values!; }
        set { Initialize(); _values!.Assign(value); }
    }
    private BicepList<string>? _values;

    /// <summary>
    /// Creates a new StringEndsWithFilter.
    /// </summary>
    public StringEndsWithFilter() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of StringEndsWithFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("operatorType", ["operatorType"], defaultValue: "StringEndsWith");
        _values = DefineListProperty<string>("Values", ["values"]);
    }
}
