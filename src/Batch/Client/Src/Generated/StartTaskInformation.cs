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
    /// Specifies the detailed runtime information of the start task, including current state, error details, exit code, 
    /// start time, end time, etc.
    /// </summary>
    public partial class StartTaskInformation : IPropertyMetadata
    {
        private readonly DateTime? endTime;
        private readonly int? exitCode;
        private readonly DateTime? lastRetryTime;
        private readonly int retryCount;
        private readonly TaskSchedulingError schedulingError;
        private readonly DateTime startTime;
        private readonly Common.StartTaskState state;

        #region Constructors

        internal StartTaskInformation(Models.StartTaskInformation protocolObject)
        {
            this.endTime = protocolObject.EndTime;
            this.exitCode = protocolObject.ExitCode;
            this.lastRetryTime = protocolObject.LastRetryTime;
            this.retryCount = protocolObject.RetryCount;
            this.schedulingError = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.SchedulingError, o => new TaskSchedulingError(o).Freeze());
            this.startTime = protocolObject.StartTime;
            this.state = UtilitiesInternal.MapEnum<Models.StartTaskState, Common.StartTaskState>(protocolObject.State);
        }

        #endregion Constructors

        #region StartTaskInformation

        /// <summary>
        /// Gets the time at which the task completed.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.endTime; }
        }

        /// <summary>
        /// Gets the exit code of the task.
        /// </summary>
        public int? ExitCode
        {
            get { return this.exitCode; }
        }

        /// <summary>
        /// Gets the most recent time at which execution of the start task was retried by the Batch service.
        /// </summary>
        public DateTime? LastRetryTime
        {
            get { return this.lastRetryTime; }
        }

        /// <summary>
        /// Gets the number of times the start task has been retried by the Batch system.
        /// </summary>
        public int RetryCount
        {
            get { return this.retryCount; }
        }

        /// <summary>
        /// Gets the error encountered by the service when scheduling the task.
        /// </summary>
        public TaskSchedulingError SchedulingError
        {
            get { return this.schedulingError; }
        }

        /// <summary>
        /// Gets the time at which the task started running.
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime; }
        }

        /// <summary>
        /// Gets the current running state of the start task.
        /// </summary>
        public Common.StartTaskState State
        {
            get { return this.state; }
        }

        #endregion // StartTaskInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}