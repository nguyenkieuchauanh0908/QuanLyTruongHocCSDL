using QuanLyTruongHoc.Helpers.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTruongHoc.DataObjects
{
    internal class SinhVien : IObject
    {
        [DataName("id")]
        [DisplayName("Mã sinh viên")]
        public int? MaSV { get; set; }

        [DataName("ten")]
        [DisplayName("Tên")]
        [Required]
        public string Ten { get; set; }

        [DataName("ho")]
        [DisplayName("Họ")]
        [Required]
        public string Ho { get; set; }

        [DataName("email")]
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataName("gioi_tinh")]
        [Required]
        [DisplayName("Giới tính")]
        [RegularExpression("Nam|Nu", ErrorMessage = "Gioi tinh chi co the la Nam hoac Nu")]
        public string GioiTinh { get; set; }

        [DataName("dia_chi")]
        [Required]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DataName("ngay_sinh")]
        [Required]
        [DisplayName("Ngày sinh")]
        public DateTime? NgaySinh { get; set; }

        [DataName("tinh_trang")]
        [Required]
        [DisplayName("Tình trạng")]
        public string TinhTrang { get; set; }

        [DataName("ma_khoa")]
        [Required]
        [DisplayName("Mã khoa")]
        public int? MaKhoa { get; set; }

        public override string ToString()
        {
            return $"Sinh vien ma so {MaSV} co ten la {Ho} {Ten}, email: {Email}, {DiaChi}, {NgaySinh}";
        }
    }
}
