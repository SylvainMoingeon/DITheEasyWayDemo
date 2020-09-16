using DITheEasyWayDemo.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DITheEasyWayDemo.Services
{
    public interface ICharacterService
    {
        List<ICharacter> GetCharacters();

        string Category { get; }
    }
}
