using DITheEasyWayDemo.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DITheEasyWayDemo.Services
{
    public class MusketeerService : ICharacterService
    {
        public List<ICharacter> GetCharacters()
        {
            return new List<ICharacter> {
                new Musketeer { FullName = "Athos"},
                new Musketeer { FullName = "Portos"},
                new Musketeer { FullName = "Aramis"}
            };
        }

        public string Category => "Mousquetaires";
    }
}
