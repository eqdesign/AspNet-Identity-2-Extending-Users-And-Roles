//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanModule.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReferFriend
    {
        public int ReferID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string WhoIs { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PrequalType { get; set; }
        public string LoanAgent { get; set; }
        public string ReferFirst { get; set; }
        public string ReferLast { get; set; }
        public string ReferEmail { get; set; }
        public string ReferPhone { get; set; }
        public Nullable<System.DateTime> LeadDate { get; set; }
        public string OptIn { get; set; }
    }
}