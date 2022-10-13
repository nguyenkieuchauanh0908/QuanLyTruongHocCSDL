create proc updateDiem 
@maLop int,
@maSV int,
@diem_giua_ky int,
@diem_cuoi_ky int
as
begin
	update DIEM set diem_giua_ky = @diem_giua_ky, diem_cuoi_ky = @diem_cuoi_ky where ma_lop_hoc = @maLop AND ma_sinh_vien = @maSV
end