﻿using System;

namespace FederataFutbollit.Entities
{
    public class Rezultati
    {
        public int Id { get; set; }
        public string EmriKlubit { get; set; }
        public string Kundershtari { get; set; }
        public DateTime DataNdeshjes { get; set; }
        public int GolatEkipi1 { get; set; }
        public int GolatEkipi2 { get; set; } 
    }
}
