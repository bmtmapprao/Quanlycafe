using Quanlycafe.DAO;
using Quanlycafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafe
{
    public partial class fQuanlycafe : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        
        public fQuanlycafe(Account acc)
        {
            InitializeComponent();


            this.LoginAccount = acc;


            loadban();
            loaddanhmuc();
            LoadComboboxTable(cbo_chuyenban);
        }
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảngToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void hienthihoadon(int  id)
        {
            lst_hoadon.Items.Clear();
            List<Quanlycafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float tongtien = 0;
            foreach (Quanlycafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Totalprive.ToString());
                tongtien += item.Totalprive;
                lst_hoadon.Items.Add(lsvItem);
            }
            //CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;
            //txt_tongtien.Text = tongtien.ToString("c",culture);
            txt_tongtien.Text = tongtien.ToString();

        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lst_hoadon.Tag = (sender as Button).Tag;
            hienthihoadon(tableID);
        }
        void loaddanhmuc()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbo_loaidoan.DataSource = listCategory;
            cbo_loaidoan.DisplayMember = "name";
        }
        void loaddanhsachfood(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbo_tenmonan.DataSource = listFood;
            cbo_tenmonan.DisplayMember = "Name";
        }
        void loadban()
        {
            flpban.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpban.Controls.Add(btn);
            }
        }
        

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fthongtincanhan f = new fthongtincanhan(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảngToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }


        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fadmin f = new fadmin();
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            loaddanhsachfood((cbo_loaidoan.SelectedItem as Category).ID);
            if (lst_hoadon.Tag != null)
                hienthihoadon((lst_hoadon.Tag as Table).ID);
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            loaddanhsachfood((cbo_loaidoan.SelectedItem as Category).ID);
            if (lst_hoadon.Tag != null)
                hienthihoadon((lst_hoadon.Tag as Table).ID);
            loadban();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            loaddanhsachfood((cbo_loaidoan.SelectedItem as Category).ID);
            if (lst_hoadon.Tag != null)
                hienthihoadon((lst_hoadon.Tag as Table).ID);
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        private void cbo_loaidoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id=0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            loaddanhsachfood(id);
        }

        private void btn_thêm_Click(object sender, EventArgs e)
        {
            Table table = lst_hoadon.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
           

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbo_tenmonan.SelectedItem as Food).ID;
            int count = (int)nmsoluong.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            hienthihoadon(table.ID);
            loadban();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Table table = lst_hoadon.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            double tongtien=Convert.ToDouble(txt_tongtien.Text.Split(',')[0]);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,(float)tongtien);
                    hienthihoadon(table.ID);

                    loadban();
                }
            }
        }

        private void btn_chuyenban_Click(object sender, EventArgs e)
        {
            int id1 = (lst_hoadon.Tag as Table).ID;

            int id2 = (cbo_chuyenban.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lst_hoadon.Tag as Table).Name, (cbo_chuyenban.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                loadban();
            }
        }

        private void fQuanlycafe_Load(object sender, EventArgs e)
        {

        }
    }
}
