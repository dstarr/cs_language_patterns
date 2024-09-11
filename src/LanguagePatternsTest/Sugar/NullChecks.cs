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
    public void PatternMatchingWithIsCheck()
    {
        if (_person is not null)
        {
            Assert.True(true);
        }
    }

    // C# 8
    [Fact]
    public void NullableReferenceTypeCheck()
    {
        string? _person = null;
        Assert.NotNull(_person);
    }

    [Fact]
    public void ClassicCheck()
    {
        if (_person != null)
        {
            Assert.True(true);
        }
    }   

    [Fact]
    public void NullCoelescingOperatorCheck()
    {
        var result = _person ?? new Person("Elle Starr");

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


