create proc updateGV 
@id int,
@ten nvarchar(50),
@ho nvarchar(50),
@email nvarchar(50),
@gioiTinh nvarchar(50),
@sdt nvarchar(50),
@diaChi nvarchar(50),
@ngaySinh datetime2(7),
@tinhTrang nvarchar(50)
as
begin
	update GIANGVIEN set ten = @ten, ho = @ho, email = @email, gioi_tinh = @gioiTinh, so_dien_thoai = @sdt, dia_chi = @diaChi, ngay_sinh = @ngaySinh, tinh_trang = @tinhTrang
	where id = @id
end