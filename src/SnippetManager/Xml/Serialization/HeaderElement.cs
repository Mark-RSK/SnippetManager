﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Pihrtsoft.Snippets.Xml.Serialization
{
    /// <summary>
    /// Represents Header element in a serialized <see cref="Snippet"/>. This class cannot be inherited.
    /// </summary>
    public sealed class HeaderElement
    {
        /// <summary>
        /// Gets or sets Title element value.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Shortcut element value.
        /// </summary>
        public string Shortcut { get; set; }

        /// <summary>
        /// Gets or sets Description element value.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Author element values.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets HelpUrl element value.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public string HelpUrl { get; set; }

        /// <summary>
        /// Gets or sets SnippetTypes element.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [XmlArrayItem("SnippetType")]
        public string[] SnippetTypes { get; set; }

        /// <summary>
        /// Gets or sets Keywords element.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [XmlArrayItem("Keyword")]
        public string[] Keywords { get; set; }
    }
}
