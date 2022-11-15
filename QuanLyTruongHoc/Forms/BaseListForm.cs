using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormSinhVien;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms
{
    public partial class BaseListForm<T> : Form
    {
        protected List<T> list;
        protected DataTable table;
        public BaseListForm()
        {
            InitializeComponent();
            list = new List<T>();
        }

        public void InitList()
        {
            table = GetTable();
            dataGridView.DataSource = table;
            foreach (DataRow row in table.Rows)
            {
                T item = ConverterHelper.ConvertDataRow<T>(row);
                list.Add(item);
            }
        }

        public virtual DataTable GetTable()
        {
            return null;
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Show context menu on selected row
                dataGridView.ClearSelection();
                dataGridView.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridView, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        protected virtual void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        protected virtual void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        protected virtual void search_btn_Click(object sender, EventArgs e)
        {
            T searchObj = SearchObject();
            MessageBox.Show(searchObj.ToString());
            DataTable result;
            if (searchObj == null)
            {
                result = GetTable();
            }   
            else
            {
                result = Helpers.Search.SearchBy<T>(table, searchObj);
            }
            dataGridView.DataSource = result;
        }

        protected virtual T SearchObject()
        {
            return default(T);
        }

        protected virtual void add_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void iObjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = GetTable();
        }
    }
}
