//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RR_System_MP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seat_available
    {
        public int serial_num { get; set; }
        public decimal Train_Id { get; set; }
        public decimal C1AC { get; set; }
        public decimal C2AC { get; set; }
        public decimal SL { get; set; }
    
        public virtual Traindetail Traindetail { get; set; }
    }
}