using QuanLyTruongHoc.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using QuanLyTruongHoc.Helpers;

namespace QuanLyTruongHoc.DataObjects
{
    internal class Login : IObject
    {        
        [DataName("ten_tai_khoan")]
        [DisplayName("Tên tài khoản")]
        [Required]
        public string tenTaiKhoan { get; set; }
        [DataName("mat_khau")]
        [DisplayName("Mật khẩu")]
        [Required]
        public string matKhau { get; set; }
        public VAITRO vaiTro { get; set; }
        public int id { get; set; }
    }
}
