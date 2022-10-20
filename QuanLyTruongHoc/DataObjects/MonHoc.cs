using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using QuanLyTruongHoc.Helpers.Attributes;

namespace QuanLyTruongHoc.DataObjects
{
    internal class MonHoc : IObject
    {
        [DataName("ma_mon_hoc")]
        [Required]
        [DisplayName("Mã môn học")]
        public int MaMonHoc { get; set; }

        [DataName("ten_mon_hoc")]
        [Required]
        [DisplayName("Tên môn học")]
        public string TenMonHoc { get; set; }

        [DataName("so_tinh_chi")]
        [Required]
        [DisplayName("Số tín chỉ")]
        public short SoTinhChi { get; set; }

        [DataName("da_xoa")]
        [Required]
        [DisplayName("Đã xóa")]
        public bool TinhTrang { get; set; }
    }
}
