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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.CTSanPhams = new HashSet<CTSanPham>();
        }
    
        public Nullable<int> MaLoai { get; set; }
        public int MaSp { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTSanPham> CTSanPhams { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
