// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNet.Http.Features
{
    public interface IFeatureCollection : IEnumerable<KeyValuePair<Type, object>>
    {
        /// <summary>
        /// Indicates if the collection can be modified.
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Incremented for each modification and can be used verify cached results.
        /// </summary>
        int Revision { get; }

        /// <summary>
        /// Gets or sets a given feature. Setting a null value removes the feature.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The requested feature, or null if it is not present.</returns>
        object this[Type key] { get; set; }
    }
}
