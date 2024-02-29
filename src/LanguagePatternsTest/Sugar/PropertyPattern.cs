using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LanguagePatternsTest.Sugar;

public class PropertyPattern
{
    private readonly Character _character = null!;

    public PropertyPattern()
    {
        _character = new Character();
    }

    [Fact]
    public void ManualPropertyChecks()
    {
        if (_character != null &&
            _character.Name == "Bilbo" &&
            _character.Race == "Hobbit")
        {
            Assert.True(true);
        }
        else
        {
            Assert.True(false);
        }
    }
    
    [Fact]
    public void UsingIs()
    {

        if (_character is { Name:"Bilbo", Race: "Hobbit" })
        {
            Assert.True(true);
        }
        else
        {
            Assert.True(false);
        }
    }

    internal class Character
    {
        public string Name { get; private set; } = "Bilbo";

        public string Race { get; private set; } = "Hobbit";
    }
}


