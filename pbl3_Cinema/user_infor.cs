//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pbl3_Cinema
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_infor
    {
        public string email_id { get; set; }
        public string full_name { get; set; }
        public string gender { get; set; }
        public string phone_number { get; set; }
        public Nullable<System.DateTime> day_of_birth { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual staff staff { get; set; }
    }
}
