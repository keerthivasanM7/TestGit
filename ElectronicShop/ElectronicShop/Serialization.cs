using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Data;
using System.Xml.Serialization;

namespace ElectronicShop
{
    class Serialization
    {
        string path;
        string username;
        DataSet ds = new DataSet();
        public Serialization(string path,string username)
        {
            this.path = path;
            this.username = username;
        }
        public void Serialize(DataSet ds)
        {
            this.ds = ds;
            string dsXml = ds.GetXml();
            if (File.Exists(@path + username + ".xml"))
            {
                ds.ReadXml(path + username + ".xml");
                ds.WriteXml(path + username + ".xml");
            }
            else
            {
                using (StreamWriter fs = new StreamWriter(path + username + ".xml"))
                {
                    ds.WriteXml(fs);
                }
            }
        }
        public void XmlSerialize(ClientDetails ob)
        {
            string dsXml = ds.GetXml();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClientDetails));
            using (StreamWriter writer = new StreamWriter(@path + ClientDetails.Name + ".xml"))
            {
                xmlSerializer.Serialize(writer, ob);
            }
        }
        public DataSet DeSerialize()
        {
            ds.ReadXml(@path + username + ".xml");
            return ds;
        }
    }
}
