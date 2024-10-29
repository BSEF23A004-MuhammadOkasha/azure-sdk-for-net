// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// The execution options of a job step.
/// </summary>
public partial class JobStepExecutionOptions : ProvisionableConstruct
{
    /// <summary>
    /// Execution timeout for the job step.
    /// </summary>
    public BicepValue<int> TimeoutSeconds 
    {
        get { Initialize(); return _timeoutSeconds!; }
        set { Initialize(); _timeoutSeconds!.Assign(value); }
    }
    private BicepValue<int>? _timeoutSeconds;

    /// <summary>
    /// Maximum number of times the job step will be reattempted if the first
    /// attempt fails.
    /// </summary>
    public BicepValue<int> RetryAttempts 
    {
        get { Initialize(); return _retryAttempts!; }
        set { Initialize(); _retryAttempts!.Assign(value); }
    }
    private BicepValue<int>? _retryAttempts;

    /// <summary>
    /// Initial delay between retries for job step execution.
    /// </summary>
    public BicepValue<int> InitialRetryIntervalSeconds 
    {
        get { Initialize(); return _initialRetryIntervalSeconds!; }
        set { Initialize(); _initialRetryIntervalSeconds!.Assign(value); }
    }
    private BicepValue<int>? _initialRetryIntervalSeconds;

    /// <summary>
    /// The maximum amount of time to wait between retries for job step
    /// execution.
    /// </summary>
    public BicepValue<int> MaximumRetryIntervalSeconds 
    {
        get { Initialize(); return _maximumRetryIntervalSeconds!; }
        set { Initialize(); _maximumRetryIntervalSeconds!.Assign(value); }
    }
    private BicepValue<int>? _maximumRetryIntervalSeconds;

    /// <summary>
    /// The backoff multiplier for the time between retries.
    /// </summary>
    public BicepValue<float> RetryIntervalBackoffMultiplier 
    {
        get { Initialize(); return _retryIntervalBackoffMultiplier!; }
        set { Initialize(); _retryIntervalBackoffMultiplier!.Assign(value); }
    }
    private BicepValue<float>? _retryIntervalBackoffMultiplier;

    /// <summary>
    /// Creates a new JobStepExecutionOptions.
    /// </summary>
    public JobStepExecutionOptions()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of JobStepExecutionOptions.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _timeoutSeconds = DefineProperty<int>("TimeoutSeconds", ["timeoutSeconds"]);
        _retryAttempts = DefineProperty<int>("RetryAttempts", ["retryAttempts"]);
        _initialRetryIntervalSeconds = DefineProperty<int>("InitialRetryIntervalSeconds", ["initialRetryIntervalSeconds"]);
        _maximumRetryIntervalSeconds = DefineProperty<int>("MaximumRetryIntervalSeconds", ["maximumRetryIntervalSeconds"]);
        _retryIntervalBackoffMultiplier = DefineProperty<float>("RetryIntervalBackoffMultiplier", ["retryIntervalBackoffMultiplier"]);
    }
}
