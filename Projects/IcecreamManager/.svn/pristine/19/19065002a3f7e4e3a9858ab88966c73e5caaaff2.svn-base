using IceCreamManager.VO;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace IceCreamManager.DAC
{
    /// <summary>
    /// 부모 상속 받은 후 원하는 메소드만 재정의 ( 빈 줄 Alt+Enter 후 [재정의 생성...] 참조 )
    /// </summary>
    public abstract class DACParent
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

 

    }
}
