//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnOOP_QuanLyKho.Model
{
    using DoAnOOP_QuanLyKho.ViewModel;
    using System;
    using System.Collections.Generic;

    public partial class PhieuNhap : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhap()
        {
            this.ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
        }

        public int MaPN { get; set; }
        public int MaNV { get; set; }

        private System.DateTime _NgayNhap;
        public System.DateTime NgayNhap { get => _NgayNhap; set { _NgayNhap = value; OnPropertyChanged(); } }
        public int MaNCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        private NhaCungCap _NhaCungCap;
        public virtual NhaCungCap NhaCungCap { get => _NhaCungCap; set { _NhaCungCap = value; OnPropertyChanged(); } }

        private NhanVien _NhanVien;
        public virtual NhanVien NhanVien { get => _NhanVien; set { _NhanVien = value; OnPropertyChanged(); } }
    }
}
