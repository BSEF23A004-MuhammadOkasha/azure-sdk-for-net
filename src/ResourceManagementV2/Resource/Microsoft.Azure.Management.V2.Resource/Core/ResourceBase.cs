﻿using Microsoft.Azure.Management.V2.Resource.Core.ResourceActions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.Azure.Management.V2.Resource.Core
{
    /// <summary>
    ///  TODO: This class uses Reflection, it will be removed once we have a Resource that is shared across all services.
    /// </summary>
    /// <typeparam name="IFluentResourceT"></typeparam>
    /// <typeparam name="InnerResourceT"></typeparam>
    /// <typeparam name="FluentResourceT"></typeparam>
    public abstract class ResourceBase<IFluentResourceT, InnerResourceT, FluentResourceT> : CreatableUpdatable<IFluentResourceT, InnerResourceT, FluentResourceT>,
        IResource
        where IFluentResourceT : class
        where InnerResourceT : class     // TODO: This constraint will change to "where InnerResourceT : Resource" once we shared "Resource"
        where FluentResourceT : ResourceBase<IFluentResourceT, InnerResourceT, FluentResourceT>
    {
        protected ResourceBase(string key, InnerResourceT innerObject) : base(key, innerObject)
        {
            EnsureResource(innerObject);
            if (getValue("Tags") == null)
            {
                setValue("Tags", new Dictionary<string, string>());
            }

        }

        public string Id
        {
            get
            {
                return getStringValue("Id");

            }
        }

        public string Name
        {
            get
            {
                return getStringValue("Name");
            }
        }

        public string RegionName
        {
            get
            {
                return getStringValue("Location");
            }
        }

        public string Type
        {
            get
            {
                return getStringValue("Type");
            }
        }

        public IReadOnlyDictionary<string, string> Tags
        {
            get
            {
                Dictionary<string, string> tags = (Dictionary < string, string>)getValue("Tags");
                return tags;
            }
        }

        private void EnsureResource(InnerResourceT innerObject)
        {
            TypeInfo typeInfo = innerObject.GetType().GetTypeInfo();
            if (!HasProperty(innerObject, "Id"))
            {
                throw new ArgumentException(typeInfo.FullName + " is not a Resource");
            }

            if (!HasProperty(innerObject, "Location"))
            {
                throw new ArgumentException(typeInfo.FullName + " is not a Resource");
            }

            if (!HasProperty(innerObject, "Name"))
            {
                throw new ArgumentException(typeInfo.FullName + " is not a Resource");
            }

            if (!HasProperty(innerObject, "Tags"))
            {
                throw new ArgumentException(typeInfo.FullName + " is not a Resource");
            }

            if (!HasProperty(innerObject, "Type"))
            {
                throw new ArgumentException(typeInfo.FullName + " is not a Resource");
            }
        }

        private bool HasProperty(InnerResourceT innerObject, string propertyName)
        {
            TypeInfo typeInfo = innerObject.GetType().GetTypeInfo();
            return typeInfo.GetDeclaredProperty(propertyName) == null;
        }

        private string getStringValue(string propertyName)
        {
            return (string) getValue(propertyName);
        }

        private object getValue(string propertyName)
        {
            TypeInfo typeInfo = Inner.GetType().GetTypeInfo();
            PropertyInfo propInfo = typeInfo.GetDeclaredProperty(propertyName);
            return propInfo.GetValue(Inner);
        }

        private void setValue(string propertyName, object val)
        {
            TypeInfo typeInfo = Inner.GetType().GetTypeInfo();
            PropertyInfo propInfo = typeInfo.GetDeclaredProperty(propertyName);
            propInfo.SetValue(Inner, val);
        }
    }
}
