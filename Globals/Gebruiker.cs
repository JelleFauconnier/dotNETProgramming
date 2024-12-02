using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Gebruiker
    {
        public string Voornaam { get; }
        public string Achternaam { get; }
        public string Email { get; }
        public string Wachtwoord { get; }

        public Gebruiker(string voornaam, string achternaam, string email, string wachtwoord) { 
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Email = email;
            this.Wachtwoord = wachtwoord;
        }
    }
}
