//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies characteristics for a temporary 'auto pool'. The Batch service will create this auto pool, run all the 
    /// tasks for the job on it, and by default delete the pool once the job has completed.
    /// </summary>
    public partial class AutoPoolSpecification : ITransportObjectProvider<Models.AutoPoolSpecification>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> AutoPoolIdPrefixProperty;
            public readonly PropertyAccessor<bool?> KeepAliveProperty;
            public readonly PropertyAccessor<Common.PoolLifetimeOption> PoolLifetimeOptionProperty;
            public readonly PropertyAccessor<PoolSpecification> PoolSpecificationProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AutoPoolIdPrefixProperty = this.CreatePropertyAccessor<string>("AutoPoolIdPrefix", BindingAccess.Read | BindingAccess.Write);
                this.KeepAliveProperty = this.CreatePropertyAccessor<bool?>("KeepAlive", BindingAccess.Read | BindingAccess.Write);
                this.PoolLifetimeOptionProperty = this.CreatePropertyAccessor<Common.PoolLifetimeOption>("PoolLifetimeOption", BindingAccess.Read | BindingAccess.Write);
                this.PoolSpecificationProperty = this.CreatePropertyAccessor<PoolSpecification>("PoolSpecification", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.AutoPoolSpecification protocolObject) : base(BindingState.Bound)
            {
                this.AutoPoolIdPrefixProperty = this.CreatePropertyAccessor(
                    protocolObject.AutoPoolIdPrefix,
                    "AutoPoolIdPrefix",
                    BindingAccess.Read | BindingAccess.Write);
                this.KeepAliveProperty = this.CreatePropertyAccessor(
                    protocolObject.KeepAlive,
                    "KeepAlive",
                    BindingAccess.Read | BindingAccess.Write);
                this.PoolLifetimeOptionProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapEnum<Models.PoolLifetimeOption, Common.PoolLifetimeOption>(protocolObject.PoolLifetimeOption),
                    "PoolLifetimeOption",
                    BindingAccess.Read | BindingAccess.Write);
                this.PoolSpecificationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Pool, o => new PoolSpecification(o)),
                    "PoolSpecification",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoPoolSpecification"/> class.
        /// </summary>
        public AutoPoolSpecification()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal AutoPoolSpecification(Models.AutoPoolSpecification protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region AutoPoolSpecification

        /// <summary>
        /// Gets or sets a prefix to be added to the unique identifier when a pool is automatically created.
        /// </summary>
        /// <remarks>
        /// The prefix is optional. If present, it can be up to 20 characters long and must adhere to the usual rules for 
        /// ids (alphanumeric characters, hyphens and underscores only).
        /// </remarks>
        public string AutoPoolIdPrefix
        {
            get { return this.propertyContainer.AutoPoolIdPrefixProperty.Value; }
            set { this.propertyContainer.AutoPoolIdPrefixProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether to keep the auto pool alive after its <see cref="PoolLifetimeOption"/> expires.
        /// </summary>
        /// <remarks>
        /// The default value is false.
        /// </remarks>
        public bool? KeepAlive
        {
            get { return this.propertyContainer.KeepAliveProperty.Value; }
            set { this.propertyContainer.KeepAliveProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the minimum lifetime of created auto pools, and how multiple jobs on a schedule are assigned to 
        /// pools.
        /// </summary>
        /// <remarks>
        /// An auto pool may live longer than its PoolLifetimeOption if <see cref="KeepAlive"/> is set.
        /// </remarks>
        public Common.PoolLifetimeOption PoolLifetimeOption
        {
            get { return this.propertyContainer.PoolLifetimeOptionProperty.Value; }
            set { this.propertyContainer.PoolLifetimeOptionProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the pool specification for the auto pool.
        /// </summary>
        public PoolSpecification PoolSpecification
        {
            get { return this.propertyContainer.PoolSpecificationProperty.Value; }
            set { this.propertyContainer.PoolSpecificationProperty.Value = value; }
        }

        #endregion // AutoPoolSpecification

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.AutoPoolSpecification ITransportObjectProvider<Models.AutoPoolSpecification>.GetTransportObject()
        {
            Models.AutoPoolSpecification result = new Models.AutoPoolSpecification()
            {
                AutoPoolIdPrefix = this.AutoPoolIdPrefix,
                KeepAlive = this.KeepAlive,
                PoolLifetimeOption = UtilitiesInternal.MapEnum<Common.PoolLifetimeOption, Models.PoolLifetimeOption>(this.PoolLifetimeOption),
                Pool = UtilitiesInternal.CreateObjectWithNullCheck(this.PoolSpecification, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}