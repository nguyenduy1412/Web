//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class favourite_item
    {
        public int id { get; set; }
        public Nullable<int> book_id { get; set; }
        public Nullable<int> favourite_id { get; set; }
    
        public virtual book book { get; set; }
        public virtual favourite favourite { get; set; }
    }
}
