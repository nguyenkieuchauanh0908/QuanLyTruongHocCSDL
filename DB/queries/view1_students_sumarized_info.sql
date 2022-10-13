USE QUANLYTRUONGHOC
GO
-------Tao view KETQUAHOCTAP-----------
CREATE VIEW KETQUAHOCTAP AS
SELECT id as MaSV, id_ky_hoc as HocKy, AVG(DIEM.diem_trung_binh) as DiemTB, SUM(mh.so_tin_chi) as SoTC, (hoc_phi*(mh.so_tin_chi)) as HocPhi
	FROM ((((SINHVIEN sv JOIN DIEM diem ON sv.id = diem.ma_sinh_vien) INNER JOIN LOPHOC lop ON diem.ma_lop_hoc = lop.ma_lop_hoc) 
				INNER JOIN MONHOC mh ON LOP.ma_mon_hoc = MH.ma_mon_hoc)INNER JOIN KYHOC ky ON lop.ma_ky_hoc=ky.id_ky_hoc)
	GROUP BY id, id_ky_hoc, hoc_phi, so_tin_chi

-------Tao view THONGTINLOPHOC-----------
GO
CREATE VIEW THONGTINLOPHOC AS
	SELECT ma_lop_hoc as MaLop, ten_mon_hoc as TenMonHoc , nam_hoc as NamHoc, gv.ten as TenGV, ky_hoc as HocKy
	FROM (((LOPHOC lh INNER JOIN MONHOC mh ON lh.ma_mon_hoc=mh.ma_mon_hoc) JOIN KYHOC ky ON ky.id_ky_hoc = lh.ma_ky_hoc)INNER JOIN GIANGVIEN gv ON gv.id = lh.ma_giang_vien)

GO
-------Tao view DANHSACHSINHVIEN-----------
CREATE VIEW DANHSACHSINHVIEN AS
	SELECT lh.ma_lop_hoc as MaLop, ten_mon_hoc as TenMonHoc, id as MaSV, sv.ho as Ho, sv.ten as Ten
	FROM (((DIEM as Diem INNER JOIN LOPHOC lh ON Diem.ma_lop_hoc = lh.ma_lop_hoc) 
	INNER JOIN MONHOC mh ON mh.ma_mon_hoc = lh.ma_mon_hoc) INNER JOIN SINHVIEN sv ON sv.id = Diem.ma_sinh_vien)
GO

