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
    internal class ThongTinLopHoc : IObject
    {
        [Helpers.Attributes.DataName("ma_lop_hoc")]
        [DisplayName("Mã lớp học")]
        [Required]
        public int maLop { get; set; }

        [Helpers.Attributes.DataName("ma_mon_hoc")]
        [DisplayName("Mã môn học")]
        [Required]
        public int maMon { get; set; }

        [Helpers.Attributes.DataName("ten_mon_hoc")]
        [DisplayName("Tên môn học")]
        [Required]
        public string tenMon { get; set; }

        [Helpers.Attributes.DataName("nam_hoc")]
        [DisplayName("Năm học")]
        [Required]
        public int namHoc { get; set; }

        [Helpers.Attributes.DataName("ky_hoc")]
        [DisplayName("Kỳ học")]
        [Required]
        public int kyHoc { get; set; }
    }
}
