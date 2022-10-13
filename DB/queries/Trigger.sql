-------Khong them diem cua sinh vien dang thoi hoc vao bang diem--------
use QUANLYTRUONGHOC
go
CREATE trigger DangKyMonHoc On DIEM
FOR Insert 
AS Declare @id tinyint
Select @id = n.ma_sinh_vien from inserted n 
IF EXISTS (Select id,tinh_trang from SINHVIEN where SINHVIEN.id=@id AND (tinh_trang='True' OR tinh_trang='Da nghi hoc' OR tinh_trang='Tam thoi hoc'))
ROLLBACK
--------Set trang thai = true khi xoa mot dong nao do---------
go
create trigger SET_TINH_TRANG_TRUE on SINHVIEN
instead of delete 
AS
declare @id tinyint
select  @id = n.id from deleted n
update SINHVIEN
set tinh_trang = 'True' where id=@id 
GO







