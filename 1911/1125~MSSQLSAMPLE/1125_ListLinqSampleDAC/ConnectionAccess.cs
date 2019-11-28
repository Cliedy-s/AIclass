using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1125_ListLinqSample
{
    public abstract class ConnectionAccess
    {
        protected string Connstr
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Sample_DEV.xml");
                XmlNodeList nodes = doc.SelectNodes("configuration/settings/add");
                foreach (XmlNode item in nodes)
                {
                    if(item.Attributes["key"].InnerText == "MyDB")
                    {
                        return ((XmlCDataSection)item.ChildNodes[0]).InnerText;
                    }
                }
                return "NoConnectionInfo";
            }
        }
    }
}
