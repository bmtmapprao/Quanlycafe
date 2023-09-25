using Quanlycafe.DAO;
using Quanlycafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafe
{
    public partial class fadmin : Form
    {
        public Account loginAccount;
        public fadmin()
        {
            InitializeComponent();
            loaddstaikhoan();
            loaddsban();
            loaddsdanhmuc();
            loaddsdoan();
            LoadCategoryIntoCombobox(cbo_danhmuc);
            AddFoodBinding();
            AddCateroryBindinh();
            AddTableBinding();
            AddAccountBinding();
        }
        void loaddstaikhoan()
        {
            string query = "select tendangnhap, tenhienthi, loaitaikhoan  from taikhoan ";

            dtgv_taikhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loaddsban()
        {
            string caulenh = "select * from ban";

            dtgv_ban.DataSource = DataProvider.Instance.ExecuteQuery(caulenh);
        }
        void loaddsdanhmuc()
        {
            string caulenh = "select * from foodcategory";

            dtgv_danhmuc.DataSource = DataProvider.Instance.ExecuteQuery(caulenh);
        }
        void loaddsdoan()
        {
            string caulenh = "select * from food";

            dtgv_doan.DataSource = DataProvider.Instance.ExecuteQuery(caulenh);
        }
        void AddCateroryBindinh() 
        {
            txt_id.DataBindings.Add(new Binding("Text", dtgv_danhmuc.DataSource, "id", true, DataSourceUpdateMode.Never));
            txt_danhmuc.DataBindings.Add(new Binding("Text", dtgv_danhmuc.DataSource, "ten", true, DataSourceUpdateMode.Never));
        }
        void AddFoodBinding()
        {
            txt_tenmon.DataBindings.Add(new Binding("Text", dtgv_doan.DataSource, "ten", true, DataSourceUpdateMode.Never));
            txt_foodid.DataBindings.Add(new Binding("Text", dtgv_doan.DataSource, "id", true, DataSourceUpdateMode.Never));
            nm_gia.DataBindings.Add(new Binding("Value", dtgv_doan.DataSource, "gia", true, DataSourceUpdateMode.Never));
        }
        void AddTableBinding() 
        {
            ID_ban.DataBindings.Add(new Binding("Text", dtgv_ban.DataSource, "id", true, DataSourceUpdateMode.Never));
            txt_ban.DataBindings.Add(new Binding("Text", dtgv_ban.DataSource, "ten", true, DataSourceUpdateMode.Never));
            txt_trangthai.DataBindings.Add(new Binding("Text", dtgv_ban.DataSource, "trangthai", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            txt_tentaikhoan.DataBindings.Add(new Binding("Text", dtgv_taikhoan.DataSource, "tendangnhap", true, DataSourceUpdateMode.Never));
            txt_tenhienthi.DataBindings.Add(new Binding("Text", dtgv_taikhoan.DataSource, "tenhienthi", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dtgv_taikhoan.DataSource, "loaitaikhoan", true, DataSourceUpdateMode.Never));
        }


        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void txt_foodid_TextChanged(object sender, EventArgs e)
        {
            if (dtgv_doan.SelectedCells.Count > 0)
            {
                int id = (int)dtgv_doan.SelectedCells[0].OwningRow.Cells["idcategory"].Value;

                Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                cbo_danhmuc.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (Category item in cbo_danhmuc.Items)
                {
                    if (item.ID == cateogory.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbo_danhmuc.SelectedIndex = index;
            }

        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            string name = txt_tenmon.Text;
            int categoryID = (cbo_danhmuc.SelectedItem as Category).ID;
            float price = (float)nm_gia.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                loaddsdoan();
                txt_foodid.Clear();
                txt_tenmon.Clear();
                
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btn_suamon_Click(object sender, EventArgs e)
        {
            string name = txt_tenmon.Text;
            int categoryID = (cbo_danhmuc.SelectedItem as Category).ID;
            float price = (float)nm_gia.Value;
            int id = Convert.ToInt32(txt_foodid.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                loaddsdoan();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btn_xoamon_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_foodid.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                loaddsdoan();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            loaddstaikhoan();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            loaddstaikhoan();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            loaddstaikhoan();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void btn_themtaikhoan_Click(object sender, EventArgs e)
        {
            string userName = txt_tentaikhoan.Text;
            string displayName = txt_tenhienthi.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, displayName, type);
        }

        private void btn_xoataikhoan_Click(object sender, EventArgs e)
        {
            string userName = txt_tentaikhoan.Text;

            DeleteAccount(userName);
        }

        private void btn_suataikhoan_Click(object sender, EventArgs e)
        {
            string userName = txt_tentaikhoan.Text;
            string displayName = txt_tenhienthi.Text;
            int type = (int)numericUpDown1.Value;

            EditAccount(userName, displayName, type);
        }

        private void btn_ressetpassword_Click(object sender, EventArgs e)
        {
            string userName = txt_tentaikhoan.Text;

            ResetPass(userName);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            DTGVDoanhthu.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            rpcafe rpt = new rpcafe();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
