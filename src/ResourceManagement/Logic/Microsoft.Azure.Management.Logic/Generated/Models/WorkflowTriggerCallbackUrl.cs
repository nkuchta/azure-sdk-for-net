// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow trigger callback URL.
    /// </summary>
    public partial class WorkflowTriggerCallbackUrl
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerCallbackUrl class.
        /// </summary>
        public WorkflowTriggerCallbackUrl() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerCallbackUrl class.
        /// </summary>
        /// <param name="value">Gets the workflow trigger callback URL.</param>
        public WorkflowTriggerCallbackUrl(string value = default(string))
        {
            Value = value;
        }

        /// <summary>
        /// Gets the workflow trigger callback URL.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; protected set; }

    }
}

