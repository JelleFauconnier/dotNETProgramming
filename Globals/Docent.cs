﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Docent : Gebruiker
    {
        public Docent(string voornaam, string achternaam, string email, string wachtwoord) : base(voornaam, achternaam, email, wachtwoord)
        {
        }

    }
}
