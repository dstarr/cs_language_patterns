using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePatternsTest.Sugar;

public class NullChecks
{
    private readonly Person _person;

    public NullChecks()
    {
        _person = new Person("David Starr");
    }

    [Fact]
    public void RedundantCheck()
    {
        if (_person is not null && _person is Person)
        {
            Assert.True(true);
        }
    }

    [Fact]
    public void CheckAgainstNull()
    {
        if (_person != null)
        {
            Assert.True(true);
        }
    }   

    [Fact]
    public void SingleCheck()
    {
        if (_person is null)
        {
            Assert.True(false);
        }
    }
    
    private class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}


