using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IceCreamManager.DAC
{
    abstract class DACParent
    {
        protected string Connstr
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Team4Connect_DEV.xml");
                XmlNodeList nodes = doc.SelectNodes("configuration/settings/add");
                foreach (XmlNode item in nodes)
                {
                    if (item.Attributes["key"].InnerText == "Team4DB")
                    {
                        return ((XmlCDataSection)item.ChildNodes[0]).InnerText;
                    }
                }
                return "NoConnectionInfo";
            }
        }
        public abstract List<T> SelectAll<T>() where T : VOParent;
        public abstract int Insert();
        public abstract int update();
        public abstract int delete();
    }
}
