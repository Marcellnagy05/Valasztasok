﻿namespace Valasztasok.Model
{
    public class Jelolt
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public Part Part { get; set; }
        public string Kerulet { get; set; }
        public int SzavazatokSzama { get; set; }
    }
}
