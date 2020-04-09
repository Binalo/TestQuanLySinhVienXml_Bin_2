using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
namespace TestQuanLySinhVien
{
    class SinvienDBMng
    {
        public  void LuuDB(string connect, XmlDocument Xmldoc)
        {
            XmlNode voucher = Xmldoc.SelectSingleNode("//VOUCHERS");

            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand();
            connection.Open();
            foreach (XmlElement item in voucher.ChildNodes)
            {
                cmd.CommandText = @"insert into Sinhvien values(
                                        @PrkId,@Id
                                        ,@Name,@Addr
                                        ,@Email,@Phone)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@PrkId", item.GetAttribute("SinhvienPrkID"));
                cmd.Parameters.AddWithValue("@Id", item.GetAttribute("SinhvienID"));
                cmd.Parameters.AddWithValue("@Name", item.GetAttribute("SinhvienName"));
                cmd.Parameters.AddWithValue("@Addr", item.GetAttribute("SinhvienAddr"));
                cmd.Parameters.AddWithValue("@Email", item.GetAttribute("SinhvienEmail"));
                cmd.Parameters.AddWithValue("@Phone", item.GetAttribute("SinhvienPhone"));
                rowAffected = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            connection.Close();

        }

        public  void FixSv(string connect , XmlDocument Xmldoc)
        {

            ///////////////////////////
            //Thao tac  voi DB
            XmlNode voucher = (XmlElement)Xmldoc.SelectSingleNode("//VOUCHERS");
            XmlElement header = (XmlElement)voucher.SelectSingleNode("HEADER");
            
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Sinhvien 
                                    set Name=@Name,
                                        Addr=@Addr,
                                        Email=@Email,
                                        Phone=@Phone
                                  where PrkId=@PrkId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            connection.Open();
            cmd.Parameters.AddWithValue("@PrkId", header.GetAttribute("SinhvienPrkID"));
            cmd.Parameters.AddWithValue("@Name", header.GetAttribute("SinhvienName"));   
            cmd.Parameters.AddWithValue("@Addr", header.GetAttribute("SinhvienAddr"));
            cmd.Parameters.AddWithValue("@Email", header.GetAttribute("SinhvienEmail"));
            cmd.Parameters.AddWithValue("@Phone", header.GetAttribute("SinhvienPhone"));
            rowAffected = cmd.ExecuteNonQuery();
            connection.Close();

        }

        
            public void Xoasinhvien(string connectionString, XmlDocument Xmldoc)
            {
                XmlNode voucher = (XmlElement)Xmldoc.SelectSingleNode("//VOUCHERS");
                XmlElement header = (XmlElement)voucher.SelectSingleNode("HEADER");
                int rowAffected = 0;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"delete from Sinhvien where PrkId=@PrkId";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                connection.Open();
                cmd.Parameters.AddWithValue("@PrkId", header.GetAttribute("SinhvienPrkID"));
                rowAffected = cmd.ExecuteNonQuery();
                connection.Close();

            }

        
        public XmlDocument GetDanhsachSinvien()
        {
            XmlDocument docDb = new XmlDocument();
            XmlElement goc = docDb.CreateElement("goc");
            string connetionString = null;
            connetionString = "Data Source=.;Initial Catalog=QLSinhVien;User ID=sa;Password=123";
            SqlConnection cnn = new SqlConnection(connetionString);
            
            cnn.Open();
            string DB = @"select PrkID, ID, Name, Addr from SinhVien";
            SqlCommand cmd = new SqlCommand(DB,cnn);
            //doc DB sang Xml
            SqlDataReader dbReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dbReader.Read())
            {
                XmlElement LINE = docDb.CreateElement("LINE");

                XmlAttribute SinhvienPrkID = docDb.CreateAttribute("SinhvienPrkID");
                SinhvienPrkID.Value = Convert.ToString(dbReader["PrkID"]);
                LINE.Attributes.Append(SinhvienPrkID);

                XmlAttribute SinhvienID = docDb.CreateAttribute("SinhvienID");
                SinhvienID.Value = Convert.ToString(dbReader["ID"]);
                LINE.Attributes.Append(SinhvienID);

                XmlAttribute SinhvienName = docDb.CreateAttribute("SinhvienName");
                SinhvienName.Value = Convert.ToString(dbReader["Name"]);
                LINE.Attributes.Append(SinhvienName);

                XmlAttribute SinhvienAddr = docDb.CreateAttribute("SinhvienAddr");
                SinhvienAddr.Value = Convert.ToString(dbReader["Addr"]);
                LINE.Attributes.Append(SinhvienAddr);
                goc.AppendChild(LINE);
            }
            docDb.AppendChild(goc);
            dbReader.Close();
            cnn.Close();

            return docDb;
        }
    }
    }

