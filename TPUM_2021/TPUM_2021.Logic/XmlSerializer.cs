using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using TPUM_2021.ServerData;

namespace TPUM_2021.ServerLogic
{
    public class XmlSerializer : IBasicSerializer
    {
        private ObservableCollection<ProductDto> _Products;
        public XmlSerializer(ObservableCollection<ProductDto> products)
        {
            _Products = products;
        }

        public void Deserialize()
        {
            Debug.WriteLine("Deserializuję");

        }

        public void Serialize()
        {
            if (_Products.Count != 0)
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<ProductDto>));
                using StreamWriter wr = new StreamWriter("products.xml");
                xs.Serialize(wr, _Products);
            }
        }
    }
}
