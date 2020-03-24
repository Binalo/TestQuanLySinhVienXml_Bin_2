using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
namespace TestQuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadfile()
        {
            listView1.Rows.Clear();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"C:\Users\ADMIN\Desktop\Train C#\TestQuanLySinhVien\TestQuanLySinhVien\XmlSinhVien_ADD_EDIT_DEL.xml");
            XPathNavigator nav = xdoc.CreateNavigator();
            XPathNodeIterator nodeiter = nav.Select(@"BIZREQUEST/DATAAREA/VOUCHERS/HEADER");
            int row = 0;
            while (nodeiter.MoveNext())
            {
                listView1.Rows.Add();
                listView1.Rows[row].Cells[0].Value = nodeiter.Current.SelectSingleNode("@SinhvienPrkID").Value.ToString();
                listView1.Rows[row].Cells[1].Value = nodeiter.Current.SelectSingleNode("@SinhvienID").Value.ToString();
                listView1.Rows[row].Cells[2].Value = nodeiter.Current.SelectSingleNode("@SinhvienName").Value.ToString();
                listView1.Rows[row].Cells[3].Value = nodeiter.Current.SelectSingleNode("@SinhvienAddr").Value.ToString();
                listView1.Rows[row].Cells[4].Value = nodeiter.Current.SelectSingleNode("@SinhvienEmail").Value.ToString();
                listView1.Rows[row].Cells[5].Value = nodeiter.Current.SelectSingleNode("@SinhvienPhone").Value.ToString();

                row++;
            }
            listView1.Refresh();

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            loadfile();
        }

        private void ListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = listView1[listView1.Columns["SinhVienID"].Index, e.RowIndex].Value.ToString();
                txtPrkId.Text = listView1[listView1.Columns["SinhvienPrkID"].Index, e.RowIndex].Value.ToString();
                txtName.Text = listView1[listView1.Columns["SinhVienName"].Index, e.RowIndex].Value.ToString();
                txtAddr.Text = listView1[listView1.Columns["SinhvienAddr"].Index, e.RowIndex].Value.ToString();
                txtEmail.Text = listView1[listView1.Columns["SinhvienEmail"].Index, e.RowIndex].Value.ToString();
                txtPhone.Text = listView1[listView1.Columns["SinhvienPhone"].Index, e.RowIndex].Value.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SinhVienXml sv = new SinhVienXml();
            sv.Id = txtId.Text;
            sv.PrkId = txtPrkId.Text;
            sv.Name = txtName.Text;
            sv.Addr = txtAddr.Text;
            sv.Email = txtEmail.Text;
            sv.Phone = txtPhone.Text;
            SinvienDBMng.Themsinhvien(sv);
            loadfile();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SinhVienXml sv = new SinhVienXml();
            sv.PrkId = txtPrkId.Text;
            sv.Id = txtId.Text;
            sv.Name = txtName.Text;
            sv.Addr = txtAddr.Text;
            sv.Email = txtEmail.Text;
            sv.Phone = txtPhone.Text;
            SinvienDBMng.Suasinhvien(sv);
            loadfile();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SinhVienXml sv = new SinhVienXml();
            sv.PrkId = txtPrkId.Text;
            SinvienDBMng.XoaSinhVien(sv);
            loadfile();
        }
    }
}
