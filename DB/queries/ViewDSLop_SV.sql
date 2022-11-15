create view [dbo].[DanhSachSV_Lop] as
select ma_lop_hoc, ma_sinh_vien, ho, ten, diem_giua_ky, diem_cuoi_ky, tinh_trang
from SINHVIEN inner join DIEM on id = ma_sinh_vien
where tinh_trang = 'Dang theo hoc'