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
    internal class KyHoc : IObject 
    {
        [DataName("id_ky_hoc")]
        [DisplayName("Mã Kỳ Học")]
        public byte? MaKyHoc { get; set; }

        [DataName("nam_hoc")]
        [DisplayName("Năm Học")]
        [Required]
        public short? NamHoc { get; set; }

        [DataName("ky_hoc")]
        [DisplayName("Kỳ Học")]
        [Required]
        public byte? kyHoc { get; set; }

        [DataName("hoc_phi")]
        [DisplayName("Học Phí")]
        [Required]
        public decimal? HocPhi { get; set; }
    }
}
