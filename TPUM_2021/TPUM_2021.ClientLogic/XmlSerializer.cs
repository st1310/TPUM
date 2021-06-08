using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
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
