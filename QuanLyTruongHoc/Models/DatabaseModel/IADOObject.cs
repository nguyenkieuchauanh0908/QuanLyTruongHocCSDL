using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal interface IADOObject
    {
        DataTable Load();
        DataTable Get<T>(T obj) where T : IObject;
    }
}
