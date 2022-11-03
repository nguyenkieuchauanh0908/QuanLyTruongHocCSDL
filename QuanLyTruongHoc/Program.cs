using QuanLyTruongHoc.Forms;
using QuanLyTruongHoc.Forms.FormLopHoc;
using QuanLyTruongHoc.Forms.FormSinhVien;
using QuanLyTruongHoc.Forms.FormDiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//Xem danh sách các môn học có thể đăng kí (bảng môn). - View Mon Hoc Table
//Bấm vào môn nào thì hiện ra danh sách các lớp hiện có của môn đó (bảng lớp học).
//Trong ds các lớp, sinh viên bấm vô dòng nào thì hiện ra thông báo xác nhận có muốn
//đăng ký hay hông? Nếu yes thì thêm mã lớp học và mã sinh viên vào bảng điểm
//(điểm tự động bằng 0 nếu giảng viên chưa có thay đổi gì) 


//- Tao 1 form (constructor nhan 1 SINHVIEN,
//hien thi tat ca cac lop hoc da dang ky bang datasource)
//Xem danh sách lớp học đã đăng ký (điểm của môn hiện ra trong cùng một dòng,
//sinh viên không được phép chỉnh sửa) 


//Xem thông tin cá nhân. //XONG


namespace QuanLyTruongHoc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
