//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalGurtejSingh
{
    using System;
    using System.Collections.Generic;
    
    public partial class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public bool IsCapital { get; set; }
        public long Population { get; set; }
        public int CountryID { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
