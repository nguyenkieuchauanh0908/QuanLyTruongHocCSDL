create function [dbo].[getAllLop_GV] (@gvId int) returns table
as
return select * from LOPHOC lh inner join KYHOC kyh on lh.ma_ky_hoc = kyh.id_ky_hoc where ma_giang_vien = @gvId and ky_hoc = 1 and nam_hoc = 2022;
go
select * from dbo.getAllLop_GV(1)



