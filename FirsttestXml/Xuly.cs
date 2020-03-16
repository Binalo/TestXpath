using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace FirsttestXml
{
    public class Xuly
    {        
        public static string test()
        {
            string txt = " ";
            XmlDocument doc = new XmlDocument();
            string filename = @"C:\Users\ADMIN\Desktop\Train C#\FirsttestXml\FirsttestXml\sinhvien.xml";
            doc.Load(filename);

            XmlNode sv = doc.SelectSingleNode("/lophoc");

            foreach(XmlElement item in sv.ChildNodes)
            {
                txt += item.InnerText +" "+ item.GetAttribute("id")+"\n";
            }

            return txt;
        }

        public static string tuoi()
        {
            string txt = " ";
            XmlDocument doc = new XmlDocument();
            string filename = @"C:\Users\ADMIN\Desktop\Train C#\FirsttestXml\FirsttestXml\sinhvien.xml";
            doc.Load(filename);
            XmlNodeList s = doc.SelectNodes("/lophoc/sinhvien[tuoi=22]/ten");
            foreach (XmlElement item in s)
            {
                txt += item.InnerText + "\n";
            }

            return txt;
        }
        
    }
}
