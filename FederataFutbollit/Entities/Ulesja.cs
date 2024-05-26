﻿using System.Text.Json.Serialization;

namespace FederataFutbollit.Entities
{
    public class Ulesja
    {
        public int Id { get; set; }
        public int Numri { get; set; }
        public  bool IsAvailable { get; set; }

        [JsonIgnore]
        public Bileta Bileta { get; set; }

        [JsonIgnore]
        public SektoriUlseve SektoriUlseve { get; set; }
        public int SektoriUlseveID { get; set; }

     



    }
}
