using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Helpers.Convert
{
    internal class ConvertToObject
    {
        public static SinhVien ToSinhVien(DataRow row)
        {
            return ConverterHelper.ConvertDataRow<SinhVien>(row);
        }
    }
}
