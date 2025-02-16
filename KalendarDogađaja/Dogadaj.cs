using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalendarDogađaja
{
    public class Dogadaj
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; } = DateTime.Now; // Default datum na sadašnji

        public override string ToString() => $"{Naziv} - {Datum:dd.MM.yyyy}";
    }
}
