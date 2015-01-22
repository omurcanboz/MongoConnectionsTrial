using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB
{
    public class Personel
    {


        
        public ObjectId Id { get; set; }

        public string ad { get; set; }

        public string soyad { get; set; }

        public string cepno { get; set; }

        public string sex { get; set; }

    }
}
