create proc deleteGV @id int
as
begin
delete from GIANGVIEN where id = @id
end