//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoCar.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int EventId { get; set; }
        public int EventTypeCode { get; set; }
        public Nullable<int> RentId { get; set; }
        public int RateOfDiscount { get; set; }
        public System.DateTime Period { get; set; }
    
        public virtual Code Code { get; set; }
        public virtual Rent Rent { get; set; }
    }
}
