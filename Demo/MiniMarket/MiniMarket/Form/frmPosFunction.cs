using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace MiniMarket
{
    public partial class frmPosFunction : Form
    {
        private ProductBUS productBUS;
        private List<Product> lstProduct;
        private List<Product> lstOrderProduct;
        private List<int> lstOrderQuantity;

        private Product currentProductSelected;
        private Customer customer;
        
        public frmPosFunction()
        {
            InitializeComponent();
        }

        private void FrmPosFunction_Load(object sender, EventArgs e)
        {
            ResizeWindows();

            productBUS = new ProductBUS();
            lstProduct = productBUS.GetAll();

            lstOrderProduct = new List<Product>();
            lstOrderQuantity = new List<int>();

            LoadDanhSachSanPham();
            ResetForm();
        }

        private void LoadDanhSachSanPham()
        {
            lsvDanhSachSanPham.LargeImageList = imgList;
            
            int i = 0;

            foreach(Product p in lstProduct)
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = p.ProductName;
                lsvItem.SubItems.Add(p.Price.ToString());
                lsvItem.ImageIndex = i++;
                lsvItem.EnsureVisible();
                lsvDanhSachSanPham.Items.Add(lsvItem);
            }

        }

        public void ResizeWindows()
        {
            Point NewLoc = Screen.FromControl(this).WorkingArea.Location;
            
            NewLoc.X += 20;
            NewLoc.Y += 20;
            this.Location = NewLoc;

            Size NewSize = Screen.FromControl(this).WorkingArea.Size;
            
            NewSize.Height -= 110;
            NewSize.Width -= 40;

            this.Size = NewSize;

            this.MinimumSize = NewSize;
            this.MaximumSize = NewSize;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Product GetProductByID(int productID)
        {
            foreach(Product p in lstProduct)
            {
                if (p.ProductID == productID)
                    return p;
            }
            MessageBox.Show("Mã sản phẩm không tồn tại trong cửa hàng", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private void LsvDanhSachSanPham_Click(object sender, EventArgs e)
        {
            int id = lsvDanhSachSanPham.SelectedItems[0].Index;

            txtMaSanPham.Text = lstProduct[id].ProductID.ToString();
        }

        private void TxtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text != String.Empty)
            {
                int id = int.Parse(txtMaSanPham.Text);
                currentProductSelected = GetProductByID(id);
                if (currentProductSelected != null)
                {
                    txtTenSanPham.Text = currentProductSelected.ProductName;
                }
                else
                {
                    txtMaSanPham.Text = String.Empty;
                    txtTenSanPham.Text = String.Empty;
                }
            }
        }

        

        private void BtnThemSanPham_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            for(int i = 0; i < lstOrderProduct.Count; i++)
            {
                if(lstOrderProduct[i].ProductID == currentProductSelected.ProductID)
                {
                    lstOrderQuantity[i]++;
                    flag = false;
                }
            }

            if(flag)
            {
                lstOrderProduct.Add(currentProductSelected);
                lstOrderQuantity.Add(1);
            }
            LoadData_dgvDanhSachDonHang();
        }

        private void LoadData_dgvDanhSachDonHang()
        {
            int iTongThanhTien = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("TenSanPham");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("GiaBan");

            for(int i = 0; i < lstOrderProduct.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i + 1;
                dr[1] = lstOrderProduct[i].ProductName;
                dr[2] = lstOrderQuantity[i].ToString();
                dr[3] = lstOrderProduct[i].Price;
                dt.Rows.Add(dr);

                iTongThanhTien += lstOrderQuantity[i] * lstOrderProduct[i].Price;
            }

            dgvDanhSachDonHang.DataSource = dt;
            txtTongThanhTien.Text = iTongThanhTien.ToString();
        }

        private void DgvDanhSachDonHang_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int id = dgvDanhSachDonHang.SelectedRows[0].Index;
            lstOrderProduct.RemoveAt(id);
            lstOrderQuantity.RemoveAt(id);
        }

        private void BtnThanhToanDonHang_Click(object sender, EventArgs e)
        {
            OrderBUS orderBUS = new OrderBUS();
            Order order = new Order();
            order.CustomerID = customer.CustomerID;
            order.EmployeeID = Session.EmployeeSession.employee.EmployeeID;
            order.CreatedAt = DateTime.Now;
            order.TotalPrice = int.Parse(txtTongThanhTien.Text);

            int orerID = orderBUS.Insert(order);

            OrderDetailBUS orderDetailBUS = new OrderDetailBUS();

            for(int i = 0;  i < lstOrderProduct.Count; i++)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderID = orerID;
                orderDetail.ProductID = lstOrderProduct[i].ProductID;
                orderDetail.SalingPrice = lstOrderProduct[i].Price;
                orderDetail.SalingQuantity = lstOrderQuantity[i];

                orderDetailBUS.Insert(orderDetail);
            }

            ResetForm();
        }

        private void ResetForm()
        {
            lstOrderProduct.Clear();
            lstOrderQuantity.Clear();

            while (dgvDanhSachDonHang.Rows.Count > 0)
            {
                int i = dgvDanhSachDonHang.Rows.Count;
                dgvDanhSachDonHang.Rows.RemoveAt(i - 1);
            }


            txtMaSanPham.Text = String.Empty;
            txtTenSanPham.Text = String.Empty;

            txtTongThanhTien.Text = "0";

            txtSoDienThoaiKhachHang.Text = "0123456789";

            BtnTimKiemThongTinKhachHang_Click(null, null);
        }

        private void BtnTimKiemThongTinKhachHang_Click(object sender, EventArgs e)
        {
            CustomerBUS customerBUS = new CustomerBUS();
            customer = customerBUS.GetByPhoneNumber(txtSoDienThoaiKhachHang.Text);
            if(customer == null)
            {
                MessageBox.Show("Khách hàng không tồn tại");
            }
            else
            {
                txtHoTenKhachHang.Text = customer.CustomerName;
            }
        }

        private void BtnTaoMoiDonHang_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnTaoMoiThongTinKhachHang_Click(object sender, EventArgs e)
        {
            CustomerBUS customerBUS = new CustomerBUS();
            customer.CustomerPhoneNumber = txtSoDienThoaiKhachHang.Text;
            customer.CustomerName = txtHoTenKhachHang.Text;

            customerBUS.Insert(customer);

            customer = customerBUS.GetByPhoneNumber(txtSoDienThoaiKhachHang.Text);
        }
    }
}
