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
    internal class LopHoc : IObject
    {
        [DataName("ma_lop_hoc")]
        [DisplayName("Mã lớp học")]
        public int? MaLop { get; set; }

        [DataName("ma_ky_hoc")]
        [Required]
        [DisplayName("Mã kỳ học")]
        public byte? MaKyHoc { get; set; }

        [DataName("ma_mon_hoc")]
        [Required]
        [DisplayName("Mã môn học")]
        public int? MaMonHoc { get; set; }

        [DataName("ma_giang_vien")]
        [Required]
        [DisplayName("Mã giảng viên")]
        public int? MaGiangVien { get; set; }

        [DataName("da_xoa")]
        [Required]
        [DisplayName("Đã xóa")]
        public bool DaXoa { get; set; }
    }
}
