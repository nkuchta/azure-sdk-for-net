// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Azure;
    using Management;
    using Sql;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a database.
    /// </summary>
    [JsonTransformation]
    public partial class Database : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        public Database() { }

        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource ID</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="kind">Kind of database.  This is metadata used for the
        /// Azure portal experience.</param>
        /// <param name="collation">The collation of the database. If
        /// createMode is not Default, this value is ignored.</param>
        /// <param name="creationDate">The creation date of the database
        /// (ISO8601 format).</param>
        /// <param name="containmentState">The containment state of the
        /// database.</param>
        /// <param name="currentServiceObjectiveId">The current service level
        /// objective ID of the database. This is the ID of the service level
        /// objective that is currently active.</param>
        /// <param name="databaseId">The ID of the database.</param>
        /// <param name="earliestRestoreDate">This records the earliest start
        /// date and time that restore is available for this database (ISO8601
        /// format).</param>
        /// <param name="createMode">Specifies the type of database to create.
        /// If createMode is not set to Default, sourceDatabaseId must be
        /// specified. If createMode is set to PointInTimeRestore, then
        /// restorePointInTime must be specified. If createMode is set to
        /// Restore, then sourceDatabaseDeletionDate must be specified.
        /// Possible values include: 'Copy', 'Default', 'NonReadableSecondary',
        /// 'OnlineSecondary', 'PointInTimeRestore', 'Recovery',
        /// 'Restore'</param>
        /// <param name="sourceDatabaseId">Conditional. If createMode is not
        /// set to Default, then this value must be specified. Specifies the
        /// resource ID of the source database. If createMode is
        /// NonReadableSecondary or OnlineSecondary, the name of the source
        /// database must be the same as this new database.</param>
        /// <param name="restorePointInTime">Conditional. If createMode is set
        /// to PointInTimeRestore, then this value must be specified. Specifies
        /// the point in time (ISO8601 format) of the source database that will
        /// be restored to create the new database. Must be greater than or
        /// equal to the source database's earliestRestoreDate value.</param>
        /// <param name="edition">The edition of the database. The
        /// DatabaseEditions enumeration contains all the valid editions. If
        /// createMode is NonReadableSecondary or OnlineSecondary, this value
        /// is ignored. Possible values include: 'Web', 'Business', 'Basic',
        /// 'Standard', 'Premium', 'Free', 'Stretch', 'DataWarehouse',
        /// 'System'</param>
        /// <param name="maxSizeBytes">The max size of the database expressed
        /// in bytes. If createMode is not Default, this value is ignored.
        /// Note: Only the following sizes are supported (in addition to
        /// limitations being placed on each edition): { 100 MB | 500 MB |1 GB
        /// | 5 GB | 10 GB | 20 GB | 30 GB … 150 GB | 200 GB … 500 GB }</param>
        /// <param name="requestedServiceObjectiveId">The configured service
        /// level objective ID of the database. This is the service level
        /// objective that is in the process of being applied to the database.
        /// Once successfully updated, it will match the value of
        /// currentServiceObjectiveId property. If requestedServiceObjectiveId
        /// and requestedServiceObjectiveName are both updated, the value of
        /// requestedServiceObjectiveId overrides the value of
        /// requestedServiceObjectiveName.</param>
        /// <param name="requestedServiceObjectiveName">The name of the
        /// configured service level objective of the database. This is the
        /// service level objective that is in the process of being applied to
        /// the database. Once successfully updated, it will match the value of
        /// serviceLevelObjective property. Possible values include: 'Basic',
        /// 'S0', 'S1', 'S2', 'S3', 'P1', 'P2', 'P3', 'P4', 'P6', 'P11', 'P15',
        /// 'System', 'ElasticPool'</param>
        /// <param name="serviceLevelObjective">The current service level
        /// objective of the database. Possible values include: 'Basic', 'S0',
        /// 'S1', 'S2', 'S3', 'P1', 'P2', 'P3', 'P4', 'P6', 'P11', 'P15',
        /// 'System', 'ElasticPool'</param>
        /// <param name="status">The status of the database.</param>
        /// <param name="elasticPoolName">The name of the elastic pool the
        /// database is in. If elasticPoolName and
        /// requestedServiceObjectiveName are both updated, the value of
        /// requestedServiceObjectiveName is ignored.</param>
        /// <param name="defaultSecondaryLocation">The default secondary region
        /// for this database.</param>
        /// <param name="serviceTierAdvisors">The list of service tier advisors
        /// for this database. Expanded property</param>
        /// <param name="schemas">The schemas from this database.</param>
        /// <param name="transparentDataEncryption">The transparent data
        /// encryption info for this database.</param>
        /// <param name="recommendedIndex">The recommended indices for this
        /// database.</param>
        /// <param name="failoverGroupId">The id indicating the failover group
        /// containing this database.</param>
        /// <param name="readScale">Conditional.  If the database is a
        /// geo-secondary, readScale indicates whether read-only connections
        /// are allowed to this database or not. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="sampleName">Indicates the name of the sample schema to
        /// apply when creating this database. If createMode is not Default,
        /// this value is ignored. Possible values include:
        /// 'AdventureWorksLT'</param>
        public Database(string location, string name = default(string), string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), string collation = default(string), System.DateTime? creationDate = default(System.DateTime?), long? containmentState = default(long?), System.Guid? currentServiceObjectiveId = default(System.Guid?), string databaseId = default(string), System.DateTime? earliestRestoreDate = default(System.DateTime?), string createMode = default(string), string sourceDatabaseId = default(string), System.DateTime? restorePointInTime = default(System.DateTime?), string edition = default(string), string maxSizeBytes = default(string), System.Guid? requestedServiceObjectiveId = default(System.Guid?), string requestedServiceObjectiveName = default(string), string serviceLevelObjective = default(string), string status = default(string), string elasticPoolName = default(string), string defaultSecondaryLocation = default(string), IList<ServiceTierAdvisor> serviceTierAdvisors = default(IList<ServiceTierAdvisor>), IList<Schema> schemas = default(IList<Schema>), IList<TransparentDataEncryption> transparentDataEncryption = default(IList<TransparentDataEncryption>), IList<RecommendedIndex> recommendedIndex = default(IList<RecommendedIndex>), System.Guid? failoverGroupId = default(System.Guid?), ReadScale? readScale = default(ReadScale?), string sampleName = default(string))
            : base(location, name, id, type, tags)
        {
            Kind = kind;
            Collation = collation;
            CreationDate = creationDate;
            ContainmentState = containmentState;
            CurrentServiceObjectiveId = currentServiceObjectiveId;
            DatabaseId = databaseId;
            EarliestRestoreDate = earliestRestoreDate;
            CreateMode = createMode;
            SourceDatabaseId = sourceDatabaseId;
            RestorePointInTime = restorePointInTime;
            Edition = edition;
            MaxSizeBytes = maxSizeBytes;
            RequestedServiceObjectiveId = requestedServiceObjectiveId;
            RequestedServiceObjectiveName = requestedServiceObjectiveName;
            ServiceLevelObjective = serviceLevelObjective;
            Status = status;
            ElasticPoolName = elasticPoolName;
            DefaultSecondaryLocation = defaultSecondaryLocation;
            ServiceTierAdvisors = serviceTierAdvisors;
            Schemas = schemas;
            TransparentDataEncryption = transparentDataEncryption;
            RecommendedIndex = recommendedIndex;
            FailoverGroupId = failoverGroupId;
            ReadScale = readScale;
            SampleName = sampleName;
        }

        /// <summary>
        /// Gets kind of database.  This is metadata used for the Azure portal
        /// experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; protected set; }

        /// <summary>
        /// Gets or sets the collation of the database. If createMode is not
        /// Default, this value is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets the creation date of the database (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; protected set; }

        /// <summary>
        /// Gets the containment state of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containmentState")]
        public long? ContainmentState { get; protected set; }

        /// <summary>
        /// Gets the current service level objective ID of the database. This
        /// is the ID of the service level objective that is currently active.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentServiceObjectiveId")]
        public System.Guid? CurrentServiceObjectiveId { get; protected set; }

        /// <summary>
        /// Gets the ID of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseId")]
        public string DatabaseId { get; protected set; }

        /// <summary>
        /// Gets this records the earliest start date and time that restore is
        /// available for this database (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.earliestRestoreDate")]
        public System.DateTime? EarliestRestoreDate { get; protected set; }

        /// <summary>
        /// Gets or sets specifies the type of database to create. If
        /// createMode is not set to Default, sourceDatabaseId must be
        /// specified. If createMode is set to PointInTimeRestore, then
        /// restorePointInTime must be specified. If createMode is set to
        /// Restore, then sourceDatabaseDeletionDate must be specified.
        /// Possible values include: 'Copy', 'Default', 'NonReadableSecondary',
        /// 'OnlineSecondary', 'PointInTimeRestore', 'Recovery', 'Restore'
        /// </summary>
        [JsonProperty(PropertyName = "properties.createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets or sets conditional. If createMode is not set to Default, then
        /// this value must be specified. Specifies the resource ID of the
        /// source database. If createMode is NonReadableSecondary or
        /// OnlineSecondary, the name of the source database must be the same
        /// as this new database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceDatabaseId")]
        public string SourceDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets conditional. If createMode is set to
        /// PointInTimeRestore, then this value must be specified. Specifies
        /// the point in time (ISO8601 format) of the source database that will
        /// be restored to create the new database. Must be greater than or
        /// equal to the source database's earliestRestoreDate value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointInTime")]
        public System.DateTime? RestorePointInTime { get; set; }

        /// <summary>
        /// Gets or sets the edition of the database. The DatabaseEditions
        /// enumeration contains all the valid editions. If createMode is
        /// NonReadableSecondary or OnlineSecondary, this value is ignored.
        /// Possible values include: 'Web', 'Business', 'Basic', 'Standard',
        /// 'Premium', 'Free', 'Stretch', 'DataWarehouse', 'System'
        /// </summary>
        [JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the max size of the database expressed in bytes. If
        /// createMode is not Default, this value is ignored. Note: Only the
        /// following sizes are supported (in addition to limitations being
        /// placed on each edition): { 100 MB | 500 MB |1 GB | 5 GB | 10 GB |
        /// 20 GB | 30 GB … 150 GB | 200 GB … 500 GB }
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public string MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets the configured service level objective ID of the
        /// database. This is the service level objective that is in the
        /// process of being applied to the database. Once successfully
        /// updated, it will match the value of currentServiceObjectiveId
        /// property. If requestedServiceObjectiveId and
        /// requestedServiceObjectiveName are both updated, the value of
        /// requestedServiceObjectiveId overrides the value of
        /// requestedServiceObjectiveName.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedServiceObjectiveId")]
        public System.Guid? RequestedServiceObjectiveId { get; set; }

        /// <summary>
        /// Gets or sets the name of the configured service level objective of
        /// the database. This is the service level objective that is in the
        /// process of being applied to the database. Once successfully
        /// updated, it will match the value of serviceLevelObjective property.
        /// Possible values include: 'Basic', 'S0', 'S1', 'S2', 'S3', 'P1',
        /// 'P2', 'P3', 'P4', 'P6', 'P11', 'P15', 'System', 'ElasticPool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedServiceObjectiveName")]
        public string RequestedServiceObjectiveName { get; set; }

        /// <summary>
        /// Gets the current service level objective of the database. Possible
        /// values include: 'Basic', 'S0', 'S1', 'S2', 'S3', 'P1', 'P2', 'P3',
        /// 'P4', 'P6', 'P11', 'P15', 'System', 'ElasticPool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceLevelObjective")]
        public string ServiceLevelObjective { get; protected set; }

        /// <summary>
        /// Gets the status of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; protected set; }

        /// <summary>
        /// Gets or sets the name of the elastic pool the database is in. If
        /// elasticPoolName and requestedServiceObjectiveName are both updated,
        /// the value of requestedServiceObjectiveName is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.elasticPoolName")]
        public string ElasticPoolName { get; set; }

        /// <summary>
        /// Gets the default secondary region for this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultSecondaryLocation")]
        public string DefaultSecondaryLocation { get; protected set; }

        /// <summary>
        /// Gets the list of service tier advisors for this database. Expanded
        /// property
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceTierAdvisors")]
        public IList<ServiceTierAdvisor> ServiceTierAdvisors { get; protected set; }

        /// <summary>
        /// Gets the schemas from this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.schemas")]
        public IList<Schema> Schemas { get; protected set; }

        /// <summary>
        /// Gets the transparent data encryption info for this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.transparentDataEncryption")]
        public IList<TransparentDataEncryption> TransparentDataEncryption { get; protected set; }

        /// <summary>
        /// Gets the recommended indices for this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendedIndex")]
        public IList<RecommendedIndex> RecommendedIndex { get; protected set; }

        /// <summary>
        /// Gets the id indicating the failover group containing this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failoverGroupId")]
        public System.Guid? FailoverGroupId { get; protected set; }

        /// <summary>
        /// Gets or sets conditional.  If the database is a geo-secondary,
        /// readScale indicates whether read-only connections are allowed to
        /// this database or not. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.readScale")]
        public ReadScale? ReadScale { get; set; }

        /// <summary>
        /// Gets or sets indicates the name of the sample schema to apply when
        /// creating this database. If createMode is not Default, this value is
        /// ignored. Possible values include: 'AdventureWorksLT'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sampleName")]
        public string SampleName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Schemas != null)
            {
                foreach (var element in Schemas)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (RecommendedIndex != null)
            {
                foreach (var element1 in RecommendedIndex)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}

