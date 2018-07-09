// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A null or empty node selector term matches no objects. The requirements
    /// of them are ANDed. The TopologySelectorTerm type implements a subset of
    /// the NodeSelectorTerm.
    /// </summary>
    public partial class V1NodeSelectorTerm
    {
        /// <summary>
        /// Initializes a new instance of the V1NodeSelectorTerm class.
        /// </summary>
        public V1NodeSelectorTerm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NodeSelectorTerm class.
        /// </summary>
        /// <param name="matchExpressions">A list of node selector requirements
        /// by node's labels.</param>
        /// <param name="matchFields">A list of node selector requirements by
        /// node's fields.</param>
        public V1NodeSelectorTerm(IList<V1NodeSelectorRequirement> matchExpressions = default(IList<V1NodeSelectorRequirement>), IList<V1NodeSelectorRequirement> matchFields = default(IList<V1NodeSelectorRequirement>))
        {
            MatchExpressions = matchExpressions;
            MatchFields = matchFields;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of node selector requirements by node's labels.
        /// </summary>
        [JsonProperty(PropertyName = "matchExpressions")]
        public IList<V1NodeSelectorRequirement> MatchExpressions { get; set; }

        /// <summary>
        /// Gets or sets a list of node selector requirements by node's fields.
        /// </summary>
        [JsonProperty(PropertyName = "matchFields")]
        public IList<V1NodeSelectorRequirement> MatchFields { get; set; }

    }
}