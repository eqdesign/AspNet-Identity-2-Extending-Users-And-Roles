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
    
    public partial class WebLead
    {
        public WebLead()
        {
            this.Notes = new HashSet<Note>();
        }
    
        public int LeadID { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Veteran { get; set; }
        public string PublicEmployee { get; set; }
        public string Credit { get; set; }
        public string County { get; set; }
        public string PropAddress { get; set; }
        public string PropCity { get; set; }
        public string PropState { get; set; }
        public string Zip { get; set; }
        public string WhoIs { get; set; }
        public string Want { get; set; }
        public string LoanType { get; set; }
        public string LoanPurpose { get; set; }
        public string RefiPurpose { get; set; }
        public string PropType { get; set; }
        public string PropUse { get; set; }
        public string PropValue { get; set; }
        public string FoundHome { get; set; }
        public string EstPurchPrice { get; set; }
        public string WhenPurch { get; set; }
        public string DownPayment { get; set; }
        public string FirstHome { get; set; }
        public string FirstTDOrigBal { get; set; }
        public string FirstTDBalance { get; set; }
        public string FirstTDRate { get; set; }
        public string FirstTDTerm { get; set; }
        public string FirstTDTransMo { get; set; }
        public string FirstTDTransYr { get; set; }
        public string SecTD { get; set; }
        public string SecTDBalance { get; set; }
        public string SecTDRate { get; set; }
        public string CashOut { get; set; }
        public string LateTDPayments { get; set; }
        public string Foreclosure { get; set; }
        public string BK { get; set; }
        public string FHALoan { get; set; }
        public string AnnualIncome { get; set; }
        public string Employment { get; set; }
        public string MoDebt { get; set; }
        public string LoanAgent { get; set; }
        public string ReferredBy { get; set; }
        public bool OptIn { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> LeadDate { get; set; }
        public Nullable<System.DateTime> DispDate { get; set; }
        public Nullable<System.DateTime> FHACalcDate { get; set; }
        public string FormName { get; set; }
        public string LeadStatus { get; set; }
    
        public virtual ICollection<Note> Notes { get; set; }
    }
}
