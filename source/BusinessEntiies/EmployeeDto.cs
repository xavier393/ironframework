//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntiies
{
    using System;using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;using Newtonsoft.Json;
    using System.Collections.Generic;
    
    [DataContract()]
    public partial class EmployeeDto : UIPaging
    {
        [Key] 
        [Required] 
        [DataMember] 
        public int EmployeeID  {get; set; }
     
        [Required] 
        [DataMember] 
        public string NationalIDNumber  {get; set; }
     
        [Required] 
        [DataMember] 
        public int ContactID  {get; set; }
     
        [Required] 
        [DataMember] 
        public string LoginID  {get; set; }
        [DataMember] 
        public Nullable<int> ManagerID  {get; set; }
     
        [Required] 
        [DataMember] 
        public string Title  {get; set; }
     
        [Required] 
        [DataMember] 
        public System.DateTime BirthDate  {get; set; }
     
        [Required] 
        [DataMember] 
        public string MaritalStatus  {get; set; }
     
        [Required] 
        [DataMember] 
        public string Gender  {get; set; }
     
        [Required] 
        [DataMember] 
        public System.DateTime HireDate  {get; set; }
     
        [Required] 
        [DataMember] 
        public bool SalariedFlag  {get; set; }
     
        [Required] 
        [DataMember] 
        public short VacationHours  {get; set; }
     
        [Required] 
        [DataMember] 
        public short SickLeaveHours  {get; set; }
     
        [Required] 
        [DataMember] 
        public bool CurrentFlag  {get; set; }
     
        [Required] 
        [DataMember] 
        public System.Guid rowguid  {get; set; }
     
        [Required] 
        [DataMember] 
        public System.DateTime ModifiedDate  {get; set; }
    
        //[DataMember] 
        //[JsonProperty("Contact")]
        //public virtual Contact Contact { get; set; }
        //[DataMember] 
        //[JsonProperty("Employee1")]
        //public virtual EmployeeDto [] Employee1 { get; set; }
        //[DataMember] 
        //[JsonProperty("Employee2")]
        //public virtual Employee Employee2 { get; set; }
        [DataMember] 
        [JsonProperty("EmployeePayHistories")]
        public virtual EmployeePayHistoryDto [] EmployeePayHistories { get; set; }
    
         public override string ToString()
         {
             return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
         }
    }
}
