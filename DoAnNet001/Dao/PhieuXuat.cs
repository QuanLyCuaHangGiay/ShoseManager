//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnNet001.Dao
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuXuat
    {
        public int MaPhieuXuat { get; set; }
        public Nullable<int> MaDonHang { get; set; }
        public Nullable<System.DateTime> NgayXuat { get; set; }
    
        public virtual DonHang DonHang { get; set; }
    }
}
