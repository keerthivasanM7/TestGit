using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace ElectronicShop
{
    public class Sales
    {
        public List<CustomerDetails> customerDetails = new List<CustomerDetails>();
        string path2 = "D:\\textxml1\\Customer.xml";
        public void AddCustomer(CustomerDetails obj)
        {
            customerDetails.Add(obj);
            Serialization ob = new Serialization();
            ob.XmlSerializeCustomer1(obj);
        }

        public bool CustomerAvailabity(double phNum)
        {
            FileStream file;
            if (File.Exists(@path2))
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(Sales));
                file = new FileStream(@path2, FileMode.Open, FileAccess.Read);
                var Details = Serializer.Deserialize(file) as Sales;
                file.Close();
                foreach (var item in Details.customerDetails)
                {
                    if (item.PhoneNumber == phNum)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
