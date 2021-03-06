// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Suppression based Action Rule
    /// </summary>
    /// <remarks>
    /// Action rule with suppression configuration
    /// </remarks>
    public partial class Suppression : ActionRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the Suppression class.
        /// </summary>
        public Suppression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Suppression class.
        /// </summary>
        /// <param name="suppressionConfig">suppression configuration for the
        /// action rule</param>
        /// <param name="scope">scope on which action rule will apply</param>
        /// <param name="conditions">conditions on which alerts will be
        /// filtered</param>
        /// <param name="description">Description of action rule</param>
        /// <param name="createdAt">Creation time of action rule. Date-Time in
        /// ISO-8601 format.</param>
        /// <param name="lastModifiedAt">Last updated time of action rule.
        /// Date-Time in ISO-8601 format.</param>
        /// <param name="createdBy">Created by user name.</param>
        /// <param name="lastModifiedBy">Last modified by user name.</param>
        /// <param name="status">Indicates if the given action rule is enabled
        /// or disabled. Possible values include: 'Enabled', 'Disabled'</param>
        public Suppression(SuppressionConfig suppressionConfig, Scope scope = default(Scope), Conditions conditions = default(Conditions), string description = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? lastModifiedAt = default(System.DateTime?), string createdBy = default(string), string lastModifiedBy = default(string), string status = default(string))
            : base(scope, conditions, description, createdAt, lastModifiedAt, createdBy, lastModifiedBy, status)
        {
            SuppressionConfig = suppressionConfig;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets suppression configuration for the action rule
        /// </summary>
        [JsonProperty(PropertyName = "suppressionConfig")]
        public SuppressionConfig SuppressionConfig { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SuppressionConfig == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SuppressionConfig");
            }
            if (SuppressionConfig != null)
            {
                SuppressionConfig.Validate();
            }
        }
    }
}
