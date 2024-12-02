using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Bedrijf
    {
        public string Bedrijfsnaam {  get; }
        public BedrijfAcc HoofdGebruiker {  get; }

        public Bedrijf(string Bedrijfsnaam, BedrijfAcc HoofdGebruiker)
        {
            this.Bedrijfsnaam = Bedrijfsnaam;
            this.HoofdGebruiker = HoofdGebruiker;
        }
    }
}
