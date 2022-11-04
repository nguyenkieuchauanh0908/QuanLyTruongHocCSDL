using QuanLyTruongHoc.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.DataObjects
{
    internal class DanhSachLop : IObject
    {
        [Helpers.Attributes.DataName("ma_sinh_vien")]
        [DisplayName("Mã sinh viên")]
        [Required]
        public int maSV { get; set; }

        [Helpers.Attributes.DataName("ho")]
        [DisplayName("Họ")]
        [Required]
        public string Ho { get; set; }

        [Helpers.Attributes.DataName("ten")]
        [DisplayName("Tên")]
        [Required]
        public string Ten { get; set; }

        [Helpers.Attributes.DataName("diem_giua_ky")]
        [DisplayName("Điểm giữa kỳ")]
        [Required]
        public double diemGK { get; set; }

        [Helpers.Attributes.DataName("diem_cuoi_ky")]
        [DisplayName("Điểm cuối kỳ")]
        [Required]
        public double diemCK { get; set; }

        [Helpers.Attributes.DataName("ma_lop_hoc")]
        [DisplayName("Mã lớp")]
        [Required]
        public int maLop { get; set; }
    }
}
