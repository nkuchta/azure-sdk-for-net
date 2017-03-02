// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Identity for the virtual machine scale set.
    /// </summary>
    public partial class VirtualMachineScaleSetIdentity
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetIdentity
        /// class.
        /// </summary>
        public VirtualMachineScaleSetIdentity() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetIdentity
        /// class.
        /// </summary>
        /// <param name="principalId">The principal id of virtual machine scale
        /// set identity.</param>
        /// <param name="tenantId">The tenant id associated with the virtual
        /// machine scale set.</param>
        /// <param name="type">The identity type. Possible values include:
        /// 'SystemAssigned'</param>
        public VirtualMachineScaleSetIdentity(string principalId = default(string), string tenantId = default(string), ResourceIdentityType? type = default(ResourceIdentityType?))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary>
        /// Gets the principal id of virtual machine scale set identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; protected set; }

        /// <summary>
        /// Gets the tenant id associated with the virtual machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; protected set; }

        /// <summary>
        /// Gets or sets the identity type. Possible values include:
        /// 'SystemAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ResourceIdentityType? Type { get; set; }

    }
}
