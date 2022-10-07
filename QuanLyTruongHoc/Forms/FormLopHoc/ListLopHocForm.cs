using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    internal class ListLopHocForm : BaseListForm
    {
        public ListLopHocForm() : base()
        {
            this.Text = "Danh sách lớp học";
            dataGridView.DataSource = MainForm.Manager.LopHoc.Load();
        }
    }
}
