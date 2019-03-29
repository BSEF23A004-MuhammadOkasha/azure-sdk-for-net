﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Azure.Search.Models;
    using Microsoft.Spatial;
    using Newtonsoft.Json.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Builds field definitions for an Azure Search index by reflecting over a user-defined model type.
    /// </summary>
    public static class FieldBuilder
    {
        private static IContractResolver CamelCaseResolver { get; } = new CamelCasePropertyNamesContractResolver();

        private static IContractResolver DefaultResolver { get; } = new DefaultContractResolver();

        /// <summary>
        /// Creates a collection of <see cref="Field"/> objects corresponding to
        /// the properties of the type supplied.
        /// </summary>
        /// <typeparam name="T">
        /// The type for which fields will be created, based on its properties.
        /// </typeparam>
        /// <returns>A collection of fields.</returns>
        public static IList<Field> BuildForType<T>()
        {
            bool useCamelCase = SerializePropertyNamesAsCamelCaseAttribute.IsDefinedOnType<T>();
            IContractResolver resolver = useCamelCase
                ? CamelCaseResolver
                : DefaultResolver;
            return BuildForType<T>(resolver);
        }

        /// <summary>
        /// Creates a collection of <see cref="Field"/> objects corresponding to
        /// the properties of the type supplied.
        /// </summary>
        /// <typeparam name="T">
        /// The type for which fields will be created, based on its properties.
        /// </typeparam>
        /// <param name="contractResolver">
        /// Contract resolver that the SearchIndexClient will use.
        /// This ensures that the field names are generated in a way that is
        /// consistent with the way the model will be serialized.
        /// </param>
        /// <returns>A collection of fields.</returns>
        public static IList<Field> BuildForType<T>(IContractResolver contractResolver)
        {
            var contract = (JsonObjectContract)contractResolver.ResolveContract(typeof(T));
            var fields = new List<Field>();
            foreach (JsonProperty prop in contract.Properties)
            {
                IList<Attribute> attributes = prop.AttributeProvider.GetAttributes(true);
                if (attributes.Any(attr => attr is JsonIgnoreAttribute))
                {
                    continue;
                }

                DataType dataType = GetDataType(prop.PropertyType, prop.PropertyName);

                var field = new Field(prop.PropertyName, dataType);
                                
                foreach (Attribute attribute in attributes)
                {
                    switch (attribute)
                    {
                        case IsSearchableAttribute _:
                            field.IsSearchable = true;
                            break;

                        case IsFilterableAttribute _:
                            field.IsFilterable = true;
                            break;

                        case IsSortableAttribute _:
                            field.IsSortable = true;
                            break;

                        case IsFacetableAttribute _:
                            field.IsFacetable = true;
                            break;

                        case IsRetrievableAttribute isRetrievableAttribute:
                            field.IsRetrievable = isRetrievableAttribute.IsRetrievable;
                            break;

                        case AnalyzerAttribute analyzerAttribute:
                            field.Analyzer = analyzerAttribute.Name;
                            break;

                        case SearchAnalyzerAttribute searchAnalyzerAttribute:
                            field.SearchAnalyzer = searchAnalyzerAttribute.Name;
                            break;

                        case IndexAnalyzerAttribute indexAnalyzerAttribute:
                            field.IndexAnalyzer = indexAnalyzerAttribute.Name;
                            break;

                        case SynonymMapsAttribute synonymMapsAttribute:
                            field.SynonymMaps = synonymMapsAttribute.SynonymMaps;
                            break;

                        default:
                            // Match on name to avoid dependency - don't want to force people not using
                            // this feature to bring in the annotations component.
                            Type attributeType = attribute.GetType();
                            if (attributeType.FullName == "System.ComponentModel.DataAnnotations.KeyAttribute")
                            {
                                field.IsKey = true;
                            }
                            break;
                    }
                }

                fields.Add(field);
            }

            return fields;
        }

        private static DataType GetDataType(Type propertyType, string propertyName)
        {
            if (propertyType == typeof(string))
            {
                return DataType.String;
            }
            if (propertyType.IsConstructedGenericType &&
                propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return GetDataType(propertyType.GenericTypeArguments[0], propertyName);
            }
            if (propertyType == typeof(int))
            {
                return DataType.Int32;
            }
            if (propertyType == typeof(long))
            {
                return DataType.Int64;
            }
            if (propertyType == typeof(double))
            {
                return DataType.Double;
            }
            if (propertyType == typeof(bool))
            {
                return DataType.Boolean;
            }
            if (propertyType == typeof(DateTimeOffset) ||
                propertyType == typeof(DateTime))
            {
                return DataType.DateTimeOffset;
            }
            if (propertyType == typeof(GeographyPoint))
            {
                return DataType.GeographyPoint;
            }
            Type elementType = GetElementTypeIfIEnumerable(propertyType);
            if (elementType != null)
            {
                return DataType.Collection(GetDataType(elementType, propertyName));
            }
            TypeInfo ti = propertyType.GetTypeInfo();
            var listElementTypes = ti
                .ImplementedInterfaces
                .Select(GetElementTypeIfIEnumerable)
                .Where(p => p != null)
                .ToList();
            if (listElementTypes.Count == 1)
            {
                return DataType.Collection(GetDataType(listElementTypes[0], propertyName));
            }

            throw new ArgumentException(
                $"Property {propertyName} has unsupported type {propertyType}",
                nameof(propertyType));
        }

        private static Type GetElementTypeIfIEnumerable(Type t) =>
            t.IsConstructedGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)
                ? t.GenericTypeArguments[0]
                : null;
    }
}
