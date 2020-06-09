// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes a Virtual Machine. </summary>
    public partial class VM : Resource
    {
        /// <summary> Initializes a new instance of VM. </summary>
        public VM()
        {
        }

        /// <summary> Initializes a new instance of VM. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal VM(string id, string name, string type, string location, IDictionary<string, string> tags) : base(id, name, type, location, tags)
        {
        }
    }
}