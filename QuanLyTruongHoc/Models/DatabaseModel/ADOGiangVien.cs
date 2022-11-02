﻿using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOGiangVien : IADOObject
    {
        private ADOOperator adoOperator;
        public ADOGiangVien(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }
        public DataTable Load()
        {
            string query = "execute getAllGV";
            return adoOperator.ExecuteQuery(query);
        }
        public bool Add<T>(T obj) where T : IObject
        {
            string query = "dbo.AddGV";
            SqlParameter[] parameters = new SqlParameter[8];
            //parameters[0] = new SqlParameter("@id", (obj as GiangVien).MaGV);
            parameters[0] = new SqlParameter("@ten", (obj as GiangVien).Ten);
            parameters[1] = new SqlParameter("@ho", (obj as GiangVien).Ho);
            parameters[2] = new SqlParameter("@email", (obj as GiangVien).Email);
            parameters[3] = new SqlParameter("@gioiTinh", (obj as GiangVien).GioiTinh);
            parameters[4] = new SqlParameter("@sdt", (obj as GiangVien).SoDT);
            parameters[5] = new SqlParameter("@diaChi", (obj as GiangVien).DiaChi);
            parameters[6] = new SqlParameter("@ngaySinh", (obj as GiangVien).NgaySinh);
            parameters[7] = new SqlParameter("@tinhTrang", (obj as GiangVien).TinhTrang);

            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            string query = "dbo.deleteGV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", (obj as GiangVien).MaGV);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "select * from getGVById()";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", (obj as GiangVien).MaGV);
            return adoOperator.ExecuteQuery(query, parameters);
        }


        public DataTable Search<T>(T obj) where T : IObject
        {
            return null;
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "dbo.updateGV";
            SqlParameter[] parameters = new SqlParameter[9];
            parameters[0] = new SqlParameter("@id", (obj as GiangVien).MaGV);
            parameters[1] = new SqlParameter("@ten", (obj as GiangVien).Ten);
            parameters[2] = new SqlParameter("@ho", (obj as GiangVien).Ho);
            parameters[3] = new SqlParameter("@email", (obj as GiangVien).Email);
            parameters[4] = new SqlParameter("@gioiTinh", (obj as GiangVien).GioiTinh);
            parameters[5] = new SqlParameter("@sdt", (obj as GiangVien).SoDT);
            parameters[6] = new SqlParameter("@diaChi", (obj as GiangVien).DiaChi);
            parameters[7] = new SqlParameter("@ngaySinh", (obj as GiangVien).NgaySinh);
            parameters[8] = new SqlParameter("@tinhTrang", (obj as GiangVien).TinhTrang);

            return adoOperator.ExecuteProcedure(query, parameters);
        }
    }
}
