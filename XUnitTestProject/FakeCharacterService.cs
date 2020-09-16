using DITheEasyWayDemo.models;
using DITheEasyWayDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject
{
    public class FakeCharacterService : ICharacterService
    {
        public List<ICharacter> GetCharacters()
        {
            return new List<ICharacter> {
                new FakeCharacter { FullName = "John Doe" },
                new FakeCharacter { FullName = "Jane Doe" },
                new FakeCharacter { FullName = "Anonymous Me" }
                };
        }

        public string Category => "Fake Category";
    }
}
