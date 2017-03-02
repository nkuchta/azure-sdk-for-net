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
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 schema reference.
    /// </summary>
    public partial class X12SchemaReference
    {
        /// <summary>
        /// Initializes a new instance of the X12SchemaReference class.
        /// </summary>
        public X12SchemaReference() { }

        /// <summary>
        /// Initializes a new instance of the X12SchemaReference class.
        /// </summary>
        /// <param name="messageId">The message id.</param>
        /// <param name="schemaVersion">The schema version.</param>
        /// <param name="schemaName">The schema name.</param>
        /// <param name="senderApplicationId">The sender application
        /// id.</param>
        public X12SchemaReference(string messageId, string schemaVersion, string schemaName, string senderApplicationId = default(string))
        {
            MessageId = messageId;
            SenderApplicationId = senderApplicationId;
            SchemaVersion = schemaVersion;
            SchemaName = schemaName;
        }

        /// <summary>
        /// Gets or sets the message id.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the sender application id.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationId")]
        public string SenderApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the schema version.
        /// </summary>
        [JsonProperty(PropertyName = "schemaVersion")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Gets or sets the schema name.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MessageId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageId");
            }
            if (SchemaVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchemaVersion");
            }
            if (SchemaName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchemaName");
            }
        }
    }
}

