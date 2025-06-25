using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks.Classes
{
    [DataContract]
    
    public enum Department
    {
        /// <summary>
        /// An enum for Departments
        /// Keep comboboxes/mentioning of departments in same order for structured work
        /// </summary>
        [EnumMember]
        Unassigned, //This is the users department on creation, will be able to be changed by the admin.
        [EnumMember]
        Human_Resources,
        [EnumMember]
        Marketing,
        [EnumMember]
        Sales,
        [EnumMember]
        Support,
        [EnumMember]
        Research_and_Development,
        [EnumMember]
        Admin
    }

}
