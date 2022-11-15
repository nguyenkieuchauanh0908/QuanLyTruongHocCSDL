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
    public class Diem : IObject 
    {
        [Helpers.Attributes.DataName("ma_lop_hoc")]
        [DisplayName("Mã lớp học")]
        [Required]
        public int? maLop { get; set; }

        [DataName("ma_sinh_vien")]
        [DisplayName("Mã sinh viên")]
        [Required]
        public int? maSV { get; set; }

        [DataName("diem_giua_ky")]
        [DisplayName("Điểm giữa kỳ")]
        [Required]
        public double? diem_giua_ky { get; set; }

        [DataName("diem_cuoi_ky")]
        [DisplayName("Điểm cuối kỳ")]
        [Required]
        public double? diem_cuoi_ky { get; set; }


        public override string ToString()
        {
            return $"SV có mã số {maSV} o ma lop {maLop} co diem giua ky la {diem_giua_ky}, diem cuoi ky la {diem_cuoi_ky}";
        }
    }
}
