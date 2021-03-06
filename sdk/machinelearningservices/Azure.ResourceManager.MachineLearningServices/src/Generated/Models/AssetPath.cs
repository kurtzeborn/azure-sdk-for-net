// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Details of an AssetUri. </summary>
    public partial class AssetPath
    {
        /// <summary> Initializes a new instance of AssetPath. </summary>
        /// <param name="path"> The path of file/directory. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public AssetPath(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            Path = path;
        }

        /// <summary> Initializes a new instance of AssetPath. </summary>
        /// <param name="path"> The path of file/directory. </param>
        /// <param name="isDirectory"> Whether the path defines a directory or a single file. </param>
        internal AssetPath(string path, bool? isDirectory)
        {
            Path = path;
            IsDirectory = isDirectory;
        }

        /// <summary> The path of file/directory. </summary>
        public string Path { get; set; }
        /// <summary> Whether the path defines a directory or a single file. </summary>
        public bool? IsDirectory { get; set; }
    }
}
