﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntiies
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using IronFramework.Utility.EntityFramewrok;

    /// <summary>
    /// EmployeePayHistoryDTO 
    /// </summary>
    [DataContract]
    public partial class EmployeePayHistoryDTO 
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public System.DateTime RateChangeDate { get; set; }
        [DataMember]
        public decimal Rate { get; set; }
        [DataMember]
        public byte PayFrequency { get; set; }
        [DataMember]
        public System.DateTime ModifiedDate { get; set; }
    }


   
}