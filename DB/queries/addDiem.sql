create proc addDiem 
@maLop int,
@maSV int,
@diem_giua_ky float,
@diem_cuoi_ky float
as
begin
	insert into DIEM values (@maLop,@maSV,@diem_giua_ky,@diem_cuoi_ky)
end