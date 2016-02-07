﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Represents a reference to the assembly.
    /// </summary>
    public class AssemblyReference : ICloneable
    {
        /// <summary>
        /// Creates a new <see cref="AssemblyReference"/> that is a deep copy of the current instance.
        /// </summary>
        /// <returns>A new <see cref="AssemblyReference"/> that is a deep copy of the current instance.</returns>
        public object Clone()
        {
            var clone = new AssemblyReference();

            clone.AssemblyName = AssemblyName;

            if (Url != null)
                clone.Url = new Uri(Url.OriginalString);

            return clone;
        }

        /// <summary>
        /// Gets or sets assembly name.
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Gets or sets url.
        /// </summary>
        public Uri Url { get; set; }
    }
}
