using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks.Classes
{
    [DataContract]
    public enum TaskStatus
    {
        /// <summary>
        /// An enum for storing the status of a task.
        /// On creation the value of all tasks is Open, and can only be changed when accessing a task from the taskdashboard -> btnChangeSelectedTask_Click event
        /// Only if the file has Open as it's status, will it be able to be changed.
        /// </summary>
        [EnumMember]
        Open,
        [EnumMember]
        In_Progress,
        [EnumMember]
        Completed,
        [EnumMember]
        Blocked,
        [EnumMember]
        Cancelled
    }
}
