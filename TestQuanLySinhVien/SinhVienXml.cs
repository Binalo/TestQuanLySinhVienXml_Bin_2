using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace TestQuanLySinhVien
{
    public class SinhVienXml
    {
        public XmlDocument doc = new XmlDocument();
        public SinhVienXml()
        {
            XmlElement BIZREQUEST = doc.CreateElement("BIZREQUEST");
            XmlElement DATAAREA = doc.CreateElement("DATAAREA");
            XmlElement VOUCHERS = doc.CreateElement("VOUCHERS");
            DATAAREA.AppendChild(VOUCHERS);
            BIZREQUEST.AppendChild(DATAAREA);
            doc.AppendChild(BIZREQUEST);
        }
        public XmlDocument AddSv(string prkId, string Id, string Name, string Addr, string Mail, string Phone)
        {
            XmlElement HeaderX = doc.CreateElement("HEADER");

            XmlAttribute SvPrkid = doc.CreateAttribute("SinhvienPrkID");
            SvPrkid.Value = prkId;
            HeaderX.Attributes.Append(SvPrkid);

            XmlAttribute SvId = doc.CreateAttribute("SinhvienID");
            SvId.Value = Id;
            HeaderX.Attributes.Append(SvId);

            XmlAttribute SvName= doc.CreateAttribute("SinhvienName");
            SvName.Value = Name;
            HeaderX.Attributes.Append(SvName);

            XmlAttribute SvAddr = doc.CreateAttribute("SinhvienAddr");
            SvAddr.Value = Addr;
            HeaderX.Attributes.Append(SvAddr);

            XmlAttribute SvMail = doc.CreateAttribute("SinhvienEmail");
            SvMail.Value = Mail;
            HeaderX.Attributes.Append(SvMail);

            XmlAttribute SvPhone = doc.CreateAttribute("SinhvienPhone");
            SvPhone.Value = prkId;
            HeaderX.Attributes.Append(SvPhone);

            doc.SelectSingleNode("/BIZREQUEST/DATAAREA/VOUCHERS").AppendChild(HeaderX);
            return doc;
        }
        public XmlDocument FixSv(string prkId, string Id, string Name, string Addr, string Mail, string Phone)
        {
            XmlDocument docX = new XmlDocument();
            XmlElement BIZREQUEST = docX.CreateElement("BIZREQUEST");
            XmlElement DATAAREA = docX.CreateElement("DATAAREA");
            XmlElement VOUCHERS = docX.CreateElement("VOUCHERS");
            DATAAREA.AppendChild(VOUCHERS);
            BIZREQUEST.AppendChild(DATAAREA);
            docX.AppendChild(BIZREQUEST);

            XmlElement HeaderX = docX.CreateElement("HEADER");

            XmlAttribute SvPrkid = docX.CreateAttribute("SinhvienPrkID");
            SvPrkid.Value = prkId;
            HeaderX.Attributes.Append(SvPrkid);

            XmlAttribute SvId = docX.CreateAttribute("SinhvienID");
            SvId.Value = Id;
            HeaderX.Attributes.Append(SvId);

            XmlAttribute SvName = docX.CreateAttribute("SinhvienName");
            SvName.Value = Name;
            HeaderX.Attributes.Append(SvName);

            XmlAttribute SvAddr = docX.CreateAttribute("SinhvienAddr");
            SvAddr.Value = Addr;
            HeaderX.Attributes.Append(SvAddr);

            XmlAttribute SvMail = docX.CreateAttribute("SinhvienEmail");
            SvMail.Value = Mail;
            HeaderX.Attributes.Append(SvMail);

            XmlAttribute SvPhone = docX.CreateAttribute("SinhvienPhone");
            SvPhone.Value = prkId;
            HeaderX.Attributes.Append(SvPhone);

            

            VOUCHERS.AppendChild(HeaderX);

            return docX;
        }
        public XmlDocument DelSv(string prkId)
        {
            XmlDocument docX = new XmlDocument();
            XmlElement BIZREQUEST = docX.CreateElement("BIZREQUEST");
            XmlElement DATAAREA = docX.CreateElement("DATAAREA");
            XmlElement VOUCHERS = docX.CreateElement("VOUCHERS");
            DATAAREA.AppendChild(VOUCHERS);
            BIZREQUEST.AppendChild(DATAAREA);
            docX.AppendChild(BIZREQUEST);

            XmlElement HeaderX = docX.CreateElement("HEADER");
            XmlAttribute SinhvienPrkIDsql = docX.CreateAttribute("SinhvienPrkID");
            SinhvienPrkIDsql.Value = prkId;
            HeaderX.Attributes.Append(SinhvienPrkIDsql);


            VOUCHERS.AppendChild(HeaderX);


            return docX;
        }
    }
}
