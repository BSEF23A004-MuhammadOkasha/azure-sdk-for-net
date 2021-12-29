// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.Core.TestFramework.Models;
using Azure.Data.Tables;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.Extensions.Tables.Tests
{
    public class EntityBindingLiveTests: TablesLiveTestBase
    {
        private static DateTimeOffset DateTimeOffsetValue = DateTimeOffset.Parse("07-08-1997", null,  DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
        private static DateTime DateTimeValue = DateTime.Parse("07-08-1997", null,  DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);

        public EntityBindingLiveTests(bool isAsync, bool useCosmos) : base(isAsync, useCosmos)
        {
            // Some recordings contain windows newlines inside string values,
            // replace them with current platform newline

            var replacementNewLine = Environment.NewLine
                .Replace("\r", "\\\\r")
                .Replace("\n", "\\\\n");

            Sanitizer.BodyRegexSanitizers.Add(
                new BodyRegexSanitizer(
                    replacementNewLine,
                    "\\r\\n"));
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(CanBindToNonExistingEntityProgram<>)})]
        public async Task CanBindToNonExistingEntity(string entityType)
        {
            // Act & Assert
            await CallAsync<CanBindToNonExistingEntityProgram<int>>(entityType);
        }

        private class CanBindToNonExistingEntityProgram<T>
        {
            public static void CustomTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] CustomTableEntity<T> entity)
            {
                Assert.Null(entity);
            }

            public static void TableEntity([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity)
            {
                Assert.Null(entity);
            }

            public static void ITableEntity([Table(TableNameExpression, PartitionKey, RowKey)] ITableEntity entity)
            {
                Assert.Null(entity);
            }

            public static void PocoTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] PocoTableEntity<T> entity)
            {
                Assert.Null(entity);
            }

            public static void JObject([Table(TableNameExpression, PartitionKey, RowKey)] JObject entity)
            {
                Assert.Null(entity);
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(CanBindToExistingEntityProgram<>)})]
        public async Task CanBindToExistingEntity(string entityType)
        {
            foreach (var values in AllowedTypedWithValues)
            {
                // Arrange
                await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = values.Value1Base
                });

                // Act & Assert
                await CallAsync(
                    typeof(CanBindToExistingEntityProgram<>).MakeGenericType(values.Type),
                    entityType,
                    arguments: new
                    {
                        original = values.Value1Base,
                        originalTyped = values.Value1
                    });
                await ClearTableAsync();
            }
        }

        private class CanBindToExistingEntityProgram<T>
        {
            public static void CustomTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] CustomTableEntity<T> entity, T originalTyped)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);
            }

            public static void TableEntity([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity, object original)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(original, entity["Value"]);
            }

            public static void ITableEntity([Table(TableNameExpression, PartitionKey, RowKey)] ITableEntity entity, object original)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(original, ((TableEntity)entity)["Value"]);
            }

            public static void PocoTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] PocoTableEntity<T> entity, T originalTyped)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);
            }

            public static void JObject([Table(TableNameExpression, PartitionKey, RowKey)] JObject entity, object original)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(JsonConvert.SerializeObject(original), JsonConvert.SerializeObject(entity["Value"]));
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(CanBindToExistingEntityUsingExpressionsProgram<>)})]
        public async Task CanBindToExistingEntityUsingExpressions(string entityType)
        {
            AllowedTypesWithValue values = AllowedTypedWithValues.First();
            // Arrange
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey)
            {
                ["Value"] = values.Value1Base
            });

            // Act & Assert
            await CallAsync(
                typeof(CanBindToExistingEntityUsingExpressionsProgram<>).MakeGenericType(values.Type),
                entityType,
                arguments: new
                {
                    original = values.Value1Base,
                    originalTyped = values.Value1,
                    tbl = TableName,
                    pk = PartitionKey,
                    rk = RowKey
                });
        }

        private class CanBindToExistingEntityUsingExpressionsProgram<T>
        {
            public static void CustomTableEntity([Table("{tbl}", "{pk}", "{rk}")] CustomTableEntity<T> entity, T originalTyped)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);
            }

            public static void TableEntity([Table("{tbl}", "{pk}", "{rk}")] TableEntity entity, object original)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(original, entity["Value"]);
            }

            public static void ITableEntity([Table("{tbl}", "{pk}", "{rk}")] ITableEntity entity, object original)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(original, ((TableEntity)entity)["Value"]);
            }

            public static void PocoTableEntity([Table("{tbl}", "{pk}", "{rk}")] PocoTableEntity<T> entity, T originalTyped)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);
            }

            public static void JObject([Table("{tbl}", "{pk}", "{rk}")] JObject entity, object original)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(JsonConvert.SerializeObject(original), JsonConvert.SerializeObject(entity["Value"]));
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(AddEntityProgram<>)})]
        public async Task CanAddEntity(string entityType)
        {
            foreach (var values in AllowedTypedWithValues)
            {
                // Act
                await CallAsync(
                    typeof(AddEntityProgram<>).MakeGenericType(values.Type),
                    entityType,
                    arguments: new
                    {
                        original = values.Value1Base,
                        originalTyped = values.Value1,
                    });

                // Assert
                TableEntity entity = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey);
                Assert.NotNull(entity);
                Assert.AreEqual(values.Value1Base, entity["Value"]);

                await ClearTableAsync();
            }
        }

        private class AddEntityProgram<T>
        {
            [return: Table(TableNameExpression)]
            public static CustomTableEntity<T> CustomTableEntity(T originalTyped)
            {
                return new CustomTableEntity<T>()
                {
                    Value = originalTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                };
            }

            [return: Table(TableNameExpression)]
            public static TableEntity TableEntity(object original)
            {
                return new TableEntity
                {
                    ["Value"] = original,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                };
            }

            [return: Table(TableNameExpression)]
            public static ITableEntity ITableEntity(object original)
            {
                return new TableEntity
                {
                    ["Value"] = original,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                };
            }

            [return: Table(TableNameExpression)]
            public static PocoTableEntity<T> PocoTableEntity(T originalTyped)
            {
                return new PocoTableEntity<T>()
                {
                    Value = originalTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                };
            }

            [return: Table(TableNameExpression)]
            public static JObject JObject(object original)
            {
                return new JObject()
                {
                    ["Value"] = JToken.FromObject(original),
                    ["PartitionKey"] = PartitionKey,
                    ["RowKey"] = RowKey
                };
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(CanAddEntityWithIdsInAttributeProgram<>)})]
        public async Task CanAddEntityWithIdsInAttribute(string entityType)
        {
            var values = AllowedTypedWithValues.First();
            // Act
            await CallAsync(
                typeof(CanAddEntityWithIdsInAttributeProgram<>).MakeGenericType(values.Type),
                entityType,
                arguments: new
                {
                    original = values.Value1Base,
                    originalTyped = values.Value1,
                });

            // Assert
            TableEntity entity = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey);
            Assert.NotNull(entity);
            Assert.AreEqual(values.Value1Base, entity["Value"]);
        }

        private class CanAddEntityWithIdsInAttributeProgram<T>
        {
            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static CustomTableEntity<T> CustomTableEntity(T originalTyped)
            {
                return new CustomTableEntity<T>()
                {
                    Value = originalTyped
                };
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static TableEntity TableEntity(object original)
            {
                return new TableEntity
                {
                    ["Value"] = original
                };
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static ITableEntity ITableEntity(object original)
            {
                return new TableEntity
                {
                    ["Value"] = original
                };
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static PocoTableEntity<T> PocoTableEntity(T originalTyped)
            {
                return new PocoTableEntity<T>()
                {
                    Value = originalTyped
                };
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static JObject JObject(object original)
            {
                return new JObject()
                {
                    ["Value"] = JToken.FromObject(original)
                };
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(CanAddEntityUsingCollectorProgram<>)})]
        public async Task CanAddEntityUsingCollector(string entityType)
        {
            var values = AllowedTypedWithValues.First();
            // Act
            await CallAsync(
                typeof(CanAddEntityUsingCollectorProgram<>).MakeGenericType(values.Type),
                entityType,
                arguments: new
                {
                    original = values.Value1Base,
                    originalTyped = values.Value1,
                    another = values.Value2Base,
                    anotherTyped = values.Value2,
                });

            // Assert
            TableEntity entity = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey);
            Assert.NotNull(entity);
            Assert.AreEqual(values.Value1Base, entity["Value"]);
            TableEntity entity2 = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey + "1");
            Assert.NotNull(entity2);
            Assert.AreEqual(values.Value2Base, entity2["Value"]);
        }

        private class CanAddEntityUsingCollectorProgram<T>
        {
            public static void CustomTableEntity([Table(TableNameExpression)] ICollector<CustomTableEntity<T>> collector, T originalTyped, T anotherTyped)
            {
                collector.Add(new CustomTableEntity<T>()
                {
                    Value = originalTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                collector.Add(new CustomTableEntity<T>()
                {
                    Value = anotherTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static void TableEntity([Table(TableNameExpression)] ICollector<TableEntity> collector, object original, object another)
            {
                collector.Add(new TableEntity
                {
                    ["Value"] = original,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                collector.Add(new TableEntity
                {
                    ["Value"] = another,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static void ITableEntity([Table(TableNameExpression)] ICollector<ITableEntity> collector, object original, object another)
            {
                collector.Add(new TableEntity
                {
                    ["Value"] = original,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                collector.Add(new TableEntity
                {
                    ["Value"] = another,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static void PocoTableEntity([Table(TableNameExpression)] ICollector<PocoTableEntity<T>> collector, T originalTyped, T anotherTyped)
            {
                collector.Add(new PocoTableEntity<T>()
                {
                    Value = originalTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                collector.Add(new PocoTableEntity<T>()
                {
                    Value = anotherTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            [return: Table(TableNameExpression, PartitionKey, RowKey)]
            public static void JObject([Table(TableNameExpression)] ICollector<JObject> collector, object original, object another)
            {
                collector.Add(new JObject()
                {
                    ["Value"] = JToken.FromObject(original),
                    ["PartitionKey"] = PartitionKey,
                    ["RowKey"] = RowKey
                });
                collector.Add(new JObject()
                {
                    ["Value"] = JToken.FromObject(another),
                    ["PartitionKey"] = PartitionKey,
                    ["RowKey"] = RowKey + "1"
                });
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(CanAddEntityUsingAsyncCollectorProgram<>)})]
        public async Task CanAddEntityUsingAsyncCollector(string entityType)
        {
            var values = AllowedTypedWithValues.First();
            // Act
            await CallAsync(
                typeof(CanAddEntityUsingAsyncCollectorProgram<>).MakeGenericType(values.Type),
                entityType,
                arguments: new
                {
                    original = values.Value1Base,
                    originalTyped = values.Value1,
                    another = values.Value2Base,
                    anotherTyped = values.Value2,
                });

            // Assert
            TableEntity entity = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey);
            Assert.NotNull(entity);
            Assert.AreEqual(values.Value1Base, entity["Value"]);
            TableEntity entity2 = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey + "1");
            Assert.NotNull(entity2);
            Assert.AreEqual(values.Value2Base, entity2["Value"]);
        }

        private class CanAddEntityUsingAsyncCollectorProgram<T>
        {
            public static async Task CustomTableEntity([Table(TableNameExpression)] IAsyncCollector<CustomTableEntity<T>> collector, T originalTyped, T anotherTyped)
            {
                await collector.AddAsync(new CustomTableEntity<T>()
                {
                    Value = originalTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                await collector.AddAsync(new CustomTableEntity<T>()
                {
                    Value = anotherTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            public static async Task TableEntity([Table(TableNameExpression)] IAsyncCollector<TableEntity> collector, object original, object another)
            {
                await collector.AddAsync(new TableEntity
                {
                    ["Value"] = original,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                await collector.AddAsync(new TableEntity
                {
                    ["Value"] = another,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            public static async Task ITableEntity([Table(TableNameExpression)] IAsyncCollector<ITableEntity> collector, object original, object another)
            {
                await collector.AddAsync(new TableEntity
                {
                    ["Value"] = original,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                await collector.AddAsync(new TableEntity
                {
                    ["Value"] = another,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            public static async Task PocoTableEntity([Table(TableNameExpression)] IAsyncCollector<PocoTableEntity<T>> collector, T originalTyped, T anotherTyped)
            {
                await collector.AddAsync(new PocoTableEntity<T>()
                {
                    Value = originalTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey
                });
                await collector.AddAsync(new PocoTableEntity<T>()
                {
                    Value = anotherTyped,
                    PartitionKey = PartitionKey,
                    RowKey = RowKey + "1"
                });
            }

            public static async Task JObject([Table(TableNameExpression)] IAsyncCollector<JObject> collector, object original, object another)
            {
                await collector.AddAsync(new JObject()
                {
                    ["Value"] = JToken.FromObject(original),
                    ["PartitionKey"] = PartitionKey,
                    ["RowKey"] = RowKey
                });
                await collector.AddAsync(new JObject()
                {
                    ["Value"] = JToken.FromObject(another),
                    ["PartitionKey"] = PartitionKey,
                    ["RowKey"] = RowKey + "1"
                });
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(UpdateEntityValueProgram<>)})]
        public async Task CanUpdateProperty(string entityType)
        {
            foreach (var values in AllowedTypedWithValuesAndNullables)
            {
                // Arrange
                await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = values.Value1Base
                });

                // Act
                await CallAsync(
                    typeof(UpdateEntityValueProgram<>).MakeGenericType(values.Type),
                    entityType,
                    arguments: new
                    {
                        original = values.Value1Base,
                        expected = values.Value2Base,
                        originalTyped = values.Value1,
                        expectedTyped = values.Value2
                    });

                // Assert
                TableEntity entity = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey);
                Assert.NotNull(entity);
                Assert.AreEqual(values.Value2Base, entity["Value"]);
                await ClearTableAsync();
            }
        }

        private class UpdateEntityValueProgram<T>
        {
            public static void CustomTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] CustomTableEntity<T> entity, T originalTyped, T expectedTyped)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);
                entity.Value = expectedTyped;
            }

            public static void TableEntity([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity, object original, object expected)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(original, entity["Value"]);
                entity["Value"] = expected;
            }

            public static void JObject([Table(TableNameExpression, PartitionKey, RowKey)] JObject entity, object original, object expected)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(JsonConvert.SerializeObject(original), JsonConvert.SerializeObject(entity["Value"]));
                entity["Value"] = expected == null ? JValue.CreateNull() : JToken.FromObject(expected);
            }

            public static void PocoTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] PocoTableEntity<T> entity, T originalTyped, T expectedTyped)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);
                entity.Value = expectedTyped;
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(NoEntityUpdateProgram<>)})]
        public async Task SkipsUpdateWithNoChanges(string entityType)
        {
            foreach (var values in AllowedTypedWithValuesAndNullables)
            {
                // Arrange
                await TableClient.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = values.Value1Base
                }, TableUpdateMode.Replace);

                // Act
                await CallAsync(
                    typeof(NoEntityUpdateProgram<>).MakeGenericType(values.Type),
                    entityType,
                    arguments: new
                    {
                        original = values.Value1Base,
                        expected = values.Value2Base,
                        originalTyped = values.Value1,
                        expectedTyped = values.Value2,
                        client = TableClient
                    });

                // Assert
                TableEntity entity = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, RowKey);
                Assert.NotNull(entity);
                Assert.AreEqual(values.Value2Base, entity["Value"]);
                await ClearTableAsync();
            }
        }

        // Invalidate the entity ETag so the Replace call fails if we try to update the entity
        private class NoEntityUpdateProgram<T>
        {
            public static async Task CustomTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] CustomTableEntity<T> entity, TableClient client, object expected)
            {
                Assert.NotNull(entity);
                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);
            }

            public static async Task TableEntity([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity, TableClient client, object expected)
            {
                Assert.NotNull(entity);
                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);
            }

            public static async Task JObject([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity, TableClient client, object expected)
            {
                Assert.NotNull(entity);
                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);
            }

            public static async Task PocoTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] PocoTableEntity<T> entity, TableClient client, object expected)
            {
                Assert.NotNull(entity);
                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(UpdatingPropertyInParallelThrowsProgram<>)})]
        public async Task UpdatingPropertyInParallelThrows(string entityType)
        {
            AllowedTypesWithValue values = AllowedTypedWithValues.First();
            // Arrange
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey)
            {
                ["Value"] = values.Value1Base
            });

            // Act
            var exception = Assert.ThrowsAsync<FunctionInvocationException>(async () => await CallAsync(
                typeof(UpdatingPropertyInParallelThrowsProgram<>).MakeGenericType(values.Type),
                entityType,
                arguments: new
                {
                    client = TableClient,
                    original = values.Value1Base,
                    expected = values.Value2Base,
                    originalTyped = values.Value1,
                    expectedTyped = values.Value2
                }));
            AssertInvocationETagFailure("entity", exception);
        }

        private void AssertInvocationETagFailure(string expectedParameterName, Exception exception)
        {
            Assert.IsInstanceOf<FunctionInvocationException>(exception);

            Assert.IsInstanceOf<InvalidOperationException>(exception.InnerException);
            string expectedMessage = String.Format(CultureInfo.InvariantCulture,
                "Error while handling parameter {0} after function returned:", expectedParameterName);
            Assert.AreEqual(expectedMessage, exception.InnerException.Message);

            Exception innerException = exception.InnerException.InnerException;
            Assert.IsInstanceOf<RequestFailedException>(innerException);

            RequestFailedException invalidOperationException = (RequestFailedException)innerException;
            Assert.NotNull(invalidOperationException.Message);
            //"Precondition Failed",
            Assert.That(invalidOperationException.Message, Contains.Substring("UpdateConditionNotSatisfied").Or.Contains("Precondition Failed"));
        }

        private class UpdatingPropertyInParallelThrowsProgram<T>
        {
            public static async Task CustomTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] CustomTableEntity<T> entity, TableClient client, T originalTyped, T expectedTyped, object expected)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);

                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);

                entity.Value = expectedTyped;
            }

            public static async Task TableEntity([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity, TableClient client, object original, object expected)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(original, entity["Value"]);

                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);

                entity["Value"] = expected;
            }

            public static async Task JObject([Table(TableNameExpression, PartitionKey, RowKey)] JObject entity, TableClient client, object original, object expected)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(JsonConvert.SerializeObject(original), JsonConvert.SerializeObject(entity["Value"]));

                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);

                entity["Value"] = expected == null ? JValue.CreateNull() : JToken.FromObject(expected);
            }

            public static async Task PocoTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] PocoTableEntity<T> entity, TableClient client, T originalTyped, T expectedTyped, object expected)
            {
                Assert.NotNull(entity);
                Assert.AreEqual(originalTyped, entity.Value);

                await client.UpsertEntityAsync(new TableEntity(PartitionKey, RowKey)
                {
                    ["Value"] = expected
                }, TableUpdateMode.Replace);

                entity.Value = expectedTyped;
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(UpdatingPartitionKeyThrowsProgram<>)})]
        public async Task UpdatingPartitionKeyThrows(string entityType)
        {
            // Arrange
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey));

            // Act
            var functionException = Assert.ThrowsAsync<FunctionInvocationException>(async () => await CallAsync(
                typeof(UpdatingPartitionKeyThrowsProgram<string>),
                entityType));

            Exception exception = functionException.InnerException;

            // Assert
            Assert.NotNull(exception);
            Assert.IsInstanceOf<InvalidOperationException>(exception);
            Assert.AreEqual("Error while handling parameter entity after function returned:", exception.Message);
            Exception innerException = exception.InnerException;
            Assert.NotNull(innerException);
            Assert.IsInstanceOf<InvalidOperationException>(innerException);
            Assert.AreEqual("When binding to a table entity, the partition key must not be changed.",
                innerException.Message);
        }

        private class UpdatingPartitionKeyThrowsProgram<T>
        {
            public static void CustomTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] CustomTableEntity<T> entity)
            {
                entity.PartitionKey = "NEWPK";
            }

            public static void TableEntity([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity)
            {
                entity["PartitionKey"] = "NEWPK";
            }

            public static void JObject([Table(TableNameExpression, PartitionKey, RowKey)] JObject entity)
            {
                entity["PartitionKey"] = "NEWPK";
            }

            public static void PocoTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] PocoTableEntity<T> entity)
            {
                entity.PartitionKey = "NEWPK";
            }
        }

        [RecordedTest]
        [TestCaseSource(nameof(MethodsOf), new object[] {typeof(UpdatingRowKeyThrowsProgram<>)})]
        public async Task UpdatingRowKeyThrows(string entityType)
        {
            // Arrange
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey));

            // Act
            var functionException = Assert.ThrowsAsync<FunctionInvocationException>(
                async () => await CallAsync<UpdatingRowKeyThrowsProgram<string>>(entityType));

            Exception exception = functionException.InnerException;

            // Assert
            Assert.NotNull(exception);
            Assert.IsInstanceOf<InvalidOperationException>(exception);
            Assert.AreEqual("Error while handling parameter entity after function returned:", exception.Message);
            Exception innerException = exception.InnerException;
            Assert.NotNull(innerException);
            Assert.IsInstanceOf<InvalidOperationException>(innerException);
            Assert.AreEqual("When binding to a table entity, the row key must not be changed.",
                innerException.Message);
        }

        private class UpdatingRowKeyThrowsProgram<T>
        {
            public static void CustomTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] CustomTableEntity<T> entity)
            {
                entity.RowKey = "NEWPK";
            }

            public static void TableEntity([Table(TableNameExpression, PartitionKey, RowKey)] TableEntity entity)
            {
                entity["RowKey"] = "NEWPK";
            }

            public static void JObject([Table(TableNameExpression, PartitionKey, RowKey)] JObject entity)
            {
                entity["RowKey"] = "NEWPK";
            }

            public static void PocoTableEntity([Table(TableNameExpression, PartitionKey, RowKey)] PocoTableEntity<T> entity)
            {
                entity.RowKey = "NEWPK";
            }
        }

        [RecordedTest]
        public async Task CanBindToJArrayWithFilter()
        {
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey + "1") { ["Value"] = "x1" });
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey + "2") { ["Value"] = "x2" });
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey + "3") { ["Value"] = "x3" });
            await TableClient.AddEntityAsync(new TableEntity(PartitionKey, RowKey + "4") { ["Value"] = "x4" });

            // Act
            var result1 = await CallAsync<BindTableEntityToJArrayProgram>(nameof(BindTableEntityToJArrayProgram.CallTakeFilter));
            Assert.AreEqual("x1;x3;", result1.Result);

            var result2 = await CallAsync<BindTableEntityToJArrayProgram>(nameof(BindTableEntityToJArrayProgram.CallFilter));
            Assert.AreEqual("x1;x3;x4;", result2.Result);

            var result3 = await CallAsync<BindTableEntityToJArrayProgram>(nameof(BindTableEntityToJArrayProgram.CallTake));
            Assert.AreEqual("x1;x2;x3;", result3.Result);

            var result4 = await CallAsync<BindTableEntityToJArrayProgram>(nameof(BindTableEntityToJArrayProgram.Call));
            Assert.AreEqual("x1;x2;x3;x4;", result4.Result);
        }

        private class BindTableEntityToJArrayProgram
        {
            public string Result;

            // Helper to flatten a Jarray for quick testing.
            private static string Flatten(JArray array)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < array.Count; i++)
                {
                    sb.Append(array[i]["Value"]);
                    sb.Append(';');
                }

                return sb.ToString();
            }

            public void CallTakeFilter([Table(TableNameExpression, PartitionKey, Take = 2, Filter = "Value ne 'x2'")] JArray array)
            {
                Result = Flatten(array);
            }

            public void CallFilter([Table(TableNameExpression, PartitionKey, Filter = "Value ne 'x2'")] JArray array)
            {
                Result = Flatten(array);
            }

            public void CallTake([Table(TableNameExpression, PartitionKey, Take = 3)] JArray array)
            {
                Result = Flatten(array);
            }

            // No take or filters
            public void Call([Table(TableNameExpression, PartitionKey)] JArray array)
            {
                Result = Flatten(array);
            }
        }

        [RecordedTest]
        public async Task InsertOverBatchLimit()
        {
            if (UseCosmos)
            {
                Assert.Ignore("Hits the rate limit");
            }

            await CallAsync<InsertOverBatchLimitProgram>();

            var entities = await TableClient.QueryAsync<TableEntity>().ToEnumerableAsync();
            Assert.AreEqual(TableEntityWriter.MaxBatchSize * 4, entities.Count);
            Assert.AreEqual(TableEntityWriter.MaxBatchSize * 4, entities.Select(e=> e.RowKey).Distinct().Count());
            Assert.AreEqual(TableEntityWriter.MaxBatchSize * 4, entities.Select(e=> (int)e["Value"]).Distinct().Count());
        }

        private class InsertOverBatchLimitProgram
        {
            public async Task Call([Table(TableNameExpression)] IAsyncCollector<TableEntity> collector)
            {
                for (int i = 0; i < TableEntityWriter.MaxBatchSize * 4; i++)
                {
                    await collector.AddAsync(new TableEntity(PartitionKey, i.ToString())
                    {
                        ["Value"] = i
                    });
                }
            }
        }

        [RecordedTest]
        [LiveOnly]
        public async Task InsertOverPartitionLimit()
        {
            await CallAsync<InsertOverPartitionLimitProgram>();
            var entities = await TableClient.QueryAsync<TableEntity>().ToEnumerableAsync();
            Assert.AreEqual(TableEntityWriter.MaxPartitionWidth + 10, entities.Count);
            Assert.AreEqual(TableEntityWriter.MaxPartitionWidth + 10, entities.Select(e=> e.RowKey).Distinct().Count());
            Assert.AreEqual(TableEntityWriter.MaxPartitionWidth + 10, entities.Select(e=> (int)e["Value"]).Distinct().Count());
        }

        private class InsertOverPartitionLimitProgram
        {
            public async Task Call([Table(TableNameExpression)] IAsyncCollector<TableEntity> collector)
            {
                for (int i = 0; i < TableEntityWriter.MaxPartitionWidth + 10; i++)
                {
                    await collector.AddAsync(new TableEntity(i.ToString(), i.ToString())
                    {
                        ["Value"] = i
                    });
                }
            }
        }

        public static IEnumerable<AllowedTypesWithValue> AllowedTypedWithValuesAndNullables
        {
            get
            {
                foreach (var value in AllowedTypedWithValues)
                {
                    var type = value.Type;
                    if (value.Type.IsValueType)
                    {
                        type = typeof(Nullable<>).MakeGenericType(type);
                    }

                    yield return value;
                    yield return new AllowedTypesWithValue(type, value.Value1, null, value.Value1Base, null);
                    yield return new AllowedTypesWithValue(type, null, value.Value2, null, value.Value2Base);
                }
            }
        }

        public static IEnumerable<AllowedTypesWithValue> AllowedTypedWithValues { get; } = new AllowedTypesWithValue[]
        {
            new(typeof(string), "Foo", "Bar"),
            new(typeof(int), 1, 2),
            new(typeof(Guid), Guid.Parse("81a130d2-502f-4cf1-a376-63edeb000e9f"),  Guid.Parse("81a130d2-502f-4cf1-a376-63edeb000e0f")),
            new(typeof(double), 1.3d, 2.2d),
            new(typeof(bool), true, false),
            new(typeof(long), long.MinValue, long.MaxValue),
            new(typeof(DateTimeOffset), DateTimeOffsetValue, DateTimeOffsetValue.AddDays(1)),
            new(typeof(DateTime), DateTimeValue, DateTimeValue.AddDays(1), new DateTimeOffset(DateTimeValue), new DateTimeOffset(DateTimeValue.AddDays(1))),
            new(typeof(byte[]), new byte[] { 1, 2 ,3}, new byte[]{ 3, 2, 1}),
            new(typeof(string[]), new string[] { "hello", "world" },new string[]{ "updated" },
                $"[{Environment.NewLine}  \"hello\",{Environment.NewLine}  \"world\"{Environment.NewLine}]",
                $"[{Environment.NewLine}  \"updated\"{Environment.NewLine}]"
            ),
            new(typeof(ConsoleColor), ConsoleColor.Black, ConsoleColor.Gray, "Black", "Gray"),
            new(typeof(TimeSpan), TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10), "\"00:00:05\"", "\"00:00:10\""),
            new(typeof(ETag), new ETag("A"), new ETag("B"), "A", "B"),
            new(typeof(InnerPoco), new InnerPoco() { Value = "1" }, new InnerPoco() { Value = "2" },
                $"{{{Environment.NewLine}  \"Value\": \"1\"{Environment.NewLine}}}",
                $"{{{Environment.NewLine}  \"Value\": \"2\"{Environment.NewLine}}}"),
            new(typeof(ulong), 0UL, (ulong)long.MaxValue, "0", "9223372036854775807"),
        };

        public static IEnumerable<string> MethodsOf(Type type)
        {
            return type.GetMethods(BindingFlags.Public |
                                   BindingFlags.DeclaredOnly |
                                   BindingFlags.Static |
                                   BindingFlags.Instance)
                .Select(n => n.Name);
        }

        public struct AllowedTypesWithValue
        {
            public Type Type { get; }
            public object Value1 { get; }
            public object Value2 { get; }
            public object Value1Base { get; }
            public object Value2Base { get; }

            public AllowedTypesWithValue(Type type, object value1, object value2, object value1Base = null, object value2Base = null)
            {
                Type = type;
                Value1 = value1;
                Value2 = value2;
                Value1Base = value1Base ?? value1;
                Value2Base = value2Base ?? value2;
            }

            public override string ToString()
            {
                return $"{Type}, {Value1Base}, {Value2Base}";
            }
        }

        private class PocoTableEntity<T>
        {
            public T Value { get; set; }
            public string PartitionKey { get; set; }
            public string RowKey { get; set; }
        }

        private class CustomTableEntity<T> : ITableEntity
        {
            public T Value { get; set; }
            public string PartitionKey { get; set; }
            public string RowKey { get; set; }
            public DateTimeOffset? Timestamp { get; set; }
            public ETag ETag { get; set; }
        }

        private class InnerPoco : IEquatable<InnerPoco>
        {
            public string Value { get; set; }

            public bool Equals(InnerPoco other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == other.Value;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((InnerPoco)obj);
            }

            public override int GetHashCode()
            {
                return (Value != null ? Value.GetHashCode() : 0);
            }

            public static bool operator ==(InnerPoco left, InnerPoco right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(InnerPoco left, InnerPoco right)
            {
                return !Equals(left, right);
            }
        }
    }
}