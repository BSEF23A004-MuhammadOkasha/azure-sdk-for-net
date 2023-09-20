﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using System.ServiceModel.Rest.Core;

namespace System.ServiceModel.Rest;

public abstract class Result
{
    public abstract IResponse Response { get; }

    public static Result Create(IResponse response) => new SimpleResult(response);

    internal class SimpleResult : Result
    {
        public readonly IResponse _response;
        public SimpleResult(IResponse response)
            => _response = response;
        public override IResponse Response => _response;
    }
}

public class NullableResult<T> : Result
{
    private T? _value;
    private IResponse _response;

    public NullableResult(T? value, Result result)
    {
        _response = result.Response;
        _value = value;
    }

    public virtual T? Value => _value;

    public virtual bool HasValue => _value != null;

    public override IResponse Response => _response;
}

public class Result<T> : NullableResult<T>
{
    public Result(T value, Result response) : base(value, response)
    {
    }

    public override T Value => base.Value!;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool HasValue => true;
}
