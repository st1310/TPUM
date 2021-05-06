﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class XMLSerializer : BasicSerializer
    {
        private ObservableCollection<ProductDto> _Products;
        public XMLSerializer(ObservableCollection<ProductDto> products)
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
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<ProductDto>));
                using (StreamWriter wr = new StreamWriter("products.xml"))
                {
                    xs.Serialize(wr, _Products);
                }
            }
        }
    }
}
