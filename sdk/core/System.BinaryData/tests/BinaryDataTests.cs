﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace System.Tests
{
    public class BinaryDataTests
    {
        [Fact]
        public void CanCreateBinaryDataFromBytes()
        {
            byte[] payload = Encoding.UTF8.GetBytes("some data");
            BinaryData data = BinaryData.FromBytes(payload);
            Assert.Equal(payload, data.ToBytes().ToArray());

            MemoryMarshal.TryGetArray<byte>(payload, out ArraySegment<byte> array);
            Assert.Same(payload, array.Array);

            // using implicit conversion
            ReadOnlyMemory<byte> bytes = data;
            Assert.Equal(payload, bytes.ToArray());

            // using implicit conversion
            ReadOnlySpan<byte> span = data;
            Assert.Equal(payload, span.ToArray());
        }

        [Fact]
        public void CanCreateBinaryDataFromString()
        {
            string payload = "some data";
            BinaryData data = new BinaryData(payload);
            Assert.Equal(payload, data.ToString());

            data = BinaryData.FromString(payload);
            Assert.Equal(payload, data.ToString());
        }

        [Fact]
        public void ToStringRespectsArraySegmentBoundaries()
        {
            string payload = "pre payload post";
            byte[] bytes = Encoding.UTF8.GetBytes(payload);
            ArraySegment<byte> segment = new ArraySegment<byte>(bytes, 4, 7);
            BinaryData data = BinaryData.FromBytes(segment);
            Assert.Equal("payload", data.ToString());

            data = BinaryData.FromBytes(segment.Array);
            Assert.Equal("pre payload post", data.ToString());
        }

        [Fact]
        public async Task ToStreamRespectsArraySegmentBoundaries()
        {
            string payload = "pre payload post";
            byte[] bytes = Encoding.UTF8.GetBytes(payload);
            ArraySegment<byte> segment = new ArraySegment<byte>(bytes, 4, 7);
            BinaryData data = BinaryData.FromBytes(segment);
            Stream stream = data.ToStream();
            StreamReader sr = new StreamReader(stream);
            Assert.Equal("payload", await sr.ReadToEndAsync());
        }

        [Fact]
        public async Task CannotWriteToReadOnlyMemoryStream()
        {
            byte[] buffer = Encoding.UTF8.GetBytes("some data");
            using MemoryStream payload = new MemoryStream(buffer);
            BinaryData data = BinaryData.FromStream(payload);
            Stream stream = data.ToStream();
            Assert.Throws<NotSupportedException>(() => stream.Write(buffer, 0, buffer.Length));
            await Assert.ThrowsAsync<NotSupportedException>(() => stream.WriteAsync(buffer, 0, buffer.Length));
            Assert.Throws<NotSupportedException>(() => stream.WriteByte(1));
            Assert.False(stream.CanWrite);
            StreamReader sr = new StreamReader(stream);
            Assert.Equal("some data", await sr.ReadToEndAsync());
        }

        [Fact]
        public async Task CanCreateBinaryDataFromStream()
        {
            byte[] buffer = Encoding.UTF8.GetBytes("some data");
            using MemoryStream stream = new MemoryStream(buffer);
            BinaryData data = BinaryData.FromStream(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            byte[] output = new byte[buffer.Length];
            var outputStream = data.ToStream();
            outputStream.Read(output, 0, (int) outputStream.Length);
            Assert.Equal(buffer, output);

            stream.Position = 0;
            data = await BinaryData.FromStreamAsync(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            outputStream = data.ToStream();
            outputStream.Read(output, 0, (int)outputStream.Length);
            Assert.Equal(buffer, output);
        }

        [Fact]
        public async Task CanCreateBinaryDataFromStreamUsingBackingBuffer()
        {
            byte[] buffer = Encoding.UTF8.GetBytes("some data");
            using MemoryStream stream = new MemoryStream();
            stream.Write(buffer, 0, buffer.Length);
            stream.Position = 0;
            BinaryData data = BinaryData.FromStream(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            byte[] output = new byte[buffer.Length];
            var outputStream = data.ToStream();
            outputStream.Read(output, 0, (int)outputStream.Length);
            Assert.Equal(buffer, output);

            stream.Position = 0;
            data = await BinaryData.FromStreamAsync(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            outputStream = data.ToStream();
            outputStream.Read(output, 0, (int)outputStream.Length);
            Assert.Equal(buffer, output);
        }

        [Fact]
        public async Task CanCreateBinaryDataFromNonSeekableStream()
        {
            byte[] buffer = Encoding.UTF8.GetBytes("some data");
            using MemoryStream stream = new NonSeekableStream(buffer);
            BinaryData data = BinaryData.FromStream(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            byte[] output = new byte[buffer.Length];
            var outputStream = data.ToStream();
            outputStream.Read(output, 0, (int)outputStream.Length);
            Assert.Equal(buffer, output);

            stream.Position = 0;
            data = await BinaryData.FromStreamAsync(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            outputStream = data.ToStream();
            outputStream.Read(output, 0, (int)outputStream.Length);
            Assert.Equal(buffer, output);
        }

        [Fact]
        public async Task CanCreateBinaryDataFromFileStream()
        {
            byte[] buffer = Encoding.UTF8.GetBytes("some data");
            using FileStream stream = new FileStream(Path.GetTempFileName(), FileMode.Open);
            stream.Write(buffer, 0, buffer.Length);
            stream.Position = 0;
            BinaryData data = BinaryData.FromStream(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            byte[] output = new byte[buffer.Length];
            var outputStream = data.ToStream();
            outputStream.Read(output, 0, (int)outputStream.Length);
            Assert.Equal(buffer, output);

            stream.Position = 0;
            data = await BinaryData.FromStreamAsync(stream);
            Assert.Equal(buffer, data.ToBytes().ToArray());

            outputStream = data.ToStream();
            outputStream.Read(output, 0, (int)outputStream.Length);
            Assert.Equal(buffer, output);
        }

        [Theory]
        [InlineData(1, 4)]
        [InlineData(0, 4)]
        [InlineData(4, 1)]
        [InlineData(4, 0)]
        public async Task StartPositionOfStreamRespected(int bufferOffset, long streamStart)
        {
            var input = "some data";
            ArraySegment<byte> buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes("some data"), bufferOffset, input.Length - bufferOffset);
            MemoryStream stream = new MemoryStream(buffer.Array, buffer.Offset, buffer.Count);
            var payload = new ReadOnlyMemory<byte>(buffer.Array, buffer.Offset, buffer.Count).Slice((int)streamStart);

            stream.Position = streamStart;
            BinaryData data = BinaryData.FromStream(stream);
            Assert.Equal(payload.ToArray(), data.ToBytes().ToArray());
            Assert.Equal(buffer.Count - streamStart, data.ToStream().Length);

            stream.Position = streamStart;
            data = await BinaryData.FromStreamAsync(stream);
            Assert.Equal(payload.ToArray(), data.ToBytes().ToArray());
            Assert.Equal(buffer.Count - streamStart, data.ToStream().Length);
        }

        [Theory]
        [InlineData(1, 4)]
        [InlineData(0, 4)]
        [InlineData(4, 1)]
        [InlineData(4, 0)]
        public async Task StartPositionOfStreamRespectedBackingBuffer(int bufferOffset, long streamStart)
        {
            var input = "some data";
            ArraySegment<byte> buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes("some data"), bufferOffset, input.Length - bufferOffset);
            MemoryStream stream = new MemoryStream();
            stream.Write(buffer.Array, buffer.Offset, buffer.Count);

            var payload = new ReadOnlyMemory<byte>(buffer.Array, buffer.Offset, buffer.Count).Slice((int)streamStart);

            stream.Position = streamStart;
            BinaryData data = BinaryData.FromStream(stream);
            Assert.Equal(payload.ToArray(), data.ToBytes().ToArray());
            Assert.Equal(buffer.Count - streamStart, data.ToStream().Length);

            stream.Position = streamStart;
            data = await BinaryData.FromStreamAsync(stream);
            Assert.Equal(payload.ToArray(), data.ToBytes().ToArray());
            Assert.Equal(buffer.Count - streamStart, data.ToStream().Length);
        }

        [Fact]
        public void MaxStreamLengthRespected()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BinaryData.FromStream(new OverFlowStream()));
        }

        [Fact]
        public void CanCreateBinaryDataFromCustomType()
        {
            TestModel payload = new TestModel { A = "value", B = 5, C = true, D = null };

            AssertData(BinaryData.FromObjectAsJson(payload));
            AssertData(BinaryData.FromObjectAsJson(payload, new Text.Json.JsonSerializerOptions { IgnoreNullValues = true }));
            AssertData(new BinaryData(payload, type: typeof(TestModel)));
            AssertData(new BinaryData(payload, options: null, typeof(TestModel)));
            AssertData(new BinaryData(payload, new Text.Json.JsonSerializerOptions() { IgnoreNullValues = true }, typeof(TestModel)));

            void AssertData(BinaryData data)
            {
                TestModel model = data.ToObjectFromJson<TestModel>();
                Assert.Equal(payload.A, model.A);
                Assert.Equal(payload.B, model.B);
                Assert.Equal(payload.C, model.C);
                Assert.Equal(payload.D, model.D);
            }
        }

        [Fact]
        public void CanSerializeNullData()
        {
            BinaryData data = new BinaryData(jsonSerializable: null);
            Assert.Null(data.ToObjectFromJson<object>());
            data = BinaryData.FromObjectAsJson<object>(null);
            Assert.Null(data.ToObjectFromJson<object>());
        }

        [Fact]
        public async Task CreateThrowsOnNullStream()
        {
            Assert.Throws<ArgumentNullException>(() => BinaryData.FromStream(null));

            await Assert.ThrowsAsync<ArgumentNullException>(() => BinaryData.FromStreamAsync(null));
        }

        [Fact]
        public void ToObjectThrowsExceptionOnIncompatibleType()
        {
            TestModel payload = new TestModel { A = "value", B = 5, C = true };
            BinaryData data = BinaryData.FromObjectAsJson(payload);
            Assert.ThrowsAny<Exception>(() => data.ToObjectFromJson<string>());
        }

        [Fact]
        public void EqualsRespectsReferenceEquality()
        {
            byte[] payload = Encoding.UTF8.GetBytes("some data");
            BinaryData a = BinaryData.FromBytes(payload);
            BinaryData b = BinaryData.FromBytes(payload);
            Assert.NotEqual(a, b);

            BinaryData c = BinaryData.FromBytes(Encoding.UTF8.GetBytes("some data"));
            Assert.NotEqual(a, c);

            Assert.False(a.Equals("string data"));
        }

        [Fact]
        public void GetHashCodeWorks()
        {
            byte[] payload = Encoding.UTF8.GetBytes("some data");
            BinaryData a = BinaryData.FromBytes(payload);
            BinaryData b = BinaryData.FromBytes(payload);
            HashSet<BinaryData> set = new HashSet<BinaryData>
            {
                a
            };
            // hashcodes of a and b should not match since instances are different.
            Assert.DoesNotContain(b, set);

            BinaryData c = BinaryData.FromBytes(Encoding.UTF8.GetBytes("some data"));
            // c should have a different hash code
            Assert.DoesNotContain(c, set);
            set.Add(c);
            Assert.Contains(c, set);
        }

        [Fact]
        public async Task CanRead()
        {
            var buffer = Encoding.UTF8.GetBytes("some data");
            var stream = new BinaryData(buffer).ToStream();

            var read = new byte[buffer.Length];
            stream.Read(read, 0, buffer.Length);
            Assert.Equal(buffer, read);

            read = new byte[buffer.Length];
            stream.Position = 0;
            await stream.ReadAsync(read, 0, buffer.Length);
            Assert.Equal(buffer, read);

            // no-op as we are at end of stream
            stream.Read(read, 0, buffer.Length);
            await stream.ReadAsync(read, 0, buffer.Length);
        }

        [Fact]
        public async Task CanReadPartial()
        {
            var buffer = Encoding.UTF8.GetBytes("some data");
            var stream = new BinaryData(buffer).ToStream();
            var length = 4;
            var read = new byte[length];
            stream.Read(read, 0, length);
            Assert.Equal(buffer.AsMemory().Slice(0, length).ToArray(), read.AsMemory().Slice(0, length).ToArray());

            read = new byte[length];
            stream.Position = 0;
            await stream.ReadAsync(read, 0, length);
            Assert.Equal(buffer.AsMemory().Slice(0, length).ToArray(), read.AsMemory().Slice(0, length).ToArray());

            // no-op as we are at end of stream
            stream.Read(read, 0, length);
            await stream.ReadAsync(read, 0, length);
            Assert.Equal(-1, stream.ReadByte());
        }

        [Fact]
        public void ReadAsyncRespectsCancellation()
        {
            var buffer = Encoding.UTF8.GetBytes("some data");
            var stream = new BinaryData(buffer).ToStream();

            var read = new byte[buffer.Length];
            var cts = new CancellationTokenSource();
            cts.Cancel();

            var task = stream.ReadAsync(read, 0, buffer.Length, cts.Token);
            Assert.True(task.IsCanceled);

            cts = new CancellationTokenSource();
            task = stream.ReadAsync(read, 0, buffer.Length, cts.Token);
            Assert.False(task.IsCanceled);
            Assert.True(task.IsCompleted);
        }

        [Fact]
        public async Task CanSeek()
        {
            var buffer = Encoding.UTF8.GetBytes("some data");
            var stream = new BinaryData(buffer).ToStream();

            stream.Seek(5, SeekOrigin.Begin);
            Assert.Equal(buffer[5], stream.ReadByte());
            stream.Seek(1, SeekOrigin.Current);
            Assert.Equal(buffer[7], stream.ReadByte());
            stream.Seek(-2, SeekOrigin.End);
            Assert.Equal(buffer.Length - 2, stream.Position);
            Assert.Equal(buffer[buffer.Length - 2], stream.ReadByte());
            stream.Seek(-2, SeekOrigin.End);
            var read = new byte[buffer.Length - stream.Position];
            await stream.ReadAsync(read, 0, read.Length);
            Assert.Equal(
                new ReadOnlyMemory<byte>(buffer, buffer.Length - 2, 2).ToArray(),
                read);
        }

        [Fact]
        public void ValidatesSeekArguments()
        {
            var buffer = Encoding.UTF8.GetBytes("some data");
            var stream = new BinaryData(buffer).ToStream();

            Assert.Throws<IOException>(() => stream.Seek(-1, SeekOrigin.Begin));

            Assert.Throws<ArgumentOutOfRangeException>(() => stream.Seek((long)int.MaxValue + 1, SeekOrigin.Begin));
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.Seek(0, (SeekOrigin)3));
        }


        [Fact]
        public async Task ValidatesReadArguments()
        {
            var buffer = Encoding.UTF8.GetBytes("some data");
            var stream = new BinaryData(buffer).ToStream();
            stream.Seek(3, SeekOrigin.Begin);
            var read = new byte[buffer.Length - stream.Position];
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => stream.ReadAsync(read, 0, buffer.Length));
            await Assert.ThrowsAsync<ArgumentNullException>(() => stream.ReadAsync(null, 0, buffer.Length));
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => stream.ReadAsync(read, -1, read.Length));
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => stream.ReadAsync(read, 0, -1));
            await stream.ReadAsync(read, 0, read.Length);
            Assert.Equal(
                new ReadOnlyMemory<byte>(buffer, 3, buffer.Length - 3).ToArray(),
                read);
        }

        [Fact]
        public void ValidatesPositionValue()
        {
            var buffer = Encoding.UTF8.GetBytes("some data");
            var stream = new BinaryData(buffer).ToStream();
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.Position = -1);
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.Position = (long)int.MaxValue + 1);
        }

        private class TestModel
        {
            public string A { get; set; }
            public int B { get; set; }
            public bool C { get; set; }
            public object D { get; set; }
        }

        private class OverFlowStream : MemoryStream
        {
            public override long Length => (long)int.MaxValue + 1;
        }

        private class NonSeekableStream : MemoryStream
        {
            public NonSeekableStream(byte[] buffer) : base(buffer) { }
            public override bool CanSeek => false;
        }
    }
}
