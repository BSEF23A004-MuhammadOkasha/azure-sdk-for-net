﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.DigitalTwins.Core.QueryBuilder;

namespace Azure.DigitalTwins.Core.Queries.QueryBuilders
{
    /// <summary>
    ///
    /// </summary>
    public class AdtQueryBuilder
    {
        private readonly SelectQuery _selectQuery;
        private readonly FromQuery _fromQuery;
        private readonly WhereQuery _whereQuery;

        /// <summary>
        ///
        /// </summary>
        public AdtQueryBuilder()
        {
            _whereQuery = new WhereQuery(this);
            _fromQuery = new FromQuery(this, _whereQuery);
            _selectQuery = new SelectQuery(this, _fromQuery);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public FromQuery Select(params string[] args)
        {
            return _selectQuery.Select(args);
        }

        /// <summary>
        /// Used when applying the TOP() aggregate from the ADT query language. Same functionality as select
        /// but inserts TOP() into the query structure as well.
        /// </summary>
        /// <param name="count"> The argument for TOP(), i.e the number of instances to return. </param>
        /// <returns> Query that contains a select clause. </returns>
        public FromQuery SelectTop(int count)
        {
            return _selectQuery.SelectTop(count);
        }

        /// <summary>
        /// Used when applying the COUNT() aggregate from the ADT query language. Similar to SelectTop().
        /// </summary>
        /// <param name="args"> The arguments that we define what we select (eg. a property name, *, collection). </param>
        /// <returns> Query that contains a select clause. </returns>
        public FromQuery SelectCount(params string[] args)
        {
            return _selectQuery.SelectCount(args);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
