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
        [DisplayName("Mã môn học")]
        public int? MaMonHoc { get; set; }

        [DataName("ten_mon_hoc")]
        [DisplayName("Tên môn học")]
        public string TenMonHoc { get; set; }

        [DataName("so_tin_chi")]
        
        [DisplayName("Số tín chỉ")]
        public Byte? SoTinhChi { get; set; }

        [DataName("da_xoa")]
       
        [DisplayName("Đã xóa")]
        public bool TinhTrang { get; set; }
    }
}
