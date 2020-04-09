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

        public string connect = "Data Source=.;Initial Catalog=QLSinhVien;User ID=sa;Password=123";
        public XmlDocument Xmldoc = new XmlDocument();

        SinhVienXml SvX = new SinhVienXml();
        SinvienDBMng SvDb = new SinvienDBMng();

        //private void loadfile()
        //{
        //    listView1.Rows.Clear();
        //    XmlDocument xdoc = new XmlDocument();
        //    XmlElement BIZREQUEST = xdoc.CreateElement("BIZREQUEST");
        //    XmlElement DATAAREA = xdoc.CreateElement("DATAAREA");
        //    XmlElement VOUCHERS = xdoc.CreateElement("VOUCHERS");
        //    DATAAREA.AppendChild(VOUCHERS);
        //    BIZREQUEST.AppendChild(DATAAREA);
        //    xdoc.AppendChild(BIZREQUEST);
        //    int row = 0;
        //    while (nodeiter.MoveNext())
        //    {
        //        listView1.Rows.Add();
        //        listView1.Rows[row].Cells[0].Value = nodeiter.Current.SelectSingleNode("@SinhvienPrkID").Value.ToString();
        //        listView1.Rows[row].Cells[1].Value = nodeiter.Current.SelectSingleNode("@SinhvienID").Value.ToString();
        //        listView1.Rows[row].Cells[2].Value = nodeiter.Current.SelectSingleNode("@SinhvienName").Value.ToString();
        //        listView1.Rows[row].Cells[3].Value = nodeiter.Current.SelectSingleNode("@SinhvienAddr").Value.ToString();
        //        listView1.Rows[row].Cells[4].Value = nodeiter.Current.SelectSingleNode("@SinhvienEmail").Value.ToString();
        //        listView1.Rows[row].Cells[5].Value = nodeiter.Current.SelectSingleNode("@SinhvienPhone").Value.ToString();

        //        row++;
        //    }
        //    listView1.Refresh();

        //}

       

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
            SvDb.LuuDB(connect, Xmldoc);
            MessageBox.Show("Saved Successfully", "Notification",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sinhvienprkid = txtPrkId.Text;
            string sinhvienid = txtId.Text;
            string sinhvienname = txtName.Text;
            string sinhvienaddr = txtAddr.Text;
            string sinhvienemail = txtEmail.Text;
            string sinhvienphone = txtPhone.Text;
            XmlDocument read1 = SvX.FixSv(sinhvienprkid, sinhvienid, sinhvienname, sinhvienaddr, sinhvienemail, sinhvienphone);
            SvDb.FixSv(connect, read1);
            MessageBox.Show("Edit Successfully", "Notification",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sinhvienprkid = txtPrkId.Text;
            XmlDocument xmldoc = SvX.DelSv(sinhvienprkid);
            SvDb.Xoasinhvien(connect, xmldoc);
            
            MessageBox.Show("Delete Successfully", "Notification",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int row = 0;
            SinvienDBMng sv = new SinvienDBMng();
            XmlDocument xmldoc = sv.GetDanhsachSinvien();
            XmlNode root = xmldoc.DocumentElement;
            foreach (XmlElement item in root.ChildNodes)
            {
                listView1.Rows.Add();
                listView1.Rows[row].Cells[0].Value = item.GetAttribute("SinhvienPrkID");
                listView1.Rows[row].Cells[1].Value = item.GetAttribute("SinhvienID");
                listView1.Rows[row].Cells[2].Value = item.GetAttribute("SinhvienName");
                listView1.Rows[row].Cells[3].Value = item.GetAttribute("SinhvienAddr");
                row++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Row = listView1.Rows.Count - 1;
            string sinhvienprkid = txtPrkId.Text;
            string sinhvienid = txtId.Text;
            string sinhvienname = txtName.Text;
            string sinhvienaddr = txtAddr.Text;
            string sinhvienemail = txtEmail.Text;
            string sinhvienphone = txtPhone.Text;
            Xmldoc = SvX.AddSv(sinhvienprkid, sinhvienid, sinhvienname, sinhvienaddr, sinhvienemail, sinhvienphone);
            listView1.Rows.Add();
            listView1.Rows[Row].Cells[0].Value = sinhvienprkid;
            listView1.Rows[Row].Cells[1].Value = sinhvienid;
            listView1.Rows[Row].Cells[2].Value = sinhvienname;
            listView1.Rows[Row].Cells[3].Value = sinhvienaddr;
            MessageBox.Show("Add Successfully", "Notification",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
