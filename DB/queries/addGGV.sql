create proc AddSV 
@id int,
@ten nvarchar(50),
@ho nvarchar (50),
@email nvarchar(50),
@gioiTinh nvarchar(50),
@sdt nvarchar(50),
@diaChi nvarchar(50),
@ngaySinh datetime2(7),
@tinhTrang nvarchar(50)
as
begin
	Insert into GIANGVIEN values(@ten,@ho,@email,@gioiTinh,@sdt,@diaChi,@ngaySinh,@tinhTrang)
end