//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryProjectUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblIssueReturn
    {
        public int IssueReturnId { get; set; }
        public Nullable<int> BookId { get; set; }
        public string IssueDate { get; set; }
        public string ReturnDate { get; set; }
        public Nullable<int> CardId { get; set; }
        public string Status { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual tblBook tblBook { get; set; }
        public virtual tblCard tblCard { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
