// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> AmlCompute update parameters. </summary>
    public partial class ClusterUpdateParameters
    {
        /// <summary> Initializes a new instance of ClusterUpdateParameters. </summary>
        public ClusterUpdateParameters()
        {
        }

        /// <summary> Desired scale settings for the amlCompute. </summary>
        public ScaleSettings ScaleSettings { get; set; }
    }
}
