using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
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
    public partial class DetailInfoForm<T> : Form where T : IObject
    {
        protected BindingSource bindingSource;
        public DetailInfoForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            bindingSource.DataSource = typeof(T);
        }

        protected virtual void Init()
        {
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LoadDataFromDB(T obj, IADOObject ado)
        {
            DataTable table = ado.Get(obj);
            if(table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                T newObj = ConverterHelper.ConvertDataRow<T>(row);
                bindingSource.DataSource = newObj;
            }
        }

        protected void LoadDataFromObject(T obj)
        {
            bindingSource.DataSource = obj;
        }
    }
}
