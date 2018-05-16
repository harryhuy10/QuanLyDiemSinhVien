using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public static SqlConnection con;
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private void connect()
        {
            String cn = @"server ='DESKTOP-J51JA3J\SQLEXPRESS' ;database ='Project_QuanlySinhVien' ;Integrated Security = true";//;Integrated Security = false
            con = new SqlConnection(cn);
            con.Open();
        }

        public void getdata()
        {
            String sqlSELECT = "SELECT * FROM DMSV";
            SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
            SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu
            DataTable dt = new DataTable();//tạo 1 bảng ảo
            da.Fill(dt); //đổ dữ liệu vào bảng ảo
            dataGridView5.DataSource = dt; // đổ dữ liệu vào dG
            txtMaSV.Enabled = false;
        }
        private void groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView5.CurrentRow.Index;
            txtMaSV.Text = dataGridView5.Rows[index].Cells[0].Value.ToString();
            txtTenSV.Text = dataGridView5.Rows[index].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridView5.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView5.Rows[index].Cells[3].Value.ToString();
            txtNoiSinh.Text = dataGridView5.Rows[index].Cells[4].Value.ToString();
            txtMaLop.Text = dataGridView5.Rows[index].Cells[5].Value.ToString();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmThemSinhVien tsv = new frmThemSinhVien();
            tsv.Show();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            TreeView_Load();
            radioMaSV.Checked = true;
        }
        public DataTable truyvan(string sql, SqlConnection con)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public void TreeView_Load()
        {
            tvDSSV.Nodes.Clear();
            DataTable dt_Khoa = truyvan("select * from DMKhoa", con);
            if (dt_Khoa.Rows.Count > 0)
            {
                for (int i = 0; i < dt_Khoa.Rows.Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = dt_Khoa.Rows[i]["MaKhoa"].ToString();//lấy column tên tác giả từ table TACGIA
                    DataTable dt_Lop = truyvan("SELECT * FROM DMLop where MaKhoa = '" + dt_Khoa.Rows[i]["MaKhoa"].ToString() + "'", con);
                    if (dt_Lop.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt_Lop.Rows.Count; j++)
                        {
                            node.Nodes.Add(dt_Lop.Rows[j]["MaLop"].ToString());//lấy column tên sách từ table SACH }
                        }
                        tvDSSV.Nodes.Add(node);
                    }
                }
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string sua = "update DMSV set TenSV =N'" + txtTenSV.Text + "',GioiTinh =N'" + txtGioiTinh.Text + "',NgaySinh='" + theDate + "',NoiSinh=N'" + txtNoiSinh.Text + "' where MaSV ='" + txtMaSV.Text + "'";
            SqlCommand comSua = new SqlCommand(sua, con);
            comSua.ExecuteNonQuery();
            getdata();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string xoa = "delete a from ThongKe a inner join DMSV b on a.MaSV = b.MaSV where b.MaSV = '" + txtMaSV.Text + "' delete c from DMSV c inner join DMSV b on c.MaSV=b.MaSV where b.MaSV = '" + txtMaSV.Text + "' delete from DMSV where MaSV = '" + txtMaSV.Text + "' ";
                SqlCommand comXoa = new SqlCommand(xoa, con);
                comXoa.ExecuteNonQuery();
                getdata();
            }
            else if (dialogResult == DialogResult.No)
            {
                getdata();
            }
        }

        private void tvDSSV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode theNode = this.tvDSSV.SelectedNode;
            string sql = "select a.MaSV,a.TenSV,a.GioiTinh,a.NgaySinh,a.NoiSinh,a.MaLop from DMSV a inner join DMLop b on a.MaLop = b.MaLop inner join DMKhoa c on b.MaKhoa = c.MaKhoa where b.MaKhoa = '" + theNode.Text + "' or a.MaLop = '" + theNode.Text + "' order by TenSV desc";
            SqlCommand com = new SqlCommand(sql, con);//thực thi câu lệnh trong SQL
            SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu
            DataTable dt = new DataTable();//tạo 1 bảng ảo
            da.Fill(dt); //đổ dữ liệu vào bảng ảo
            dataGridView5.DataSource = dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String sqlSELECT;
            SqlCommand com;
            SqlDataAdapter da;
            DataTable dt;
            if (radioMaSV.Checked == true)
            {
                sqlSELECT = "select * from DMSV where MaSV = '" + txtTimKiemDiem.Text + "'";
                com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
                da = new SqlDataAdapter(com); //vận chuyển dữ liệu
                dt = new DataTable();//tạo 1 bảng ảo
                da.Fill(dt); //đổ dữ liệu vào bảng ảo
                dataGridView5.DataSource = dt; // đổ dữ liệu vào dG
            }
            if (radioMaLop.Checked == true)
            {
                sqlSELECT = "select * from DMSV where MaLop = '" + txtTimKiemDiem.Text + "'";
                com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
                da = new SqlDataAdapter(com); //vận chuyển dữ liệu
                dt = new DataTable();//tạo 1 bảng ảo
                da.Fill(dt); //đổ dữ liệu vào bảng ảo
                dataGridView5.DataSource = dt; // đổ dữ liệu vào dG
            }
            if (radioTenSV.Checked == true)
            {
                sqlSELECT = "select * from DMSV where TenSV like N'%" + txtTimKiemDiem.Text + "%'";
                com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
                da = new SqlDataAdapter(com); //vận chuyển dữ liệu
                dt = new DataTable();//tạo 1 bảng ảo
                da.Fill(dt); //đổ dữ liệu vào bảng ảo
                dataGridView5.DataSource = dt; // đổ dữ liệu vào dG
            }
            if (radioTatCa.Checked == true)
            {
                sqlSELECT = "select * from DMSV where TenSV like N'%" + txtTimKiemDiem.Text + "%' or MaLop = '" + txtTimKiemDiem.Text + "' or MaSV = '" + txtTimKiemDiem.Text + "' or GioiTinh = '"+txtTimKiemDiem.Text+"' or NoiSinh like N'%"+txtTimKiemDiem.Text+"%'";
                com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
                da = new SqlDataAdapter(com); //vận chuyển dữ liệu
                dt = new DataTable();//tạo 1 bảng ảo
                da.Fill(dt); //đổ dữ liệu vào bảng ảo
                dataGridView5.DataSource = dt; // đổ dữ liệu vào dG
            }
        }
    }
}
