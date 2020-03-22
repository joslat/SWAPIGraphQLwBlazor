using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorSWAPI
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Character
        : ICharacter
    {
        public Character(
            string name, 
            double height)
        {
            Name = name;
            Height = height;
        }

        public string Name { get; }

        public double Height { get; }
    }
}
