create proc getDiemById 
@maLop int,
@maSV int
as
begin
	select * from DIEM where ma_lop_hoc = @maLop AND ma_sinh_vien = @maSV
end