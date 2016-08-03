﻿using System;
using System.Threading.Tasks;
using Microsoft.Azure.Management.V2.Resource.Core.DAG;
using System.Threading;

namespace Microsoft.Azure.Management.V2.Resource.Core.ResourceActions
{
    /// <summary>
    /// The base class for all creatable resource.
    /// </summary>
    /// <typeparam name="IFluentResourceT">The fluent model type representing the creatable resource</typeparam>
    /// <typeparam name="InnerResourceT">The model inner type that the fluent model type wraps</typeparam>
    /// <typeparam name="FluentResourceT">The fluent model implementation type</typeparam>
    /// <typeparam name="IResourceT">The fluent resourced or one of the base interface from which inherits</typeparam>
    public abstract class Creatable<IFluentResourceT, InnerResourceT, FluentResourceT, IResourceT> :
        IndexableRefreshableWrapper<IFluentResourceT, InnerResourceT>,
        IResourceCreator<IResourceT>
        where FluentResourceT : class
        where IFluentResourceT : class, IResourceT
        where IResourceT : class
    {
        protected Creatable(string name, InnerResourceT innerObject) : base(name, innerObject)
        {
            IResourceCreator<IResourceT> creator =this as IResourceCreator<IResourceT>;
            CreatorTaskGroup = new CreatorTaskGroup<IResourceT>(name, creator);
        }

        protected void AddCreatableDependency(IResourceCreator<IResourceT> creatableResource)
        {
            creatableResource.CreatorTaskGroup.Merge(CreatorTaskGroup);
        }

        public IResourceT Create()
        {
            return CreateAsync(CancellationToken.None).Result;
        }

        public Task<IResourceT> CreateAsync(CancellationToken cancellationToken, bool multiThreaded = true)
        {
            TaskCompletionSource<IResourceT> taskCompletionSource = new TaskCompletionSource<IResourceT>();
            if (CreatorTaskGroup.IsPreparer)
            {
                CreatorTaskGroup.Prepare();
                CreatorTaskGroup.ExecuteAsync(cancellationToken, multiThreaded).ContinueWith(task =>
                {
                    if (task.Exception != null)
                    {
                        taskCompletionSource.SetException(task.Exception.InnerExceptions);
                    }
                    else
                    {
                        IResourceT thisResource = this as IResourceT;
                        if (thisResource == null)
                        {
                            taskCompletionSource.SetException(new InvalidOperationException("Interal Error: Expected 'of type' '" + typeof(IFluentResourceT) + "', but got '" + this.GetType().Namespace + "'"));
                        }
                        else
                        {
                            taskCompletionSource.SetResult(thisResource);
                        }
                    }
                });
            }
            else
            {
                taskCompletionSource.SetException(new InvalidOperationException("Interal Error: Creatable::CreateAsync can be invoked only on preparer"));
            }
            return taskCompletionSource.Task;
        }


        protected IResourceT CreatedResource(string key)
        {
            return CreatorTaskGroup.TaskResult(key);
        }

        #region Implementation of IResourceCreator

        public CreatorTaskGroup<IResourceT> CreatorTaskGroup { get; private set; }

        public abstract Task<IResourceT> CreateResourceAsync(CancellationToken cancellationToken);

        public abstract IResourceT CreateResource();

        #endregion
    }

    public interface IResourceCreator<IResourceT>
    {
        Task<IResourceT> CreateResourceAsync(CancellationToken cancellationToken);
        IResourceT CreateResource();
        CreatorTaskGroup<IResourceT> CreatorTaskGroup { get; }
    }
}
