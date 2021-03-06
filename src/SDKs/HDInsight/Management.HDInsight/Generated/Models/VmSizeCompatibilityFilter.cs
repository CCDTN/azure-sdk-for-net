// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The virtual machine type compatibility filter.
    /// </summary>
    public partial class VmSizeCompatibilityFilter
    {
        /// <summary>
        /// Initializes a new instance of the VmSizeCompatibilityFilter class.
        /// </summary>
        public VmSizeCompatibilityFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VmSizeCompatibilityFilter class.
        /// </summary>
        /// <param name="filterMode">The mode for the filter.</param>
        /// <param name="regions">The list of regions.</param>
        /// <param name="clusterFlavors">The list of cluster types
        /// available.</param>
        /// <param name="nodeTypes">The list of node types.</param>
        /// <param name="clusterVersions">The list of cluster versions.</param>
        /// <param name="vmsizes">The list of virtual machine sizes.</param>
        public VmSizeCompatibilityFilter(string filterMode = default(string), IList<string> regions = default(IList<string>), IList<string> clusterFlavors = default(IList<string>), IList<string> nodeTypes = default(IList<string>), IList<string> clusterVersions = default(IList<string>), IList<string> vmsizes = default(IList<string>))
        {
            FilterMode = filterMode;
            Regions = regions;
            ClusterFlavors = clusterFlavors;
            NodeTypes = nodeTypes;
            ClusterVersions = clusterVersions;
            Vmsizes = vmsizes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mode for the filter.
        /// </summary>
        [JsonProperty(PropertyName = "FilterMode")]
        public string FilterMode { get; set; }

        /// <summary>
        /// Gets or sets the list of regions.
        /// </summary>
        [JsonProperty(PropertyName = "Regions")]
        public IList<string> Regions { get; set; }

        /// <summary>
        /// Gets or sets the list of cluster types available.
        /// </summary>
        [JsonProperty(PropertyName = "ClusterFlavors")]
        public IList<string> ClusterFlavors { get; set; }

        /// <summary>
        /// Gets or sets the list of node types.
        /// </summary>
        [JsonProperty(PropertyName = "NodeTypes")]
        public IList<string> NodeTypes { get; set; }

        /// <summary>
        /// Gets or sets the list of cluster versions.
        /// </summary>
        [JsonProperty(PropertyName = "ClusterVersions")]
        public IList<string> ClusterVersions { get; set; }

        /// <summary>
        /// Gets or sets the list of virtual machine sizes.
        /// </summary>
        [JsonProperty(PropertyName = "vmsizes")]
        public IList<string> Vmsizes { get; set; }

    }
}
