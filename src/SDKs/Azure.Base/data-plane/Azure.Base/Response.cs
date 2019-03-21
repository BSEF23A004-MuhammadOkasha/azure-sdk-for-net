﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Base.Buffers;
using Azure.Base.Http;
using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace Azure
{
    public readonly struct Response: IDisposable
    {
        private readonly HttpPipelineResponse _httpResponse;

        public Response(HttpPipelineResponse httpResponse)
        {
            _httpResponse = httpResponse;
        }

        public int Status => _httpResponse.Status;

        public Stream ContentStream => _httpResponse.ResponseContentStream;

        public bool TryGetHeader(ReadOnlySpan<byte> name, out long value)
        {
            value = default;
            if (!TryGetHeader(name, out ReadOnlySpan<byte> bytes)) return false;
            if (!Utf8Parser.TryParse(bytes, out value, out int consumed) || consumed != bytes.Length)
                throw new Exception("bad content-length value");
            return true;
        }

        public bool TryGetHeader(ReadOnlySpan<byte> name, out ReadOnlySpan<byte> value)
            => _httpResponse.TryGetHeader(name, out value);

        public bool TryGetHeader(ReadOnlySpan<byte> name, out string value)
        {
            if (TryGetHeader(name, out ReadOnlySpan<byte> span)) {
                value = span.AsciiToString();
                return true;
            }
            value = default;
            return false;
        }

        public bool TryGetHeader(string name, out long value)
        {
            value = default;
            if (!TryGetHeader(name, out string valueString)) return false;
            if (!long.TryParse(valueString, out value))
                throw new Exception("bad content-length value");
            return true;
        }

        public bool TryGetHeader(string name, out string value)
        {
            var utf8Name = Encoding.ASCII.GetBytes(name);
            return TryGetHeader(utf8Name, out value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        public void Dispose()
        {
            _httpResponse.Dispose();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => _httpResponse.ToString();
    }
}
