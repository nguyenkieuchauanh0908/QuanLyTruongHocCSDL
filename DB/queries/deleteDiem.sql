create proc deleteDiem
@maLop int,
@maSV int
as
begin
	delete from Diem where ma_lop_hoc = @maLop AND ma_sinh_vien = @maSV
end