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
        

        public static bool Themsinhvien(SinhVienXml XmlDoc)
        {
            XElement sv = new XElement("HEADER",
                new XAttribute("SinhvienPrkID", XmlDoc.PrkId),
                new XAttribute("SinhvienID", XmlDoc.Id),
                new XAttribute("SinhvienName", XmlDoc.Name),
                new XAttribute("SinhvienAddr", XmlDoc.Addr),
                new XAttribute("SinhvienEmail", XmlDoc.Email),
                new XAttribute("SinhvienPhone", XmlDoc.Phone));
            XmlDocument doc = new XmlDocument();
            string filename = @"C:\Users\ADMIN\Desktop\Train C#\TestQuanLySinhVien\TestQuanLySinhVien\XmlSinhVien_ADD_EDIT_DEL.xml";
            doc.Load(filename);
            XPathNavigator nav = doc.CreateNavigator();
            nav.SelectSingleNode(@"BIZREQUEST/DATAAREA/VOUCHERS[last()]").AppendChild(sv.ToString());
            doc.Save(filename);

            ///////////////////////////
            //Thao tac  voi DB
            int rowEft;
            string connetionString = null;
            connetionString = "Data Source=.;Initial Catalog=QLSinhVien;User ID=sa;Password=123";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string String = @"Insert into SinhVien Values(@PrkId,@Id,@Name,@Addr,@Email,@Phone)";
                SqlCommand Cmd = new SqlCommand(String, cnn);
                Cmd.Parameters.AddWithValue("@Id", XmlDoc.Id);
                Cmd.Parameters.AddWithValue("@PrkId", XmlDoc.PrkId);
                Cmd.Parameters.AddWithValue("@Name", XmlDoc.Name);
                Cmd.Parameters.AddWithValue("@Addr", XmlDoc.Addr);
                Cmd.Parameters.AddWithValue("@Email", XmlDoc.Email);
                Cmd.Parameters.AddWithValue("@Phone", XmlDoc.Phone);
                cnn.Open();
                rowEft = Cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return !(rowEft == 0);
        }

        public static bool Suasinhvien(SinhVienXml XmlDoc)
        {

            XmlDocument doc = new XmlDocument();
            string filename = @"C:\Users\ADMIN\Desktop\Train C#\TestQuanLySinhVien\TestQuanLySinhVien\XmlSinhVien_ADD_EDIT_DEL.xml";
            doc.Load(filename);
            XPathNavigator nav = doc.CreateNavigator();
            XPathNavigator sv = nav.SelectSingleNode($"BIZREQUEST/DATAAREA/VOUCHERS/HEADER[@SinhvienPrkID='{XmlDoc.PrkId}']");
            sv.SelectSingleNode("@SinhvienID").SetValue(XmlDoc.Id);
            sv.SelectSingleNode("@SinhvienName").SetValue(XmlDoc.Name);
            sv.SelectSingleNode("@SinhvienAddr").SetValue(XmlDoc.Addr);
            sv.SelectSingleNode("@SinhvienEmail").SetValue(XmlDoc.Email);
            sv.SelectSingleNode("@SinhvienPhone").SetValue(XmlDoc.Phone);

            doc.Save(filename);

            /////////////////////////////////
            ///Thao tac voi DB
            int rowEft;
            string connetionString = null;
            connetionString = "Data Source=.;Initial Catalog=QLSinhVien;User ID=sa;Password=123";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string String = @"Update SinhVien set Id=@Id, Name = @Name, Addr = @Addr, Email = @Email,
                 Phone = @Phone Where Prkid = @Prkid";
                SqlCommand Cmd = new SqlCommand(String, cnn);
                Cmd.Parameters.AddWithValue("@Id", XmlDoc.Id);
                Cmd.Parameters.AddWithValue("@PrkId", XmlDoc.PrkId);
                Cmd.Parameters.AddWithValue("@Name", XmlDoc.Name);
                Cmd.Parameters.AddWithValue("@Addr", XmlDoc.Addr);
                Cmd.Parameters.AddWithValue("@Email", XmlDoc.Email);
                Cmd.Parameters.AddWithValue("@Phone", XmlDoc.Phone);
                cnn.Open();
                rowEft = Cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return !(rowEft == 0);
        
    }

        public static bool XoaSinhVien(SinhVienXml XmlDoc)
        {
            string path = @"C:\Users\ADMIN\Desktop\Train C#\TestQuanLySinhVien\TestQuanLySinhVien\XmlSinhVien_ADD_EDIT_DEL.xml";

            XmlDocument editDoc = new XmlDocument();
            editDoc.Load(path);
            XPathNavigator editNav = editDoc.CreateNavigator();
            XPathNavigator student = editNav.SelectSingleNode($"BIZREQUEST/DATAAREA/VOUCHERS/HEADER[@SinhvienPrkID='{XmlDoc.PrkId}']");
            student.DeleteSelf();
            editDoc.Save(path);

            /////////////////////////////////
            ///Thao tac voi DB
            int rowEft;
            string connetionString = null;
            connetionString = "Data Source=.;Initial Catalog=QLSinhVien;User ID=sa;Password=123";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string String = @"Delete from SinhVien where PrkId=@PrkId";
                 
                SqlCommand Cmd = new SqlCommand(String, cnn);
                Cmd.Parameters.AddWithValue("@PrkId", XmlDoc.PrkId);
                
                cnn.Open();
                rowEft = Cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return !(rowEft == 0);
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

