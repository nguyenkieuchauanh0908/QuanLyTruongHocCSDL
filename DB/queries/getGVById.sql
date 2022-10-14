create proc getGVById @id int
as
begin
select * from GIANGVIEN where id = @id
end